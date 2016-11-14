using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is your batch of cookies.");
            ///
            ///this function will create a batch containing these cookies with these parameters
            ///
            Random Die = new Random();
            int total = Die.Next(1, 7);

            batch bakedCookies = new batch();
            bakedCookies.createCookies("2", "raisin", "round");
            bakedCookies.createCookies("2", "sugar", "square");
            bakedCookies.createCookies("4", "oatmeal", "round");
            bakedCookies.createCookies("1", "gingerbread", "man shaped");
            bakedCookies.createCookies("2", "chocolate", "round");


            
           for (int c = 1; c <= bakedCookies.cookieCount; c++)
            {
                Console.WriteLine("\n" + bakedCookies.cookie[c - 1].cookieCount + " " + bakedCookies.cookie[c - 1].cookieShape + " " + bakedCookies.cookie[c - 1].cookieType + " cookie(s)");
            }
            Console.ReadKey();
        }
    }
}
