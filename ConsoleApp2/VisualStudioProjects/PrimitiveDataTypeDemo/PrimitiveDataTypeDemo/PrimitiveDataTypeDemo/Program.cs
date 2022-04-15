// See https://aka.ms/new-console-template for more information


string myGreeting = "Hello, my name is Anastasija with variable";
int age = 40;
double money = 1450.36;
char favoriteSymbol = '@';
bool isFemale = true;

Console.WriteLine(myGreeting);
Console.WriteLine(age);
Console.WriteLine(money);
Console.WriteLine(favoriteSymbol);
Console.WriteLine(isFemale);

Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();

int a = 5;
double b = 2;

double sum =  a + b;
double difference = a - b;
double multiplication = a * b;
double divided = a / b;

Console.WriteLine(sum);
Console.WriteLine(difference);
Console.WriteLine(multiplication);
Console.WriteLine(divided);


Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();

int c = 5;
int d = 2;

int sum2 = c + d;
int difference2 = c - d;
int multiplication2 = c * d;
double divided2 =c / (double)d;
int divisionLeft = c % d;

Console.WriteLine(sum2);
Console.WriteLine(difference2);
Console.WriteLine(multiplication2);
Console.WriteLine(divided2);
Console.WriteLine(divisionLeft);

c++;
d--;

Console.WriteLine(c);
Console.WriteLine(d);

//salidzinasana
Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();

int num1 = 10;
int num2 = 15;

bool isEqual = num1 == num2;    
bool isNotEqual = num1 != num2;
bool isLarger = num1 > num2;
bool isSmaller = num1 < num2;
bool isLargerEqual = num1 >= num2;
bool isSmallerEqual = num1 <= num2;

Console.WriteLine(isEqual);
Console.WriteLine(isNotEqual);
Console.WriteLine(isLarger);
Console.WriteLine(isSmaller);
Console.WriteLine(isLargerEqual);
Console.WriteLine(isSmallerEqual);

//logiskie operatori
Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();

bool isTrue = true;
bool isFalse = false;

bool andAction = isTrue && isFalse; //ir True jesli obe true
bool orAction = isTrue || isFalse;
bool convertedTrue = !isTrue; //pokazivajet obratnoje ot ukazannogo v peremenno

Console.WriteLine(andAction);
Console.WriteLine(orAction);
Console.WriteLine(convertedTrue);


//pieskirsanas operatori
Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();

int x = 4;
int y = 8;

x += 2; // x = x + 2
Console.WriteLine(x);

x -= 3; // x = x - 3
Console.WriteLine(x);


//Console.WriteLine();
//Console.WriteLine("==================================");
//Console.WriteLine();


//// 1. Poprositj vvesti imja.
//Console.WriteLine("Lūdzu ievadi savu vārdu.");
////Console.Write("Lūdzu ievadi savu vārdu:"); - tak budet vvod imeni na toj zhe stroke

//// 2. Dozhdatsja vvoda imeni.
//string userName = Console.ReadLine();


//// 3. Pozdorovatsja s poljzovatelem: "Sveiks, ..."
//Console.WriteLine("Sveiks, " + userName + "!");

//Console.WriteLine("Lūdzu ievadi skaitli");
//string userNumberString = Console.ReadLine();
//int userNumber = int.Parse(userNumberString); //int.Parse - peredelivajet iz string formata v 4islovoj

//int byThenLarger = userNumber + 10;
//Console.WriteLine("Tavs skaitlis palielinats par 10: " + byThenLarger); //kogda zojedinjaje6 +-som, to 4islovoj format perehodit v tekst

Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();

int positiveNumber = 15;
int negativeNumber = -15;

int positiveAbs = Math.Abs(positiveNumber);
int negativeAbs = Math.Abs(negativeNumber); 


Console.WriteLine(positiveAbs);
Console.WriteLine("Default negative: " + negativeAbs);
Console.WriteLine(negativeAbs);

Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();

int maxNumberHigh = 40;
int maxNumberLow = 39;

int largerNumber = Math.Max(maxNumberHigh, maxNumberLow);
Console.WriteLine("Larger number is " + largerNumber);

Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();

int minNumberHigh = 40;
int minNumberLow = 39;

int smallerNumber = Math.Min(minNumberHigh, minNumberLow);
Console.WriteLine("Smaller number is " + smallerNumber);

Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();

double roundNumber = 145.56789;
double rounded = Math.Round(roundNumber, 2); //2 - eto koli4estvo cifr posle zapjatoj

Console.WriteLine("Rounded number is " + rounded);

//interpolacija
Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine();

string name = "Anastasija";
int age2 = 50;

string formattedMessage = $"Hello {name} it is very nice to see You at Your age {age2}! "; //$ - s etim simvolom mozhno dobavitj peremennuju v test
string formattedMessage2 = "Hello " + name + " it is very nice to see You at Your age " + age2 + "!"; 

Console.WriteLine(formattedMessage);
Console.WriteLine(formattedMessage2);
