using System;
using System.IO;

namespace HelloWorldDemo
{
    class Program
    {
        //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE 
        static readonly string textFile = @"C:\Users\a702852\OneDrive - Atos\Documents\GitHub\HelloWorld\Test.txt";  
        
        static void Main(string[] args)
        {
            if (File.Exists(textFile))
            {  
                // Read entire text file content in one string  
                string text = File.ReadAllText(textFile);  
                Console.WriteLine(text);  
            }  
        
            if (File.Exists(textFile))
            {
                // Read a text file line by line.
                string[] lines = File.ReadAllLines(textFile);
                foreach (string line in lines)
                Console.WriteLine(line);
            }
        
            if (File.Exists(textFile))
            {
                // Read file using StreamReader. Reads file line by line
                using (StreamReader file = new StreamReader(textFile))
                {
                    int counter = 0;
                    string ln;
                    
                    while ((ln = file.ReadLine()) != null)
                    {
                        Console.WriteLine(ln);
                        counter++;
                    }
                    file.Close();
                    Console.WriteLine($"File has {counter} lines.");
                }
            }   
        }
    }
}
