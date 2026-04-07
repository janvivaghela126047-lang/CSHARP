using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_21
{
    internal class car:vehicle
    {
        String model_type, company_name;
        public void get_car()
        {
            Console.WriteLine("enter model type ");
            model_type = Console.ReadLine();

            Console.WriteLine("enter company name");
            company_name = Console.ReadLine();
        }
        public  void show_car()
        {
            Console.WriteLine("enter type" + model_type);
            Console.WriteLine("company name" + company_name);
                
        }
    }
}
