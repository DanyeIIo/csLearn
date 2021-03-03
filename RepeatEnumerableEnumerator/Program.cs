using System;

namespace RepeatEnumerableEnumerator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    namespace HelloApp
    {

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public DateTime DateTime { get; set; }
        }
        public class People : IEnumerable<Person>
        {
            private Person[] people;
            public People(Person[] people)
            {
                this.people = people;
            }
            public IEnumerator<Person> GetEnumerator()
            {
                return new PersonEnumerator(people);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return new PersonEnumerator(people);
            }
        }
        public class PersonEnumerator : IEnumerator<Person>, IEnumerator
        {
            private Person[] people;
            private int index = -1;
            public Person Current => people[index];
            object IEnumerator.Current => people[index];
            public PersonEnumerator(Person[] people)
            {
                this.people = people;
            }
            
            public bool MoveNext()
            {
                if (index + 1 == people.Length)
                    return false;
                
                index++;
                return true;
            }

            public void Reset()
            {
                index = 0;
            }
            public void Dispose()
            {
            }
        }
        public class Program
        {
            private static void Main(string[] args)
            {
                var people = new[]
                {
                    new Person
                    {
                        Name = "Dondo",
                        Age = 17,
                        DateTime  = DateTime.Now.AddHours(5)
                    },
                    new Person
                    {
                        Name = "Bondo",
                        Age = 17,
                        DateTime  = DateTime.Now.AddDays(10)
                    },
                    new Person
                    {
                        Name = "Fondo",
                        Age = 17,
                        DateTime  = DateTime.Now
                    }
                };
                var data = new People(people);
                foreach (var item in data)
                {
                    Console.WriteLine(item.Name + " " + item.DateTime);
                }
            }
        }
    }

}
