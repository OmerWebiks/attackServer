using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
          string result = await GetDataAsync();
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static async Task<string> GetDataAsync()
        {
            await Task.Delay(2000);
            return "Recivde Data";
        }

        public static async Task<string> ReadFileAsync() { 
            //file.ReadAllText
            //Task.run()
        }
    }
}
