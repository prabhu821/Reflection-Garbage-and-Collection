using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoprograms
{
    internal class Operations
    {
        public void RetreiveTopAge(List<Person> persons)
        {
            var data =persons.Where(x => x.Age > 60).ToList().Take(2);
            foreach(var result in data)
            {
                Console.WriteLine("SSN: {0} Name: {1} Address: {2} Age: {3} ", result.SSN, result.Name, result.Address, result.Age);
            }
        }

        public void RetreiveAllAge(List<Person> persons)
        {
            var data = persons.Where(x => x.Age > 13 && x.Age<18).ToList();
            foreach (var result in data)
            {
                Console.WriteLine("SSN: {0} Name: {1} Address: {2} Age: {3} ",result.SSN,result.Name,result.Address,result.Age);
            }
        }

        public void AverageAge(List<Person> persons)
        {
            var data = persons.Average(x => x.Age);
            Console.WriteLine("\nAverage Age is: {0}",data);
            
        }
    }
}
