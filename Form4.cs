using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhirPPLG
{
    public partial class Form4 : Form
    {

        private int totalBelanja = 0;
        private object txtBayar;

        public Form4()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kodeProduk = "P001";
            string namaProduk = "Prdouk";
            int hargaSatuan = 15000;
            int qty = (int)numericUpDown1.Value;

            if (qty <= 0) ;
            {
                MessageBox.Show("Jumlah (QTY) harus lebih dari 0!", "Peringatan");
                return;
            }

            int subtotal = hargaSatuan * qty;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int GetTotalBelanja()
        {
            return totalBelanja;
        }

        private void GetV(DataGridViewCellEventArgs e) => dataGridView1.Rows.RemoveAt(e.RowIndex);

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e, int subtotal, int totalBelanja)
        {

            if (e.RowIndex < 0)
            {
                return;
            }
            int Subtotal = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            totalBelanja -= subtotal;

            if (int.TryParse(textBox1.Text, out int uangBayar))
            {
                return;
            }
            int kembalian = uangBayar - totalBelanja;
            textBox2.Text = kembalian >= 0 ? kembalian.ToString() : "Uang Kurang";
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
