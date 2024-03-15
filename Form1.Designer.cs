namespace Materi1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNama = new TextBox();
            listKelas = new ListBox();
            txtAbsen = new TextBox();
            label8 = new Label();
            txtAgama = new Label();
            txtRumah = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            checkLK = new CheckBox();
            checkPR = new CheckBox();
            listAgama = new ListBox();
            txtAlamat = new TextBox();
            btnKeluar = new Button();
            btnClear = new Button();
            label14 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(336, 53);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 0;
            label1.Text = "Formulir Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 104);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Masukkan Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 143);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Kelas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 186);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "No. Absen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 104);
            label5.Name = "label5";
            label5.Size = new Size(10, 15);
            label5.TabIndex = 4;
            label5.Text = ":";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(148, 143);
            label6.Name = "label6";
            label6.Size = new Size(10, 15);
            label6.TabIndex = 5;
            label6.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(148, 186);
            label7.Name = "label7";
            label7.Size = new Size(10, 15);
            label7.TabIndex = 6;
            label7.Text = ":";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(184, 96);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(284, 23);
            txtNama.TabIndex = 7;
            // 
            // listKelas
            // 
            listKelas.FormattingEnabled = true;
            listKelas.ItemHeight = 15;
            listKelas.Items.AddRange(new object[] { "", "10 PPLG 1", "10 PPLG 2", "11 PPL 1", "11 PPLG 2", "12 PPLG 1", "12 PPLG 2" });
            listKelas.Location = new Point(184, 143);
            listKelas.Name = "listKelas";
            listKelas.Size = new Size(142, 19);
            listKelas.TabIndex = 8;
            // 
            // txtAbsen
            // 
            txtAbsen.Location = new Point(184, 186);
            txtAbsen.Name = "txtAbsen";
            txtAbsen.Size = new Size(142, 23);
            txtAbsen.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 225);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 10;
            label8.Text = "Jenis Kelamin";
            label8.Click += label8_Click;
            // 
            // txtAgama
            // 
            txtAgama.AutoSize = true;
            txtAgama.Location = new Point(46, 263);
            txtAgama.Name = "txtAgama";
            txtAgama.Size = new Size(45, 15);
            txtAgama.TabIndex = 11;
            txtAgama.Text = "Agama";
            // 
            // txtRumah
            // 
            txtRumah.AutoSize = true;
            txtRumah.Location = new Point(46, 302);
            txtRumah.Name = "txtRumah";
            txtRumah.Size = new Size(45, 15);
            txtRumah.TabIndex = 12;
            txtRumah.Text = "Alamat";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(148, 225);
            label11.Name = "label11";
            label11.Size = new Size(10, 15);
            label11.TabIndex = 13;
            label11.Text = ":";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(148, 263);
            label12.Name = "label12";
            label12.Size = new Size(10, 15);
            label12.TabIndex = 14;
            label12.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(148, 302);
            label13.Name = "label13";
            label13.Size = new Size(10, 15);
            label13.TabIndex = 15;
            label13.Text = ":";
            // 
            // checkLK
            // 
            checkLK.AutoSize = true;
            checkLK.Location = new Point(184, 224);
            checkLK.Name = "checkLK";
            checkLK.Size = new Size(70, 19);
            checkLK.TabIndex = 16;
            checkLK.Text = "Laki-laki";
            checkLK.UseVisualStyleBackColor = true;
            checkLK.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkPR
            // 
            checkPR.AutoSize = true;
            checkPR.Location = new Point(285, 225);
            checkPR.Name = "checkPR";
            checkPR.Size = new Size(87, 19);
            checkPR.TabIndex = 17;
            checkPR.Text = "Perempuan";
            checkPR.UseVisualStyleBackColor = true;
            // 
            // listAgama
            // 
            listAgama.FormattingEnabled = true;
            listAgama.ItemHeight = 15;
            listAgama.Items.AddRange(new object[] { "", "Islam", "Kristen", "Katolik", "Hindu", "Budha", "Konghucu", "Atheis" });
            listAgama.Location = new Point(184, 263);
            listAgama.Name = "listAgama";
            listAgama.Size = new Size(142, 19);
            listAgama.TabIndex = 18;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(184, 299);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(284, 50);
            txtAlamat.TabIndex = 19;
            // 
            // btnKeluar
            // 
            btnKeluar.Cursor = Cursors.Hand;
            btnKeluar.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnKeluar.Location = new Point(664, 388);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(75, 23);
            btnKeluar.TabIndex = 20;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            btnKeluar.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(558, 388);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 426);
            label14.Name = "label14";
            label14.Size = new Size(82, 15);
            label14.TabIndex = 22;
            label14.Text = "by ratih shinta";
            label14.Click += label14_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label14);
            Controls.Add(btnClear);
            Controls.Add(btnKeluar);
            Controls.Add(txtAlamat);
            Controls.Add(listAgama);
            Controls.Add(checkPR);
            Controls.Add(checkLK);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtRumah);
            Controls.Add(txtAgama);
            Controls.Add(label8);
            Controls.Add(txtAbsen);
            Controls.Add(listKelas);
            Controls.Add(txtNama);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Materi1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNama;
        private ListBox listKelas;
        private TextBox txtAbsen;
        private Label label8;
        private Label txtAgama;
        private Label txtRumah;
        private Label label11;
        private Label label12;
        private Label label13;
        private CheckBox checkLK;
        private CheckBox checkPR;
        private ListBox listAgama;
        private TextBox txtAlamat;
        private Button btnKeluar;
        private Button btnClear;
        private Label label14;
    }
}