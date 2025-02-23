using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZR17OOP_ODEV.Classes
{
    public class Car
    {
        public string marka;
        public string model;
        public string vites;

        public void ekranaYaz(string markasi,string modeli,string vitesi)
        {
            Console.WriteLine(markasi+" "+modeli+" "+vitesi+" viteslidir.");
        }
    }
}
