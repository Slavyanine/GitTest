// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Test, Test!");
Console.WriteLine("Test 4");
Console.WriteLine("Test 5");
Console.WriteLine("Test 6");
Console.WriteLine("Test 7");

/// <summary>
/// Calculate the body mass index (BMI) based on weight in kg and height in meter
/// </summary>
/// <param name="weight">
/// The weight in kilogram
/// </param>
/// <param name="height">
/// The height in meter
/// </param>
/// <returns>
/// The body mass index
/// </returns>
double CalculateBMI(double weight, double height)
{
    return weight / (height * height);
}
