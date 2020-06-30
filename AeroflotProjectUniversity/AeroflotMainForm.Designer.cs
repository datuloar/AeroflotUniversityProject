namespace AeroflotProjectUniversity
{
    partial class AeroflotMainForm
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
            this.FillButton = new System.Windows.Forms.Button();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.DestinationBox = new System.Windows.Forms.TextBox();
            this.FlightNumberBox = new System.Windows.Forms.TextBox();
            this.TypeAirplaneBox = new System.Windows.Forms.TextBox();
            this.SearchTypeAirplaneBox = new System.Windows.Forms.TextBox();
            this.SearchTypeAirplaneButton = new System.Windows.Forms.Button();
            this.AddAirplane = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddAirplane.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FillButton
            // 
            this.FillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FillButton.Location = new System.Drawing.Point(12, 22);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(75, 24);
            this.FillButton.TabIndex = 0;
            this.FillButton.Text = "Fill in";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Enabled = false;
            this.ClearListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearListButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearListButton.Location = new System.Drawing.Point(93, 22);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(75, 24);
            this.ClearListButton.TabIndex = 1;
            this.ClearListButton.Text = "Clear";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteButton.Location = new System.Drawing.Point(174, 22);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 24);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddButton.Location = new System.Drawing.Point(6, 155);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(175, 24);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(246)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(405, 108);
            this.listBox1.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Location = new System.Drawing.Point(12, 166);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "by Flight Number";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.OutList);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton2.Location = new System.Drawing.Point(113, 166);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "by Destination";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.OutList);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton3.Location = new System.Drawing.Point(203, 166);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "by Type Airplane";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.OutList);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton4.Location = new System.Drawing.Point(305, 166);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(112, 17);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "by Departure Date";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.OutList);
            // 
            // DestinationBox
            // 
            this.DestinationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(246)))));
            this.DestinationBox.Location = new System.Drawing.Point(81, 34);
            this.DestinationBox.MaxLength = 20;
            this.DestinationBox.Name = "DestinationBox";
            this.DestinationBox.Size = new System.Drawing.Size(100, 20);
            this.DestinationBox.TabIndex = 9;
            // 
            // FlightNumberBox
            // 
            this.FlightNumberBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(246)))));
            this.FlightNumberBox.Location = new System.Drawing.Point(81, 60);
            this.FlightNumberBox.MaxLength = 6;
            this.FlightNumberBox.Name = "FlightNumberBox";
            this.FlightNumberBox.Size = new System.Drawing.Size(100, 20);
            this.FlightNumberBox.TabIndex = 10;
            // 
            // TypeAirplaneBox
            // 
            this.TypeAirplaneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(246)))));
            this.TypeAirplaneBox.Location = new System.Drawing.Point(81, 86);
            this.TypeAirplaneBox.MaxLength = 20;
            this.TypeAirplaneBox.Name = "TypeAirplaneBox";
            this.TypeAirplaneBox.Size = new System.Drawing.Size(100, 20);
            this.TypeAirplaneBox.TabIndex = 11;
            // 
            // SearchTypeAirplaneBox
            // 
            this.SearchTypeAirplaneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(246)))));
            this.SearchTypeAirplaneBox.Location = new System.Drawing.Point(91, 18);
            this.SearchTypeAirplaneBox.MaxLength = 20;
            this.SearchTypeAirplaneBox.Name = "SearchTypeAirplaneBox";
            this.SearchTypeAirplaneBox.Size = new System.Drawing.Size(196, 20);
            this.SearchTypeAirplaneBox.TabIndex = 12;
            // 
            // SearchTypeAirplaneButton
            // 
            this.SearchTypeAirplaneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchTypeAirplaneButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchTypeAirplaneButton.Location = new System.Drawing.Point(293, 14);
            this.SearchTypeAirplaneButton.Name = "SearchTypeAirplaneButton";
            this.SearchTypeAirplaneButton.Size = new System.Drawing.Size(100, 28);
            this.SearchTypeAirplaneButton.TabIndex = 13;
            this.SearchTypeAirplaneButton.Text = "Search";
            this.SearchTypeAirplaneButton.UseVisualStyleBackColor = true;
            this.SearchTypeAirplaneButton.Click += new System.EventHandler(this.SearchTypeAirplaneButton_Click);
            // 
            // AddAirplane
            // 
            this.AddAirplane.Controls.Add(this.maskedTextBox1);
            this.AddAirplane.Controls.Add(this.label4);
            this.AddAirplane.Controls.Add(this.label3);
            this.AddAirplane.Controls.Add(this.label2);
            this.AddAirplane.Controls.Add(this.label1);
            this.AddAirplane.Controls.Add(this.AddButton);
            this.AddAirplane.Controls.Add(this.DestinationBox);
            this.AddAirplane.Controls.Add(this.FlightNumberBox);
            this.AddAirplane.Controls.Add(this.TypeAirplaneBox);
            this.AddAirplane.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddAirplane.Location = new System.Drawing.Point(423, 52);
            this.AddAirplane.Name = "AddAirplane";
            this.AddAirplane.Size = new System.Drawing.Size(187, 186);
            this.AddAirplane.TabIndex = 14;
            this.AddAirplane.TabStop = false;
            this.AddAirplane.Text = "Add Airplane";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(246)))));
            this.maskedTextBox1.Location = new System.Drawing.Point(120, 110);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(61, 20);
            this.maskedTextBox1.TabIndex = 19;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(34, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Departure Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Type Airplane";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Flight Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Destination";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SearchTypeAirplaneBox);
            this.groupBox1.Controls.Add(this.SearchTypeAirplaneButton);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 49);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by type airplane";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(13, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Type Airplane";
            // 
            // AeroflotMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(621, 249);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddAirplane);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.FillButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AeroflotMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aeroflot project university";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AeroflotMainForm_Load);
            this.AddAirplane.ResumeLayout(false);
            this.AddAirplane.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox DestinationBox;
        private System.Windows.Forms.TextBox FlightNumberBox;
        private System.Windows.Forms.TextBox TypeAirplaneBox;
        private System.Windows.Forms.TextBox SearchTypeAirplaneBox;
        private System.Windows.Forms.Button SearchTypeAirplaneButton;
        private System.Windows.Forms.GroupBox AddAirplane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
    }
}

