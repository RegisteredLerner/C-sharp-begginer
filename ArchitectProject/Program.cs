using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pick Monument\nPick 1: Teotihuacan\nPick 2: TajMahal\nPick 3: Great Mosque of Mecca");
        string intup = Console.ReadLine();
        switch (intup)
        {
            case "1":
                Console.WriteLine($"The plan for that monument cost {CalculateTotalCost(intup)} pesos!");
                break;
            case "2":
                Console.WriteLine($"The plan for that monument cost {CalculateTotalCost(intup)} pesos!");
                break;
            case "3":
                Console.WriteLine($"The plan for that monument cost {CalculateTotalCost(intup)} pesos!");
                break;
            default:
                Console.WriteLine($"The plan for that monument cost nothing pesos!");
                break;
        }
        
    }
    static double Rectangle(double length, double width)
    {
        double area = length * width;
        return area;
    }
    static double Radius(double rad)
    {
        double area = Math.PI * (Math.Pow(rad, 2));
        return area;
    }
    static double Triangle(double bottom, double height)
    {
        double area = 0.5 * bottom * height;
        return area;
    }
    static double Pesos(double pesos) {
        double sum =pesos* 180;
        double sum1 = Math.Round(sum, 2);
        return sum1;
    }
    static double CalculateTotalCost(string put)
    {
        /*
        Code for Teotihuacan
        */
        double rect = Rectangle(2500, 1500);
        double circ = Radius(375);
        double correctcirc = circ / 2;
        double triang = Triangle(750, 500);
        double sum = rect + correctcirc + triang;
        double pesos = Pesos(sum);
        /*
        Code for TajMahal
        */
        double rect1 = Rectangle(90.5, 90.5);
        double triang1 = Triangle(24, 24);
        double sum1 = rect1 - (4 * triang1);
        double pesos1 = Pesos(sum1);
        /*
        Code for Great Mosque of Mecca
        */
        double rect2 = Rectangle(180, 106);
        double rect3 = Rectangle(284, 264);
        double triang3 = Triangle(84, 264);
        double sum2 = rect2 + rect3 - triang3;
        double pesos3 = Pesos(sum2);
        switch (put)
        {
            case "1":
                return pesos;
                break;
            case "2":
                return pesos1;
                break;
            case "3":
                return pesos3;
                break;
            default:
                return 0;

        }
        return 0;


    }
    
}