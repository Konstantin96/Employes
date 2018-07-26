using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.model;
using ConsoleApplication2;

namespace ConsoleApplication2
{
    public enum UI : int
    {
        Name, family, shortName = 5, age, sex
    }
    public enum Discount : ulong
    {
        Name, family, shortName = 5, age, sex, salara = 20000000
    }



    public enum ResultCode { success, warning, error }

    class Program
    {
        static void Main(string[] args)
        {
            // cw();

            ServiceEmployer s = new ServiceEmployer();
            s.CreateEmployers();
            foreach (Employer item in s.employers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
          foreach(Employer item in s.Find(prof.klerk))
                Console.WriteLine(item);
        }

        public static void cw()
        {
            Discount d = Discount.Name;

            //ulong
            Console.WriteLine(Enum.GetUnderlyingType(d.GetType()));

            // все пары имя / значение
            Array EnumData = Enum.GetValues(d.GetType());
            foreach (var item in EnumData)
            {
                Console.WriteLine("name: {0} - {0:D}", item);
            }

            //поиск по значению
            var result = 5;
            if (!Enum.IsDefined(typeof(ResultCode), result))
            {
                throw new InvalidOperationException("enum out of range");
            }

            //поиск по имени
            string option = "success";
            var resultStr = (ResultCode)Enum.Parse(typeof(ResultCode), option);
            if (resultStr == ResultCode.success)
                Console.WriteLine("!!!!");
        }


    }
}
