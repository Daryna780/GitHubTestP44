using System;
using System.Collections.Generic;
using System.Text;

namespace GitHubTestP44
{
    internal class Group
    {
        public string? Name { get; set; }
        private List<Person> _people = new();

        public void AddPerson(Person person)
        {
            _people.Add(person);
        }
        public void RemovePerson(Person person)
        {
            _people.Remove(person);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Group: {Name}");
            foreach (Person person in _people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
