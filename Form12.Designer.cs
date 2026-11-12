namespace ProjectAkhirPPLG
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            button9 = new Button();
            button6 = new Button();
            button2 = new Button();
            button7 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 80, 112);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 140);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F);
            label1.ForeColor = Color.FromArgb(224, 181, 143);
            label1.Location = new Point(211, 44);
            label1.Name = "label1";
            label1.Size = new Size(428, 60);
            label1.TabIndex = 2;
            label1.Text = "WELCOME KASIR!";
            label1.Click += Label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ChatGPT_Image_Oct_2__2026__11_52_25_AM;
            pictureBox2.Location = new Point(309, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 129);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 80, 112);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(12, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 262);
            panel2.TabIndex = 1;
            panel2.Paint += Panel2_Paint;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(200, 90, 50);
            button9.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.FromArgb(245, 240, 233);
            button9.Location = new Point(499, 20);
            button9.Name = "button9";
            button9.Size = new Size(209, 75);
            button9.TabIndex = 14;
            button9.Text = "Riwayat";
            button9.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(200, 90, 50);
            button6.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(245, 240, 233);
            button6.Location = new Point(274, 181);
            button6.Name = "button6";
            button6.Size = new Size(209, 75);
            button6.TabIndex = 12;
            button6.Text = "Laporan";
            button6.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(200, 90, 50);
            button2.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(245, 240, 233);
            button2.Location = new Point(50, 109);
            button2.Name = "button2";
            button2.Size = new Size(209, 75);
            button2.TabIndex = 11;
            button2.Text = "Data";
            button2.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(200, 90, 50);
            button7.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.FromArgb(245, 240, 233);
            button7.Location = new Point(499, 109);
            button7.Name = "button7";
            button7.Size = new Size(209, 75);
            button7.TabIndex = 13;
            button7.Text = "Stok";
            button7.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(200, 90, 50);
            button1.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(245, 240, 233);
            button1.Location = new Point(50, 20);
            button1.Name = "button1";
            button1.Size = new Size(209, 75);
            button1.TabIndex = 3;
            button1.Text = "Transaksi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click_1;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 34, 80);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form12";
            Text = "Dashboard Kasir - PixelMart";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button9;
        private Button button6;
        private Button button2;
        private Button button7;
    }
}