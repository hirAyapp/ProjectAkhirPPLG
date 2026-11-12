namespace ProjectAkhirPPLG
{
    partial class Form11 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            button9 = new Button();
            button6 = new Button();
            button2 = new Button();
            button7 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            label1.Size = new Size(481, 60);
            label1.TabIndex = 2;
            label1.Text = "WELCOME GUDANG!";
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
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ChatGPT_Image_Oct_2__2026__11_59_33_AM;
            pictureBox3.Location = new Point(309, 45);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(146, 164);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += PictureBox3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 80, 112);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button7);
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
            button6.Location = new Point(47, 163);
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
            button2.Location = new Point(47, 20);
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
            button7.Location = new Point(499, 163);
            button7.Name = "button7";
            button7.Size = new Size(209, 75);
            button7.TabIndex = 13;
            button7.Text = "Stok";
            button7.UseVisualStyleBackColor = false;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 34, 80);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form11";
            Text = "Dashboard Gudang - PixelMart";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button button9;
        private Button button6;
        private Button button2;
        private Button button7;
    }
}