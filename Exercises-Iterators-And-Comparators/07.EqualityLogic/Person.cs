using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


public class Person : IComparable<Person>
{
    private string name;
    private int age;
 

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Age}";
    }

    public int CompareTo(Person other)
    {
        var result = this.Name.CompareTo(other.Name);
        if ( result == 0)
        {
            result = this.Age.CompareTo(other.Age);
        }

        return result;
    }

    public override bool Equals(object obj)
    {
        var otherPerson = (Person)obj;

        if (this.Name == otherPerson.Name && this.Age == otherPerson.Age)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int GetHashCode()
    {
        return (this.Name + this.Age.ToString()).GetHashCode();
    }

}

