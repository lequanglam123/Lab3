using System;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main()
    {
        string filePath = "example.txt";

        // Gọi phương thức để ghi dữ liệu vào file từ bai1a.cs
        Bai1a.WriteToFile(filePath);

        // Gọi phương thức để đọc dữ liệu từ file từ bai1b.cs
        Bai1b.ReadFromFile(filePath);
    }
}