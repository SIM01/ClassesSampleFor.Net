using System;
using System.IO;

namespace SampleForFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.DirectorySeparatorChar.ToString(), "home","sim","RiderProjects","test1");
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            Console.WriteLine("Введите текст");
            var text = Console.ReadLine();
            using (FileStream fileStream = new FileStream($"{path}/test.txt",FileMode.Append))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fileStream.Write(array,0,array.Length);
            }

            using (FileStream fileStream = new FileStream($"{path}/test.txt",FileMode.Open))
            {
                byte[] arraytest = new byte[fileStream.Length];
                fileStream.Read(arraytest, 0, arraytest.Length);
                string readText = System.Text.Encoding.Default.GetString(arraytest);
                Console.WriteLine(readText);
            }
        }
    }
}