using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //"oled liiga noor, et juhilube saada";
            //kui kasutaja on vanem, kui 18, siis program kuvab konsoolis
            //"oled piisavlt vana, et juhi lube saada";
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne! Nüüd sa saad juhilube taotleda";

            Console.WriteLine("Palun, siseta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            
            int userAge = 2021 - yearOfBirth;

            if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada");
            }
            else if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad juhilube taotleda");
            }
        }
    }
}
