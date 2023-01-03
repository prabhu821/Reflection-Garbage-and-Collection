using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoprograms
{
    internal class Collection
    {
        public static void List()
        {
            List<int> list = new List<int>();
            list.Add(50);
            list.Add(40);
            list.Add(20);
            list.Add(70);
            list.Add(90);
            Console.WriteLine("Values in List are: ");
            foreach (var values in list)
            {
                Console.WriteLine(values);
            }
        }
        public static void Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(500);
            stack.Push(400);
            stack.Push(200);
            stack.Push(700);
            stack.Push(900);
            int popvalue = stack.Pop();
            Console.WriteLine("Values in Stack are: ");
            foreach (var values in stack)
            {
                Console.WriteLine(values);
            }
            Console.WriteLine("Deleted value is: " + popvalue);
        }
        public static void Queue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(500);
            queue.Enqueue(400);
            queue.Enqueue(200);
            queue.Enqueue(700);
            queue.Enqueue(900);
            int peekvalue = queue.Peek();
            int dequeuevalue = queue.Dequeue();
            Console.WriteLine("Values in Queue are: ");
            foreach (var values in queue)
            {
                Console.WriteLine(values);
            }
            Console.WriteLine("Peek value is: " + peekvalue);
            Console.WriteLine("Peek value is: " + dequeuevalue);
        }
        public static void Set()
        {
            var set = new HashSet<int>();
            set.Add(500);
            set.Add(400);
            set.Add(200);
            set.Add(700);
            set.Add(900);
            Console.WriteLine("Values in Set are: ");
            HashSet<int>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.MoveNext());
            }
        }
        public static void Dictinory()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(500, "Apple");
            dictionary.Add(400, "Banana");
            dictionary.Add(200, "Mango");
            dictionary.Add(700, "Peach");
            dictionary.Add(900, "Orange");
            string accesskeyvalue = dictionary[200];
            Console.WriteLine("Values in Dictinory are: ");
            foreach (var element in dictionary)
            {
                Console.WriteLine("Element_Key {0} ", element.Key + "  Element_Value " + element.Value);
            }
            Console.WriteLine("Access value {0}", accesskeyvalue);
        }
    }
}