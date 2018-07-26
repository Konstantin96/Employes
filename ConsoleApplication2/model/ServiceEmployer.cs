using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;

namespace ConsoleApplication2.model
{
    public struct ServiceEmployer
    {
        public List<Employer> employers;
        public void CreateEmployers()
        {
            employers = new List<Employer>();
            Random rnd = new Random();

            Console.Write("введите кол-во сотрудников: ");
            int x = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Employer employer = new Employer();
                Generator gen = new Generator();


                //  employer.Name = "people " + rnd.Next(20, 50).ToString();
                employer.Name = gen.GenerateDefault((Gender)rnd.Next(2)).Replace("<center><b><font size=7>", "")
                .Replace("</font></b></center>", "")
                .Replace("\n", "")
                .Substring(1);
                employer.Age = rnd.Next(20, 50);
                employer.Salary = rnd.Next(500,1000);
                employer.Prof = (prof)rnd.Next(3);
                employer.DateOfStart = DateTime.Now.AddMonths(rnd.Next(1, 50));

                employers.Add(employer);

            }
        }

        public List<Employer> Find(prof p)
        {
            int g = employers.Where(w => w.Prof == p).Sum(s => s.Salary);
            int c = employers.Where(w => w.Prof == p).Count();
            double avg = g / c;

            List<Employer> Managers =   employers.Where(w => w.Prof == prof.manager && w.Salary >= avg).ToList();

            return Managers.OrderBy(o=>o.Name).ToList();
        }
    }
}
