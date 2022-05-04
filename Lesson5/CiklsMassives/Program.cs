int[] nums = new int[3];

Console.WriteLine($"{nums[0]} {nums[1]} {nums[2]}");

nums[0] = 15;
nums[1] = 5;
nums[2] = 8;

Console.WriteLine($"{nums[0]} {nums[1]} {nums[2]}");

string[] fruits = { "Apple", "Orange" };

Console.WriteLine($"{fruits[0]} {fruits[1]}");


Console.WriteLine();
Console.WriteLine("===================================================");
Console.WriteLine();

for (int i = 0; i < nums.Length; i++)
{
    int num = nums[i];
    Console.WriteLine($"i = {i} num = {num}");
}

Console.WriteLine();
Console.WriteLine("===================================================");
Console.WriteLine();

foreach (int num in nums)
{
    Console.WriteLine($"number is = {num}");
}

Console.WriteLine();
Console.WriteLine("===================================================");
Console.WriteLine();


int whileIterator = 0;
while (whileIterator < nums.Length)
{
    int num = nums[whileIterator];
    Console.WriteLine($"whileIterator = {whileIterator} num = {num}");
    whileIterator++;
}

Console.WriteLine();
Console.WriteLine("===================================================");
Console.WriteLine();

int userNumber;
bool isNumberEntered = false;

do
{
    Console.WriteLine("Lūdzu ievadi veselu skaitli?");
    string userNumberText = Console.ReadLine();
    isNumberEntered = int.TryParse(userNumberText, out userNumber);

} while (!isNumberEntered);

Console.WriteLine($"You entered {userNumber}");

