using System.Text.Json;

namespace ProjectAkhirPPLG
{
    public partial class Form1 : Form
    {
        // Lokasi users.json (satu folder dengan file .exe)
        private readonly string jsonPath = Path.Combine(AppContext.BaseDirectory, "users.json");

        // Pengaturan agar isi JSON tampil rapi
        private static readonly JsonSerializerOptions opsiJson = new() { WriteIndented = true };

        public Form1()
        {
            InitializeComponent();
        }

        // ================= FUNGSI BANTU JSON =================

        // Membaca semua akun dari users.json.
        // Jika file belum ada atau tidak terbaca, hasilnya daftar kosong.
        private List<User> BacaUsers()
        {
            try
            {
                if (!File.Exists(jsonPath))
                {
                    return new List<User>();
                }

                string json = File.ReadAllText(jsonPath);
                return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
            catch
            {
                return new List<User>();
            }
        }

        // Menyimpan semua akun ke users.json (file dibuat otomatis jika belum ada)
        private void SimpanUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(users, opsiJson);
            File.WriteAllText(jsonPath, json);
        }

        // ================= TOMBOL DAFTAR (button3) =================
        private void button3_Click(object sender, EventArgs e)
        {
            //1. Ambil nilai dari TextBox
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            //2. Pastikan tidak kosong
            if (username == "" || password == "")
            {
                MessageBox.Show("Username dan password tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //3. Baca akun yang sudah ada, cek apakah username sudah dipakai
            List<User> users = BacaUsers();
            if (users.Any(u => u.Username == username))
            {
                MessageBox.Show("Username sudah dipakai, gunakan username lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //4. Tambahkan akun baru lalu simpan ke users.json
            users.Add(new User { Username = username, Password = password });
            SimpanUsers(users);

            MessageBox.Show("Akun berhasil didaftarkan! Silakan login.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        // ================= TOMBOL LOGIN (button1) =================
        private void button1_Click(object sender, EventArgs e)
        {
            //1. Ambil nilai dari TextBox saat tombol diklik
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            //2. Baca akun yang tersimpan di users.json
            List<User> users = BacaUsers();

            if (users.Count == 0)
            {
                MessageBox.Show("Belum ada akun terdaftar. Silakan klik Daftar terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //3. Cocokkan username dan password
            bool loginValid = users.Any(u => u.Username == username && u.Password == password);

            if (loginValid)
            {
                MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Buat objek/instance baru dari Form2, lalu tampilkan
                Form2 formBaru = new Form2();
                formBaru.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login gagal! Periksa username dan password Anda.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Clear();
                textBox2.Focus();
            }
        }

        // ================= EVENT BAWAAN DESIGNER (jangan dihapus) =================

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // ================= TOMBOL CLOSE (button2) =================
        private void button2_Click(object sender, EventArgs e) => Application.Exit();
    }
}