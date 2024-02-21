using System;
namespace StaticExercise
{
	public static class TempConverter
	{
        
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            // Fahrenheit formula: (F - 32) * 5/9
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            // Celsius formula: (C * 9/5) + 32
            return (celsius * 9 / 5) + 32;
        }

    }
}

