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
