// See https://aka.ms/new-console-template for more information


using ClassObject3;

Person person = new Person();

person.Name = "Anastasija";
person.Age = 15;
person.isFemale = true;

//vizivajem funkciju. Pri vizove funkcii vsegda skobki pustije v konce
person.Greeting();

//2-oj object
Person person2 = new Person();

person2.Name = "Anastasija2";
person2.Age = 52;
person2.isFemale = true;

person2.Greeting();


bool isAnastasijaAdult = person2.isAdult;
bool isAnastasijaAdult2 = person2.GetIsAdult();

Console.WriteLine(isAnastasijaAdult);
Console.WriteLine(isAnastasijaAdult2);


Console.WriteLine();
Console.WriteLine("==========================");
Console.WriteLine();

string name = "Anastasija";
string nameToChange = name;

nameToChange = "22222222";

Console.WriteLine($"Name: {name}");
Console.WriteLine($"Name to change: {nameToChange}");


Person person3 = new Person();
person.Name = "Anastasija";

Person personToChange = person3;
personToChange.Name = "222222";

Console.WriteLine($"Name: {person3}");
Console.WriteLine($"Name to change: {personToChange}");


Console.WriteLine();
Console.WriteLine("==========================");
Console.WriteLine();

//Person person = new Person()
//{
//    Name = "Artis",
//    IsMale = true,
//    Age = 46
//};
//vnizu to zhe samoje toljko po drugomu
Person person = new Person();
person.Name = "Artis";
person.IsMale = true;
person.Age = 46;


person.Car = new Car();
person.Car.Brand = "BMW";

person.Car.BeepBeep();