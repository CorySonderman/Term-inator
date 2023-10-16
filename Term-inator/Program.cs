using System;
using System.Diagnostics;
using System.Threading;
using System.Media;
using NAudio.Wave;


namespace Term_inator
{
    public class Program
    {
        static void Main(string[] args)
        {
            IntroPage introPage = new();
            introPage.Intro();
            Console.ReadKey();
            Console.Clear();

            DescriptionPage descriptionPage = new();
            descriptionPage.Description();

            //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //string waveFilePath = Path.Combine(baseDirectory, "583733__warped_tension__suspense_thriller_full WAV.wav");
            //Console.ReadLine();

        }

        //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        //string waveFilePath = Path.Combine(baseDirectory, "624600__victor_natas__detective-hawkeye (1).mp3");
        //    PlayMusic("624600__victor_natas__detective-hawkeye (1).mp3");
        //    Console.WriteLine("Playing music");
        //    Console.ReadLine();

        //}

        //public static void PlayMusic(string filepath)
        //{
        //    SoundPlayer musicPlayer = new SoundPlayer();
        //    musicPlayer.SoundLocation = filepath;
        //    musicPlayer.Play();
        //}
    }
}