namespace Demoprograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Collection.List();
            //Collection.Queue();
            //Collection.Stack();
            //Collection.Dictinory();
            //Collection.Set();

            //ReflectionOnCustomer.ReflectionTest();

            Operations operations = new Operations();
            List<Person> persons = new List<Person>();
            persons.Add(new Person() 
            {  SSN =1, Name="Prabhu", Address="Moradabad",Age=24});
            persons.Add(new Person()
            { SSN = 2, Name = "Hemant", Address = "Delhi", Age = 16 });
            persons.Add(new Person()
            { SSN = 3, Name = "Vinesh", Address = "Ghaziabad", Age = 15 });
            persons.Add(new Person()
            { SSN = 4, Name = "Atul", Address = "Chandigarh", Age = 61 });
            persons.Add(new Person()
            { SSN = 5, Name = "Rita", Address = "Ajmer", Age = 63 });
            persons.Add(new Person()
            { SSN = 6, Name = "Akash", Address = "Deharadun", Age = 65 });
            persons.Add(new Person()
            { SSN = 7, Name = "Surbhi", Address = "Rajasthan", Age = 42 });
            persons.Add(new Person()
            { SSN = 8, Name = "Anita", Address = "Kanpur", Age = 17 });
            Console.WriteLine("Person above age 60 are:");
            operations.RetreiveTopAge(persons);
            Console.WriteLine("\nPerson btw age 13 to 18 are:");
            operations.RetreiveAllAge(persons);
            operations.AverageAge(persons);
        }
    }
}