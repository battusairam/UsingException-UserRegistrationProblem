﻿using System; 
using static UsingException_UserRegistrationProblem.Program;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingException_UserRegistrationProblem
{
    public class Persons
    {
        public static string GetValidFirstName()
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            if (string.IsNullOrEmpty(firstName) || firstName.Length < 3 || !char.IsUpper(firstName[0]))
            {
                throw new Exception("Invalid First Name!");
            }

            return firstName;
        }

        /*
        public static string GetValidLastName()
        {
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            if (string.IsNullOrEmpty(lastName) || lastName.Length < 3 || !char.IsUpper(lastName[0]))
            {
                throw new Exception("Invalid Last Name!");
            }

            return lastName;
        }

        public static string GetValidEmail()
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            if (!IsValidEmail(email))
            {
                throw new Exception("Invalid Email!");
            }

            return email;
        }

        public static bool IsValidEmail(string email)
        {
            // Regular expression for validating email format
            string pattern = @"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*(\.[a-zA-Z]{2,})$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }

        public static string GetValidMobile()
        {
            Console.Write("Enter Mobile: ");
            string mobile = Console.ReadLine();

            if (!IsValidMobile(mobile))
            {
                throw new Exception("Invalid Mobile!");
            }

            return mobile;
        }

        public static bool IsValidMobile(string mobile)
        {
            // Regular expression for validating mobile format
            string pattern = @"^\d{2}\s\d{10}$";
            return System.Text.RegularExpressions.Regex.IsMatch(mobile, pattern);
        }

        public static string GetValidPassword()
        {
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (!IsValidPassword(password))
            {
                throw new Exception("Invalid Password!");
            }

            return password;
        }

        public static bool IsValidPassword(string password)
        {
            // Regular expressions for password rules
            string[] patterns = {
            @".{8,}",         // Minimum 8 characters
            @"[A-Z]",         // At least 1 uppercase letter
            @"\d",            // At least 1 numeric digit
            @"[^a-zA-Z0-9]"   // Exactly 1 special character
        };

            foreach (string pattern in patterns)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(password, pattern))
                {
                    return false;
                }
            }

            return true;
        }
     */

    }
}
