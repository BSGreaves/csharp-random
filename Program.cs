using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> randomNumbers = new List<int>();
            Random random = new Random();
            for (int count = 0; count < 10; count++) {
                 randomNumbers.Add(random.Next(1, 51));
            }
            List <int> rndNumSquared = new List<int>();
            foreach (int number in randomNumbers) {
                rndNumSquared.Add(number*number);
            }
            List <int> rndNumsFiltered = new List<int>();
            foreach (int number in rndNumSquared) {
                if(number % 2 == 0)
                {
                    rndNumsFiltered.Add(number);
                }
            }
            foreach (int number in rndNumsFiltered) {
                Console.WriteLine(number);
            }
        }
    }
}
