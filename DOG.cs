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
