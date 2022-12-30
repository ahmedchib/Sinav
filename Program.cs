using System;

namespace Family_Averge_Age01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan adını ve soyadını girmesini isteyin
            Console.WriteLine("Lütfen Adınız Girin: ");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen Adınız Girin: ");
            string surname = Console.ReadLine();

            // Print adı ve soyadı
            Console.WriteLine($"Merhaba, {name} {surname}!");

            // Kullanıcıdan odadaki kişi sayısını girmesini isteyin
            Console.WriteLine("odanızda kaç kişi var?");
            int numPeople = Convert.ToInt16(Console.ReadLine());

            // Dizi kurdum
            int[] ages = new int[numPeople];

            // Kullanıcıdan odadaki kişilerin yaşlarını girmesini isteyin
            Console.WriteLine("Lütfen odadaki kişilerin yaşlarını, bir boşlukla ayırarak girin:");
            string[] ageStrings = Console.ReadLine().Split(' ');
            for (int i = 0; i < numPeople; i++)
            {
                ages[i] = Convert.ToInt16(ageStrings[i]);
            }

            // Odadaki kişilerin yaş ortalamasını hesaplayın
            int totalAge = 0, numAdults = 0;
            
            foreach (int age in ages)
            {
                totalAge += age;
                if (age >= 18)
                {
                    numAdults++;
                }
            }
            double ageAverage = (double)totalAge / numPeople;

            // Yaş ortalamasını ve odadaki yetişkin sayısına göre bir mesaj yazdırın
            Console.WriteLine($"The age average of the people in the room is {ageAverage} years.");
            if (numAdults > 4)
            {
                Console.WriteLine("Bu büyük bir aile!");
            }
            else
            {
                Console.WriteLine("Bu küçük bir aile.");
            }

            // Yaşı 18'den büyük olan kişilerin sayısını yazdır
            Console.WriteLine("Yaşı 18'den büyük olan " + numAdults+ " kişi.");
            Console.ReadKey();
        }
    }
}

