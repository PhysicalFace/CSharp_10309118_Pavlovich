using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Заполняем список кол-вом доступных массивов
            for (int i = 0; i < 5; i++)
                lB_vector.Items.Add("None");
        }

        // Объекты, с которыми будет работать пользователь
        Vector v0 = new Vector(0, 0);
        Vector v1 = new Vector(0, 0); 
        Vector v2 = new Vector(0, 0);
        Vector v3 = new Vector(0, 0);
        Vector v4 = new Vector(0, 0);

        // Некоторые константы
        private const int min_rand = -10;
        private const int max_rand = 10;

        // Делегат и события
        public delegate void VectorDelegate(string message);

        VectorDelegate _del = Show_Message;
        public event VectorDelegate AdditionEvent = Show_Message;
        public event VectorDelegate MultiplyEvent = Show_Message;
        public event VectorDelegate DivisionEvent = Show_Message;
        public event VectorDelegate SubtractionEvent = Show_Message;

        // Метод вывода сообщения на экран (для делегата и событий)
        private static void Show_Message(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Вывод информации о массиве на левый TextBox и активация кнопок
        private void lB_vector_SelectedIndexChanged(object sender, EventArgs e)
        {
            b_AddVector.Enabled = true;
            b_ShowAllVector.Enabled = true;
            b_ActionVector.Enabled = true;

            try
            {
                if (lB_vector.Items[lB_vector.SelectedIndex] != "None")
                {
                    var stringBuilder = new StringBuilder();
                    switch (lB_vector.SelectedIndex)
                    {
                        case 0: for (int i = v0._lowRange; i <= v0._highRange; i++) stringBuilder.AppendFormat("Индекс: {0} = {1}" + Environment.NewLine, i, v0[i]); break;
                        case 1: for (int i = v1._lowRange; i <= v1._highRange; i++) stringBuilder.AppendFormat("Индекс: {0} = {1}" + Environment.NewLine, i, v1[i]); break;
                        case 2: for (int i = v2._lowRange; i <= v2._highRange; i++) stringBuilder.AppendFormat("Индекс: {0} = {1}" + Environment.NewLine, i, v2[i]); break;
                        case 3: for (int i = v3._lowRange; i <= v3._highRange; i++) stringBuilder.AppendFormat("Индекс: {0} = {1}" + Environment.NewLine, i, v3[i]); break;
                        case 4: for (int i = v4._lowRange; i <= v4._highRange; i++) stringBuilder.AppendFormat("Индекс: {0} = {1}" + Environment.NewLine, i, v4[i]); break;
                    }

                    tB_InfoVector.Text = "Имя массива:" + Environment.NewLine + lB_vector.Items[lB_vector.SelectedIndex].ToString() + Environment.NewLine + stringBuilder.ToString();
                }
                else
                    tB_InfoVector.Text = "";
            }
            catch { }
        }

        // Кнопка добавления массива
        private void b_AddVector_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            if (form2.IsClose())
                return;

            #region Велосипед
            if (form2.LowRange() != null && form2.HighRange() != null && form2.VectorName() != null)
            {
                for (int i = 0; i < lB_vector.Items.Count; i++)
                    if (lB_vector.Items[i].ToString() == form2.VectorName())
                    {
                        MessageBox.Show("Массив с таким именем уже существует!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                var rand = new Random();
                switch (lB_vector.SelectedIndex)
                {
                    case 0:
                        v0._lowRange = form2.LowRange();
                        v0._highRange = form2.HighRange();
                        for (int i = v0._lowRange; i <= v0._highRange; i++)
                            v0[i] = rand.Next(min_rand, max_rand);
                        lB_vector.Items.RemoveAt(0);
                        lB_vector.Items.Insert(0, form2.VectorName());
                        break;

                    case 1:
                        v1._lowRange = form2.LowRange();
                        v1._highRange = form2.HighRange();
                        for (int i = v1._lowRange; i <= v1._highRange; i++)
                            v1[i] = rand.Next(min_rand, max_rand);
                        lB_vector.Items.RemoveAt(1);
                        lB_vector.Items.Insert(1, form2.VectorName());
                        break;

                    case 2:
                        v2._lowRange = form2.LowRange();
                        v2._highRange = form2.HighRange();
                        for (int i = v2._lowRange; i <= v2._highRange; i++)
                            v2[i] = rand.Next(min_rand, max_rand);
                        lB_vector.Items.RemoveAt(2);
                        lB_vector.Items.Insert(2, form2.VectorName());
                        break;

                    case 3:
                        v3._lowRange = form2.LowRange();
                        v3._highRange = form2.HighRange();
                        for (int i = v3._lowRange; i <= v3._highRange; i++)
                            v3[i] = rand.Next(min_rand, max_rand);
                        lB_vector.Items.RemoveAt(3);
                        lB_vector.Items.Insert(3, form2.VectorName());
                        break;

                    case 4:
                        v4._lowRange = form2.LowRange();
                        v4._highRange = form2.HighRange();
                        for (int i = v4._lowRange; i <= v4._highRange; i++)
                            v4[i] = rand.Next(min_rand, max_rand);
                        lB_vector.Items.RemoveAt(4);
                        lB_vector.Items.Insert(4, form2.VectorName());
                        break;
                }
            #endregion
            }
        }

        // Кнопка показа массива
        private void b_ShowAllVector_Click(object sender, EventArgs e)
        {
            try
            {
                if (lB_vector.Items[lB_vector.SelectedIndex] != "None")
                {
                    string allVector = "";

                    switch (lB_vector.SelectedIndex)
                    {
                        case 0: allVector = v0.ShowVector(); break;
                        case 1: allVector = v1.ShowVector(); break;
                        case 2: allVector = v2.ShowVector(); break;
                        case 3: allVector = v3.ShowVector(); break;
                        case 4: allVector = v4.ShowVector(); break;
                    }

                    if(_del != null)
                        _del("Имя массива: " + lB_vector.Items[lB_vector.SelectedIndex] + "\n" + allVector);
                }
            }
            catch { }
        }

        // Кнопка математического д-вия над массивом(ми)
        private void b_ActionVector_Click(object sender, EventArgs e)
        {
            try
            {
                if (lB_vector.Items[lB_vector.SelectedIndex] != "None")
                {
                    if (r_Mult.Checked || r_Div.Checked)
                    {
                        Form3 form3 = new Form3();
                        form3.ShowDialog();

                        if (form3.IsClose())
                            return;

                        int skalyar = form3.skalyar;

                        if (r_Mult.Checked)
                        {
                            switch (lB_vector.SelectedIndex)
                            {
                                case 0: v0.Multiply(v0, skalyar); break;
                                case 1: v1.Multiply(v0, skalyar); break;
                                case 2: v2.Multiply(v0, skalyar); break;
                                case 3: v3.Multiply(v0, skalyar); break;
                                case 4: v4.Multiply(v0, skalyar); break;
                            }

                            if (MultiplyEvent != null)
                                MultiplyEvent("Произведение массива на скаляр прошёл успешно!");
                        }
                        else if (r_Div.Checked && skalyar != 0)
                        {
                            switch (lB_vector.SelectedIndex)
                            {
                                case 0: v0.Division(v0, skalyar); break;
                                case 1: v1.Division(v0, skalyar); break;
                                case 2: v2.Division(v0, skalyar); break;
                                case 3: v3.Division(v0, skalyar); break;
                                case 4: v4.Division(v0, skalyar); break;
                            }

                            if (DivisionEvent != null)
                                DivisionEvent("Деление массива на скаляр прошёл успешно!");
                        }
                    }
                    else if (r_Add.Checked || r_Sub.Checked)
                    {
                        Form4 form4 = new Form4();
                        form4.ShowDialog();

                        if (form4.IsClose())
                            return;

                        int countVector1 = 0, countVector2 = 0;
                        bool isVector1InListBox = false;
                        bool isVector2InListBox = false;

                        for (int i = 0; i < lB_vector.Items.Count; i++)
                        {
                            if (lB_vector.Items[i].ToString() == form4.Vector1())
                            {
                                isVector1InListBox = true;
                                countVector1 = i;
                            }
                            if (lB_vector.Items[i].ToString() == form4.Vector2())
                            {
                                isVector2InListBox = true;
                                countVector2 = i;
                            }
                        }

                        if (isVector1InListBox && isVector2InListBox)
                        {
                            #region Велосипед
                            if (r_Add.Checked)
                            {
                                if (AdditionEvent != null)
                                {
                                    if (countVector1 == 0 && countVector2 == 1) { Vector vector = v0 + v1; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 0 && countVector2 == 2) { Vector vector = v0 + v2; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 0 && countVector2 == 3) { Vector vector = v0 + v3; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 0 && countVector2 == 4) { Vector vector = v0 + v4; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 1 && countVector2 == 2) { Vector vector = v1 + v2; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 1 && countVector2 == 3) { Vector vector = v1 + v3; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 1 && countVector2 == 4) { Vector vector = v1 + v4; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 2 && countVector2 == 3) { Vector vector = v2 + v3; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 2 && countVector2 == 4) { Vector vector = v2 + v4; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 3 && countVector2 == 4) { Vector vector = v3 + v4; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }

                                    if (countVector2 == 0 && countVector1 == 1) { Vector vector = v0 + v1; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 0 && countVector1 == 2) { Vector vector = v0 + v2; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 0 && countVector1 == 3) { Vector vector = v0 + v3; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 0 && countVector1 == 4) { Vector vector = v0 + v4; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 1 && countVector1 == 2) { Vector vector = v1 + v2; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 1 && countVector1 == 3) { Vector vector = v1 + v3; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 1 && countVector1 == 4) { Vector vector = v1 + v4; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 2 && countVector1 == 3) { Vector vector = v2 + v3; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 2 && countVector1 == 4) { Vector vector = v2 + v4; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 3 && countVector1 == 4) { Vector vector = v3 + v4; AdditionEvent("Сложение элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                }
                            }
                            else if(r_Sub.Checked)
                            {
                                if(SubtractionEvent != null)
                                {
                                    if (countVector1 == 0 && countVector2 == 1) { Vector vector = v0 - v1; AdditionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 0 && countVector2 == 2) { Vector vector = v0 - v2; AdditionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 0 && countVector2 == 3) { Vector vector = v0 - v3; AdditionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 0 && countVector2 == 4) { Vector vector = v0 - v4; AdditionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 1 && countVector2 == 2) { Vector vector = v1 - v2; AdditionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 1 && countVector2 == 3) { Vector vector = v1 - v3; AdditionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 1 && countVector2 == 4) { Vector vector = v1 - v4; AdditionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 2 && countVector2 == 3) { Vector vector = v2 - v3; AdditionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 2 && countVector2 == 4) { Vector vector = v2 - v4; AdditionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector1 == 3 && countVector2 == 4) { Vector vector = v3 - v4; AdditionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }

                                    if (countVector2 == 0 && countVector1 == 1) { Vector vector = v0 - v1; SubtractionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 0 && countVector1 == 2) { Vector vector = v0 - v2; SubtractionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 0 && countVector1 == 3) { Vector vector = v0 - v3; SubtractionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 0 && countVector1 == 4) { Vector vector = v0 - v4; SubtractionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 1 && countVector1 == 2) { Vector vector = v1 - v2; SubtractionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 1 && countVector1 == 3) { Vector vector = v1 - v3; SubtractionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 1 && countVector1 == 4) { Vector vector = v1 - v4; SubtractionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 2 && countVector1 == 3) { Vector vector = v2 - v3; SubtractionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 2 && countVector1 == 4) { Vector vector = v2 - v4; SubtractionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                    if (countVector2 == 3 && countVector1 == 4) { Vector vector = v3 - v4; SubtractionEvent("Вычитание элементов массивов между собой прошёл успешно! Результат:\n" + vector.ShowVector()); }
                                }
                            }
                            #endregion
                        }
                        else
                            MessageBox.Show("Массивы не найдены! Проверьте правильность ввведённых имён.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
        }
    }
}
