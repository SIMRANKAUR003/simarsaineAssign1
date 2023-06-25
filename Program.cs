
//Group 6
//Simran Kaur (200537975) and Parampreet Singh (200535733)
//This code is used to find blood pressure and bmi of patient


using System;

namespace C_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------****------     Made by simran and Parampreet     ------****------");

            Console.Write("Please provide your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the following patient information:");
            Console.Write("Please write your First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please write your Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Weight in (KG): ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Height in (CM): ");
            double height = double.Parse(Console.ReadLine());

            Patient patient = new Patient(firstName, lastName, weight, height);
            patient.OutputPatientInformation();

            Console.ReadLine();
        }
    }
}
