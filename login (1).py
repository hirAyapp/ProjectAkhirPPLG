"""
LANGKAH 1 - Form Login (padanan Form1.cs)
Jalankan: python login.py
"""
import tkinter as tk
from tkinter import messagebox

# Akun sementara (di C# belum ada logika login, jadi kita tentukan dulu)
USERNAME_BENAR = "admin"
PASSWORD_BENAR = "admin123"


class LoginForm(tk.Tk):
    def __init__(self):
        super().__init__()
        self.title("Login Kasir")
        self.geometry("500x380")
        self.resizable(False, False)

        # ===== Header (panel1 di Form1.cs) =====
        header = tk.Frame(self, bg="#2c3e50", height=100)
        header.pack(fill="x", padx=12, pady=(12, 0))
        header.pack_propagate(False)
        tk.Label(
            header, text="KASIR", font=("Segoe UI", 24, "bold"),
            bg="#2c3e50", fg="white",
        ).pack(expand=True)

        # ===== Isi form (panel2 di Form1.cs) =====
        body = tk.Frame(self)
        body.pack(fill="both", expand=True, padx=12, pady=12)

        tk.Label(body, text="Username", font=("Segoe UI", 11)).pack(anchor="w")
        self.txt_user = tk.Entry(body, font=("Segoe UI", 11))
        self.txt_user.pack(fill="x", pady=(2, 10))

        tk.Label(body, text="Password", font=("Segoe UI", 11)).pack(anchor="w")
        self.txt_pass = tk.Entry(body, font=("Segoe UI", 11), show="*")
        self.txt_pass.pack(fill="x", pady=(2, 4))

        # Centang untuk menampilkan / menyembunyikan password
        self.var_lihat = tk.BooleanVar(value=False)
        tk.Checkbutton(
            body, text="Tampilkan kata sandi", variable=self.var_lihat,
            command=self.toggle_password, font=("Segoe UI", 10),
        ).pack(anchor="w", pady=(0, 15))

        # ===== Tombol =====
        tombol = tk.Frame(body)
        tombol.pack(anchor="e")
        tk.Button(tombol, text="Login", width=10, command=self.proses_login
                  ).pack(side="left", padx=(0, 6))
        tk.Button(tombol, text="Close", width=10, command=self.destroy
                  ).pack(side="left")

        # Tekan Enter = Login
        self.bind("<Return>", lambda e: self.proses_login())
        self.txt_user.focus()

    def toggle_password(self):
        """Tampilkan password kalau dicentang, sembunyikan kalau tidak."""
        self.txt_pass.config(show="" if self.var_lihat.get() else "*")

    def proses_login(self):
        """Padanan button1_Click di Form1.cs"""
        user = self.txt_user.get().strip()
        pwd = self.txt_pass.get()

        if not user or not pwd:
            messagebox.showwarning("Peringatan", "Username dan Password harus diisi!")
            return

        if user == USERNAME_BENAR and pwd == PASSWORD_BENAR:
            self.buka_dashboard()
        else:
            messagebox.showerror("Gagal", "Username atau Password salah!")
            self.txt_pass.delete(0, "end")
            self.txt_pass.focus()

    def buka_dashboard(self):
        """Pindah ke Form2 (Dashboard Admin). Dibuat di langkah berikutnya."""
        try:
            from dashboard import DashboardForm
        except ImportError:
            messagebox.showinfo(
                "Login Berhasil",
                "Login berhasil!\n(Dashboard / Form2 belum dibuat - langkah 2)",
            )
            return
        self.withdraw()
        DashboardForm(self)


if __name__ == "__main__":
    LoginForm().mainloop()
