using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_Text
{
    public partial class Form1 : Form
    {
        public string copyText = "";
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt";
            fontDialog1.ShowColor = true;

            // расширенное окно для выбора цвета
            colorDialog1.FullOpen = true;
            // установка начального цвета для colorDialog
            colorDialog1.Color = this.BackColor;

            // горячие клавиши
            saveAsMenu.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            openMenu.ShortcutKeys = Keys.Control | Keys.N;
            printMenu.ShortcutKeys = Keys.Control | Keys.P;
            copyMenu.ShortcutKeys = Keys.Control | Keys.C;
            pasteMenu.ShortcutKeys = Keys.Control | Keys.V;
            cutMenu.ShortcutKeys = Keys.Control | Keys.X;
            findMenu.ShortcutKeys = Keys.Control | Keys.F;
            boldMenu.ShortcutKeys = Keys.Control | Keys.B;
            italicMenu.ShortcutKeys = Keys.Control | Keys.I;
            regularMenu.ShortcutKeys = Keys.Control | Keys.R;
            leftAlign.ShortcutKeys = Keys.Alt | Keys.L;
            centerAlign.ShortcutKeys = Keys.Alt | Keys.C;
            rightAlign.ShortcutKeys = Keys.Alt | Keys.R;
        }

        // Сохранить как...
        private void saveAsMenu_click(object sender, EventArgs e)
        {
            SaveOpenFile save = new SaveOpenFile();
            save.saveAsFile(saveFileDialog1, richTextBox1);
        }

        // Открыть
        private void openMenu_click(object sender, EventArgs e)
        {
            SaveOpenFile open = new SaveOpenFile();
            open.openFile(saveFileDialog1, openFileDialog1, richTextBox1);
        }

        // Проверка, если можно использовать кнопки редактирования текста
        public void CanUseButtons()
        {
            buttonBold.Enabled = richTextBox1.SelectionLength > 0 && richTextBox1.Text != "";
            buttonItalic.Enabled = richTextBox1.SelectionLength > 0 && richTextBox1.Text != "";
            buttonR.Enabled = richTextBox1.SelectionLength > 0 && richTextBox1.Text != "";
            boldMenu.Enabled = richTextBox1.SelectionLength > 0 && richTextBox1.Text != "";
            italicMenu.Enabled = richTextBox1.SelectionLength > 0 && richTextBox1.Text != "";
            regularMenu.Enabled = richTextBox1.SelectionLength > 0 && richTextBox1.Text != "";
        }

        // Превращает текст в жирный
        private void bold_click(object sender, EventArgs e)
        {
            String s = richTextBox1.SelectedText;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            richTextBox1.SelectedText = s;
        }

        // Превращает текст в наклонный
        private void buttonItalic_Click(object sender, EventArgs e)
        {
            String s = richTextBox1.SelectedText;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
            richTextBox1.SelectedText = s;
        }

        // Очищает текст от стилей
        private void buttonR_Click(object sender, EventArgs e)
        {
            String s = richTextBox1.SelectedText;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            richTextBox1.SelectedText = s;
        }

        // Печать документа
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        // Меню выбора шрифта
        private void fontMenu_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        // Меню выбора цвета
        private void colorMenu_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        // Копирование
        private void copyMenuButton_Click(object sender, EventArgs e)
        {
            string copyText = richTextBox1.SelectedText;
            this.copyText = copyText;
        }

        // Вставка
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += copyText;
        }

        // Вырезание текста
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        // Изменение "цветовой схемы" окна
        private void colorSchemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            this.BackColor = colorDialog1.Color;
            buttonClear.ForeColor = colorDialog1.Color;
            openFile.ForeColor = colorDialog1.Color;
            saveAs.ForeColor = colorDialog1.Color;
            buttonBold.ForeColor = colorDialog1.Color;
            buttonItalic.ForeColor = colorDialog1.Color;
            buttonR.ForeColor = colorDialog1.Color;

            fileStripMenu.ForeColor = colorDialog1.Color;
            openMenu.ForeColor = colorDialog1.Color;
            saveMenu.ForeColor = colorDialog1.Color;
            saveAsMenu.ForeColor = colorDialog1.Color;
            printMenu.ForeColor = colorDialog1.Color;

            editStripMenu.ForeColor = colorDialog1.Color;
            copyMenu.ForeColor = colorDialog1.Color;
            pasteMenu.ForeColor = colorDialog1.Color;
            cutMenu.ForeColor = colorDialog1.Color;
            findMenu.ForeColor = colorDialog1.Color;

            treatmentStripMenu.ForeColor = colorDialog1.Color;
            boldMenu.ForeColor = colorDialog1.Color;
            italicMenu.ForeColor = colorDialog1.Color;
            regularMenu.ForeColor = colorDialog1.Color;

            fontStripMenu.ForeColor = colorDialog1.Color;
            fontMenu.ForeColor = colorDialog1.Color;
            colorMenu.ForeColor = colorDialog1.Color;

            colorSchemeMenu.ForeColor = colorDialog1.Color;

            aligmentMenu.ForeColor = colorDialog1.Color;
            leftAlign.ForeColor = colorDialog1.Color;
            centerAlign.ForeColor = colorDialog1.Color;
            rightAlign.ForeColor = colorDialog1.Color;
        }

        // Закрытие через кнопку "Close"
        private void closeFile_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
            // Выводим сообщение на экран
                DialogResult result = MessageBox.Show(
                "Вероятно, ваши данные не были сохранены. Сохранить?",
                "Предупреждение",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    saveAsMenu_click(sender, e);
                else
                    Application.Exit();
            }
            Application.Exit();
        }

        private void leftAlign_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerAlign_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightAlign_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void treatmentStripMenu_Click(object sender, EventArgs e)
        {
            CanUseButtons();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}