using System;

namespace Lesson07_02
{
    internal class Program
    {
        public struct Bibliotekosknyga 
        {
            public int id;
            public string Title;
            public string ReaderName;
            public DateTime TakenAt;
            //Kontruktorius priskiria visas reiksmes, kad butu objektas su visomis reiksmemis
            //public Bibliotekosknyga()
            //{

            //}
            public int HowLongBookIsTaken() 
            {
                DateTime currentDate = DateTime.Today;
                int bookTakenInDays = (currentDate - TakenAt).Days;
                return bookTakenInDays;
            }
        }
        static void Main(string[] args)
        {
            Bibliotekosknyga bibliotekosknyga = new Bibliotekosknyga();
            bibliotekosknyga.id = 1;
            bibliotekosknyga.Title = "Haris Poteris";
            bibliotekosknyga.TakenAt = new DateTime(2022,09,09);
            int bookTakenInDays = bibliotekosknyga.HowLongBookIsTaken();
            Console.WriteLine($"Knyga su ID {bibliotekosknyga.id} paimta {bookTakenInDays} dienu");
            Console.WriteLine(bibliotekosknyga.Title);
        }
    }
}
