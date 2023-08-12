
namespace graphics3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox_Direction = new System.Windows.Forms.ListBox();
            this.button1_RotatePlus = new System.Windows.Forms.Button();
            this.checkBox1_X = new System.Windows.Forms.CheckBox();
            this.checkBox2_Y = new System.Windows.Forms.CheckBox();
            this.checkBox3_Z = new System.Windows.Forms.CheckBox();
            this.button2_RotateMinus = new System.Windows.Forms.Button();
            this.button4_MoveMinus = new System.Windows.Forms.Button();
            this.button3_MovePlus = new System.Windows.Forms.Button();
            this.button5_ScalePlus = new System.Windows.Forms.Button();
            this.button6_ScaleMinus = new System.Windows.Forms.Button();
            this.comboBox_Figure = new System.Windows.Forms.ComboBox();
            this.comboBoxN = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3_Z = new System.Windows.Forms.Label();
            this.label2_Y = new System.Windows.Forms.Label();
            this.label1_X = new System.Windows.Forms.Label();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.comboBoxM = new System.Windows.Forms.ComboBox();
            this.button_SetChanges = new System.Windows.Forms.Button();
            this.checkBox_Hide = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(360, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(649, 430);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // listBox_Direction
            // 
            this.listBox_Direction.FormattingEnabled = true;
            this.listBox_Direction.ItemHeight = 16;
            this.listBox_Direction.Items.AddRange(new object[] {
            "front",
            "left",
            "above",
            "dimetry",
            "isometry"});
            this.listBox_Direction.Location = new System.Drawing.Point(34, 12);
            this.listBox_Direction.Name = "listBox_Direction";
            this.listBox_Direction.Size = new System.Drawing.Size(91, 84);
            this.listBox_Direction.TabIndex = 1;
            this.listBox_Direction.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1_RotatePlus
            // 
            this.button1_RotatePlus.Location = new System.Drawing.Point(12, 129);
            this.button1_RotatePlus.Name = "button1_RotatePlus";
            this.button1_RotatePlus.Size = new System.Drawing.Size(140, 49);
            this.button1_RotatePlus.TabIndex = 2;
            this.button1_RotatePlus.Text = "Rotate +";
            this.button1_RotatePlus.UseVisualStyleBackColor = true;
            this.button1_RotatePlus.Click += new System.EventHandler(this.button1_RotateX_Click);
            // 
            // checkBox1_X
            // 
            this.checkBox1_X.AutoSize = true;
            this.checkBox1_X.Location = new System.Drawing.Point(19, 102);
            this.checkBox1_X.Name = "checkBox1_X";
            this.checkBox1_X.Size = new System.Drawing.Size(39, 21);
            this.checkBox1_X.TabIndex = 3;
            this.checkBox1_X.Text = "X";
            this.checkBox1_X.UseVisualStyleBackColor = true;
            // 
            // checkBox2_Y
            // 
            this.checkBox2_Y.AutoSize = true;
            this.checkBox2_Y.Location = new System.Drawing.Point(64, 102);
            this.checkBox2_Y.Name = "checkBox2_Y";
            this.checkBox2_Y.Size = new System.Drawing.Size(39, 21);
            this.checkBox2_Y.TabIndex = 4;
            this.checkBox2_Y.Text = "Y";
            this.checkBox2_Y.UseVisualStyleBackColor = true;
            // 
            // checkBox3_Z
            // 
            this.checkBox3_Z.AutoSize = true;
            this.checkBox3_Z.Location = new System.Drawing.Point(109, 102);
            this.checkBox3_Z.Name = "checkBox3_Z";
            this.checkBox3_Z.Size = new System.Drawing.Size(39, 21);
            this.checkBox3_Z.TabIndex = 5;
            this.checkBox3_Z.Text = "Z";
            this.checkBox3_Z.UseVisualStyleBackColor = true;
            // 
            // button2_RotateMinus
            // 
            this.button2_RotateMinus.Location = new System.Drawing.Point(12, 184);
            this.button2_RotateMinus.Name = "button2_RotateMinus";
            this.button2_RotateMinus.Size = new System.Drawing.Size(140, 52);
            this.button2_RotateMinus.TabIndex = 6;
            this.button2_RotateMinus.Text = "Rotate -";
            this.button2_RotateMinus.UseVisualStyleBackColor = true;
            this.button2_RotateMinus.Click += new System.EventHandler(this.button2_RotateMinus_Click);
            // 
            // button4_MoveMinus
            // 
            this.button4_MoveMinus.Location = new System.Drawing.Point(12, 304);
            this.button4_MoveMinus.Name = "button4_MoveMinus";
            this.button4_MoveMinus.Size = new System.Drawing.Size(140, 49);
            this.button4_MoveMinus.TabIndex = 8;
            this.button4_MoveMinus.Text = "Move -";
            this.button4_MoveMinus.UseVisualStyleBackColor = true;
            this.button4_MoveMinus.Click += new System.EventHandler(this.button4_MoveMinus_Click);
            // 
            // button3_MovePlus
            // 
            this.button3_MovePlus.Location = new System.Drawing.Point(12, 249);
            this.button3_MovePlus.Name = "button3_MovePlus";
            this.button3_MovePlus.Size = new System.Drawing.Size(140, 49);
            this.button3_MovePlus.TabIndex = 7;
            this.button3_MovePlus.Text = "Move +";
            this.button3_MovePlus.UseVisualStyleBackColor = true;
            this.button3_MovePlus.Click += new System.EventHandler(this.button3_MovePlus_Click);
            // 
            // button5_ScalePlus
            // 
            this.button5_ScalePlus.Location = new System.Drawing.Point(12, 367);
            this.button5_ScalePlus.Name = "button5_ScalePlus";
            this.button5_ScalePlus.Size = new System.Drawing.Size(140, 49);
            this.button5_ScalePlus.TabIndex = 10;
            this.button5_ScalePlus.Text = "Scale +";
            this.button5_ScalePlus.UseVisualStyleBackColor = true;
            this.button5_ScalePlus.Click += new System.EventHandler(this.button5_ScalePlus_Click);
            // 
            // button6_ScaleMinus
            // 
            this.button6_ScaleMinus.Location = new System.Drawing.Point(12, 422);
            this.button6_ScaleMinus.Name = "button6_ScaleMinus";
            this.button6_ScaleMinus.Size = new System.Drawing.Size(140, 49);
            this.button6_ScaleMinus.TabIndex = 9;
            this.button6_ScaleMinus.Text = "Scale -";
            this.button6_ScaleMinus.UseVisualStyleBackColor = true;
            this.button6_ScaleMinus.Click += new System.EventHandler(this.button6_ScaleMinus_Click);
            // 
            // comboBox_Figure
            // 
            this.comboBox_Figure.FormattingEnabled = true;
            this.comboBox_Figure.Items.AddRange(new object[] {
            "Pyr",
            "Surface"});
            this.comboBox_Figure.Location = new System.Drawing.Point(188, 23);
            this.comboBox_Figure.Name = "comboBox_Figure";
            this.comboBox_Figure.Size = new System.Drawing.Size(134, 24);
            this.comboBox_Figure.TabIndex = 11;
            this.comboBox_Figure.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxN
            // 
            this.comboBoxN.FormattingEnabled = true;
            this.comboBoxN.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBoxN.Location = new System.Drawing.Point(13, 21);
            this.comboBoxN.Name = "comboBoxN";
            this.comboBoxN.Size = new System.Drawing.Size(57, 24);
            this.comboBoxN.TabIndex = 13;
            this.comboBoxN.Text = "0";
            this.comboBoxN.SelectedIndexChanged += new System.EventHandler(this.comboBoxN_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3_Z);
            this.panel1.Controls.Add(this.label2_Y);
            this.panel1.Controls.Add(this.label1_X);
            this.panel1.Controls.Add(this.textBoxZ);
            this.panel1.Controls.Add(this.textBoxY);
            this.panel1.Controls.Add(this.textBoxX);
            this.panel1.Controls.Add(this.comboBoxM);
            this.panel1.Controls.Add(this.comboBoxN);
            this.panel1.Location = new System.Drawing.Point(175, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 187);
            this.panel1.TabIndex = 14;
            // 
            // label3_Z
            // 
            this.label3_Z.AutoSize = true;
            this.label3_Z.Location = new System.Drawing.Point(13, 147);
            this.label3_Z.Name = "label3_Z";
            this.label3_Z.Size = new System.Drawing.Size(17, 17);
            this.label3_Z.TabIndex = 20;
            this.label3_Z.Text = "Z";
            // 
            // label2_Y
            // 
            this.label2_Y.AutoSize = true;
            this.label2_Y.Location = new System.Drawing.Point(13, 106);
            this.label2_Y.Name = "label2_Y";
            this.label2_Y.Size = new System.Drawing.Size(17, 17);
            this.label2_Y.TabIndex = 19;
            this.label2_Y.Text = "Y";
            // 
            // label1_X
            // 
            this.label1_X.AutoSize = true;
            this.label1_X.Location = new System.Drawing.Point(13, 64);
            this.label1_X.Name = "label1_X";
            this.label1_X.Size = new System.Drawing.Size(17, 17);
            this.label1_X.TabIndex = 18;
            this.label1_X.Text = "X";
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(53, 144);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(100, 22);
            this.textBoxZ.TabIndex = 17;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(53, 106);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 22);
            this.textBoxY.TabIndex = 16;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(53, 64);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 22);
            this.textBoxX.TabIndex = 15;
            // 
            // comboBoxM
            // 
            this.comboBoxM.FormattingEnabled = true;
            this.comboBoxM.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBoxM.Location = new System.Drawing.Point(92, 21);
            this.comboBoxM.Name = "comboBoxM";
            this.comboBoxM.Size = new System.Drawing.Size(61, 24);
            this.comboBoxM.TabIndex = 14;
            this.comboBoxM.Text = "0";
            this.comboBoxM.SelectedIndexChanged += new System.EventHandler(this.comboBoxN_SelectedIndexChanged);
            // 
            // button_SetChanges
            // 
            this.button_SetChanges.Location = new System.Drawing.Point(202, 348);
            this.button_SetChanges.Name = "button_SetChanges";
            this.button_SetChanges.Size = new System.Drawing.Size(97, 35);
            this.button_SetChanges.TabIndex = 15;
            this.button_SetChanges.Text = "set";
            this.button_SetChanges.UseVisualStyleBackColor = true;
            this.button_SetChanges.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_Hide
            // 
            this.checkBox_Hide.AutoSize = true;
            this.checkBox_Hide.Location = new System.Drawing.Point(202, 63);
            this.checkBox_Hide.Name = "checkBox_Hide";
            this.checkBox_Hide.Size = new System.Drawing.Size(59, 21);
            this.checkBox_Hide.TabIndex = 16;
            this.checkBox_Hide.Text = "Hide";
            this.checkBox_Hide.UseVisualStyleBackColor = true;
            this.checkBox_Hide.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 483);
            this.Controls.Add(this.checkBox_Hide);
            this.Controls.Add(this.button_SetChanges);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox_Figure);
            this.Controls.Add(this.button5_ScalePlus);
            this.Controls.Add(this.button6_ScaleMinus);
            this.Controls.Add(this.button4_MoveMinus);
            this.Controls.Add(this.button3_MovePlus);
            this.Controls.Add(this.button2_RotateMinus);
            this.Controls.Add(this.checkBox3_Z);
            this.Controls.Add(this.checkBox2_Y);
            this.Controls.Add(this.checkBox1_X);
            this.Controls.Add(this.button1_RotatePlus);
            this.Controls.Add(this.listBox_Direction);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox_Direction;
        private System.Windows.Forms.Button button1_RotatePlus;
        private System.Windows.Forms.CheckBox checkBox1_X;
        private System.Windows.Forms.CheckBox checkBox2_Y;
        private System.Windows.Forms.CheckBox checkBox3_Z;
        private System.Windows.Forms.Button button2_RotateMinus;
        private System.Windows.Forms.Button button4_MoveMinus;
        private System.Windows.Forms.Button button3_MovePlus;
        private System.Windows.Forms.Button button5_ScalePlus;
        private System.Windows.Forms.Button button6_ScaleMinus;
        private System.Windows.Forms.ComboBox comboBox_Figure;
        private System.Windows.Forms.ComboBox comboBoxN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3_Z;
        private System.Windows.Forms.Label label2_Y;
        private System.Windows.Forms.Label label1_X;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.ComboBox comboBoxM;
        private System.Windows.Forms.Button button_SetChanges;
        private System.Windows.Forms.CheckBox checkBox_Hide;
    }
}

