namespace Editor_grafic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFillColor = new System.Windows.Forms.Button();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.colorChange = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.drawRectangle = new System.Windows.Forms.Button();
            this.drawLine = new System.Windows.Forms.Button();
            this.drawEllips = new System.Windows.Forms.Button();
            this.drawingPlace = new System.Windows.Forms.Panel();
            this.drawCurve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.drawCurve);
            this.groupBox1.Controls.Add(this.buttonFillColor);
            this.groupBox1.Controls.Add(this.buttonEraser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.colorChange);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.drawRectangle);
            this.groupBox1.Controls.Add(this.drawLine);
            this.groupBox1.Controls.Add(this.drawEllips);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonFillColor
            // 
            this.buttonFillColor.Image = ((System.Drawing.Image)(resources.GetObject("buttonFillColor.Image")));
            this.buttonFillColor.Location = new System.Drawing.Point(304, 4);
            this.buttonFillColor.Name = "buttonFillColor";
            this.buttonFillColor.Size = new System.Drawing.Size(35, 35);
            this.buttonFillColor.TabIndex = 7;
            this.buttonFillColor.UseVisualStyleBackColor = true;
            this.buttonFillColor.Click += new System.EventHandler(this.buttonFillColor_Click);
            // 
            // buttonEraser
            // 
            this.buttonEraser.Image = ((System.Drawing.Image)(resources.GetObject("buttonEraser.Image")));
            this.buttonEraser.Location = new System.Drawing.Point(263, 4);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(35, 35);
            this.buttonEraser.TabIndex = 6;
            this.buttonEraser.UseVisualStyleBackColor = true;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(166, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Цвета";
            // 
            // colorChange
            // 
            this.colorChange.BackColor = System.Drawing.Color.White;
            this.colorChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colorChange.BackgroundImage")));
            this.colorChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.colorChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorChange.Location = new System.Drawing.Point(172, 4);
            this.colorChange.Name = "colorChange";
            this.colorChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colorChange.Size = new System.Drawing.Size(35, 35);
            this.colorChange.TabIndex = 4;
            this.colorChange.Click += new System.EventHandler(this.colorChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фигуры";
            // 
            // drawRectangle
            // 
            this.drawRectangle.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangle.Image")));
            this.drawRectangle.Location = new System.Drawing.Point(88, 4);
            this.drawRectangle.Name = "drawRectangle";
            this.drawRectangle.Size = new System.Drawing.Size(35, 35);
            this.drawRectangle.TabIndex = 2;
            this.drawRectangle.UseVisualStyleBackColor = true;
            this.drawRectangle.Click += new System.EventHandler(this.drawRectangle_Click);
            // 
            // drawLine
            // 
            this.drawLine.Image = ((System.Drawing.Image)(resources.GetObject("drawLine.Image")));
            this.drawLine.Location = new System.Drawing.Point(47, 4);
            this.drawLine.Name = "drawLine";
            this.drawLine.Size = new System.Drawing.Size(35, 35);
            this.drawLine.TabIndex = 1;
            this.drawLine.UseVisualStyleBackColor = true;
            this.drawLine.Click += new System.EventHandler(this.drawLine_Click);
            // 
            // drawEllips
            // 
            this.drawEllips.Image = ((System.Drawing.Image)(resources.GetObject("drawEllips.Image")));
            this.drawEllips.Location = new System.Drawing.Point(6, 4);
            this.drawEllips.Name = "drawEllips";
            this.drawEllips.Size = new System.Drawing.Size(35, 35);
            this.drawEllips.TabIndex = 0;
            this.drawEllips.UseVisualStyleBackColor = true;
            this.drawEllips.Click += new System.EventHandler(this.drawEllips_Click);
            // 
            // drawingPlace
            // 
            this.drawingPlace.BackColor = System.Drawing.Color.White;
            this.drawingPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingPlace.Location = new System.Drawing.Point(0, 89);
            this.drawingPlace.Name = "drawingPlace";
            this.drawingPlace.Size = new System.Drawing.Size(800, 361);
            this.drawingPlace.TabIndex = 1;
            this.drawingPlace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPlace_MouseDown);
            this.drawingPlace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPlace_MouseMove);
            this.drawingPlace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPlace_MouseUp);
            // 
            // drawCurve
            // 
            this.drawCurve.Image = ((System.Drawing.Image)(resources.GetObject("drawCurve.Image")));
            this.drawCurve.Location = new System.Drawing.Point(345, 4);
            this.drawCurve.Name = "drawCurve";
            this.drawCurve.Size = new System.Drawing.Size(35, 35);
            this.drawCurve.TabIndex = 8;
            this.drawCurve.UseVisualStyleBackColor = true;
            this.drawCurve.Click += new System.EventHandler(this.drawCurve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(269, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Инструменты";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(432, 4);
            this.trackBar1.Maximum = 15;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(433, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Толщина";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawingPlace);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button drawRectangle;
        private System.Windows.Forms.Button drawLine;
        private System.Windows.Forms.Button drawEllips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel colorChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFillColor;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.Panel drawingPlace;
        private System.Windows.Forms.Button drawCurve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

