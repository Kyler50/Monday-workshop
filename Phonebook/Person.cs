using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    struct Person
    {
        public Person(string name, string address, int age, int mobile, string type)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.mobile = mobile;
            this.type = type;
        }

        string name;
        string address;
        int age;
        int mobile;
        string type;

        public override string ToString()
        {
            return string.Format("Name: {0}, Address: {1}, Age: {2}, Mobile: {3}, Type: {4}", name, age, address, mobile, type.ToString());
        }
    }
    class Directory
    {
        public static List<Person> persons = new List<Person>(50);
    }
    enum Type
    {
        Home, Workplace, Mobile
    }
}
