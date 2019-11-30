using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace Laba_9_Server
{
    public partial class Server : Form
    {
        class ClientInfo // Класс для хранения информации о клиенте
        {
            public Socket socket; // сокет
            public string name; // имя пользователя

            public override string ToString()
            {
                return name + " (" + socket.RemoteEndPoint + ")";
            }
        }

        TcpListener listener; // объект для приёма входящих TCP-соединений
        List<ClientInfo> clients; // список информации о пользователях

        public Server()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        //загрузка базы данных из файла
        private void Form1_Load(object sender, EventArgs e)
        {
            Stream fs = new FileStream(@"D:\data.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            DataTable dt = new DataTable();
            dt.Columns.Add("Номер студента");
            dt.Columns.Add("Фамилия");
            int count = 1;

            while (sr.Peek() != -1)
            {
                string s = sr.ReadLine();
                dt.Rows.Add(count, s);
                count++;
            }

            dataGridView.DataSource = dt;
        }

        private void buttonBind_Click(object sender, EventArgs e)
        {
            try
            {
                //преобразует текст из textBoxLocalPort в число localPort
                int localPort = Int32.Parse(textBoxLocalPort.Text);

                //создаем пару (адрес, порт) для открытия сокета
                IPEndPoint localPoint = new IPEndPoint(IPAddress.Any, localPort);

                //создаем обхект TcpListener и сохраняем его в переменную listener
                listener = new TcpListener(localPoint);

                //запускаем процесс прослушивания сокета
                listener.Start();

                //создаем список пользователей (изначально пустой)
                clients = new List<ClientInfo>();


                //включаем таймер для периодической проверки
                timer1.Enabled = true;

                //выводим текст об успешном открытии сокета
                textBoxLog.AppendText("Открыт TCP порт " + textBoxLocalPort.Text + Environment.NewLine);
            }
            catch (Exception exc)
            {
                textBoxLog.AppendText(exc.Message + Environment.NewLine);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                CheckListener(); //проверяем новые подключения

                //для всех текущих подключений проверяем сокет на новые данные
                for (int i = clients.Count - 1; i >= 0; i--)
                {
                    //выбираем i-й элемент списка и запоминаем в переменной client
                    ClientInfo client = clients[i];

                    if (client.socket.Available > 0) // если есть новые данные
                    {
                        //получаем данные и преобразуем в текст
                        byte[] data = new byte[client.socket.Available];
                        int data_size = client.socket.Receive(data);
                        string text_data = Encoding.UTF8.GetString(data, 0, data_size);

                        //вызываем обработку
                        DoClient(client, text_data);
                    }
                }
            }
            catch (Exception exc)
            {
                textBoxLog.AppendText(exc.Message + Environment.NewLine);
            }
        }

        private void CheckListener()
        {
            if (listener.Pending()) // есть новые соединения!
            {
                //создаем объект ClientInfo для хранения информации о новом пользователе
                ClientInfo newClient = new ClientInfo();

                //создаем сокет для нового пользователя и сохраняем его в поле newClient.socket
                newClient.socket = listener.AcceptSocket();

                //добавляем обхект newClient в список clients
                clients.Add(newClient);

                //передаем клиенту базу данных с сервера
                string str = FromDataBaseToString(dataGridView);
                SendToClient(str, newClient);

                //выводим информацию
                textBoxLog.AppendText("Пользователь " + newClient.socket.RemoteEndPoint + " подключился" + Environment.NewLine);
            }
        }

        private void DoClient(ClientInfo client, string text_data)
        {
            if (text_data.StartsWith("name ")) //текст начинается с "name "
            {
                //запоминаем имя пользователя в поле client.name
                client.name = text_data.Substring(5);

                //добавляем пользователя в список listBoxClients
                listBoxClients.Items.Add(client);

                //выводим информацию
                textBoxLog.AppendText("Пользователь " + client.socket.RemoteEndPoint + " выбрал имя " + client.name + Environment.NewLine);
            }

            if (text_data == "quit") //текст "quit"
            {
                //отправляем пользователям информацию об уходе пользователя
                SendToClient("exit " + client.name, client);

                //выводим информацию
                textBoxLog.AppendText("Пользователь " + client.socket.RemoteEndPoint + " покинул базу данных" + Environment.NewLine);

                //закрыываем соединение
                client.socket.Shutdown(SocketShutdown.Both);
                client.socket.Close();

                //убираем клиента из списка listBoxClients
                listBoxClients.Items.Remove(client);

                //убираем клиента из списка clients
                clients.Remove(client);
            }

            if (text_data.StartsWith("data ")) //текст начинается с "message "
            {
                //выводим полученную строку в БД
                string str = text_data.Substring(5);
                dataGridView.DataSource = FromStringToDataBase(str);

                //выводим информацию
                textBoxLog.AppendText("Пользователь " + client.socket.RemoteEndPoint + " передал базу данных" + Environment.NewLine);
            }
        }

        //отправка данных command клиенту
        private void SendToClient(string command, ClientInfo thisClient)
        {
            try
            {
                //преобразуем текст в байты
                byte[] data = Encoding.UTF8.GetBytes(command);

                //отправляем
                thisClient.socket.Send(data);
            }
            catch(Exception exc)
            {
                textBoxLog.AppendText(exc.Message + Environment.NewLine);
            }
        }

        //конвертация БД в строку
        private string FromDataBaseToString(DataGridView dgv)
        {
            string str = "data";

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                str += " " + (dataGridView.Rows[i].Cells[1].Value).ToString();
            }

            return str;
        }

        //конвертация строки в БД
        private DataTable FromStringToDataBase(string str)
        {
            String[] data_base = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            DataTable dt = new DataTable();

            dt.Columns.Add("Номер студента");
            dt.Columns.Add("Фамилия");

            for (int i = 0; i < data_base.Length; i++)
            {
                dt.Rows.Add(i + 1, data_base[i]);
            }

            return dt;
        }
    }
}
