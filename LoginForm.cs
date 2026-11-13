namespace ProjectAkhirPPLG
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        
            this.Resize += (s, e) =>
            {
                CenterLoginPanel();
            };

            CenterLoginPanel();
        }

        private void CenterLoginPanel()
        {
            panelLogin.Left =
                (this.ClientSize.Width - panelLogin.Width) / 2;

            panelLogin.Top =
                (this.ClientSize.Height - panelLogin.Height) / 2;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
