using System;
using System.IO;

class Program
{
    static void Main()
    {
        string username = "example_username";
        string password = "example_password";
        string time = "example_time";

        // Sử dụng StringWriter để lưu tài khoản, mật khẩu và thời gian
        using (StringWriter sw = new StringWriter())
        {
            sw.WriteLine("username: " + username);
            sw.WriteLine("password: " + password);
            sw.WriteLine("time save: " + time);

            // Lấy chuỗi từ StringWriter
            string content = sw.ToString();

            // Sử dụng StringReader để chỉ đọc tài khoản và mật khẩu 
            using (StringReader sr = new StringReader(content))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("username:") || line.StartsWith("password:"))
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}