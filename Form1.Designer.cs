﻿
namespace AutokNyilvantartasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxRendszam = new System.Windows.Forms.TextBox();
            this.tbxGyartmany = new System.Windows.Forms.TextBox();
            this.tbxTipus = new System.Windows.Forms.TextBox();
            this.dtpUzembehelyezes = new System.Windows.Forms.DateTimePicker();
            this.dtpErvenyesseg = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxSzin = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gyártmány:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Típus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Üzembehelyezés dátuma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Színe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "A műszaki érvényessége:";
            // 
            // tbxRendszam
            // 
            this.tbxRendszam.ForeColor = System.Drawing.Color.Silver;
            this.tbxRendszam.Location = new System.Drawing.Point(169, 10);
            this.tbxRendszam.MaxLength = 6;
            this.tbxRendszam.Name = "tbxRendszam";
            this.tbxRendszam.Size = new System.Drawing.Size(382, 20);
            this.tbxRendszam.TabIndex = 1;
            this.tbxRendszam.Text = "XYZ123";
            // 
            // tbxGyartmany
            // 
            this.tbxGyartmany.Location = new System.Drawing.Point(169, 37);
            this.tbxGyartmany.Name = "tbxGyartmany";
            this.tbxGyartmany.Size = new System.Drawing.Size(382, 20);
            this.tbxGyartmany.TabIndex = 2;
            // 
            // tbxTipus
            // 
            this.tbxTipus.Location = new System.Drawing.Point(169, 64);
            this.tbxTipus.Name = "tbxTipus";
            this.tbxTipus.Size = new System.Drawing.Size(382, 20);
            this.tbxTipus.TabIndex = 3;
            // 
            // dtpUzembehelyezes
            // 
            this.dtpUzembehelyezes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUzembehelyezes.Location = new System.Drawing.Point(169, 92);
            this.dtpUzembehelyezes.Name = "dtpUzembehelyezes";
            this.dtpUzembehelyezes.Size = new System.Drawing.Size(382, 20);
            this.dtpUzembehelyezes.TabIndex = 4;
            // 
            // dtpErvenyesseg
            // 
            this.dtpErvenyesseg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpErvenyesseg.Location = new System.Drawing.Point(169, 144);
            this.dtpErvenyesseg.Name = "dtpErvenyesseg";
            this.dtpErvenyesseg.Size = new System.Drawing.Size(382, 20);
            this.dtpErvenyesseg.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(535, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Küldés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxSzin
            // 
            this.cbxSzin.FormattingEnabled = true;
            this.cbxSzin.Items.AddRange(new object[] {
            "Fekete",
            "Ezüst",
            "Piros",
            "Zöld",
            "Egyéb"});
            this.cbxSzin.Location = new System.Drawing.Point(169, 118);
            this.cbxSzin.Name = "cbxSzin";
            this.cbxSzin.Size = new System.Drawing.Size(382, 21);
            this.cbxSzin.TabIndex = 5;
            this.cbxSzin.Text = "Válassz!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(12, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxSzin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpErvenyesseg);
            this.Controls.Add(this.dtpUzembehelyezes);
            this.Controls.Add(this.tbxTipus);
            this.Controls.Add(this.tbxGyartmany);
            this.Controls.Add(this.tbxRendszam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Autók nyilvántartása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxRendszam;
        private System.Windows.Forms.TextBox tbxGyartmany;
        private System.Windows.Forms.TextBox tbxTipus;
        private System.Windows.Forms.DateTimePicker dtpUzembehelyezes;
        private System.Windows.Forms.DateTimePicker dtpErvenyesseg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxSzin;
        private System.Windows.Forms.Label label7;
    }
}

