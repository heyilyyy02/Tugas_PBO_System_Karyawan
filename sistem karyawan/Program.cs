using System;
using System.Collections.Generic;

namespace SistemKaryawan
{
    class Karyawan
    {
        public string Nama { get; set; }
        public double Gaji { get; set; }

        public Karyawan(string Nama, double Gaji)
        {
            this.Nama = Nama;
            this.Gaji = Gaji;
        }

        public virtual void Kerja()
        {
            Console.WriteLine(Nama + " sedang melaksanakan pekerjaan.");
        }

        public virtual void InfoKaryawan()
        {
            Console.WriteLine("Nama : " + Nama);
            Console.WriteLine("Gaji : " + Gaji);
        }
    }

    class Tetap : Karyawan
    {
        public double Tunjangan { get; set; }

        public Tetap(string Nama, double Gaji, double Tunjangan) : base(Nama, Gaji)
        {
            Tunjangan = Tunjangan;
        }

        public double HitungGajiTotal()
        {
            return Gaji + Tunjangan;
        }

        public override void Kerja()
        {
            Console.WriteLine(Nama + " bekerja sebagai karyawan tetap.");
        }
    }

    class Kontrak : Karyawan
    {
        public int Durasi { get; set; }
        public Kontrak(string Nama, double Gaji, int Durasi)
            : base(Nama, Gaji)
        {
            Durasi = Durasi;
        }

        public void CekKontrak()
        {
            Console.WriteLine("Durasi kontrak: " + Durasi + "bulan");
        }

        public override void Kerja()
        {
            Console.WriteLine(Nama + " bekerja sebagai karyawan kontrak.");
        }
    }

    class Manager : Tetap
    {
        public Manager(string Nama, double Gaji, double Tunjangan)
            : base(Nama, Gaji, Tunjangan) { }

        public void Memimpin()
        {
            Console.WriteLine(Nama + " memimpin tim.");
        }

        public override void Kerja()
        {
            Console.WriteLine(Nama + " mengelola operasional perusahaan.");
        }
    }

    class Staff : Tetap
    {
        public Staff(string Nama, double Gaji, double Tunjangan)
            : base(Nama, Gaji, Tunjangan) { }

        public void KerjakanTugas()
        {
            Console.WriteLine(nama + " mengerjakan tugas.");
        }

        public override void Kerja()
        {
            Console.WriteLine(nama + " mengerjakan pekerjaan kantor.");
        }
    }



class Magang : Kontrak
    {
        public Magang(string Nama, double Gaji, int Durasi)
            : base(Nama, Gaji, Durasi) { }

        public void Belajar()
        {
            Console.WriteLine(nama + " sedang belajar.");
        }

        public override void Kerja()
        {
            Console.WriteLine(nama + " belajar sambil bekerja.");
        }
    }

    class Freelancer : Kontrak
    {
        public Freelancer(string Nama, double Gaji, int Durasi)
            : base(Nama, Gaji, Durasi) { }

        public void AmbilProyek()
        {
            Console.WriteLine(nama + " mengambil proyek.");
        }

        public override void Kerja()
        {
            Console.WriteLine(nama + " mengerjakan proyek sebagai freelancer.");
        }
    }


    class Perusahaan
    {
        List<Karyawan> daftar = new List<Karyawan>();

        public void TambahKaryawan(Karyawan karyawan)
        {
            daftar.Add(karyawan);
        }

        public void DaftarKaryawan()
        {
            foreach (Karyawan K in daftar)
            {
                K.InfoKaryawan();
                K.Kerja();
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Perusahaan P = new Perusahaan();

            Manager M = new Manager("Alex", 11000000, 5000000);
            Staff S = new Staff("Freya", 7000000, 2000000);
            Magang MG = new Magang("Kenzo", 3000000, 6);
            Freelancer F = new Freelancer("Ziva", 5000000, 3);

            P.TambahKaryawan(M);
            P.TambahKaryawan(S);
            P.TambahKaryawan(MG);
            P.TambahKaryawan(F);

            P.DaftarKaryawan();

            M.Memimpin();
            S.KerjakanTugas();
            MG.Belajar();
            F.AmbilProyek();
        }
    }
}

        