using System;
using System.Collections.Generic;
using System.Text;


namespace Sem3Lab5
{
    [Serializable]
    class TimeItem
    {
        public int Size { get; set; }
        public int RepeatNum { get; set; }
        public double TimeCharp { get; set; }
        public double TimeCplus { get; set; }
        public double Coeffiecient { get; set; }

        public override string ToString()
        {
            string str = "";
            str += "\n\t\tПорядок матрицы: " + Size + "\n";
            str += "\t\tКоличество повторений: " + RepeatNum + "\n";
            str += "\t\tВремя выплнения C#: " + TimeCharp + "\n";
            str += "\t\tВремя выполения С++: " + TimeCplus + "\n";
            str += "\t\tОтношение: " + Coeffiecient + "\n";
            return str;
        }
    }
}
