"""
LANGKAH 2 - Dashboard Admin (padanan Form2.cs)
Taruh di folder yang sama dengan login.py, lalu jalankan login.py
"""
import importlib
import tkinter as tk
from tkinter import messagebox


class DashboardForm(tk.Toplevel):
    def __init__(self, login_window):
        super().__init__(login_window)
        self.login_window = login_window  # window login (sedang disembunyikan)

        self.title("Dashboard Admin")
        self.geometry("800x450")
        self.resizable(False, False)
        self.protocol("WM_DELETE_WINDOW", self.keluar_aplikasi)

        # ===== Header (panel1 di Form2.cs) =====
        header = tk.Frame(self, bg="#2c3e50", height=100)
        header.pack(fill="x", padx=12, pady=(12, 0))
        header.pack_propagate(False)
        tk.Label(
            header, text="WELCOME ADMIN!", font=("Segoe UI", 22, "bold"),
            bg="#2c3e50", fg="white",
        ).pack(expand=True)

        # ===== Isi menu (panel2 di Form2.cs) =====
        isi = tk.Frame(self)
        isi.pack(fill="both", expand=True, padx=12, pady=12)
        isi.columnconfigure(0, weight=1)
        isi.columnconfigure(1, weight=1)

        # --- Kolom KASIR ---
        self.buat_kolom(
            isi, kolom=0, judul="KASIR",
            menu=[
                ("Transaksi", "transaksi", "TransaksiForm"),   # Form4 (langkah 4)
                ("Pencarian", "katalog", "KatalogForm"),       # Form3 (langkah 3)
                ("Riwayat", None, None),
                ("Laporan", None, None),
            ],
        )

        # --- Kolom GUDANG ---
        self.buat_kolom(
            isi, kolom=1, judul="GUDANG",
            menu=[
                ("Data", None, None),
                ("Pemasukan", None, None),
                ("Pengeluaran", None, None),
                ("Stok", None, None),
            ],
        )

        # ===== Tombol bawah =====
        bawah = tk.Frame(self)
        bawah.pack(fill="x", padx=12, pady=(0, 12))
        tk.Button(bawah, text="Logout", width=10, command=self.logout
                  ).pack(side="right")

    # ------------------------------------------------------------------
    def buat_kolom(self, parent, kolom, judul, menu):
        """Bikin satu kolom: judul + tombol-tombol menunya (grid 2 x 2)."""
        frame = tk.LabelFrame(
            parent, text=f" {judul} ", font=("Segoe UI", 12, "bold"),
            padx=10, pady=10,
        )
        frame.grid(row=0, column=kolom, sticky="nsew", padx=6)

        for i, (teks, modul, kelas) in enumerate(menu):
            tk.Button(
                frame, text=teks, width=14, height=2, font=("Segoe UI", 10),
                command=lambda t=teks, m=modul, k=kelas: self.buka_form(t, m, k),
            ).grid(row=i // 2, column=i % 2, padx=8, pady=12)

    def buka_form(self, nama_menu, modul, kelas):
        """Buka form lain. Kalau filenya belum dibuat, tampilkan pemberitahuan."""
        if modul is None:
            messagebox.showinfo("Info", f"Menu '{nama_menu}' belum tersedia.")
            return
        try:
            form = getattr(importlib.import_module(modul), kelas)
        except (ImportError, AttributeError):
            messagebox.showinfo(
                "Info", f"Menu '{nama_menu}' belum dibuat (file {modul}.py)."
            )
            return
        form(self)

    def logout(self):
        """Tutup dashboard, kembali ke form login."""
        if messagebox.askyesno("Logout", "Yakin mau logout?"):
            self.destroy()
            self.login_window.txt_pass.delete(0, "end")
            self.login_window.deiconify()

    def keluar_aplikasi(self):
        """Kalau dashboard ditutup lewat tombol X, seluruh aplikasi ikut ditutup."""
        self.login_window.destroy()
