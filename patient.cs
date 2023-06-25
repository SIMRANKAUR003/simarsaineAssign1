//Group 6
//Simran Kaur (200537975) and Parampreet Singh (200535733)
//This code is used to find blood pressure and bmi of patient


using System;

namespace C_Assignment1
{
    public class Patient
    {
        public string FirstName { get; set; }//The code snippet declares a public string property named "FirstName" with a get and set accessor.

        public string LastName { get; set; }//The code snippet declares a public string property named "LastName" with a get and set accessor.
        public double Weight { get; set; } // in KG
        public double Height { get; set; } // in Centimeters

        public Patient(string firstName, string lastName, double weight, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            Weight = weight;
            Height = height;
        }

        public double CalculateBMI()//calculating bmi of a person according to the given info
        {
            double heightInMeters = Height / 100; // Converting height from centimeters to meters
            return Weight / (heightInMeters * heightInMeters);
        }

        public string CalculateBloodPressure(int systolic, int diastolic)
        {

            if (systolic < 0 || diastolic < 0)
            {
                return "Invalid blood pressure values";
            }

            if (systolic < 120 && diastolic < 80)
            {
                return "NORMAL";
            }
            else if (systolic < 130 && diastolic < 80)
            {
                return "ELEVATED";
            }
            else if (systolic < 140 || diastolic < 90)
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
            }
            else if (systolic < 180 || diastolic < 120)
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
            }
            else if (systolic >= 180 || diastolic >= 120)
            {
                return "HYPERTENSIVE CRISIS (consult your doctor immediately)";
            }
            else
            {
                return "Blood pressure values not in range";
            }
        }

        public void OutputPatientInformation()
        {
            double bmi = CalculateBMI();
            string bmiStatus = "";

            if (bmi >= 25.0)
            {
                bmiStatus = "Overweight";
            }
            else if (bmi >= 18.5 && bmi < 25.0)
            {
                bmiStatus = "Normal (In the healthy range)";
            }
            else
            {
                bmiStatus = "Underweight";
            }

            Console.WriteLine("Please provide the patient information:");
            Console.WriteLine("Your Full Name: {0} {1}", FirstName, LastName);
            Console.WriteLine("Your Weight: {0} KG", Weight);
            Console.WriteLine("Your Height: {0} CM", Height);
            Console.WriteLine("Your Blood Pressure: {0}", CalculateBloodPressure(120, 80));
            Console.WriteLine("Your BMI: {0}", bmi);
            Console.WriteLine("Your BMI Status: {0}", bmiStatus);
        }
    }
}
