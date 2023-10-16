using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_inator
{
    public class DescriptionPage
    {
        public void Description()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Welcome to TERM-INATOR C# Edition. This was " +
                "my first side project while attending a coding bootcamp. " +
                "I created it to help my classmates and I learn the basics." +
                "  If this is new to you... be patient with yourself. " +
                "Learning to code is a lot like learning a new language. " +
                "If you enjoyed this and want to learn how to make a project " +
                "like this one then, ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Truecoders.io");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" is where you'll find all the cool cats.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("This study tool is mostly multiple choice.  " +
                "Periodically you will be given the option to go over what " +
                "you just learned or continue with new materials.  There are " +
                "consequences for a wrong answer.  You lose health when you " +
                "choose the incorrect answer and gain health when you get it " +
                "right.  If you run out of health you will be given the " +
                "option to continue or start over.  \n Press any key to " +
                "continue");
                
                /*("This study tool has 3 levels. 1. EZ PZ Lemon" +
                " Squeezy. 2. Stuck in the middle like the fluff in a " +
                "fluffernutter.  3. Hard Rock Hotshot!  Periodically you " +
                "will be given the option to go over what you just learned" +
                " or continue with new materials.  There are consequences for " +
                "a wrong answer.  You lose health when you get it wrong and " +
                "gain health when you get it right.  Please pick your " +
                "difficulty level now by entering 1, 2, or 3."); */
            Console.ResetColor();
        }
    }
}
