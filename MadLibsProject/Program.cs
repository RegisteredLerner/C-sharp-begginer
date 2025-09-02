using System;
using System.Formats.Asn1;
/*
Program about string and is called
MadLibs
*/
namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program MadLibs
      Author: RegisteredLerner
      */


      // Let the user know that the program is starting:
      Console.WriteLine("MadLibs Project is Running...");

      // Give the Mad Lib a title:
      string title = "Story about my uncle";

      Console.WriteLine(title);
    // Define user input and variables:
    Console.Write("Enter a name:");
    string name=Console.ReadLine();
    Console.WriteLine("write three adjectives");
    string adjective1=Console.ReadLine();
    string adjective2=Console.ReadLine();
    string adjective3=Console.ReadLine();
    Console.WriteLine("Enter one verb representing action");
    string verb=Console.ReadLine();
    Console.WriteLine("We need two nouns");
    string noun=Console.ReadLine();
    string noun1=Console.ReadLine();
    Console.WriteLine("Enter an animal");
    string animal=Console.ReadLine();
    Console.WriteLine("Enter a food");
    string food=Console.ReadLine(); 
    Console.WriteLine("Enter a fruit");
    string fruit=Console.ReadLine();
    Console.WriteLine("Enter a superhero");
    string superhero=Console.ReadLine();
    Console.WriteLine("Enter a country");
    string country=Console.ReadLine();
    Console.WriteLine("Enter a dessert");
    string dessert=Console.ReadLine();
    Console.WriteLine("Enter a year");
    string year=Console.ReadLine();





      // The template for the story:

            string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun}s ruled the world.";
    

      // Print the story:
        Console.WriteLine(story);
    }
  }
}