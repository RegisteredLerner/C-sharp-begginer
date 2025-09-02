using System;
using System.Runtime.CompilerServices;
public class Tools
{

    public static bool Contains(string target, string list)
    {
        return target.IndexOfAny(list.ToCharArray()) != -1;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        int minLength = 8;
        string uppercase = "ABCDEFGHIJKLMNOPRSTUWXYZ";
        string lowercase = uppercase.ToLower();
        string digits = "0123456789";
        string specialChars = "!@#$%^&*()_=+-[{}]:;'><.,/?|";
        Console.WriteLine("Enter Password");
        string password = Console.ReadLine();
        int score = 0;
        if (password.Length >= minLength) { score += 1; }
        if (Tools.Contains(password, uppercase)) { score += 1; }
        if (Tools.Contains(password, lowercase)) { score += 1; }
        if (Tools.Contains(password, digits)) { score += 1; }
        if (Tools.Contains(password, specialChars)) { score += 1; }
        Console.WriteLine(score);
        switch (score)
        {
            case >= 4:
                Console.WriteLine("Extremely Strong");
                break;
            case 3:
                Console.WriteLine("Strong");
                break;
            case 2:
                Console.WriteLine("Medium");
                break;
            case 1:
                Console.WriteLine("Weak");
                break;
            default:
                Console.WriteLine("Doesn't meet any standards");
                break;
        }
   }
}