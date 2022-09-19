using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudArray
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] names = new string[4];

            names[0] = "chiu";
            names[1] = "rahul";
            names[2] = "shubham";
            names[3] = "mahesh";

            for (int i = 0; i < names.Length; i++)
            {
                string s = names[i];
                Console.WriteLine(s);
                
                

            }
        }
            


        
    }
}
