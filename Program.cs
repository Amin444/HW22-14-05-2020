using System;
using System.Collections.Generic;
using System.Text;
namespace HW22_14_05_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Insert
            function.Add(new Shop { Company = "HP", Model = "HP22" });

            //Select
            List<Shop> list = function.Read<Shop> ();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Id},{item.Company},{item.Model}");
            }

            //Update
            function.Update(new Shop { Company = "HP", Model = "HP25", Id = 13 });

            //Delete
            function.Delete(new Shop { Id = 13 });

            Console.ReadKey();
        }
    }
}
