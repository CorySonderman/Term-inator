using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using NAudio.Wave;


namespace Term_inator
{
    public class IntroPage
    {

        public void Intro()
        {
            //***Can't figure out how to add audio file.  ***Table this for later.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@" ___________  _______   _______   ___      ___     -      __    _____  ___        __  ___________  ______     _______   
(""     _   "")/""     ""| /""      \ |""  \    /""  |          |"" \  (\""   \|""  \      /""""\(""     _   "")/    "" \   /""      \  
 )__/  \\__/(: ______)|:        | \   \  //   |          ||  | |.\\   \    |    /    \)__/  \\__/// ____  \ |:        | ");
            Thread.Sleep(750);
            Console.ForegroundColor= ConsoleColor.DarkBlue;
            Console.WriteLine(@"    \\_ /    \/    |  |_____/   ) /\\  \/.    |          |:  | |: \.   \\  |   /' /\  \  \\_ /  /  /    ) :)|_____/   ) 
    |.  |    // ___)_  //      / |: \.        |          |.  | |.  \    \. |  //  __'  \ |.  | (: (____/ //  //      /  
    \:  |   (:      ""||:  __   \ |.  \    /:  |          /\  |\|    \    \ | /   /  \\  \\:  |  \        /  |:  __   \  ");
            Thread.Sleep(750);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"     \__|    \_______)|__|  \___)|___|\__/|___|         (__\_|_)\___|\____\)(___/    \___)\__|   \""_____/   |__|  \___) 
                                                                                                                        ");

            Console.WriteLine();
            Console.WriteLine();
            string textToCenter = "C# Edition.  Press Any Key To Continue";
            int screenWidth = Console.WindowWidth;
            int leftMargin = (screenWidth - textToCenter.Length) / 2;
            Console.SetCursorPosition(leftMargin, Console.CursorTop);
            Console.WriteLine(textToCenter);

            

            Console.ResetColor();
            //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //string waveFilePath = Path.Combine(baseDirectory, "583733__warped_tension__suspense_thriller_full WAV");
            
        }

    }

}
