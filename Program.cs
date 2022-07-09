using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanArray2;
class program
{
    static void Main(string[] args)
    {
        // deklarasi 3 buah objek mahasiswa
        Mahasiswa mhs1 = new Mahasiswa();
        mhs1.Nim = "12345";
        mhs1.Nama = "Alice";

        Mahasiswa mhs2 = new Mahasiswa();
        mhs2.Nim = "12346";
        mhs2.Nama = "Steven";

        Mahasiswa mhs3 = new Mahasiswa();
        mhs3.Nim = "12347";
        mhs3.Nama = "Jhon";

        // deklarasi objek array mahasiswa
        Mahasiswa[] arrMahasiswa = new Mahasiswa[3];

        // menyimpan onjek mahasiswa kedalam array
        arrMahasiswa[0] = mhs1;
        arrMahasiswa[1] = mhs2;
        arrMahasiswa[2] = mhs3;

        // mengakses semua element array
        for (int i =0; i < arrMahasiswa.Length; i++)
        {
            Mahasiswa mhs = arrMahasiswa[i];
            Console.WriteLine("Nama : {0}", mhs.Nama);
            Console.WriteLine("Nim : {0}", mhs.Nim);
        }

        // mengakses semua elemen array dengan menggunakaan foreach
        foreach(Mahasiswa mhs in arrMahasiswa)
        {
            Console.WriteLine("Nama : {0}", mhs.Nama);
            Console.WriteLine("Nim : {0}", mhs.Nim);
        }
    }
}