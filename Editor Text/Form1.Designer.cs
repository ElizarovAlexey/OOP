namespace Editor_Text
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.printMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.editStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.findMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.treatmentStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.boldMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.italicMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.regularMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fontStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSchemeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aligmentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.leftAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.centerAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.rightAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClear = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.saveAs = new System.Windows.Forms.Button();
            this.buttonItalic = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonBold = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenu,
            this.editStripMenu,
            this.treatmentStripMenu,
            this.fontStripMenu,
            this.colorSchemeMenu,
            this.aligmentMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileStripMenu
            // 
            this.fileStripMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fileStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenu,
            this.saveMenu,
            this.saveAsMenu,
            this.printMenu,
            this.closeFile});
            this.fileStripMenu.Name = "fileStripMenu";
            this.fileStripMenu.Size = new System.Drawing.Size(37, 20);
            this.fileStripMenu.Text = "File";
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(180, 22);
            this.openMenu.Text = "Open";
            this.openMenu.Click += new System.EventHandler(this.openMenu_click);
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(180, 22);
            this.saveMenu.Text = "Save";
            // 
            // saveAsMenu
            // 
            this.saveAsMenu.Name = "saveAsMenu";
            this.saveAsMenu.Size = new System.Drawing.Size(180, 22);
            this.saveAsMenu.Text = "Save as";
            this.saveAsMenu.Click += new System.EventHandler(this.saveAsMenu_click);
            // 
            // printMenu
            // 
            this.printMenu.Name = "printMenu";
            this.printMenu.Size = new System.Drawing.Size(180, 22);
            this.printMenu.Text = "Print";
            this.printMenu.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // closeFile
            // 
            this.closeFile.Name = "closeFile";
            this.closeFile.Size = new System.Drawing.Size(180, 22);
            this.closeFile.Text = "Close";
            this.closeFile.Click += new System.EventHandler(this.closeFile_Click);
            // 
            // editStripMenu
            // 
            this.editStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyMenu,
            this.pasteMenu,
            this.cutMenu,
            this.findMenu});
            this.editStripMenu.Name = "editStripMenu";
            this.editStripMenu.Size = new System.Drawing.Size(39, 20);
            this.editStripMenu.Text = "Edit";
            // 
            // copyMenu
            // 
            this.copyMenu.Name = "copyMenu";
            this.copyMenu.Size = new System.Drawing.Size(149, 22);
            this.copyMenu.Text = "Copy";
            this.copyMenu.Click += new System.EventHandler(this.copyMenuButton_Click);
            // 
            // pasteMenu
            // 
            this.pasteMenu.Name = "pasteMenu";
            this.pasteMenu.Size = new System.Drawing.Size(149, 22);
            this.pasteMenu.Text = "Paste";
            this.pasteMenu.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // cutMenu
            // 
            this.cutMenu.Name = "cutMenu";
            this.cutMenu.Size = new System.Drawing.Size(149, 22);
            this.cutMenu.Text = "Cut";
            this.cutMenu.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // findMenu
            // 
            this.findMenu.Name = "findMenu";
            this.findMenu.Size = new System.Drawing.Size(149, 22);
            this.findMenu.Text = "Find / Replace";
            // 
            // treatmentStripMenu
            // 
            this.treatmentStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldMenu,
            this.italicMenu,
            this.regularMenu});
            this.treatmentStripMenu.Name = "treatmentStripMenu";
            this.treatmentStripMenu.Size = new System.Drawing.Size(72, 20);
            this.treatmentStripMenu.Text = "Treatment";
            this.treatmentStripMenu.Click += new System.EventHandler(this.treatmentStripMenu_Click);
            // 
            // boldMenu
            // 
            this.boldMenu.Name = "boldMenu";
            this.boldMenu.Size = new System.Drawing.Size(114, 22);
            this.boldMenu.Text = "Bold";
            this.boldMenu.Click += new System.EventHandler(this.bold_click);
            // 
            // italicMenu
            // 
            this.italicMenu.Name = "italicMenu";
            this.italicMenu.Size = new System.Drawing.Size(114, 22);
            this.italicMenu.Text = "Italic";
            this.italicMenu.Click += new System.EventHandler(this.buttonItalic_Click);
            // 
            // regularMenu
            // 
            this.regularMenu.Name = "regularMenu";
            this.regularMenu.Size = new System.Drawing.Size(114, 22);
            this.regularMenu.Text = "Regular";
            this.regularMenu.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // fontStripMenu
            // 
            this.fontStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontMenu,
            this.colorMenu});
            this.fontStripMenu.Name = "fontStripMenu";
            this.fontStripMenu.Size = new System.Drawing.Size(43, 20);
            this.fontStripMenu.Text = "Font";
            // 
            // fontMenu
            // 
            this.fontMenu.Name = "fontMenu";
            this.fontMenu.Size = new System.Drawing.Size(103, 22);
            this.fontMenu.Text = "Fonts";
            this.fontMenu.Click += new System.EventHandler(this.fontMenu_Click);
            // 
            // colorMenu
            // 
            this.colorMenu.Name = "colorMenu";
            this.colorMenu.Size = new System.Drawing.Size(103, 22);
            this.colorMenu.Text = "Color";
            this.colorMenu.Click += new System.EventHandler(this.colorMenu_Click);
            // 
            // colorSchemeMenu
            // 
            this.colorSchemeMenu.Name = "colorSchemeMenu";
            this.colorSchemeMenu.Size = new System.Drawing.Size(92, 20);
            this.colorSchemeMenu.Text = "Color scheme";
            this.colorSchemeMenu.Click += new System.EventHandler(this.colorSchemeToolStripMenuItem_Click);
            // 
            // aligmentMenu
            // 
            this.aligmentMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftAlign,
            this.centerAlign,
            this.rightAlign});
            this.aligmentMenu.Name = "aligmentMenu";
            this.aligmentMenu.Size = new System.Drawing.Size(68, 20);
            this.aligmentMenu.Text = "Aligment";
            // 
            // leftAlign
            // 
            this.leftAlign.Name = "leftAlign";
            this.leftAlign.Size = new System.Drawing.Size(109, 22);
            this.leftAlign.Text = "Left";
            this.leftAlign.Click += new System.EventHandler(this.leftAlign_Click);
            // 
            // centerAlign
            // 
            this.centerAlign.Name = "centerAlign";
            this.centerAlign.Size = new System.Drawing.Size(109, 22);
            this.centerAlign.Text = "Center";
            this.centerAlign.Click += new System.EventHandler(this.centerAlign_Click);
            // 
            // rightAlign
            // 
            this.rightAlign.Name = "rightAlign";
            this.rightAlign.Size = new System.Drawing.Size(109, 22);
            this.rightAlign.Text = "Right";
            this.rightAlign.Click += new System.EventHandler(this.rightAlign_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear text";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(78, 4);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(60, 23);
            this.openFile.TabIndex = 4;
            this.openFile.Text = "Open";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openMenu_click);
            // 
            // saveAs
            // 
            this.saveAs.Location = new System.Drawing.Point(145, 4);
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(60, 23);
            this.saveAs.TabIndex = 5;
            this.saveAs.Text = "Save as";
            this.saveAs.UseVisualStyleBackColor = true;
            this.saveAs.Click += new System.EventHandler(this.saveAsMenu_click);
            // 
            // buttonItalic
            // 
            this.buttonItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonItalic.Location = new System.Drawing.Point(256, 4);
            this.buttonItalic.Name = "buttonItalic";
            this.buttonItalic.Size = new System.Drawing.Size(21, 23);
            this.buttonItalic.TabIndex = 7;
            this.buttonItalic.Text = "i";
            this.buttonItalic.UseVisualStyleBackColor = true;
            this.buttonItalic.Click += new System.EventHandler(this.buttonItalic_Click);
            // 
            // buttonR
            // 
            this.buttonR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonR.Location = new System.Drawing.Point(284, 4);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(21, 23);
            this.buttonR.TabIndex = 8;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonBold
            // 
            this.buttonBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBold.Location = new System.Drawing.Point(228, 4);
            this.buttonBold.Name = "buttonBold";
            this.buttonBold.Size = new System.Drawing.Size(21, 23);
            this.buttonBold.TabIndex = 6;
            this.buttonBold.Text = "B";
            this.buttonBold.UseVisualStyleBackColor = true;
            this.buttonBold.Click += new System.EventHandler(this.bold_click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.openFile);
            this.panel1.Controls.Add(this.buttonR);
            this.panel1.Controls.Add(this.saveAs);
            this.panel1.Controls.Add(this.buttonItalic);
            this.panel1.Controls.Add(this.buttonBold);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 31);
            this.panel1.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(715, 386);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 441);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Блокнот";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenu;
        private System.Windows.Forms.ToolStripMenuItem printMenu;
        private System.Windows.Forms.ToolStripMenuItem editStripMenu;
        private System.Windows.Forms.ToolStripMenuItem copyMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteMenu;
        private System.Windows.Forms.ToolStripMenuItem cutMenu;
        private System.Windows.Forms.ToolStripMenuItem findMenu;
        private System.Windows.Forms.ToolStripMenuItem treatmentStripMenu;
        private System.Windows.Forms.ToolStripMenuItem boldMenu;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveAs;
        private System.Windows.Forms.ToolStripMenuItem italicMenu;
        private System.Windows.Forms.Button buttonItalic;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonBold;
        private System.Windows.Forms.ToolStripMenuItem fontStripMenu;
        private System.Windows.Forms.ToolStripMenuItem fontMenu;
        private System.Windows.Forms.ToolStripMenuItem regularMenu;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem colorMenu;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem colorSchemeMenu;
        private System.Windows.Forms.ToolStripMenuItem closeFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem aligmentMenu;
        private System.Windows.Forms.ToolStripMenuItem leftAlign;
        private System.Windows.Forms.ToolStripMenuItem centerAlign;
        private System.Windows.Forms.ToolStripMenuItem rightAlign;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

