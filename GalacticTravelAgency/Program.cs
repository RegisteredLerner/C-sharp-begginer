using System;

class Program
{
    static void Main(string[] args)
    {
        string passengerName = "Zara";
        int passengerAge = 28;
        string ticketType = "First Class";
        string prefferedPlanet = "Mars";
        Console.WriteLine(passengerName);
        Console.WriteLine(passengerAge);
        Console.WriteLine(ticketType);
        Console.WriteLine(prefferedPlanet);
        passengerAge += 1;
        Console.WriteLine(passengerAge);
        double passengerAgeDouble = (double)passengerAge;
        Console.WriteLine(passengerAgeDouble);
        double passengerAgeDouble2 = passengerAge;
        Console.WriteLine(passengerAgeDouble2);
        string passengerAgeString = Convert.ToString(passengerAge);


   }
}
