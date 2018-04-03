using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgess_quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Repo repo = new Repo();
            var headerlist = repo.Task1();
            foreach(var a in headerlist)
            {
                Console.WriteLine($"HeaderID:{a.p1}");
                //Console.WriteLine($"ClientName":{repo.GetClientNameByID(p2)}");
            }

            Console.ReadLine();
                
               

        }


    }
}
