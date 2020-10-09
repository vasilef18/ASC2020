using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");
            Console.WriteLine("Introduceti numarul de la pantof");
            
            string line;
            line = Console.ReadLine();

            int numarpantof;
            try
            {
                numarpantof = int.Parse(line);
               
                Console.WriteLine($"aveti {numarpantof} numarul la pantof");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            //int.TryParse(line,out numarpantof)
        }
    }
}
