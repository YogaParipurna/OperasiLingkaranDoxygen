using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas
{
    /// <summary>
    /// Main Class
    /// </summary>
    /// <remarks>class Lingkaran dapat memuat operasi Masukkan Data, Menghitung luas lingkaran, menghitung keliling dan menampilkan data</remarks>
    class Lingkaran
    {
        /// <summary>
        /// <var> Jari </var>
        /// </summary>
        public double jari;

        /// <summary>
        /// <param name="jari">Jari jari lingkaran yang ingin dihitung </param>
        /// </summary>
        public void MasukkanData()
        {
            Console.Write("Masukkan Jari jari: ");
            jari = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// <param name="luas">Menghitung luas lingkaran </param>
        /// <param name="jari"> Jari jari lingkaran yang ingin dihitung </param>
        /// </summary>
        /// <returns> Hasil dari penghitungan luas lingkaran </returns>
        public double HitungLuas()
    { 
            double luas;
            luas = (22/7)* jari* jari;
            return luas;
    }
        /// <summary>
        /// <param name="keliling">Menghitung keliling lingkaran </param>
        /// <param name="jari"> Jari jari lingkaran yang ingin dihitung </param>
        /// </summary>
        /// <returns>Hasil dari perhitungan kelilingan lingkaran </returns>
        public double Hitungkeliling()
    {
            double keliling;
            keliling = (22/7)* (2*jari);
            return keliling;
    }

        /// <summary>
        /// Menampilkan luas dan keliling lingkaran yang telah dihitung tadi
        /// </summary>
        public void Tampil()
        {
            Console.WriteLine("Luas lingkaran = {0}", HitungLuas());
            Console.Write("keliling lingkaran = {0}", Hitungkeliling());
        }
}

    /// <summary>
    /// Sub class Program
    /// </summary>
class Program
{
    static void Main(string[] args)
    {
        Lingkaran yoga = new Lingkaran();
        yoga.MasukkanData();
        yoga.Hitungkeliling();
        yoga.HitungLuas();
        yoga.Tampil();
        Console.ReadKey();

        }
   }
}