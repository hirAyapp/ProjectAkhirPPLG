namespace ProjectAkhirPPLG
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panelLogin = new RoundedPanel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(198, 214, 226);
            panelLogin.BorderColor = Color.Transparent;
            panelLogin.BorderRadius = 25;
            panelLogin.BorderSize = 1;
            panelLogin.Controls.Add(button2);
            panelLogin.Controls.Add(button1);
            panelLogin.Controls.Add(checkBox1);
            panelLogin.Controls.Add(textBox2);
            panelLogin.Controls.Add(textBox1);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Location = new Point(204, 12);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(346, 422);
            panelLogin.TabIndex = 0;
            panelLogin.Paint += roundedPanel1_Paint;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(231, 372);
            button1.Name = "button1";
            button1.Size = new Size(94, 32);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(16, 266);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(217, 32);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Tampilkan Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(16, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 30);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(16, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 30);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 196);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 115);
            label1.Name = "label1";
            label1.Size = new Size(121, 31);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.PixelMart_Point_of_Sale_Logo;
            pictureBox1.Location = new Point(88, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(131, 372);
            button2.Name = "button2";
            button2.Size = new Size(94, 32);
            button2.TabIndex = 7;
            button2.Text = "Daftar";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 34, 80);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(776, 446);
            Controls.Add(panelLogin);
            Name = "Form1";
            Text = "Login Form";
            WindowState = FormWindowState.Maximized;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel panelLogin;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
    }
}
