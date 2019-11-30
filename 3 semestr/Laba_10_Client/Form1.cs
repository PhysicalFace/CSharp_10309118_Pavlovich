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
using System.Net.Sockets;

namespace Laba_9_Client
{
    public partial class Client : Form
    {
        Socket socket;

        private void SendToServer(string command)
        {
            //переводим комманду command в список байт
            byte[] data = Encoding.UTF8.GetBytes(command);

            //отправляем данные
            socket.Send(data);
        }

        public Client()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //создаем объект Socket и сохраняем его в переменную socket
                //в кач-ве параметров указываем: сеть интернета, передача данных в виде потока байт, протокол TCP
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                //подключаемся к серверу
                socket.Connect(textBoxHost.Text, Int32.Parse(textBoxPort.Text));

                //передаем серверу имя пользователя
                SendToServer("name " + textBoxName.Text);

                //включаем таймер для периодической проверки входящих сообдений
                timer1.Enabled = true;

                //выводим текст об успешном открытии сокета
                textBoxLog.AppendText("Подключено к " + textBoxHost.Text + ":" + textBoxPort.Text + Environment.NewLine);

                //меняем доступность кнопок "Подключиться и отключиться"
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
            }
            catch (Exception exc)
            {
                textBoxLog.AppendText(exc.Message + Environment.NewLine);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                //посылает серверу команду о выходе из чата
                SendToServer("quit");

                //закрываем получение и отправку данных
                socket.Shutdown(SocketShutdown.Both);

                //закрываем сокет
                socket.Close();

                //отключаем таймер
                timer1.Enabled = false;

                //меняем доступность кнопок
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;

                //выводим сообщение об отключении
                textBoxLog.AppendText("Отключено" + Environment.NewLine);
            }
            catch (Exception exc)
            {
                textBoxLog.AppendText(exc.Message + Environment.NewLine);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                //передаем серверу базу данных с клиента
                string str = FromDataBaseToString(dataGridView);
                SendToServer(str);

                //выводим информацию
                textBoxLog.AppendText("База данных успешна отправлена на " + textBoxHost.Text + ":" + textBoxPort.Text + Environment.NewLine);
            }
            catch (Exception exc)
            {
                textBoxLog.AppendText(exc.Message + Environment.NewLine);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (socket.Available != 0)
            {
                try
                {
                    //создаем буффер для получения данных
                    byte[] data = new byte[socket.Available];

                    //получаем данные
                    int data_size = socket.Receive(data);

                    //преобразуем данные в текст
                    string text_data = Encoding.UTF8.GetString(data, 0, data_size);

                    if (text_data.StartsWith("data "))
                    {
                        //выводим полученную строку в БД
                        string str = text_data.Substring(5);
                        dataGridView.DataSource = FromStringToDataBase(str);

                        //выводим информацию
                        textBoxLog.AppendText("Получена база данных с " + textBoxHost.Text + ":" + textBoxPort.Text + Environment.NewLine);
                    }
                }
                catch (Exception exc)
                {
                    textBoxLog.AppendText(exc.Message + Environment.NewLine);
                }
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
