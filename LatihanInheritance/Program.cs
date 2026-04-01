Siswa siswaobj = new Siswa("paww2112", "fawwaz2112@gmail.com", "170110", "siswa", "XMGAG1");
Guru guruobj = new Guru("Bulus", "bulus@gmail.com", "12345", "guru", "jawa");

siswaobj.TampilkanInfo();
siswaobj.SubmitTugas();

Console.WriteLine();

guruobj.TampilkanInfo();
guruobj.NilaiTugas();

public class User
{
    public string nama;
    public string email;
    public string password;
    public string role;

    public User(string nama, string email, string password, string role)
    {
        this.nama = nama;
        this.email = email;
        this.password = password;
        this.role = role;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Nama : {nama} | Role : {role}");
    }
}

class Siswa : User
{
    public string ClassName;

    public Siswa(string nama, string email, string password, string role, string className) : base(nama, email, password, role)
    {
        ClassName = className;
    }

    public void SubmitTugas()   
    {
        Console.WriteLine($"{nama} dari kelas {ClassName} sudah mengumpulkan tugas");
    }
}

class Guru : User
{
    public string Mapel;
    public Guru(string nama, string email, string password, string role, string mapel) : base(nama, email, password, role)
    {
        Mapel = mapel;
    }
    public void NilaiTugas()
    {
        Console.WriteLine($"Guru {nama} telah menilai semua tugas {Mapel}");
    }
}
