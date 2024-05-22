using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Tạo thư mục "data"
        Directory.CreateDirectory("data");

        // Tạo file "data.txt" và ghi thông tin vào file
        using (StreamWriter sw = File.CreateText("data/data.txt"))
        {
            sw.WriteLine("Msvv");
            sw.WriteLine("Họ và tên");
        }

        // Tạo thư mục "data2"
        Directory.CreateDirectory("data2");

        // Copy toàn bộ file từ thư mục "data" sang thư mục "data2"
        string sourceDir = "data";
        string targetDir = "data2";

        DirectoryInfo dir = new DirectoryInfo(sourceDir);
        DirectoryInfo[] dirs = dir.GetDirectories();

        // Copy các thư mục
        foreach (DirectoryInfo subdir in dirs)
        {
            Directory.CreateDirectory(Path.Combine(targetDir, subdir.Name));
            CopyAllFiles(subdir, Path.Combine(targetDir, subdir.Name));
        }

        Console.WriteLine("Copy thành công!");
    }

    static void CopyAllFiles(DirectoryInfo source, string target)
    {
        foreach (FileInfo file in source.GetFiles())
        {
            file.CopyTo(Path.Combine(target, file.Name), true);
        }
    }
}
