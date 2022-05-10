using ListsDictionaries;

List<string> guesableNames = new List<string>();

guesableNames.Add("māja");
guesableNames.Add("Sss");
guesableNames.Add("aaaaa");

foreach (string gueableName in guesableNames)
{
    Console.WriteLine($"Name {gueableName}");
}

int elementsCount2 = guesableNames.Count;
Console.WriteLine($"Count {elementsCount2}");

Console.WriteLine("=============");
guesableNames.Remove("aaaaa");
Console.WriteLine("=============");

foreach (string gueableName in guesableNames)
{
    Console.WriteLine($"Name 2 {gueableName}");
}


string firstElement = guesableNames[0];
Console.WriteLine($"First name {firstElement}");

int elementsCount = guesableNames.Count;
Console.WriteLine($"Count {elementsCount}");


//List s drigim tipom 

List<int> nums = new List<int>();

nums.Add(15);
nums.Add(25);
nums.Add(48);

foreach (int num in nums)
{
    Console.WriteLine($"num: {num}");
}

List<Person> persons = new List<Person>();

Person artis = new Person
{
    Name = "Artis",
    Surname = "Vilciņš"
};

persons.Add(artis);
persons.Add(artis);
persons.Add(artis);

foreach (Person person in persons)
{
    Console.WriteLine($"Hello {person.Name} {person.Surname}");
}


Console.WriteLine("=============");
Console.WriteLine("=============");
Console.WriteLine("=============");

///Dictionary
///

Dictionary<string, Person> personsDictionary = new Dictionary<string, Person>();


Person otherPerson = new Person
{
    Name = "Jānis",
    Surname = "Stabule"
};

personsDictionary.Add("a", artis);
personsDictionary.Add("b", artis);
personsDictionary.Add("c", artis);

foreach (KeyValuePair<string, Person> item in personsDictionary)
{
    string key = item.Key;
    Person person = item.Value;

    Console.WriteLine($"Key: {key} person ame {person.Name} {person.Surname}");
}

var artis2 = personsDictionary["a"];
Console.WriteLine($"Retrieved Artis {artis2.Name} {artis2.Surname}");

bool hasKey = personsDictionary.ContainsKey("a");
Console.WriteLine($"Has key {hasKey}");


Console.WriteLine("=============");
Console.WriteLine("=============");
Console.WriteLine("=============");

foreach (string key in personsDictionary.Keys) //tak mozhno posmotretj Key zna4enije
{
    Console.WriteLine($"Key from dic {key}");
}