using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class Customer
    {
        private int MusteriNo;
        private string Name, Surname, Country;
        public Customer(int MusteriNo, string name, string surname, string country)
        {
            this.MusteriNo = MusteriNo;
            this.Name = name;
            this.Surname = surname;
            this.Country = country;
        }
      
        public int GetMusteriNo(Customer customer)
        {
            return this.MusteriNo;
        }
        
        public string GetName(Customer customer)
        {
            return Name;
        }
    }
}