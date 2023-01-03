using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoprograms
{
    public class CustomerInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CustomerInfo(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public CustomerInfo()
        {
            this.Id = -1;
            this.Name=string.Empty;
        }

        public void PrintId()
        {
            Console.WriteLine("Id is:{0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name is:{0}", this.Name);
        }
    }
}
