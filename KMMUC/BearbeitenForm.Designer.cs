namespace KMMUC
{
    partial class BearbeitenForm
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
            this.listBoxPersonenArt = new System.Windows.Forms.ListBox();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGeschlechter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerGeburt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxGehalt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.labelBetreuer = new System.Windows.Forms.Label();
            this.panelPatient = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxICDCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerAufnahme = new System.Windows.Forms.DateTimePicker();
            this.panelMitarbeiter = new System.Windows.Forms.Panel();
            this.panelArzt = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxDisziplin = new System.Windows.Forms.ComboBox();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelSchwester = new System.Windows.Forms.Panel();
            this.checkBoxOberschwester = new System.Windows.Forms.CheckBox();
            this.panelPatient.SuspendLayout();
            this.panelMitarbeiter.SuspendLayout();
            this.panelArzt.SuspendLayout();
            this.panelSchwester.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPersonenArt
            // 
            this.listBoxPersonenArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPersonenArt.FormattingEnabled = true;
            this.listBoxPersonenArt.ItemHeight = 32;
            this.listBoxPersonenArt.Location = new System.Drawing.Point(27, 26);
            this.listBoxPersonenArt.Name = "listBoxPersonenArt";
            this.listBoxPersonenArt.Size = new System.Drawing.Size(171, 132);
            this.listBoxPersonenArt.TabIndex = 1;
            this.listBoxPersonenArt.SelectedIndexChanged += new System.EventHandler(this.listBoxPersonenArt_SelectedIndexChanged);
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVorname.Location = new System.Drawing.Point(229, 203);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(213, 39);
            this.textBoxVorname.TabIndex = 3;
            this.textBoxVorname.Text = "Max";
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNachname.Location = new System.Drawing.Point(229, 248);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(213, 39);
            this.textBoxNachname.TabIndex = 4;
            this.textBoxNachname.Text = "Mustermann";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vorname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nachname:";
            // 
            // comboBoxGeschlechter
            // 
            this.comboBoxGeschlechter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGeschlechter.FormattingEnabled = true;
            this.comboBoxGeschlechter.Location = new System.Drawing.Point(229, 291);
            this.comboBoxGeschlechter.Name = "comboBoxGeschlechter";
            this.comboBoxGeschlechter.Size = new System.Drawing.Size(213, 40);
            this.comboBoxGeschlechter.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Geschlecht:";
            // 
            // dateTimePickerGeburt
            // 
            this.dateTimePickerGeburt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerGeburt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerGeburt.Location = new System.Drawing.Point(228, 340);
            this.dateTimePickerGeburt.Name = "dateTimePickerGeburt";
            this.dateTimePickerGeburt.Size = new System.Drawing.Size(214, 39);
            this.dateTimePickerGeburt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Geburtsdatum:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 64);
            this.button1.TabIndex = 11;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_ok_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(230, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 64);
            this.button2.TabIndex = 12;
            this.button2.Text = "Abbrechen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_abbrechen_click);
            // 
            // textBoxGehalt
            // 
            this.textBoxGehalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGehalt.Location = new System.Drawing.Point(679, 115);
            this.textBoxGehalt.Name = "textBoxGehalt";
            this.textBoxGehalt.Size = new System.Drawing.Size(213, 39);
            this.textBoxGehalt.TabIndex = 13;
            this.textBoxGehalt.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(544, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gehalt:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(24, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(320, 57);
            this.button3.TabIndex = 15;
            this.button3.Text = "Betreuer hinzufügen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_betreuer_hinzufügen);
            // 
            // labelBetreuer
            // 
            this.labelBetreuer.AutoSize = true;
            this.labelBetreuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBetreuer.Location = new System.Drawing.Point(19, 27);
            this.labelBetreuer.Name = "labelBetreuer";
            this.labelBetreuer.Size = new System.Drawing.Size(0, 25);
            this.labelBetreuer.TabIndex = 16;
            // 
            // panelPatient
            // 
            this.panelPatient.Controls.Add(this.label7);
            this.panelPatient.Controls.Add(this.textBoxICDCode);
            this.panelPatient.Controls.Add(this.label6);
            this.panelPatient.Controls.Add(this.dateTimePickerAufnahme);
            this.panelPatient.Controls.Add(this.labelBetreuer);
            this.panelPatient.Controls.Add(this.button3);
            this.panelPatient.Location = new System.Drawing.Point(472, 206);
            this.panelPatient.Name = "panelPatient";
            this.panelPatient.Size = new System.Drawing.Size(954, 319);
            this.panelPatient.TabIndex = 17;
            this.panelPatient.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 32);
            this.label7.TabIndex = 19;
            this.label7.Text = "ICD-Code:";
            // 
            // textBoxICDCode
            // 
            this.textBoxICDCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxICDCode.Location = new System.Drawing.Point(637, 253);
            this.textBoxICDCode.Name = "textBoxICDCode";
            this.textBoxICDCode.Size = new System.Drawing.Size(213, 39);
            this.textBoxICDCode.TabIndex = 18;
            this.textBoxICDCode.Text = "EF-6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Aufnahmedatum:";
            // 
            // dateTimePickerAufnahme
            // 
            this.dateTimePickerAufnahme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAufnahme.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAufnahme.Location = new System.Drawing.Point(637, 197);
            this.dateTimePickerAufnahme.Name = "dateTimePickerAufnahme";
            this.dateTimePickerAufnahme.Size = new System.Drawing.Size(214, 39);
            this.dateTimePickerAufnahme.TabIndex = 18;
            // 
            // panelMitarbeiter
            // 
            this.panelMitarbeiter.Controls.Add(this.panelArzt);
            this.panelMitarbeiter.Controls.Add(this.panelSchwester);
            this.panelMitarbeiter.Controls.Add(this.label5);
            this.panelMitarbeiter.Controls.Add(this.textBoxGehalt);
            this.panelMitarbeiter.Location = new System.Drawing.Point(469, 15);
            this.panelMitarbeiter.Name = "panelMitarbeiter";
            this.panelMitarbeiter.Size = new System.Drawing.Size(957, 172);
            this.panelMitarbeiter.TabIndex = 18;
            this.panelMitarbeiter.Visible = false;
            // 
            // panelArzt
            // 
            this.panelArzt.Controls.Add(this.label9);
            this.panelArzt.Controls.Add(this.comboBoxDisziplin);
            this.panelArzt.Controls.Add(this.textBoxTitel);
            this.panelArzt.Controls.Add(this.label8);
            this.panelArzt.Location = new System.Drawing.Point(15, 16);
            this.panelArzt.Name = "panelArzt";
            this.panelArzt.Size = new System.Drawing.Size(383, 144);
            this.panelArzt.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 32);
            this.label9.TabIndex = 19;
            this.label9.Text = "Disziplin:";
            // 
            // comboBoxDisziplin
            // 
            this.comboBoxDisziplin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDisziplin.FormattingEnabled = true;
            this.comboBoxDisziplin.Location = new System.Drawing.Point(143, 79);
            this.comboBoxDisziplin.Name = "comboBoxDisziplin";
            this.comboBoxDisziplin.Size = new System.Drawing.Size(213, 40);
            this.comboBoxDisziplin.TabIndex = 19;
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitel.Location = new System.Drawing.Point(143, 10);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(213, 39);
            this.textBoxTitel.TabIndex = 20;
            this.textBoxTitel.Text = "Doktor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Titel:";
            // 
            // panelSchwester
            // 
            this.panelSchwester.Controls.Add(this.checkBoxOberschwester);
            this.panelSchwester.Location = new System.Drawing.Point(620, 20);
            this.panelSchwester.Name = "panelSchwester";
            this.panelSchwester.Size = new System.Drawing.Size(325, 68);
            this.panelSchwester.TabIndex = 15;
            // 
            // checkBoxOberschwester
            // 
            this.checkBoxOberschwester.AutoSize = true;
            this.checkBoxOberschwester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOberschwester.Location = new System.Drawing.Point(13, 13);
            this.checkBoxOberschwester.Name = "checkBoxOberschwester";
            this.checkBoxOberschwester.Size = new System.Drawing.Size(231, 36);
            this.checkBoxOberschwester.TabIndex = 0;
            this.checkBoxOberschwester.Text = "Oberschwester";
            this.checkBoxOberschwester.UseVisualStyleBackColor = true;
            // 
            // BearbeitenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1653, 537);
            this.Controls.Add(this.panelMitarbeiter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerGeburt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxGeschlechter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNachname);
            this.Controls.Add(this.textBoxVorname);
            this.Controls.Add(this.listBoxPersonenArt);
            this.Controls.Add(this.panelPatient);
            this.Name = "BearbeitenForm";
            this.Text = "BearbeitenForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelPatient.ResumeLayout(false);
            this.panelPatient.PerformLayout();
            this.panelMitarbeiter.ResumeLayout(false);
            this.panelMitarbeiter.PerformLayout();
            this.panelArzt.ResumeLayout(false);
            this.panelArzt.PerformLayout();
            this.panelSchwester.ResumeLayout(false);
            this.panelSchwester.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGeschlechter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerGeburt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListBox listBoxPersonenArt;
        private System.Windows.Forms.TextBox textBoxGehalt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelBetreuer;
        private System.Windows.Forms.Panel panelPatient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerAufnahme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxICDCode;
        private System.Windows.Forms.Panel panelMitarbeiter;
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelSchwester;
        private System.Windows.Forms.CheckBox checkBoxOberschwester;
        private System.Windows.Forms.Panel panelArzt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxDisziplin;
    }
}