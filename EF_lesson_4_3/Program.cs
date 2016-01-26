using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;
namespace EF_lesson_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PhoneContext db = new PhoneContext())
            {
                int id = 3;
                IEnumerable phoneIEnum = db.Phones;
                phoneIEnum = phoneIEnum.Where(p => p.Id > id);

                //IQueryable phoneIQuer = db.Phones;
                //phoneIQuer = phoneIQuer.Where(p => p.Id > id);

                //IEnumerable phoneIEnum = db.Phones.Where(p => p.Id > id);
 
                //IQueryable phoneIQuer = db.Phones.Where(p => p.Id > id);
                 

                
                
                
            }
            Console.ReadLine();
        }
    }
}
