using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Tạo và bắt đầu một luồng mới để chạy hàm ff
        Thread thread = new Thread(new ThreadStart(ff));
        thread.Start();

        // Chờ đợi luồng kết thúc
        thread.Join();

        // Hiển thị thông báo khi luồng kết thúc
        Console.WriteLine("Đã thực hiện xong");
    }

    static void ff()
    {
        Random random = new Random();

        while (true)
        {
            int n = random.Next();
            if (n % 2025 == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine(n);
                Thread.Sleep(100); // Delay 100ms
            }
        }
    }
}
