using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace textDosyasiOkumaOlusturma
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\serif\metinler\deneme.txt";
            //List<string> lines = File.ReadAllLines(filePath).ToList();
            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //lines.Add("ben,seni,sen,sana");
            //File.WriteAllLines(filePath, lines);
            //--------------------------------------------------------

            List<Kisiler> kisi = new List<Kisiler>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] girisler = line.Split(',');
                Kisiler yenikisi = new Kisiler();

                yenikisi.ad = girisler[0];
                yenikisi.soyad = girisler[1];

                kisi.Add(yenikisi);
            }

            foreach (var kisi2 in kisi)
            {
                Console.WriteLine($"{kisi2.soyad}{kisi2.ad}");
            }
            
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        public class Kisiler
        {
            public string ad { get; set; }
            public string soyad { get; set; }
        }
    }
}
