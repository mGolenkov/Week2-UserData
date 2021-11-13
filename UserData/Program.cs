using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib katutaja sünniaastat;
            //programm küsib kasutaja vanust;
            //programm kuvab kastutaja vanust konsoolis;

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            //Console.WriteLine("Oled " + userAge + " aastatvana.");

            //string interpolation

            Console.WriteLine($"Oled {userAge} aastat vana.");






        }
    }
}
