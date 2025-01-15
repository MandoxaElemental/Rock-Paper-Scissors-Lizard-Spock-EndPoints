using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock.Services
{
    public class GameplayServices
    {
        public List<string> resultList = new();
        public Random rng = new Random();
        public string[] cpu = {"Kleavor", "Scyther", "Scizor", "Scrafty", "Mewtwo"};

        // 0 = 
        public List<string> ComputerMove()
        {
            int ourRandomNumber = rng.Next(cpu.Length);
            resultList.Add(cpu[ourRandomNumber]);
            return resultList;

        }
    }
}