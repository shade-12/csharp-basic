using System.Collections.Generic;
using System.Diagnostics;

namespace Data
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class FakeService
    {
        public static string Name = "Fake Data Service.";

        public static List<Person> GetPeople()
        {
            Debug.WriteLine("GET for people.");
            return new List<Person>()
                {
                    new Person() { Name="Chris Cole", Age=10 },
                    new Person() { Name="Kelly Kale", Age=32 },
                    new Person() { Name="Dylan Durbin", Age=18 }
                };
        }

        public static void Write(Person person)
        {
            Debug.WriteLine("INSERT person with name " + person.Name);
        }

        public static void Delete(Person person)
        {
            Debug.WriteLine("DELETE person with name " + person.Name);
        }
    }
}
