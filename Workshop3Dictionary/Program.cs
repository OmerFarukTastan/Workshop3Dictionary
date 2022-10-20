using System;
using System.Collections.Generic;
namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> kelimeler = new Dictionary<string, string>();
            //Ekleme
            kelimeler.Add("silgi", "erazer");
            kelimeler.Add("kitap", "book");
            kelimeler.Add("orange", "portakal");
            kelimeler.Add("türkçe", "turkish");
            kelimeler.Add("bilgisayar", "computer");
            kelimeler.Last();
            //Foreach ile Gezme
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }
        }
    }
}