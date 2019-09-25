using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Laba_3
{
    internal class Vector
    {
        // Поля
        public int _lowRange;
        public int _highRange;

        private readonly Hashtable _vector;

        #region Конструктор
        // Возможность задания произвольных границ индексов при создании объекта
        public Vector(int lowRange, int highRange)
        {
            _vector = new Hashtable();
            _lowRange = lowRange;
            _highRange = highRange;
            // инициализация по типу int[]
            for (int i = _lowRange; i <= _highRange; i++)
                _vector[i] = 0;
        }
        #endregion

        #region Свойства
        public int LowRange { get { return _lowRange; } }

        public int HighRange { get { return _highRange; } }

        // возможность обращения к отдельному элементу массива с контролем выхода за пределы индексов
        public int this[int index]
        {
            get
            {
                if (index < _lowRange || index > _highRange)
                    throw new IndexOutOfRangeException("Значение индекса за пределами диапазона");
                return (int)_vector[index];
            }
            set
            {
                if (index < _lowRange || index > _highRange)
                    throw new IndexOutOfRangeException("Значение индекса за пределами диапазона");
                _vector[index] = value;
            }
        }
        #endregion

        #region Методы
        // Операция поэлементного сложения
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            if (vector1.LowRange != vector2.LowRange || vector1.HighRange != vector2.HighRange)
                throw new NotSupportedException("Операция сложения векторов с разными границами не поддерживается");
            var vector = new Vector(vector1.LowRange, vector1.HighRange);
            for (int i = vector1.LowRange; i <= vector1.HighRange; i++)
                vector[i] = vector1[i] + vector2[i];
            return vector;
        }

        // Операция вычитания массивов с одинаковыми границами индексов
        public static Vector operator -(Vector vector1, Vector vector2)
        {
            if (vector1.LowRange != vector2.LowRange || vector1.HighRange != vector2.HighRange)
                throw new NotSupportedException("Операция вычитания векторов с разными границами не поддерживается");
            var vector = new Vector(vector1.LowRange, vector1.HighRange);
            for (int i = vector1.LowRange; i <= vector1.HighRange; i++)
                vector[i] = vector1[i] - vector2[i];
            return vector;
        }

        // Операция умножения всех элементов массива на скаляр
        public void Multiply(Vector vector1, int scalar)
        {
            for (int i = vector1.LowRange; i <= vector1.HighRange; i++)
                vector1[i] = vector1[i] * scalar;
        }

        // Операция деления всех элементов массива на скаляр
        public void Division(Vector vector1, int scalar)
        {
            for (int i = vector1.LowRange; i <= vector1.HighRange; i++)
                vector1[i] = vector1[i] / scalar;
        }

        // Операция печати (вывода на экран) всего массива
        public string ShowVector()
        {
            var stringBuilder = new StringBuilder();
            for (int i = _lowRange; i <= _highRange; i++)
                stringBuilder.AppendFormat(" |{0}: {1}| ", i, _vector[i]);
            return stringBuilder.ToString();
        }

        #endregion
    }
}
