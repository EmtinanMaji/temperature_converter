using System;

class Program
{
    static string TempConvert (double tempAmount,string Unit){
        double convertedTemp;
        string result;

        switch (Unit.ToUpper())
        {
            case "C":
                convertedTemp = (tempAmount * 9 / 5) + 32;
                result = $"Converted: {tempAmount} C = {convertedTemp} F";
                break;
            case "F":
                convertedTemp = (tempAmount - 32) * 5 / 9;
                result = $"Converted: {tempAmount} F = {convertedTemp} C";
                break;
            default:
                result = "Unit is not valid";
                break;
        }

        return result;
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter a temperature and its unit (C or F), or type 'Quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit") {
                Console.WriteLine("Program terminated.");
                break;
            }

            string[] index = input.Split(" ");
            if (index.Length != 2) {
                Console.WriteLine("Invalid input. Please enter a temperature followed by its unit.");
                continue;
            }
            if (!double.TryParse(index[0], out double tempAmount)) {
                Console.WriteLine("Invalid input. Please enter a numeric temperature.");
                continue;
            }
            string tempUnit = index[1].ToUpper();
            if (tempUnit != "C" && tempUnit != "F") {
                Console.WriteLine("Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
                continue;
            }
            Console.WriteLine(TempConvert(tempAmount, tempUnit));
        }  
    }
}
