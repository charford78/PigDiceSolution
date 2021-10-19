using System;

namespace PigDice
{
    class Program
    {
        static void Main(string[] args)
        {
            var pd = new PigDice();
            var score = pd.RunToHighScore(500);
            Console.WriteLine($"New high score is {score}");
            
            //var highScore = 0;
            //for(var idx = 0; idx < 100; idx++)
            //{
            //    var score = pd.PlayPigDice();
            //    if(score > highScore)
            //    {
            //        highScore = score;
            //        Console.WriteLine($"Score is {highScore}");
                //}
            //}
        }
    }
}
