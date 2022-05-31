// See https://aka.ms/new-console-template for more information
using EnumsAndInterfaces;

DifficultyLevel playerDifficulty = DifficultyLevel.Medium;

string difficultytext = playerDifficulty.ToString();
Console.WriteLine($"Player difficulty: {difficultytext}");

int difficultyValue = (int)playerDifficulty;
Console.WriteLine($"Player difficulty value: {difficultyValue}");

Console.WriteLine();
Console.WriteLine("======================");
Console.WriteLine();








ConsoleLogger consoleLogger = new ConsoleLogger();
FileLogger fileLogger = new FileLogger();

CheckCanLog(consoleLogger);
CheckCanLog(fileLogger);

List<ILogger> loggers = new List<ILogger>();
loggers.Add(consoleLogger);
loggers.Add(fileLogger);

CheckAllLoggers(loggers);


void CheckCanLog(ILogger logger)
{
    logger.Log("Application has started");
}

void CheckAllLoggers(List<ILogger> loggers)
{
    foreach (var logger in loggers)
    {
        logger.Log("Application has started");
    }
}
