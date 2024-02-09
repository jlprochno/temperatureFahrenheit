namespace temperatureFahrenheit;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, por gentileza, digite quantos graus você deseja converter: ");
        double degrees = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (degrees * 9/5) + 32;

        Console.WriteLine($"{degrees}°C são {fahrenheit}ºF.");
    }
}
