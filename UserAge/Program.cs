using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaasta;
            //programm kuvab sünniaastat konsoolis;
            //"oled sündinud aastal {yearOfBirth}

            Console.WriteLine("Palun, sisesta oma vanus:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

            Console.WriteLine("Oled sündinud " + userage + " aastal.");

          


        }
    }
}
