using System;
 
public class ConstructorsAndDestructors
{

    public class Person
    {
        public string Name { get; set; }
 
        public Person(string name)
        {
            Name = name;
        }
         ~Person()
        {
            Name = string.Empty;
        }
        public override string ToString()
        {
            return "Person name is " + Name;
        }
    }
    public static void Main(string[] args)
    {
        int total = 3;
        Person[] persons = new Person[total];
        for (int i = 0; i < total; i++)
        {
            persons[i] = new Person(Console.ReadLine());
        }
 
        for (int i = 0; i < total; i++)
        {
            Console.WriteLine(persons[i].ToString());
        }
    } 
}