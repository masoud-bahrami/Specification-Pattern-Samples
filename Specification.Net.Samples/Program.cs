using System;
using System.Threading.Tasks;
using Specification.Net.Samples.EricAndMartinSample;

namespace Specification.Net.Samples
{
    class Program
    {
        static void Main(string[] args) => Run().GetAwaiter();

        static async Task Run()
        {
            Bootstraper.Run();
            Console.ReadLine();
        }
    }
}
