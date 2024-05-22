using System;
using System.IO;

public class Bai1a
{
    public static void WriteToFile(string filePath)
    {
        string data = "Username: example_user\nPassword: example_password\nTime: " + DateTime.Now.ToString();

        using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.WriteLine(data);
            Console.WriteLine("Data has been written to the file.");
        }
    }
}