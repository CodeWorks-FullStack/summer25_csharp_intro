// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.Clear();
Console.WriteLine("Hello, World!"); // console.log

// SECTION strings

// NOTE in order to create a variable, you must specify the type for that variable first
// NOTE strings can only be declared with double quotes ("")
string firstName = "Jeremy";

// NOTE a single character is the `char` data type. They must be declared with sing quotes('')
char middleInitial = 'B';

// explicit typing
string lastName = "Fowler";
// implicit typing
var catName = "Gopher";

// string concatenation works
// if you concat `char` data types together, the result will be a string
string fullName = firstName + ' ' + middleInitial + ' ' + lastName;

// catName = 75; ❌ cannot reassign a variable into a different type

// NOTE in order to use string interpolation, the dollar sign ($) goes at the beginning of the string
Console.WriteLine($"My name is {firstName} {middleInitial} {lastName}.");
Console.WriteLine($"My name is {fullName} and my cat's name is {catName}.");

// !SECTION

// SECTION numbers

int age = 34;
age += 1; // 35
age++; // 36
age = age + 1; //37

double money = 3.50;

double weirdNumber = money + age;

int max = 2147483647;

max++; // -2,147,483,648

var bigNumber = 3000000000; // uint

// !SECTION

// SECTION booleans

bool isHungry = true;

bool ateBreakfast = false;

bool overThirty = age > 29;

if (isHungry)
{
  Console.WriteLine("Go eat a snack");
}

// if ( age > 29)
if (overThirty)
{
  Console.WriteLine("I should probably open a savings account");
}
else
{
  Console.WriteLine("I should probably be doing a kickflip");
}

if (overThirty && !ateBreakfast)
{
  Console.WriteLine("You will be grumpy");
}

// if (7){} NO TRUTHY/FALSY IN C#

// !SECTION

// SECTION weird stuff

string? notHere = null;
string dogsName; // null
int numberOfDogs; // 0
bool tookDogForWalk; // false
char nickName; // ''

// var x; ❌ undefined does not exist in c#

// !SECTION

// SECTION arrays (lists)

// REVIEW arrays are dumb don't use them
// string[] dogNames = new string[] { "Hooper", "Fritz", "Dipper", "Pluto", "Jackson" };

// NOTE Lists are preferred to arrays in C# since they are more flexible. When you create a List variable, you must specify the type for each item in the List
// List<string> dogNames = new List<string> { "Hooper", "Fritz", "Dipper", "Pluto", "Jackson" }; 👎
List<string> dogNames = ["Hooper", "Fritz", "Dipper", "Pluto", "Jackson"]; // 👍

dogNames.Add("Rusty"); // push
dogNames.Insert(0, "Rex"); // unshift

for (int i = 0; i < dogNames.Count; i++)
{
  string dogName = dogNames[i];
  Console.WriteLine($"Bark bark my name is {dogName}!");
}

// !SECTION

// SECTION objects

Cat gopher = new Cat("Gopher", 3, "black", false);

Console.WriteLine(gopher.Introduce());

List<Cat> cats = [gopher, new Cat("Georgie", 8, "gray", true)];

cats.ForEach(cat => Console.WriteLine(cat.Introduce()));
class Cat
{
  // NOTE constructor
  // parameters must be typed in C#. Convention says use lower camelCase for parameters and variables
  public Cat(string name, int age, string color, bool likesCheese)
  {
    Name = name; // this.Name = name;
    Age = age;
    Color = color;
    LikesCheese = likesCheese;
  }

  // class members
  // class members must have an access modifier (public, private, internal, protected)
  // properties
  // NOTE Convention says use upper PascalCase for class members 
  // public denotes that you can access this member without restriction
  // get and set denotes that you can read this member and change this member after instantiation (newing up)
  public string Name { get; set; }
  public int Age { get; set; }
  public string Color { get; set; }
  public bool LikesCheese { get; set; }


  // methods
  // NOTE methods must have a return type and access modifier

  public string Introduce()
  {
    return $"Hello my name is {Name}. I am {Age} years old. I am a {Color} cat and I {CheesePreference} cheese.";
  }

  public string CheesePreference //getter
  {
    get
    {
      return LikesCheese ? "like" : "hate";
    }
  }
}

// !SECTION


