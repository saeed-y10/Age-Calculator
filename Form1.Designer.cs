namespace Age_Calculator
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
            this.components = new System.ComponentModel.Container();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txbHead = new System.Windows.Forms.TextBox();
            this.panelHead = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtCurrentDate = new System.Windows.Forms.DateTimePicker();
            this.chkCustomDate = new System.Windows.Forms.CheckBox();
            this.btnCaluculate = new System.Windows.Forms.Button();
            this.gbAge = new System.Windows.Forms.GroupBox();
            this.lblTotalSeconds = new System.Windows.Forms.Label();
            this.lblTotalMinutes = new System.Windows.Forms.Label();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.lblTotalDays = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblMonths = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbAge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirthDate.Location = new System.Drawing.Point(118, 152);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(200, 22);
            this.dtBirthDate.TabIndex = 0;
            this.dtBirthDate.Value = new System.DateTime(2023, 8, 23, 0, 0, 0, 0);
            this.dtBirthDate.ValueChanged += new System.EventHandler(this.dtBirthDate_ValueChanged);
            // 
            // txbHead
            // 
            this.txbHead.BackColor = System.Drawing.SystemColors.Control;
            this.txbHead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbHead.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbHead.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txbHead.ForeColor = System.Drawing.Color.Maroon;
            this.txbHead.Location = new System.Drawing.Point(3, 26);
            this.txbHead.Multiline = true;
            this.txbHead.Name = "txbHead";
            this.txbHead.Size = new System.Drawing.Size(303, 48);
            this.txbHead.TabIndex = 0;
            this.txbHead.TabStop = false;
            this.txbHead.Text = "Age Calculator";
            this.txbHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.pictureBox1);
            this.panelHead.Controls.Add(this.txbHead);
            this.panelHead.Location = new System.Drawing.Point(12, 13);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(478, 100);
            this.panelHead.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Age_Calculator.Properties.Resources.AgeRange;
            this.pictureBox1.Location = new System.Drawing.Point(294, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dtCurrentDate
            // 
            this.dtCurrentDate.CustomFormat = "dd/MM/yyyy";
            this.dtCurrentDate.Enabled = false;
            this.dtCurrentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCurrentDate.Location = new System.Drawing.Point(118, 187);
            this.dtCurrentDate.Name = "dtCurrentDate";
            this.dtCurrentDate.Size = new System.Drawing.Size(200, 22);
            this.dtCurrentDate.TabIndex = 1;
            this.dtCurrentDate.TabStop = false;
            this.dtCurrentDate.Value = new System.DateTime(2023, 8, 23, 0, 0, 0, 0);
            // 
            // chkCustomDate
            // 
            this.chkCustomDate.AutoSize = true;
            this.chkCustomDate.Location = new System.Drawing.Point(324, 189);
            this.chkCustomDate.Name = "chkCustomDate";
            this.chkCustomDate.Size = new System.Drawing.Size(74, 20);
            this.chkCustomDate.TabIndex = 2;
            this.chkCustomDate.Text = "Custom";
            this.chkCustomDate.UseVisualStyleBackColor = true;
            this.chkCustomDate.CheckedChanged += new System.EventHandler(this.chkCustomDate_CheckedChanged);
            // 
            // btnCaluculate
            // 
            this.btnCaluculate.Location = new System.Drawing.Point(403, 182);
            this.btnCaluculate.Name = "btnCaluculate";
            this.btnCaluculate.Size = new System.Drawing.Size(87, 32);
            this.btnCaluculate.TabIndex = 3;
            this.btnCaluculate.Text = "Calculate";
            this.btnCaluculate.UseVisualStyleBackColor = true;
            this.btnCaluculate.Click += new System.EventHandler(this.btnCaluculate_Click);
            // 
            // gbAge
            // 
            this.gbAge.Controls.Add(this.lblTotalSeconds);
            this.gbAge.Controls.Add(this.lblTotalMinutes);
            this.gbAge.Controls.Add(this.lblTotalHours);
            this.gbAge.Controls.Add(this.lblTotalDays);
            this.gbAge.Controls.Add(this.label7);
            this.gbAge.Controls.Add(this.label6);
            this.gbAge.Controls.Add(this.label5);
            this.gbAge.Controls.Add(this.label4);
            this.gbAge.Controls.Add(this.lblDays);
            this.gbAge.Controls.Add(this.lblMonths);
            this.gbAge.Controls.Add(this.lblYears);
            this.gbAge.Controls.Add(this.label3);
            this.gbAge.Controls.Add(this.label2);
            this.gbAge.Controls.Add(this.label1);
            this.gbAge.Location = new System.Drawing.Point(12, 217);
            this.gbAge.Name = "gbAge";
            this.gbAge.Size = new System.Drawing.Size(478, 221);
            this.gbAge.TabIndex = 7;
            this.gbAge.TabStop = false;
            this.gbAge.Text = "Age";
            // 
            // lblTotalSeconds
            // 
            this.lblTotalSeconds.AutoSize = true;
            this.lblTotalSeconds.Font = new System.Drawing.Font("Lemon", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSeconds.Location = new System.Drawing.Point(116, 185);
            this.lblTotalSeconds.Name = "lblTotalSeconds";
            this.lblTotalSeconds.Size = new System.Drawing.Size(23, 22);
            this.lblTotalSeconds.TabIndex = 22;
            this.lblTotalSeconds.Text = "0";
            // 
            // lblTotalMinutes
            // 
            this.lblTotalMinutes.AutoSize = true;
            this.lblTotalMinutes.Font = new System.Drawing.Font("Lemon", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMinutes.Location = new System.Drawing.Point(116, 158);
            this.lblTotalMinutes.Name = "lblTotalMinutes";
            this.lblTotalMinutes.Size = new System.Drawing.Size(23, 22);
            this.lblTotalMinutes.TabIndex = 21;
            this.lblTotalMinutes.Text = "0";
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Font = new System.Drawing.Font("Lemon", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHours.Location = new System.Drawing.Point(116, 128);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(23, 22);
            this.lblTotalHours.TabIndex = 20;
            this.lblTotalHours.Text = "0";
            // 
            // lblTotalDays
            // 
            this.lblTotalDays.AutoSize = true;
            this.lblTotalDays.Font = new System.Drawing.Font("Lemon", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDays.Location = new System.Drawing.Point(116, 98);
            this.lblTotalDays.Name = "lblTotalDays";
            this.lblTotalDays.Size = new System.Drawing.Size(23, 22);
            this.lblTotalDays.TabIndex = 19;
            this.lblTotalDays.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lemon", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Seconds: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lemon", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Minutes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lemon", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hours:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lemon", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Days:";
            // 
            // lblDays
            // 
            this.lblDays.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.lblDays.Location = new System.Drawing.Point(333, 30);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(138, 23);
            this.lblDays.TabIndex = 14;
            this.lblDays.Text = "0";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonths
            // 
            this.lblMonths.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.lblMonths.Location = new System.Drawing.Point(169, 30);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(138, 23);
            this.lblMonths.TabIndex = 13;
            this.lblMonths.Text = "0";
            this.lblMonths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYears
            // 
            this.lblYears.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.lblYears.Location = new System.Drawing.Point(5, 30);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(138, 23);
            this.lblYears.TabIndex = 12;
            this.lblYears.Text = "0";
            this.lblYears.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.label3.Location = new System.Drawing.Point(334, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Days";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(170, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Months";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.label1.Location = new System.Drawing.Point(5, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Years";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(403, 137);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date of Birth: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Current Date: ";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCaluculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 445);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbAge);
            this.Controls.Add(this.btnCaluculate);
            this.Controls.Add(this.chkCustomDate);
            this.Controls.Add(this.dtCurrentDate);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.dtBirthDate);
            this.Name = "Form1";
            this.Text = "Age Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbAge.ResumeLayout(false);
            this.gbAge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.TextBox txbHead;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtCurrentDate;
        private System.Windows.Forms.CheckBox chkCustomDate;
        private System.Windows.Forms.Button btnCaluculate;
        private System.Windows.Forms.GroupBox gbAge;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalSeconds;
        private System.Windows.Forms.Label lblTotalMinutes;
        private System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.Label lblTotalDays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

