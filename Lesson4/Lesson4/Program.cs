
Console.WriteLine("Start");
Console.WriteLine();

//string userAgeText = Console.ReadLine();
//int age = int.Parse(userAgeText);

//if (age >= 18)
//{
//    Console.WriteLine("You are a teenager.");
//}
//else if (age >= 13)
//{
//    Console.WriteLine("You are an adult.");
//}
//else
//{
//    Console.WriteLine("You are a kid.")
//}


Console.WriteLine("Enter your name.");
string name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
    
    Console.WriteLine("You did not enter your name");
    Console.WriteLine("Try again.");

    name = Console.ReadLine();

    if (string.IsNullOrWhiteSpace (name))
    {
        Console.WriteLine("No more tries");
    }
    else
    {
        Console.WriteLine($"Your name is {name}.");
    }
}
else
{
    Console.WriteLine($"Your name is {name}.");
}


//int age2 = 3;
//switch (age2)
//{
//    case 1:
//        Console.WriteLine("Case 1");
//        break;
//    case 2:
//        Console.WriteLine("Case 2");
//        break;
//    case 3:
//        Console.WriteLine("Case 3");
//        break;
//    case -1:
//        Console.WriteLine("Negative age");
//        break ;
//    case 0:
//        Console.WriteLine("Baby");
//        break;
//    default:
//        Console.WriteLine("Didn't get.");
//        break;
//}


//string name2 = "Aa";
//switch (name2)
//{
//    case "Aa": //jesli "Aa" ILI "Bb"
//    case "Bb":
//        Console.WriteLine("Case 1");
//        Console.WriteLine("Case 2");
//        break;
//    case "Cc":
//        Console.WriteLine("Case 3");
//        break;
//    case "Dd":
//        Console.WriteLine("Negative age");
//        break;
//    case "EE":
//        Console.WriteLine("Baby");
//        break;
//    default:
//        Console.WriteLine("Didn't get.");
//        break;
//}


Console.WriteLine();
Console.WriteLine("End");


