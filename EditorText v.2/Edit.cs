using System;
using System.Drawing;
using System.Windows.Forms;

namespace EditorText_v._2
{
    class Edit
    {
        public void CopyText(TextBoxBase richTextBox)
        {
            try
            {
                Clipboard.SetText(richTextBox.SelectedText);
            }
            catch (System.Exception)
            {
                if (richTextBox.SelectionLength == 0)
                    MessageBox.Show("Для копирования необходимо выделить текст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PasteText(TextBoxBase richTextBox)
        {
            richTextBox.Paste();
        }

        public void CutText(TextBoxBase richTextBox)
        {
            richTextBox.Cut();
        }

        public void IsEnabled(RichTextBox richTextBox, ToolStripMenuItem item)
        {
            item.Enabled = richTextBox.SelectionLength > 0 && richTextBox.Text != "";
        }

        public void FindReplace(RichTextBox richTextBox, string word1, string word2)
        {
            richTextBox.Text = richTextBox.Text.Replace(word1, word2);
        }

        public void Find(RichTextBox richTextBox, TextBox wordTextBox)
        {
            int i = 0;
            while (i <= richTextBox.Text.Length - wordTextBox.Text.Length)
            {
                i = richTextBox.Text.IndexOf(wordTextBox.Text, i);
                if (i < 0) break;
                {
                    richTextBox.SelectionStart = i;
                    richTextBox.SelectionLength = wordTextBox.Text.Length;
                    richTextBox.SelectionBackColor = Color.Aqua;
                    i += wordTextBox.Text.Length;
                }
            }
        }

        public void FindClear(RichTextBox richTextBox)
        {
            richTextBox.SelectAll();
            richTextBox.SelectionBackColor = Color.White;
        }
    }
}
