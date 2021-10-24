using System;

namespace Mp1_Baldesamo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AddUser();

            Console.ReadKey();
        }

        public static void AddUser()
        {
            bool validate;
            string Firstname;
            string Lastname;
            do
            {
                Console.Write("First Name: ");
                Firstname = Console.ReadLine();
                validate = ValidateUser(Firstname);

                
            } while (validate == false);

            do
            {
                Console.Write("Last Name: ");
                Lastname = Console.ReadLine();
                validate = ValidateUser(Lastname);

            }
            while (validate == false);
            Console.WriteLine("Correct!");

            
        }

        public static bool ValidateUser(string a)
        {
            if (string.IsNullOrEmpty(a))
            {
                return false;
            }

            foreach (char c in a)
            {
                while (char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}