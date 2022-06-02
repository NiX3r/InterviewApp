namespace InterviewApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pbLanguage = new System.Windows.Forms.PictureBox();
            this.lFullname = new System.Windows.Forms.Label();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.tbIdentifyNumber = new System.Windows.Forms.TextBox();
            this.lIdentifyNumber = new System.Windows.Forms.Label();
            this.chbHaventIdNumber = new System.Windows.Forms.CheckBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.lBirth = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.lSex = new System.Windows.Forms.Label();
            this.lNationality = new System.Windows.Forms.Label();
            this.cbNationality = new System.Windows.Forms.ComboBox();
            this.chbGDPR = new System.Windows.Forms.CheckBox();
            this.lGDPR = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button1.Location = new System.Drawing.Point(290, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button2.Location = new System.Drawing.Point(252, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbLanguage
            // 
            this.pbLanguage.Image = global::InterviewApp.Properties.Resources.united_kingdom;
            this.pbLanguage.Location = new System.Drawing.Point(214, 12);
            this.pbLanguage.Name = "pbLanguage";
            this.pbLanguage.Size = new System.Drawing.Size(32, 32);
            this.pbLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLanguage.TabIndex = 2;
            this.pbLanguage.TabStop = false;
            this.pbLanguage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lFullname
            // 
            this.lFullname.AutoSize = true;
            this.lFullname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lFullname.Location = new System.Drawing.Point(41, 68);
            this.lFullname.Name = "lFullname";
            this.lFullname.Size = new System.Drawing.Size(116, 17);
            this.lFullname.TabIndex = 3;
            this.lFullname.Text = "Jméno a příjmení";
            // 
            // tbFullname
            // 
            this.tbFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tbFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFullname.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.tbFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbFullname.Location = new System.Drawing.Point(24, 91);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(285, 15);
            this.tbFullname.TabIndex = 4;
            // 
            // tbIdentifyNumber
            // 
            this.tbIdentifyNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tbIdentifyNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIdentifyNumber.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.tbIdentifyNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbIdentifyNumber.Location = new System.Drawing.Point(24, 145);
            this.tbIdentifyNumber.Name = "tbIdentifyNumber";
            this.tbIdentifyNumber.Size = new System.Drawing.Size(195, 15);
            this.tbIdentifyNumber.TabIndex = 6;
            this.tbIdentifyNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIdentifyNumber_KeyPress);
            this.tbIdentifyNumber.Leave += new System.EventHandler(this.tbIdentifyNumber_Leave);
            // 
            // lIdentifyNumber
            // 
            this.lIdentifyNumber.AutoSize = true;
            this.lIdentifyNumber.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lIdentifyNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lIdentifyNumber.Location = new System.Drawing.Point(41, 122);
            this.lIdentifyNumber.Name = "lIdentifyNumber";
            this.lIdentifyNumber.Size = new System.Drawing.Size(81, 17);
            this.lIdentifyNumber.TabIndex = 5;
            this.lIdentifyNumber.Text = "Rodné číslo";
            // 
            // chbHaventIdNumber
            // 
            this.chbHaventIdNumber.AutoSize = true;
            this.chbHaventIdNumber.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.chbHaventIdNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chbHaventIdNumber.Location = new System.Drawing.Point(236, 145);
            this.chbHaventIdNumber.Name = "chbHaventIdNumber";
            this.chbHaventIdNumber.Size = new System.Drawing.Size(73, 21);
            this.chbHaventIdNumber.TabIndex = 7;
            this.chbHaventIdNumber.Text = "nemám";
            this.chbHaventIdNumber.UseVisualStyleBackColor = true;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(24, 195);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(285, 20);
            this.dtpBirth.TabIndex = 8;
            // 
            // lBirth
            // 
            this.lBirth.AutoSize = true;
            this.lBirth.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lBirth.Location = new System.Drawing.Point(41, 172);
            this.lBirth.Name = "lBirth";
            this.lBirth.Size = new System.Drawing.Size(107, 17);
            this.lBirth.TabIndex = 9;
            this.lBirth.Text = "Datum narození";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbEmail.Location = new System.Drawing.Point(24, 306);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(285, 15);
            this.tbEmail.TabIndex = 11;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lEmail.Location = new System.Drawing.Point(41, 283);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(42, 17);
            this.lEmail.TabIndex = 10;
            this.lEmail.Text = "Email";
            // 
            // cbSex
            // 
            this.cbSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.cbSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSex.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Muž",
            "Žena",
            "Jiné"});
            this.cbSex.Location = new System.Drawing.Point(24, 249);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(285, 21);
            this.cbSex.TabIndex = 12;
            // 
            // lSex
            // 
            this.lSex.AutoSize = true;
            this.lSex.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lSex.Location = new System.Drawing.Point(41, 227);
            this.lSex.Name = "lSex";
            this.lSex.Size = new System.Drawing.Size(54, 17);
            this.lSex.TabIndex = 13;
            this.lSex.Text = "Pohlaví";
            // 
            // lNationality
            // 
            this.lNationality.AutoSize = true;
            this.lNationality.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lNationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lNationality.Location = new System.Drawing.Point(41, 332);
            this.lNationality.Name = "lNationality";
            this.lNationality.Size = new System.Drawing.Size(116, 17);
            this.lNationality.TabIndex = 15;
            this.lNationality.Text = "Státní příslušnost";
            // 
            // cbNationality
            // 
            this.cbNationality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.cbNationality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNationality.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cbNationality.FormattingEnabled = true;
            this.cbNationality.Location = new System.Drawing.Point(24, 354);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(285, 21);
            this.cbNationality.TabIndex = 14;
            // 
            // chbGDPR
            // 
            this.chbGDPR.AutoSize = true;
            this.chbGDPR.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.chbGDPR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chbGDPR.Location = new System.Drawing.Point(92, 399);
            this.chbGDPR.Name = "chbGDPR";
            this.chbGDPR.Size = new System.Drawing.Size(85, 21);
            this.chbGDPR.TabIndex = 16;
            this.chbGDPR.Text = "Souhlas s";
            this.chbGDPR.UseVisualStyleBackColor = true;
            // 
            // lGDPR
            // 
            this.lGDPR.AutoSize = true;
            this.lGDPR.Font = new System.Drawing.Font("Nirmala UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGDPR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lGDPR.Location = new System.Drawing.Point(171, 400);
            this.lGDPR.Name = "lGDPR";
            this.lGDPR.Size = new System.Drawing.Size(43, 17);
            this.lGDPR.TabIndex = 17;
            this.lGDPR.Text = "GDPR";
            this.lGDPR.Click += new System.EventHandler(this.lGDPR_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel1.Location = new System.Drawing.Point(24, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 5);
            this.panel1.TabIndex = 18;
            // 
            // bSend
            // 
            this.bSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.bSend.FlatAppearance.BorderSize = 0;
            this.bSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSend.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.bSend.Location = new System.Drawing.Point(24, 465);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(285, 51);
            this.bSend.TabIndex = 19;
            this.bSend.Text = "Odeslat";
            this.bSend.UseVisualStyleBackColor = false;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(334, 538);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lGDPR);
            this.Controls.Add(this.chbGDPR);
            this.Controls.Add(this.lNationality);
            this.Controls.Add(this.cbNationality);
            this.Controls.Add(this.lSex);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lBirth);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.chbHaventIdNumber);
            this.Controls.Add(this.tbIdentifyNumber);
            this.Controls.Add(this.lIdentifyNumber);
            this.Controls.Add(this.tbFullname);
            this.Controls.Add(this.lFullname);
            this.Controls.Add(this.pbLanguage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pbLanguage;
        private System.Windows.Forms.Label lFullname;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.TextBox tbIdentifyNumber;
        private System.Windows.Forms.Label lIdentifyNumber;
        private System.Windows.Forms.CheckBox chbHaventIdNumber;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label lBirth;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label lSex;
        private System.Windows.Forms.Label lNationality;
        private System.Windows.Forms.ComboBox cbNationality;
        private System.Windows.Forms.CheckBox chbGDPR;
        private System.Windows.Forms.Label lGDPR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bSend;
    }
}

