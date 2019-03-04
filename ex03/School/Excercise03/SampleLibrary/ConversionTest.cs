using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise03.SampleLibrary
{
    internal class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Person(int id)
        {
            ID = id;
        }

        public static explicit operator Person(int v)
        {
            return new Person(v);
        }
        public static implicit operator int(Person person)
        {
            return person.ID;
        }

    }

    public static class ConversionTest
    {
        public static void DoIt()
        {
            Double realNumber = 3.14;
            realNumber = Math.PI;
            realNumber = 10;
            realNumber = 10.0;
            realNumber = (double)10;

            int integerNumber = 3;
            integerNumber = (int)3.14;
            integerNumber = realNumber;
            integerNumber = Math.PI;

            Person person = new Person(1);
            Person person02 = (Person)integerNumber;//explicit conversion; row18
            int integerNumber2 = person02;//implicit conversion; row23

            Object person2 = new Person(2);
            (person2 as Person).Name = "Jarda";
            if (person2 is Person) ;
            //if(person2.GetType()==typeof(Person))
        }
    }
}
