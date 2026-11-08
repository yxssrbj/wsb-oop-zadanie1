using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.InvariantCulture; // accept "3.5" regardless of system locale

while (true)
{
    Console.WriteLine("\n1 - Calculator\n2 - Temperature converter\n3 - Grade average\n0 - Exit");
    Console.Write("Choose: ");
    string? choice = Console.ReadLine()?.Trim();
    if (choice == null || choice == "0") break;
    try
    {
        switch (choice)
        {
            case "1": Calculator(); break;
            case "2": TemperatureConverter(); break;
            case "3": GradeAverage(); break;
            default: Console.WriteLine("Unknown option."); break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid number.");
    }
}

static string Ask(string prompt)
{
    Console.Write(prompt);
    return Console.ReadLine()?.Trim() ?? "";
}

static void Calculator()
{
    double a = double.Parse(Ask("First number: "));
    double b = double.Parse(Ask("Second number: "));
    string op = Ask("Operation (+, -, *, /): ");
    double result;
    if (op == "+") result = a + b;
    else if (op == "-") result = a - b;
    else if (op == "*") result = a * b;
    else if (op == "/")
    {
        if (b == 0) { Console.WriteLine("Error: division by zero."); return; }
        result = a / b;
    }
    else { Console.WriteLine("Unknown operation."); return; }
    Console.WriteLine($"Result: {result}");
}

static void TemperatureConverter()
{
    string direction = Ask("Convert from (C = Celsius -> Fahrenheit, F = Fahrenheit -> Celsius): ").ToUpper();
    double value = double.Parse(Ask("Temperature: "));
    if (direction == "C") Console.WriteLine($"{value}°C = {value * 1.8 + 32}°F");
    else if (direction == "F") Console.WriteLine($"{value}°F = {(value - 32) / 1.8}°C");
    else Console.WriteLine("Unknown direction, choose C or F.");
}

static void GradeAverage()
{
    int count = int.Parse(Ask("How many grades? "));
    if (count <= 0) { Console.WriteLine("Number of grades must be positive."); return; }
    int total = 0;
    for (int i = 1; i <= count; i++)
    {
        int grade = int.Parse(Ask($"Grade {i} (1-6): "));
        while (grade < 1 || grade > 6) grade = int.Parse(Ask("Grade must be 1-6, try again: "));
        total += grade;
    }
    double average = (double)total / count;
    Console.WriteLine($"Average: {average:F2}");
    Console.WriteLine(average >= 3.0 ? "Student passed." : "Student failed.");
}
