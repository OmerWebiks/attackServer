using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace attackServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //string result = await GetDataAsync();
            //  Console.WriteLine(result);
            //  Console.ReadLine();
            string filePathToRead = "C:\\Users\\Omer Munk\\source\\repos\\attackServer\\instructions.txt";
            string content = await ReadFileAsync(filePathToRead);
            Console.WriteLine(content);
        }
        public static async Task<string> GetDataAsync()
        {
            await Task.Delay(2000);
            return "Recivde Data";
        }

        public static async Task<string> ReadFileAsync(string filePath) {
            string result = await Task.Run(
                () => File.ReadAllText(filePath)
                );
            return result;

        }
    }
}
