/*
C# program that demonstrates the Dog class  and then display the results of caling methods  Bark and GetTag methods*/
//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Dog
{
class Program
{
static void Main(string[] args)
{
/*Create an instance of Dog and all Bark and GetTag method*/
Dog puppy = new Dog("Orian", "Shawn", 1, Gender.MALE);
puppy.Bark(3);
Console.WriteLine(puppy.GetTag());


/*Create an instance of Dog and all Bark and GetTag method*/
Dog myDog = new Dog("Lileu", "Dale", 4, Gender.FEMALE);
myDog.Bark(1);
Console.WriteLine(myDog.GetTag());
Console.ReadLine();

Console.ReadLine();
}
}
}
-----------------------------------------------------------------------------------------------------------------------------

//Dog.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Dog
{
//Enum Gender for male and female
enum Gender { MALE, FEMALE };
//Class Dog class
class Dog
{
private string name;
private string owner;
private int age;
private Gender gender;

/*constructor that to initialize
the instace variables*/
public Dog(string name,
string owner, int age, Gender gender)
{
this.name = name;
this.owner = owner;
this.age = age;
this.gender = gender;
}

/*Bark method that takes n as input
* and print the Woof! n times*/
public void Bark(int n)
{
for (int index = 0; index < n; index++)
Console.Write("{0}", "Woof!");

Console.WriteLine();
}
/*Method GetTag that returns the owner name and age as string value*/
public String GetTag()
{
if (gender == Gender.MALE)
return String.Format("If lost, call {0}. His name is {1} and he is {2} year old.", owner, name, age);
else
return String.Format("If lost, call {0}. Her name is {1} and she is {2} year old.", owner, name, age);
}

}
}
