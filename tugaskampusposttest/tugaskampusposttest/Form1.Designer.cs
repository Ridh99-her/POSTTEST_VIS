namespace tugaskampusposttest
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
            textBox1 = new TextBox();
            lblIPK = new Label();
            lblPredikat = new Label();
            btnTambah = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(352, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // lblIPK
            // 
            lblIPK.AutoSize = true;
            lblIPK.Location = new Point(346, 191);
            lblIPK.Name = "lblIPK";
            lblIPK.Size = new Size(106, 15);
            lblIPK.TabIndex = 1;
            lblIPK.Text = "IPK Kumulatif: 0.00";
            lblIPK.Click += label1_Click;
            // 
            // lblPredikat
            // 
            lblPredikat.AutoSize = true;
            lblPredikat.Location = new Point(365, 250);
            lblPredikat.Name = "lblPredikat";
            lblPredikat.Size = new Size(61, 15);
            lblPredikat.TabIndex = 2;
            lblPredikat.Text = "Predikat: -";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(253, 282);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 23);
            btnTambah.TabIndex = 3;
            btnTambah.Text = "TAMBAH IP";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click_1;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(453, 283);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 4;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnTambah);
            Controls.Add(lblPredikat);
            Controls.Add(lblIPK);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lblIPK;
        private Label lblPredikat;
        private Button btnTambah;
        private Button btnReset;
    }
}
