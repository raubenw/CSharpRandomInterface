using System;
using System.Collections.Generic;

namespace CSharpRandomInterface {

    interface IRandomize {
        double GetRandomNumber(int uBound);
    }

    class RandomizedNumbers : IRandomize {

        public double GetRandomNumber(int uBound) {
            
            Random number = new Random();
            return number.NextDouble() * uBound;

        }
    }

    class Program {

        static void Main(string[] args)  {

            string str;
            int upperbound = 0;

            do {
                Console.WriteLine("Provide the upperbound number: ");
                str = Console.ReadLine();
                if(!str.Equals("exit")) {
                    try {
                        upperbound = int.Parse(str);
                        RandomizedNumbers randomized = new RandomizedNumbers();
                        Console.WriteLine($"A random number between 0 and {upperbound} = {randomized.GetRandomNumber(upperbound)}");
                    } catch(FormatException e) {
                        continue;
                    } 
                    
                        
                }

            } while(!str.Equals("exit"));
        }// End static Main

        
    }
}