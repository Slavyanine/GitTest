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

const calculateResults = (data) => {
    const results = [];
    for (let i = 0; i < data.length; i++) {
        let sum = data[i].value;
        for (let j = i + 1; j < data.length; j++) {
            if (data[i].id === data[j].id) {
                sum += data[j].value;
            }
        }
        // Проверяем, не добавили ли уже этот id в результаты
        if (!results.some(entry => entry[0] === data[i].id)) {
            results.push([data[i].id, sum]);
        }
    }
    return results;
};
