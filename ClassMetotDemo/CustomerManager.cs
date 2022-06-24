using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        private List<Customer> customers;
        public CustomerManager()
        {
            customers = new List<Customer>();
        }
        public void Affixer(Customer customer)
        {
            customers.Add(customer);
        }
        public void CustomerRemover(int MusteriNo)
        {
            var cus = customers.Where(x => x.GetMusteriNo(x) == MusteriNo).FirstOrDefault();
            if (cus != null)
            {
                customers.Remove(cus);
                Console.WriteLine("Başarıyla silinmiştir.");
            }
            else
            {
                Console.WriteLine("Müşteri bulunamadı.");
            }
        }
        public void List()
        {
            foreach (var c in customers)
            {
                Console.WriteLine("İsim :" + c.GetName(c) + " Musteri No :" + c.GetMusteriNo(c));
            }
        }
    }

}

