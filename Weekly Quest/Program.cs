using System;

namespace Weekly_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mau Berapa Anggota : ");
            int ang = Convert.ToInt32(Console.ReadLine());
            string[,] nama = new string[ang,6];
            for (int x = 0; x < ang; x++)
            {
                Console.WriteLine("Anggota ke - " + (x + 1));
                Console.Write("NIM           : ");
                nama[x,0] = Console.ReadLine();
                Console.Write("NAMA          : ");
                nama[x, 1] = Console.ReadLine();
                Console.Write("JENIS KELAMIN : ");
                nama[x, 2] = Console.ReadLine();
                Console.Write("TAHUN MASUK   : ");
                nama[x, 3] = Console.ReadLine();
                Console.Write("PROGRAM STUDI : ");
                nama[x, 4] = Console.ReadLine();
                Console.Write("KELAS         : ");
                nama[x, 5] = Console.ReadLine();
            }
            while (true)
            {
                Console.WriteLine("Ingin mencetak Anggota ? (y/n) ");
                string cetak = Console.ReadLine();
                if (cetak == "y")
                {
                    Console.WriteLine("NIM          NAMA          JENIS KELAMIN          TAHUN MASUK          PROGRAM STUDI          KELAS          ");
                    for (int x = 0; x < ang; x++)
                    {
                        string prin = String.Format("{0}          {1}          {2}          {3}          {4}          {5}",
                            nama[x, 0], nama[x, 1], nama[x, 2], nama[x, 3], nama[x, 4], nama[x, 5]);
                        Console.WriteLine(prin);
                    }
                }
                else if (cetak == "n")
                {
                    Console.WriteLine("Babay :D");
                    Environment.ExitCode = 0;
                }
            }
        }
    }
}
