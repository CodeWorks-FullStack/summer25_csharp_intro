// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.Clear();
Console.WriteLine("Hello, World!"); // console.log

// SECTION strings

// explicit typing
string firstName = "Jeremy";

char middleInitial = 'B';

string lastName = "Fowler";

string fullName = firstName + ' ' + middleInitial + ' ' + lastName;

// implicit typing
var catName = "Gopher";

// catName = 75; ❌

Console.WriteLine($"My name is {firstName} {middleInitial} {lastName}.");
Console.WriteLine($"My name is {fullName} and my cat's name is {catName}.");

// !SECTION

// SECTION numbers

int age = 34;
age += 1;
age++;
age = age + 1;

double money = 3.50;

double weirdNumber = money + age;

int max = 2147483647;

max++; // -2,147,483,648

var bigNumber = 3000000000; //uint

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

string? girlfriendsName = null;
string dogsName; // null
int numberOfDogs; // 0
bool tookDogForWalk; // false
char nickName; // ''

// NOTE undefined does not exist in c#

// !SECTION

// SECTION arrays (lists)

// alternate syntax
// string[] dogNames = new string[] { "Hooper", "Fritz", "Dipper", "Pluto", "Jackson" };
// REVIEW arrays are dumb don't use them
// string[] dogNames = ["Hooper", "Fritz", "Dipper", "Pluto", "Jackson"];

List<string> dogNames = ["Hooper", "Fritz", "Dipper", "Pluto", "Jackson"];
dogNames.Add("Rusty"); // push
dogNames.Insert(0, "Rex"); // unshift

for (int i = 0; i < dogNames.Count; i++)
{
  string dogName = dogNames[i];
  // Console.WriteLine($"Bark bark my name is {dogName}!");
}

// !SECTION

// SECTION objects

Cat gopher = new Cat("Gopher", 3, "black", false);

// Console.WriteLine(gopher.Introduce());

List<Cat> cats = [gopher, new Cat("Georgie", 8, "gray", true)];

cats.ForEach(cat => Console.WriteLine(cat.Introduce()));

class Cat
{
  // class members (properties)
  public string Name { get; set; }
  public int Age { get; set; }
  public string Color { get; set; }
  public bool LikesCheese { get; set; }

  // constructor
  public Cat(string name, int age, string color, bool likesCheese)
  {
    Name = name; // this.Name = name;
    Age = age;
    Color = color;
    LikesCheese = likesCheese;
  }

  // class members (methods)
  public string CheesePreference //getter
  {
    get
    {
      return LikesCheese ? "like" : "hate";
    }
  }

  public string Introduce()
  {
    return $"Hello my name is {Name}. I am {Age} years old. I am a {Color} cat and I {CheesePreference} cheese.";
  }
}

// !SECTION


