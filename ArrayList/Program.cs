using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList dizi = new ArrayList();

            dizi.Add("Kedi");
            dizi.Add(99);
            dizi.Add(true);

            foreach (var item in dizi)
            {
                Console.WriteLine(dizi);
            }
        }
    }
}
