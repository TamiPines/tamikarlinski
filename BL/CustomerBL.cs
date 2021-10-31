using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{

    public static class CustomerBL
    {
        public static List<DAL.Customer> GetByStatus(int status)
        {
            using (DAL.tamiEntities db = new DAL.tamiEntities())
            {
                return db.Customers.Where(p => p.Status == status).ToList();
            }

        }

        public static bool Add(string name)
        {
            using (DAL.tamiEntities db = new DAL.tamiEntities())
            {
                db.Customers.Add(new DAL.Customer() { Name = name, Status = 1, Date = DateTime.Now });
                db.SaveChanges();
                return true;
            }
        }

        public static bool Update(int id)
        {
            using (DAL.tamiEntities db = new DAL.tamiEntities())
            { 
                var customerr = db.Customers.FirstOrDefault(p => p.Status == 2);
                db.Customers.Remove(customerr);
                db.SaveChanges();
                var customer = db.Customers.FirstOrDefault(p => p.ID == id);
                customer.Status = 2;
                db.SaveChanges();
                return true;
            }
        }
    }
}
