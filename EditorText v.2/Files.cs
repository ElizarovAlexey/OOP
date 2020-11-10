using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace EditorText_v._2
{
    class Files
    {
        private string filePath;

        private bool SelectFilePath(OpenFileDialog dialogOpen)
        {
            if (dialogOpen.ShowDialog() == DialogResult.OK)
            {
                filePath = dialogOpen.FileName;
                return true;
            }
            else
                return false;
        }

        private DialogResult Message()
        {
            string message = "Вероятно, вы не сохранили текст. Хотите его сохранить?";
            string caption = "Предупреждение";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;

            // Выводим сообщение на экран
            DialogResult result = MessageBox.Show(
                message,
                caption,
                buttons,
                MessageBoxIcon.Question);
            return result;
        }

        public void CreateFile(RichTextBox richTextBox)
        {
            if (richTextBox.Text != "")
            {
                DialogResult result = Message();

                if (result == DialogResult.Yes)
                {
                    SaveFile(richTextBox);
                }
                else if (result == DialogResult.No)
                {
                    filePath = "";
                    richTextBox.Text = "";
                }
                else
                    return;

                if (richTextBox.Text == "")
                {
                    filePath = "";
                    richTextBox.Text = "";
                }
            }
        }

        public void OpenFile(RichTextBox richTextBox)
        {
            OpenFileDialog dialogOpen = new OpenFileDialog();

            if (richTextBox.Text != "")
            {
                DialogResult result = Message();
                if (result == DialogResult.Yes)
                {
                    SaveFile(richTextBox);
                }
                else if (result == DialogResult.No)
                {
                    if (SelectFilePath(dialogOpen))
                    {
                        SelectFilePath(dialogOpen);
                        string fileText = File.ReadAllText(filePath);
                        richTextBox.Text = fileText;
                        MessageBox.Show("Файл открыт!");
                    }
                }
                else if (result == DialogResult.Cancel)
                    filePath = "";
            }

            if (richTextBox.Text == "")
            {
                SelectFilePath(dialogOpen);
                string fileText = File.ReadAllText(filePath);
                richTextBox.Text = fileText;
                MessageBox.Show("Файл открыт!");
            }
        }

        public void SaveFile(RichTextBox richTextBox)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFile.FileName;
            File.WriteAllText(filename, richTextBox.Text);
            MessageBox.Show($"Файл сохранен!");
        }

        public void PrintFile()
        {
            PrintDocument printDocument = new PrintDocument();
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.Cancel)
                return;

            printDialog.Document.Print();
        }

        public void CloseFile(Form form)
        {
            form.Close();
        }
    }
}
