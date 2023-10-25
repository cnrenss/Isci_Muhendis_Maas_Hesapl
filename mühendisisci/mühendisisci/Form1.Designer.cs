namespace mühendisisci
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
            btnhesapla = new Button();
            lbladsoyad = new Label();
            lblsaat = new Label();
            lblmeslek = new Label();
            txtadsoyad = new TextBox();
            txtsaat = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // btnhesapla
            // 
            btnhesapla.Location = new Point(288, 225);
            btnhesapla.Name = "btnhesapla";
            btnhesapla.Size = new Size(75, 23);
            btnhesapla.TabIndex = 0;
            btnhesapla.Text = "Hesapla";
            btnhesapla.UseVisualStyleBackColor = true;
            btnhesapla.Click += btnhesapla_Click;
            // 
            // lbladsoyad
            // 
            lbladsoyad.AutoSize = true;
            lbladsoyad.Location = new Point(166, 112);
            lbladsoyad.Name = "lbladsoyad";
            lbladsoyad.Size = new Size(66, 15);
            lbladsoyad.TabIndex = 1;
            lbladsoyad.Text = "Ad , Soyad:";
            // 
            // lblsaat
            // 
            lblsaat.AutoSize = true;
            lblsaat.Location = new Point(155, 153);
            lblsaat.Name = "lblsaat";
            lblsaat.Size = new Size(77, 15);
            lblsaat.TabIndex = 2;
            lblsaat.Text = "Calisma Saati";
            // 
            // lblmeslek
            // 
            lblmeslek.AutoSize = true;
            lblmeslek.Location = new Point(188, 193);
            lblmeslek.Name = "lblmeslek";
            lblmeslek.Size = new Size(44, 15);
            lblmeslek.TabIndex = 3;
            lblmeslek.Text = "Meslek";
            // 
            // txtadsoyad
            // 
            txtadsoyad.Location = new Point(263, 109);
            txtadsoyad.Name = "txtadsoyad";
            txtadsoyad.Size = new Size(100, 23);
            txtadsoyad.TabIndex = 4;
            // 
            // txtsaat
            // 
            txtsaat.Location = new Point(263, 145);
            txtsaat.Name = "txtsaat";
            txtsaat.Size = new Size(100, 23);
            txtsaat.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(263, 185);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(txtsaat);
            Controls.Add(txtadsoyad);
            Controls.Add(lblmeslek);
            Controls.Add(lblsaat);
            Controls.Add(lbladsoyad);
            Controls.Add(btnhesapla);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnhesapla;
        private Label lbladsoyad;
        private Label lblsaat;
        private Label lblmeslek;
        private TextBox txtadsoyad;
        private TextBox txtsaat;
        private ComboBox comboBox1;
    }
}