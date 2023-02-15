namespace down
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //包名 操作命令 文件路径 设备id
            var pack = args.Length > 1 ? args[0] : null;
            var cmd = args.Length > 2 ? args[1] : null;
            var path = args.Length > 3 ? args[2] : null;
            var device = args.Length > 4 ? args[3] : null;
            Console.WriteLine($"download {pack},{cmd},{path},{device}");

            //测试下载失败的样子
            if(path == "fail")
            {
                Console.WriteLine($"[fail]test fail");
                return;
            }

            //就不真做个下载功能了，假装打印下进度好了
            Console.WriteLine($"[0%]start download!");
            Thread.Sleep(1000);
           
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine($"[{i}%]downloading...");
                Thread.Sleep(10);
            }

            Console.WriteLine($"[done]");
        }
    }
}