using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demoprograms
{
    class ReflectionOnCustomer
    {
        public static void ReflectionTest()
        {
            Type type = Type.GetType("Demoprograms.CustomerInfo");
            Console.WriteLine("Full Name :{0}", type.FullName);
            Console.WriteLine("Class name is:{0}",type.Name);
            Console.WriteLine("Methods in customer class");
            MethodInfo[] methodInfos = type.GetMethods();
            foreach(MethodInfo methodInfo in methodInfos)
            {
                Console.WriteLine(methodInfo.ReturnType.Name + " " + methodInfo.Name);
            }
            Console.WriteLine("Properties in CustomerInfo Class");

            PropertyInfo[] propertyInfos=type.GetProperties();
            foreach(PropertyInfo propertyInfo in propertyInfos)
            {
                Console.WriteLine(propertyInfo.PropertyType.Name + " " + propertyInfo.Name);
            }
            Console.WriteLine("Constructors in customerinfo class");

            ConstructorInfo[] constructorInfos=type.GetConstructors();
            foreach(ConstructorInfo constructorInfo in constructorInfos)
            {
                Console.WriteLine(constructorInfo.ToString());
            }
        }
    }
}
