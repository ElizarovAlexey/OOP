using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EditorText_v._2
{
    public partial class Form1 : Form
    {
        Files file = new Files();
        Edit edit = new Edit();
        Formate formate = new Formate();
        public Form1()
        {
            InitializeComponent();
            // Фильтры расширений для сохранения и открытия файлов
            saveFileDialog1.Filter = "Text Files(*.txt)|*.txt | RTF Files(*.rtf)|*.rtf";
            openFileDialog1.Filter = "Text files(*.txt)|*.txt | RTF Files(*.rtf)|*.rtf";

            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            openToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.N;
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            findAndReplaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;

        }

        // Событие "Close"
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file.CloseFile(Form.ActiveForm);
        }

        // Событие "New"
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file.CreateFile(richTextBox1);
        }

        // Событие "Open"
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            file.OpenFile(richTextBox1);
        }

        // Событие "Save As"
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file.SaveFile(richTextBox1);
        }

        // Событие "Print"
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file.PrintFile();
        }

        // Вкладка "EDIT"

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit.IsEnabled(richTextBox1, cutToolStripMenuItem);
            edit.IsEnabled(richTextBox1, copyToolStripMenuItem);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit.CopyText(richTextBox1);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit.PasteText(richTextBox1);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit.CutText(richTextBox1);
        }

        // Вкладка "FORMATE"


        private void formateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formate.IsEnabled(boldMenu, richTextBox1);
            formate.IsEnabled(italicMenu, richTextBox1);
            formate.IsEnabled(regularMenu, richTextBox1);
        }

        private void fontsMenu_Click(object sender, EventArgs e)
        {
            formate.FontMenu(richTextBox1);
        }

        private void colorMenu_Click(object sender, EventArgs e)
        {
            formate.ColorMenu(richTextBox1);
        }

        private void boldMenu_Click(object sender, EventArgs e)
        {
            formate.MakeTextBold(richTextBox1);
        }

        private void italicMenu_Click(object sender, EventArgs e)
        {
            formate.MakeTextItalic(richTextBox1);
        }

        private void regularMenu_Click(object sender, EventArgs e)
        {
            formate.MakeTextRegular(richTextBox1);
        }

        // Вкладка "ALIGNMENT"

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void colorSchemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            Form.ActiveForm.BackColor = colorDialog1.Color;
            menuStrip.BackColor = colorDialog1.Color;
            menuStrip.ForeColor = Color.White;

            buttonClear.BackColor = colorDialog1.Color;
            buttonClear.ForeColor = Color.White;

            buttonOpenFile.BackColor = colorDialog1.Color;
            buttonOpenFile.ForeColor = Color.White;

            buttonSaveAs.BackColor = colorDialog1.Color;
            buttonSaveAs.ForeColor = Color.White;
        }

        private int StringCount()
        {
            Graphics g = CreateGraphics();
            float count = (g.MeasureString(richTextBox1.Text, richTextBox1.Font).Width / richTextBox1.Width);
            int n;
            n = (int)count;
            if (count > n)
                n++;

            return n;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int words = richTextBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            toolStripLabel1.Text = words.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form form = new Form { Size = new Size(180, 150), FormBorderStyle = FormBorderStyle.FixedToolWindow, StartPosition = FormStartPosition.CenterParent };
            Label LettersCount = new Label { Size = new Size(150, 25), Location = new Point(10, 5) };
            Label LettersWSC = new Label { Size = new Size(150, 25), Location = new Point(10, 30) };
            Label WordsCount = new Label { Size = new Size(150, 25), Location = new Point(10, 55) };
            Label StringsCount = new Label { Size = new Size(150, 25), Location = new Point(10, 80) };
            LettersCount.Text = "Letters:" + richTextBox1.TextLength.ToString();
            LettersWSC.Text = "Symbols without Space:" + richTextBox1.Text.Replace(" ", "").Length.ToString();
            WordsCount.Text = "Words:" + richTextBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length.ToString();
            StringsCount.Text = "Strings:" + StringCount().ToString();
            form.Controls.Add(LettersCount);
            form.Controls.Add(LettersWSC);
            form.Controls.Add(WordsCount);
            form.Controls.Add(StringsCount);
            form.ShowDialog();
        }

        private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form() { Size = new Size(275, 190), ControlBox = false, StartPosition = FormStartPosition.CenterParent };
            Label labelWordOne = new Label() { Size = new Size(275, 25), Location = new Point(40, 10) };
            TextBox wordOne = new TextBox() { Size = new Size(130, 25), Location = new Point(70, 35) };
            Label labelWordTwo = new Label() { Size = new Size(275, 25), Location = new Point(40, 80) };
            TextBox wordTwo = new TextBox() { Size = new Size(130, 25), Location = new Point(70, 105) };
            Button replace = new Button() { Size = new Size(80, 25), Location = new Point(25, 135) };
            Button close = new Button() { Size = new Size(80, 25), Location = new Point(155, 135) };

            labelWordOne.Text = "Слово, которое хотите заменить: ";
            labelWordTwo.Text = "Слово, на которое хотите заменить: ";
            replace.Text = "Заменить";
            close.Text = "Закрыть";

            close.Click += (send, evt) => form.Close();
            replace.Click += (send, evt) => edit.FindReplace(richTextBox1, wordOne.Text, wordTwo.Text);

            form.Controls.Add(labelWordOne);
            form.Controls.Add(wordOne);
            form.Controls.Add(labelWordTwo);
            form.Controls.Add(wordTwo);
            form.Controls.Add(replace);
            form.Controls.Add(close);
            form.ShowDialog();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form() { Size = new Size(265, 150), ControlBox = false, StartPosition = FormStartPosition.CenterParent };
            Label labelWord = new Label() { Size = new Size(275, 25), Location = new Point(85, 10) };
            TextBox word = new TextBox() { Size = new Size(130, 25), Location = new Point(60, 35) };
            Button find = new Button() { Size = new Size(70, 25), Location = new Point(10, 95) };
            Button clear = new Button() { Size = new Size(70, 25), Location = new Point(90, 95) };
            Button close = new Button() { Size = new Size(70, 25), Location = new Point(170, 95) };

            labelWord.Text = "Введите слово";
            close.Text = "Закрыть";
            find.Text = "Найти";
            clear.Text = "Очистить";

            close.Click += (send, evt) => form.Close();
            find.Click += (send, evt) => edit.Find(richTextBox1, word);
            clear.Click += (send, evt) => edit.FindClear(richTextBox1);

            form.Controls.Add(labelWord);
            form.Controls.Add(word);
            form.Controls.Add(close);
            form.Controls.Add(find);
            form.Controls.Add(clear);
            form.ShowDialog();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
