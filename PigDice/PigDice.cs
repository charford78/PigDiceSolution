using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice
{
    public class PigDice
    {
        private Random rnd = new Random();
        
        public int RunToHighScore(int highScore)
        {
            var score = PlayPigDice();
            var currHighScore = 0;
            while(score < highScore)
            {
                score = PlayPigDice();
                if(score > currHighScore)
                {
                    currHighScore = score;
                    Console.WriteLine($"Your current highscore is {score}");
                }
            }
            return score;
         }
        
        public int PlayPigDice()
        {
            var Total = 0;
            var roll = RollDice();
            while(roll != 1)
            {
                Total += roll;
                roll = RollDice();
            }
            return Total; 
        }

        private int RollDice()
        {
            return rnd.Next(1, 7);
        }
    }
}
