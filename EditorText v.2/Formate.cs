using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorText_v._2
{
    class Formate
    {

        private void TextMakeUp(RichTextBox richTextBox, FontStyle fontStyle)
        {
            String line = richTextBox.SelectedText;
            richTextBox.SelectionFont = new Font(richTextBox.Font, fontStyle);
            richTextBox.SelectedText = line;
        }

        public void IsEnabled(ToolStripMenuItem item, RichTextBox richTextBox)
        {
            item.Enabled = richTextBox.SelectionLength > 0 && richTextBox.Text != "";
        }

        public void MakeTextBold(RichTextBox richTextBox)
        {
            TextMakeUp(richTextBox, FontStyle.Bold);
        }

        public void MakeTextItalic(RichTextBox richTextBox)
        {
            TextMakeUp(richTextBox, FontStyle.Italic);
        }

        public void MakeTextRegular(RichTextBox richTextBox)
        {
            TextMakeUp(richTextBox, FontStyle.Regular);
        }


        // Меню выбора шрифта
        public void FontMenu(RichTextBox richTextBox)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            richTextBox.Font = fontDialog.Font;
        }

        // Меню выбора цвета
        public void ColorMenu(RichTextBox richTextBox)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            richTextBox.SelectionColor = colorDialog.Color;
        }

    }
}
