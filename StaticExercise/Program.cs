namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double fahrenheitValue = 98.6;
            double celsiusValue = 37;

            // Convert Fahrenheit to Celsius
            double celsiusResult = TempConverter.FahrenheitToCelsius(fahrenheitValue);
            Console.WriteLine($"{fahrenheitValue} Fahrenheit is {celsiusResult:F2} Celsius");

            // Convert Celsius to Fahrenheit
            double fahrenheitResult = TempConverter.CelsiusToFahrenheit(celsiusValue);
            Console.WriteLine($"{celsiusValue} Celsius is {fahrenheitResult:F2} Fahrenheit");
        }
    
    }
}
