
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
            this.tbxRendszam = new System.Windows.Forms.TextBox();
            this.tbxTipus = new System.Windows.Forms.TextBox();
            this.dtpUzembehelyezes = new System.Windows.Forms.DateTimePicker();
            this.btnKuldes = new System.Windows.Forms.Button();
            this.cbxSzin = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbxGyartmany = new System.Windows.Forms.ComboBox();
            this.btnVisszatoltes = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rendszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gyartmany = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szin = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Muszaki = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // tbxRendszam
            // 
            this.tbxRendszam.BackColor = System.Drawing.SystemColors.Window;
            this.tbxRendszam.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxRendszam.Location = new System.Drawing.Point(169, 10);
            this.tbxRendszam.MaxLength = 6;
            this.tbxRendszam.Name = "tbxRendszam";
            this.tbxRendszam.Size = new System.Drawing.Size(382, 20);
            this.tbxRendszam.TabIndex = 1;
            this.tbxRendszam.TextChanged += new System.EventHandler(this.tbxRendszam_TextChanged);
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
            // btnKuldes
            // 
            this.btnKuldes.Location = new System.Drawing.Point(16, 173);
            this.btnKuldes.Name = "btnKuldes";
            this.btnKuldes.Size = new System.Drawing.Size(260, 31);
            this.btnKuldes.TabIndex = 7;
            this.btnKuldes.Text = "Küldés";
            this.btnKuldes.UseVisualStyleBackColor = true;
            this.btnKuldes.Click += new System.EventHandler(this.btnKuldes_Click);
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
            this.cbxSzin.Click += new System.EventHandler(this.cbxSzin_Click);
            this.cbxSzin.Enter += new System.EventHandler(this.cbxSzin_Enter);
            this.cbxSzin.Leave += new System.EventHandler(this.cbxSzin_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(12, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(169, 145);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Érvényes műszaki vizsga";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbxGyartmany
            // 
            this.cbxGyartmany.FormattingEnabled = true;
            this.cbxGyartmany.Location = new System.Drawing.Point(169, 37);
            this.cbxGyartmany.Name = "cbxGyartmany";
            this.cbxGyartmany.Size = new System.Drawing.Size(382, 21);
            this.cbxGyartmany.TabIndex = 2;
            this.cbxGyartmany.Click += new System.EventHandler(this.cbxGyartmany_Click);
            this.cbxGyartmany.Enter += new System.EventHandler(this.cbxGyartmany_Enter);
            this.cbxGyartmany.Leave += new System.EventHandler(this.cbxGyartmany_Leave);
            // 
            // btnVisszatoltes
            // 
            this.btnVisszatoltes.Location = new System.Drawing.Point(291, 173);
            this.btnVisszatoltes.Name = "btnVisszatoltes";
            this.btnVisszatoltes.Size = new System.Drawing.Size(260, 31);
            this.btnVisszatoltes.TabIndex = 14;
            this.btnVisszatoltes.Text = "Visszatöltés";
            this.btnVisszatoltes.UseVisualStyleBackColor = true;
            this.btnVisszatoltes.Click += new System.EventHandler(this.btnVisszatoltes_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rendszam,
            this.Gyartmany,
            this.Tipus,
            this.U_Datum,
            this.Szin,
            this.Muszaki});
            this.dataGridView1.Location = new System.Drawing.Point(16, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 228);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Rendszam
            // 
            this.Rendszam.HeaderText = "Rendszám";
            this.Rendszam.MaxInputLength = 6;
            this.Rendszam.MinimumWidth = 6;
            this.Rendszam.Name = "Rendszam";
            this.Rendszam.ToolTipText = "Kötőjel nélkül! Pontosan hat karakter.";
            this.Rendszam.Width = 60;
            // 
            // Gyartmany
            // 
            this.Gyartmany.HeaderText = "Gyártmány";
            this.Gyartmany.Name = "Gyartmany";
            // 
            // Tipus
            // 
            this.Tipus.HeaderText = "Típus";
            this.Tipus.Name = "Tipus";
            // 
            // U_Datum
            // 
            this.U_Datum.HeaderText = "ÜhelyDátum";
            this.U_Datum.Name = "U_Datum";
            this.U_Datum.ToolTipText = "Üzembehelyezés dátuma";
            this.U_Datum.Width = 80;
            // 
            // Szin
            // 
            this.Szin.HeaderText = "Színe";
            this.Szin.Name = "Szin";
            this.Szin.Width = 80;
            // 
            // Muszaki
            // 
            this.Muszaki.HeaderText = "ÉrvMűszaki";
            this.Muszaki.Name = "Muszaki";
            this.Muszaki.ToolTipText = "Érvényes műszakival rendelkezik (Igen/Nem)";
            this.Muszaki.Width = 71;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVisszatoltes);
            this.Controls.Add(this.cbxGyartmany);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxSzin);
            this.Controls.Add(this.btnKuldes);
            this.Controls.Add(this.dtpUzembehelyezes);
            this.Controls.Add(this.tbxTipus);
            this.Controls.Add(this.tbxRendszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Autók nyilvántartása";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxRendszam;
        private System.Windows.Forms.TextBox tbxTipus;
        private System.Windows.Forms.DateTimePicker dtpUzembehelyezes;
        private System.Windows.Forms.Button btnKuldes;
        private System.Windows.Forms.ComboBox cbxSzin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbxGyartmany;
        private System.Windows.Forms.Button btnVisszatoltes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rendszam;
        private System.Windows.Forms.DataGridViewComboBoxColumn Gyartmany;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_Datum;
        private System.Windows.Forms.DataGridViewComboBoxColumn Szin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Muszaki;
    }
}

