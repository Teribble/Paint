namespace Paint
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.colorBar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonFill = new System.Windows.Forms.ToolStripButton();
            this.buttonPensil = new System.Windows.Forms.ToolStripButton();
            this.buttonErase = new System.Windows.Forms.ToolStripButton();
            this.buttonLine = new System.Windows.Forms.ToolStripButton();
            this.buttonCircle = new System.Windows.Forms.ToolStripButton();
            this.buttonRectangle = new System.Windows.Forms.ToolStripButton();
            this.buttonText = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.currentColor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainPicture = new System.Windows.Forms.PictureBox();
            this.colorSelection = new System.Windows.Forms.ColorDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.colorBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // colorBar
            // 
            this.colorBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBar.Image = ((System.Drawing.Image)(resources.GetObject("colorBar.Image")));
            this.colorBar.Location = new System.Drawing.Point(509, 3);
            this.colorBar.Name = "colorBar";
            this.colorBar.Size = new System.Drawing.Size(585, 136);
            this.colorBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorBar.TabIndex = 0;
            this.colorBar.TabStop = false;
            this.colorBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnColorBarMouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.buttonLoadImage);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.currentColor);
            this.panel1.Controls.Add(this.colorBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1484, 145);
            this.panel1.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(14, 36);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.OnClickButtonSave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(275, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 40);
            this.panel3.TabIndex = 4;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(200, 40);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.OnScrollTrackBar1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(200, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.TextChanged += new System.EventHandler(this.OnTextChangedLabel1);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(14, 12);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.OnClickButtonClear);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.toolStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1097, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 145);
            this.panel4.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonFill,
            this.buttonPensil,
            this.buttonErase,
            this.buttonLine,
            this.buttonCircle,
            this.buttonRectangle,
            this.buttonText,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(387, 145);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonFill
            // 
            this.buttonFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonFill.Image = ((System.Drawing.Image)(resources.GetObject("buttonFill.Image")));
            this.buttonFill.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(44, 142);
            this.buttonFill.Text = "toolStripButton1";
            this.buttonFill.Click += new System.EventHandler(this.OnClickButtonFill);
            // 
            // buttonPensil
            // 
            this.buttonPensil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPensil.Image = ((System.Drawing.Image)(resources.GetObject("buttonPensil.Image")));
            this.buttonPensil.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonPensil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPensil.Name = "buttonPensil";
            this.buttonPensil.Size = new System.Drawing.Size(44, 142);
            this.buttonPensil.Text = "toolStripButton1";
            this.buttonPensil.Click += new System.EventHandler(this.OnButtonPensilClick);
            // 
            // buttonErase
            // 
            this.buttonErase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonErase.Image = ((System.Drawing.Image)(resources.GetObject("buttonErase.Image")));
            this.buttonErase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonErase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(44, 142);
            this.buttonErase.Text = "toolStripButton1";
            this.buttonErase.BackColorChanged += new System.EventHandler(this.OnBackColorChangedButtonErase);
            this.buttonErase.Click += new System.EventHandler(this.OnButtonEraseClick);
            // 
            // buttonLine
            // 
            this.buttonLine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonLine.Image = ((System.Drawing.Image)(resources.GetObject("buttonLine.Image")));
            this.buttonLine.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(44, 142);
            this.buttonLine.Text = "toolStripButton1";
            this.buttonLine.Click += new System.EventHandler(this.OnButtonLineClick);
            // 
            // buttonCircle
            // 
            this.buttonCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCircle.Image = ((System.Drawing.Image)(resources.GetObject("buttonCircle.Image")));
            this.buttonCircle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(44, 142);
            this.buttonCircle.Text = "toolStripButton1";
            this.buttonCircle.Click += new System.EventHandler(this.OnButtonCircleClick);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("buttonRectangle.Image")));
            this.buttonRectangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(44, 142);
            this.buttonRectangle.Text = "toolStripButton1";
            this.buttonRectangle.Click += new System.EventHandler(this.OnButtonRectangleClick);
            // 
            // buttonText
            // 
            this.buttonText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonText.Image = ((System.Drawing.Image)(resources.GetObject("buttonText.Image")));
            this.buttonText.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(44, 142);
            this.buttonText.Text = "toolStripButton1";
            this.buttonText.BackColorChanged += new System.EventHandler(this.OnButtonTextChangedBackColor);
            this.buttonText.Click += new System.EventHandler(this.OnClickButtonText);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 142);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.OnClickSelectColor);
            // 
            // currentColor
            // 
            this.currentColor.BackColor = System.Drawing.Color.White;
            this.currentColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.currentColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentColor.Location = new System.Drawing.Point(180, 12);
            this.currentColor.Name = "currentColor";
            this.currentColor.Size = new System.Drawing.Size(89, 40);
            this.currentColor.TabIndex = 4;
            this.currentColor.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 839);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1484, 22);
            this.panel2.TabIndex = 2;
            // 
            // mainPicture
            // 
            this.mainPicture.BackColor = System.Drawing.Color.White;
            this.mainPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPicture.Location = new System.Drawing.Point(0, 145);
            this.mainPicture.Name = "mainPicture";
            this.mainPicture.Size = new System.Drawing.Size(1484, 694);
            this.mainPicture.TabIndex = 3;
            this.mainPicture.TabStop = false;
            this.mainPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaintMainPicture);
            this.mainPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClickMainPicture);
            this.mainPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMainPictureMouseDown);
            this.mainPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMainPictureMouseMove);
            this.mainPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMainPictureMouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Visible = false;
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(95, 12);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadImage.TabIndex = 14;
            this.buttonLoadImage.Text = "Load image";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.OnClickButtonLoadImage);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Введите текст";
            this.label2.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.mainPicture);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1500, 900);
            this.MinimumSize = new System.Drawing.Size(1500, 900);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox colorBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button currentColor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonFill;
        private System.Windows.Forms.ToolStripButton buttonPensil;
        private System.Windows.Forms.ToolStripButton buttonErase;
        private System.Windows.Forms.ToolStripButton buttonLine;
        private System.Windows.Forms.ToolStripButton buttonCircle;
        private System.Windows.Forms.ToolStripButton buttonRectangle;
        private System.Windows.Forms.PictureBox mainPicture;
        private System.Windows.Forms.ColorDialog colorSelection;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ToolStripButton buttonText;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
    }
}

