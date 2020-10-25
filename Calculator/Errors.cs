using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class Errors : Form1
    {
        public void CorrectNumber(TextBox displayBox)
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (displayBox.Text.IndexOf("∞") != -1)
                displayBox.Text = displayBox.Text.Substring(0, displayBox.Text.Length - 1);

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (displayBox.Text[0] == '0' && (displayBox.Text.IndexOf(",") != 1))
                displayBox.Text = displayBox.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (displayBox.Text[0] == '-')
                if (displayBox.Text[1] == '0' && (displayBox.Text.IndexOf(",") != 2))
                    displayBox.Text = displayBox.Text.Remove(1, 1);
        }
    }
}
