using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Структура

        struct WORKER
        {
            public string Surname;
            public string Initials;
            public string Post;
            public int Date;
        }

        const int max_worker_count = 1000; // установка лимита сотрудников в списке

        WORKER[] worker = new WORKER[max_worker_count - 1]; // стр-ра для всех сотрудников
        WORKER[] search_worker = new WORKER[max_worker_count - 1]; // стр-ра для сотрудников из поиска

        #endregion

        #region Вывод_информации_о_сотруднике

        bool search_enabled = false; // определяет, что выводить в список сотрудников

        private void lB_workers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Выводим информацию о сотруднике в правую панель
                if (!search_enabled)
                {
                    tB_workers.Text =
                        "Фамилия: " + worker[lB_workers.SelectedIndex].Surname + Environment.NewLine +
                        "Инициалы: " + worker[lB_workers.SelectedIndex].Initials + Environment.NewLine +
                        "Должность: " + worker[lB_workers.SelectedIndex].Post + Environment.NewLine +
                        "Год поступления на работу: " + worker[lB_workers.SelectedIndex].Date;
                }
                else
                {
                    tB_workers.Text =
                        "Фамилия: " + search_worker[lB_workers.SelectedIndex].Surname + Environment.NewLine +
                        "Инициалы: " + search_worker[lB_workers.SelectedIndex].Initials + Environment.NewLine +
                        "Должность: " + search_worker[lB_workers.SelectedIndex].Post + Environment.NewLine +
                        "Год поступления на работу: " + search_worker[lB_workers.SelectedIndex].Date;
                }
            }
            catch (IndexOutOfRangeException)
            {
                // НИЧЕГО
            }

            // Если список слева пустой то панелька справа тоже станет пустой
            if (lB_workers.Items.Count == 0)
                tB_workers.Text = "";
        }

        #endregion

        #region Кнопка_загрузки

        private void b_Load_Click(object sender, EventArgs e)
        {
            try
            {
                // Открываем диалоговое окно загрузки
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

                if (file.ShowDialog() == DialogResult.Cancel)
                    return;

                // Получаем выбранный файл
                string filename = file.FileName;

                // Читаем данные из файла
                string[] lines = File.ReadAllLines(filename);

                // Если в файле число сотрудников превышает макс-но допустимое кол-во
                int count = lines.Length;
                if (count > max_worker_count)
                {
                    MessageBox.Show("Файл содержит слишком много данных!");
                    return;
                }

                // Очищаем списки
                ClearInfo();

                // Очищаем структуру от старых данных
                ClearInfoWorker(max_worker_count - 1);

                // Получаем данные из файла и заполняем структуру этими новыми данными
                int i = 0;
                foreach (string line in lines)
                {
                    // Разбиваем строку на отдельные слова
                    string[] data = line.Split(' ');

                    worker[i].Surname = data[0];
                    worker[i].Initials = data[1];
                    worker[i].Post = data[2];
                    worker[i].Date = Int32.Parse(data[3]);

                    // Выводим сотрудника в список
                    lB_workers.Items.Add(worker[i].Surname + " " + worker[i].Initials);
                    i++;
                }

                tB_search.Text = ""; // чистим поле поиска по критерию
                b_Add.Enabled = true; // включаем кнопку добавления сотрудника

                UpdateLabelCountOfWorkers();
                MessageBox.Show("Список загрузился успешно!");
            }
            catch (FormatException)
            {
                ClearInfo();
                MessageBox.Show("Возникла ошибка!");
            }
            catch (IndexOutOfRangeException)
            {
                ClearInfo();
                MessageBox.Show("Ошибка! Убедитесь, что в данном текстовом файле корректно записаны данные и лишние пробелы.");
            }
        }

        #endregion

        #region Кнопка_сохранения

        private void b_Save_Click(object sender, EventArgs e)
        {
            // Открываем диалоговое окно сохранения
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (file.ShowDialog() == DialogResult.Cancel)
                return;

            // Получаем выбранный файл
            string filename = file.FileName;

            // Записываем данные в файл 
            using (StreamWriter sw = new StreamWriter(filename))
            {
                for (int i = 0; i < lB_workers.Items.Count; i++)
                {
                    if (!search_enabled)
                    {
                        sw.WriteLine(worker[i].Surname + " " +
                            worker[i].Initials + " " +
                            worker[i].Post + " " +
                            worker[i].Date
                            );
                    }
                    else
                    {
                        sw.WriteLine(search_worker[i].Surname + " " +
                            search_worker[i].Initials + " " +
                            search_worker[i].Post + " " +
                            search_worker[i].Date
                            );
                    }
                }
            }

            MessageBox.Show("Список сохранён!");
        }

        #endregion

        #region Кнопка_добавления_сотрудника

        private void b_Add_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли место в списке
            int i = lB_workers.Items.Count;

            if (i < max_worker_count)
            {
                // Открываем новую форму
                Form2 form2 = new Form2();
                form2.ShowDialog();

                // Добавляем нового сотрудника вместе с его инфой
                if (form2.Surname() != "" && form2.Initials() != "" && form2.Post() != "" && form2.Date() != 0)
                {
                    worker[i].Surname = form2.Surname();
                    worker[i].Initials = form2.Initials();
                    worker[i].Post = form2.Post();
                    worker[i].Date = form2.Date();

                    // Выводим нового сотрудника в список
                    lB_workers.Items.Add(worker[i].Surname + " " + worker[i].Initials);
                    UpdateLabelCountOfWorkers();
                }
            }
            else
            {
                MessageBox.Show("Достигнуто максимальное число рабочих в списке!");
            }
        }

        #endregion

        #region Кнопка_удаления_сотрудника

        private void b_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Запоминаем сотрудника, которого нужно удалить
                int n = lB_workers.SelectedIndex;

                if (!search_enabled)
                {
                    // Удаляем этого сотрудника из списка и структуры
                    worker[n].Date = 0;
                    lB_workers.Items.RemoveAt(n);

                    // Смещаем массив структуры на один индекс влево
                    ArrayShiftByOneIndex(worker, lB_workers.Items.Count);

                    // Очищаем табель информации о сотруднике
                    tB_workers.Clear();

                    UpdateLabelCountOfWorkers();
                }
                else
                {
                    // Получаем кол-во сотрудников в списке
                    int length = 0; // искомая длина непустой части структуры
                    int count = 0; // счётчик

                    while (worker[count].Date != 0)
                        count++;

                    length = count; // конечная длина непустой части структуры

                    for (int i = 0; i < length; i++)
                    {
                        // Если ВСЁ сходиться
                        if (worker[i].Surname == search_worker[n].Surname &&
                            worker[i].Initials == search_worker[n].Initials &&
                            worker[i].Post == search_worker[n].Post &&
                            worker[i].Date == search_worker[n].Date
                            )
                        {
                            // Удаляем этого сотрудника из списка и структуры
                            worker[i].Date = 0;
                            search_worker[n].Date = 0;
                            lB_workers.Items.RemoveAt(n);

                            // Смещаем массивы структур на один индекс влево
                            ArrayShiftByOneIndex(worker, length);
                            ArrayShiftByOneIndex(search_worker, lB_workers.Items.Count);

                            // Очищаем табель информации о сотруднике
                            tB_workers.Clear();

                            UpdateLabelCountOfWorkers();

                            return;
                        }
                    }
                }
            }
            catch
            {
                // НИЧЕГО
            }
        }

        #endregion

        #region Кнопка_поиска_сотрудника_по_критерию

        private void b_Search_Click(object sender, EventArgs e)
        {
            // Получаем кол-во сотрудников в списке
            int length = 0; // искомая длина непустой части структуры
            int count = 0; // счётчик

            while (worker[count].Date != 0)
                count++;

            length = count; // конечная длина непустой части структуры

            int j = 0; // индекс search_worker структуры

            if (tB_search.Text != "")
            {
                search_enabled = true;

                b_Add.Enabled = false; // отключаем кнопку добавления сотрудника, когда работает фильтр

                // Очищаем списки
                ClearInfo();

                // Очищаем структуру search_worker
                ClearInfoSearchWorker(length);

                // Поиск по критерию: Фамилия
                if (rB_Surname.Checked)
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (worker[i].Surname == tB_search.Text)
                        {
                            SetInfoSearchWorker(j, i);
                            lB_workers.Items.Add(search_worker[j].Surname + " " + search_worker[j].Initials);
                            j++;
                        }
                    }
                }

                // Поиск по критерию: Инициалы
                if (rB_Initials.Checked)
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (worker[i].Initials == tB_search.Text)
                        {
                            SetInfoSearchWorker(j, i);
                            lB_workers.Items.Add(search_worker[j].Surname + " " + search_worker[j].Initials);
                            j++;
                        }
                    }
                }

                // Поиск по критерию: Должность
                if (rB_Post.Checked)
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (worker[i].Post == tB_search.Text)
                        {
                            SetInfoSearchWorker(j, i);
                            lB_workers.Items.Add(search_worker[j].Surname + " " + search_worker[j].Initials);
                            j++;
                        }
                    }
                }

                // Поиск по критерию: Год поступления на работу
                if (rB_Date.Checked)
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (worker[i].Date.ToString() == tB_search.Text)
                        {
                            SetInfoSearchWorker(j, i);
                            lB_workers.Items.Add(search_worker[j].Surname + " " + search_worker[j].Initials);
                            j++;
                        }
                    }
                }

                // Проверка кол-ва найденных результатов запроса
                count = 0;
                while (search_worker[count].Date != 0)
                    count++;

                if (count == 0)
                    MessageBox.Show("По заданному критерию ничего не найдено!");
            }
            else
            {
                search_enabled = false;

                b_Add.Enabled = true; // включаем кнопку добавления сотрудника, когда работает фильтр

                // Очищаем списки
                ClearInfo();

                for (int i = 0; i < length; i++)
                {
                    //MessageBox.Show("OK!");
                    lB_workers.Items.Add(worker[i].Surname + " " + worker[i].Initials);
                }
            }

            UpdateLabelCountOfWorkers();
        }

        #endregion

        #region Кнопка_реверса_сотрудников

        private void b_Revers_Click(object sender, EventArgs e)
        {
            // Создаём новую структуру для переворачивания
            WORKER[] new_worker = new WORKER[lB_workers.Items.Count];

            if (!search_enabled)
            {
                // Кидаем инфу новой структуре о данных старой структуры
                for (int i = 0; i < lB_workers.Items.Count; i++)
                {
                    new_worker[i].Surname = worker[i].Surname;
                    new_worker[i].Initials = worker[i].Initials;
                    new_worker[i].Post = worker[i].Post;
                    new_worker[i].Date = worker[i].Date;
                }

                // Переворачиваем новую структуру
                Array.Reverse(new_worker);

                // Отдаём "перевернутую" инфу старой структуре
                for (int i = 0; i < lB_workers.Items.Count; i++)
                {
                    worker[i].Surname = new_worker[i].Surname;
                    worker[i].Initials = new_worker[i].Initials;
                    worker[i].Post = new_worker[i].Post;
                    worker[i].Date = new_worker[i].Date;
                }

                ClearInfo();

                // Получаем кол-во сотрудников в списке
                int length = 0; // счётчик

                while (worker[length].Date != 0)
                    length++;

                // Добавляем "перевёрнутую" структуру в листбокс
                for (int i = 0; i < length; i++)
                {
                    lB_workers.Items.Add(worker[i].Surname + " " + worker[i].Initials);
                }
            }
            else
            {
                // Кидаем инфу новой структуре о данных search структуры
                for (int i = 0; i < lB_workers.Items.Count; i++)
                {
                    new_worker[i].Surname = search_worker[i].Surname;
                    new_worker[i].Initials = search_worker[i].Initials;
                    new_worker[i].Post = search_worker[i].Post;
                    new_worker[i].Date = search_worker[i].Date;
                }

                // Переворачиваем новую структуру
                Array.Reverse(new_worker);

                // Отдаём "перевернутую" инфу search структуре
                for (int i = 0; i < lB_workers.Items.Count; i++)
                {
                    search_worker[i].Surname = new_worker[i].Surname;
                    search_worker[i].Initials = new_worker[i].Initials;
                    search_worker[i].Post = new_worker[i].Post;
                    search_worker[i].Date = new_worker[i].Date;
                }

                // Очищаем панельки от инфы
                ClearInfo();

                // Получаем кол-во сотрудников в списке
                int length = 0; // счётчик

                while (search_worker[length].Date != 0)
                    length++;

                // Добавляем "перевёрнутую" структуру в листбокс
                for (int i = 0; i < length; i++)
                {
                    lB_workers.Items.Add(search_worker[i].Surname + " " + search_worker[i].Initials);
                }
            }
        }

        #endregion

        #region Кнопка_сортировки_сотрудников

        private void b_Sort_Click(object sender, EventArgs e)
        {
            if (rB_sortDate.Checked)
            {
                if (!search_enabled)
                {
                    // Получаем кол-во сотрудников в списке
                    int length = 0; // счётчик

                    while (worker[length].Date != 0)
                        length++;

                    // Сортируем сотрудников по стажу работы
                    SortWorkersByDate(worker, length);

                    ClearInfo();

                    // Добавляем структуру в листбокс
                    for (int i = 0; i < length; i++)
                    {
                        lB_workers.Items.Add(worker[i].Surname + " " + worker[i].Initials);
                    }
                }
                else
                {
                    // Получаем кол-во сотрудников в списке
                    int length = 0; // счётчик

                    while (search_worker[length].Date != 0)
                        length++;

                    // Сортируем сотрудников по стажу работы
                    SortWorkersByDate(search_worker, length);

                    ClearInfo();

                    // Добавляем структуру в листбокс
                    for (int i = 0; i < length; i++)
                    {
                        lB_workers.Items.Add(search_worker[i].Surname + " " + search_worker[i].Initials);
                    }
                }
            }
        }

        #endregion

        #region Методы

        // М-од сортировки сотрудников по стажу работы(по возрастанию)
        void SortWorkersByDate(WORKER[] element_worker, int N)
        {
            // Сортировка пузырьком
            WORKER[] tmp = new WORKER[1];

            for (int i = N - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    // Сравниваем элементы массива структур по стажу работы сотрудников
                    if (element_worker[j].Date > element_worker[j + 1].Date)
                    {
                        tmp[0].Surname = element_worker[j].Surname;
                        tmp[0].Initials = element_worker[j].Initials;
                        tmp[0].Post = element_worker[j].Post;
                        tmp[0].Date = element_worker[j].Date;

                        element_worker[j].Surname = element_worker[j + 1].Surname;
                        element_worker[j].Initials = element_worker[j + 1].Initials;
                        element_worker[j].Post = element_worker[j + 1].Post;
                        element_worker[j].Date = element_worker[j + 1].Date;

                        element_worker[j + 1].Surname = tmp[0].Surname;
                        element_worker[j + 1].Initials = tmp[0].Initials;
                        element_worker[j + 1].Post = tmp[0].Post;
                        element_worker[j + 1].Date = tmp[0].Date;
                    }
                }
            }
        }

        // М-од смещения массива структуры на один индекс влево
        void ArrayShiftByOneIndex(WORKER[] element_worker, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (element_worker[i].Date == 0)
                {
                    element_worker[i].Surname = element_worker[i + 1].Surname;
                    element_worker[i].Initials = element_worker[i + 1].Initials;
                    element_worker[i].Post = element_worker[i + 1].Post;
                    element_worker[i].Date = element_worker[i + 1].Date;

                    element_worker[i + 1].Surname = "";
                    element_worker[i + 1].Initials = "";
                    element_worker[i + 1].Post = "";
                    element_worker[i + 1].Date = 0;
                }
            }
        }

        // М-од очищения информации из правой и левой панелек
        void ClearInfo()
        {
            lB_workers.Items.Clear();
            tB_workers.Clear();
        }

        // М-од заполнения структуры search_worker данными, соотв-щим критерию
        void SetInfoSearchWorker(int a, int b)
        {
            search_worker[a].Surname = worker[b].Surname;
            search_worker[a].Initials = worker[b].Initials;
            search_worker[a].Post = worker[b].Post;
            search_worker[a].Date = worker[b].Date;
        }

        // М-од очищения структуры worker
        void ClearInfoWorker(int length)
        {
            for (int a = 0; a < length; a++)
            {
                worker[a].Surname = "";
                worker[a].Initials = "";
                worker[a].Post = "";
                worker[a].Date = 0;
            }
        }

        // М-од очищения структуры search_worker
        void ClearInfoSearchWorker(int length)
        {
            for (int a = 0; a < length; a++)
            {
                search_worker[a].Surname = "";
                search_worker[a].Initials = "";
                search_worker[a].Post = "";
                search_worker[a].Date = 0;
            }
        }

        // М-од смены кол-ва сотрудников в тексте над списком сотрудников слева
        void UpdateLabelCountOfWorkers()
        {
            label2.Text = "Всего сотрудников: " + lB_workers.Items.Count;
        }

        #endregion

    }
}
