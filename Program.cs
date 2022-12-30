using System;

namespace kelimenin_uzunluğu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dört kelimeyi bildirin
            string Kalima1, Kalima2, Kalima3, Kalima4;

            // Kullanıcıdan dört kelimeyi girmesini isteyin
            Console.WriteLine("Enter four words: ");
            Kalima1 = Console.ReadLine();
            Kalima2 = Console.ReadLine();
            Kalima3 = Console.ReadLine();
            Kalima4 = Console.ReadLine();

            // En büyük uzunluğa sahip kelimeyi bulun
            string largestWord = FindLargestWord(Kalima1, Kalima2, Kalima3, Kalima4);

            // En büyük uzunluğa sahip kelimeyi göster
            Console.WriteLine("The word with the largest length is: " + largestWord);
            Console.ReadLine();
        }

        static string FindLargestWord(string Kalima1, string Kalima2, string Kalima3, string Kalima4)
        {
            // Initialize the largest word to be the first word
            string largestWord = Kalima1;

            // Diğer kelimelerin uzunluklarını en büyük kelime ile karşılaştırın
            if (Kalima2.Length > largestWord.Length)
            {
                largestWord = Kalima2;
            }
            if (Kalima3.Length > largestWord.Length)
            {
                largestWord = Kalima3;
            }
            if (Kalima4.Length > largestWord.Length)
            {
                largestWord = Kalima4;
            }

            // En büyük kelimeyi döndür
            return largestWord;
        }
    }
}

