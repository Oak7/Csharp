using System;
using System.IO;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {   
            string[] a = new string[3];
            a[0] = "Gabriela";
            a[1] = "Gerson";
            a[2] = "Desiree";
            foreach(string nome in a){
                Console.WriteLine(nome);

            }      
        }        
    }
}
