using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Editor_Text
{
    public class SaveOpenFile : Form1
    {
        public void saveAsFile(SaveFileDialog dialogSave, RichTextBox textBox)
        {
            if (dialogSave.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = dialogSave.FileName;
            File.WriteAllText(filename, textBox.Text);
            MessageBox.Show($"Файл {filename} сохранен!");

        }

        public void openFile(SaveFileDialog dialogSave, OpenFileDialog dialogOpen, RichTextBox textBox)
        {
            if (textBox.Text != "")
            {
                string message = "Вероятно, вы не сохранили текст. Хотите его сохранить?";
                string caption = "Предупреждение";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                // Выводим сообщение на экран
                DialogResult result = MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    saveAsFile(dialogSave, textBox);
                else
                    openFiles(dialogOpen, textBox);
            }
            openFiles(dialogOpen, textBox);

            if (dialogOpen.ShowDialog() == DialogResult.Cancel)
                return;
        }

        // вспомогалка для "Открыть"
        public void openFiles(OpenFileDialog dialogOpen, RichTextBox textBox)
        {
            string filename = dialogOpen.FileName;
            string fileText = File.ReadAllText(filename);
            textBox.Text = fileText;
            MessageBox.Show("Файл открыт!");
        }
    }
}
