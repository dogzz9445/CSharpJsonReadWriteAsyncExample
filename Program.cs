using System;
using System.Threading.Tasks;
using Dongmin.Common;
using Dongmin.Models;

namespace Dongmin
{
    class Program
    {
        private async void WritePersonData()
        {
            Person person = new Person();
            var task = await Task.Run(() => JsonFileManager.WriteJsonFile<Person>("SampleData", person));
        }

        private async Person ReadPersonData()
        {
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
