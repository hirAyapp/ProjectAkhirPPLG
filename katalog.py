"""
LANGKAH 3 - Katalog Produk (padanan Form3.cs)
Taruh di folder yang sama dengan login.py dan dashboard.py
"""
import tkinter as tk
from tkinter import messagebox

# ----------------------------------------------------------------------
# DATA PRODUK (dipakai juga oleh transaksi.py di langkah 4)
# Gambar di C# = Chitato, Teh Kotak, Coca-Cola, Japota.
# Harga di bawah hanya perkiraan, silakan ubah sesuai kebutuhan.
# ----------------------------------------------------------------------
PRODUK = [
    {"kode": "P001", "nama": "Chitato",   "harga": 15000, "ikon": "🥔"},
    {"kode": "P002", "nama": "Teh Kotak", "harga": 5000,  "ikon": "🧃"},
    {"kode": "P003", "nama": "Coca-Cola", "harga": 7000,  "ikon": "🥤"},
    {"kode": "P004", "nama": "Japota",    "harga": 12000, "ikon": "🍟"},
]

WARNA_BG = "#112250"      # biru tua (BackColor Form3)
WARNA_CARD = "#D9CBC2"    # krem (BackColor panel di Form3)


def rupiah(angka):
    """15000 -> 'Rp 15.000'"""
    return "Rp " + f"{angka:,}".replace(",", ".")


class KatalogForm(tk.Toplevel):
    def __init__(self, master):
        super().__init__(master)
        self.title("Katalog Produk")
        self.geometry("800x450")
        self.resizable(False, False)
        self.configure(bg=WARNA_BG)

        # ===== Baris atas: search, tombol cari, setting, keranjang =====
        atas = tk.Frame(self, bg=WARNA_BG)
        atas.pack(fill="x", padx=12, pady=(20, 0))

        self.txt_cari = tk.Entry(atas, font=("Segoe UI", 11))
        self.txt_cari.pack(side="left", fill="x", expand=True, ipady=4)
        self.txt_cari.bind("<Return>", lambda e: self.cari())

        tk.Button(atas, text="🔍", width=4, command=self.cari
                  ).pack(side="left", padx=(6, 0))
        tk.Button(atas, text="🛒", width=4, command=lambda: self.buka_transaksi(None)
                  ).pack(side="left", padx=(6, 0))
        tk.Button(atas, text="⚙️", width=4, command=self.pengaturan
                  ).pack(side="left", padx=(6, 0))

        # ===== Banner (panel5 / pictureBox1 di Form3.cs) =====
        banner = tk.Frame(self, bg=WARNA_CARD, height=134)
        banner.pack(fill="x", padx=12, pady=(18, 0))
        banner.pack_propagate(False)
        tk.Label(
            banner, text="PROMO HARI INI", font=("Segoe UI", 22, "bold"),
            bg=WARNA_CARD, fg=WARNA_BG,
        ).pack(expand=True)

        # ===== Area kartu produk (panel1-4 di Form3.cs) =====
        self.area_produk = tk.Frame(self, bg=WARNA_BG)
        self.area_produk.pack(fill="both", expand=True, padx=12, pady=16)

        self.tampilkan_produk(PRODUK)
        self.txt_cari.focus()

    # ------------------------------------------------------------------
    def tampilkan_produk(self, daftar):
        """Gambar ulang kartu produk sesuai daftar yang diberikan."""
        for w in self.area_produk.winfo_children():
            w.destroy()

        if not daftar:
            tk.Label(
                self.area_produk, text="Produk tidak ditemukan",
                font=("Segoe UI", 12), bg=WARNA_BG, fg="white",
            ).pack(expand=True)
            return

        for i, p in enumerate(daftar):
            self.area_produk.columnconfigure(i, weight=1, uniform="kartu")
            self.buat_kartu(i, p)

    def buat_kartu(self, kolom, p):
        kartu = tk.Frame(self.area_produk, bg=WARNA_CARD)
        kartu.grid(row=0, column=kolom, sticky="nsew", padx=6)

        tk.Label(kartu, text=p["ikon"], font=("Segoe UI Emoji", 32),
                 bg=WARNA_CARD).pack(pady=(10, 0))
        tk.Label(kartu, text=p["nama"], font=("Segoe UI", 11, "bold"),
                 bg=WARNA_CARD).pack()
        tk.Label(kartu, text=rupiah(p["harga"]), font=("Segoe UI", 10),
                 bg=WARNA_CARD).pack()
        tk.Button(
            kartu, text="Beli",
            command=lambda kode=p["kode"]: self.buka_transaksi(kode),
        ).pack(pady=8)

    # ------------------------------------------------------------------
    def cari(self):
        """Filter produk berdasarkan nama atau kode."""
        kata = self.txt_cari.get().strip().lower()
        hasil = [
            p for p in PRODUK
            if kata in p["nama"].lower() or kata in p["kode"].lower()
        ]
        self.tampilkan_produk(hasil)

    def buka_transaksi(self, kode):
        """Buka form transaksi (dibuat di langkah 4)."""
        try:
            from transaksi import TransaksiForm
        except ImportError:
            messagebox.showinfo(
                "Info", "Form transaksi belum dibuat (transaksi.py - langkah 4)."
            )
            return
        TransaksiForm(self, kode_awal=kode)

    def pengaturan(self):
        messagebox.showinfo("Pengaturan", "Menu pengaturan belum tersedia.")
