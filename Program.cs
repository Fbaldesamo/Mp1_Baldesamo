using System;
using System.IO;

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
            
            string Firstname, Lastname;
            double ContacNum;
            bool validate, validation_Contactnum;
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

            

            do
            {
                Console.Write("Contact Number: ");
                string ContactNum_Validate = Console.ReadLine();
                validation_Contactnum = double.TryParse(ContactNum_Validate, out ContacNum);
            }
            while (validation_Contactnum == false);

            Console.Write("Email: ");
            string UserEmail = Console.ReadLine();

            //open/creat the file text
            FileStream fs = new FileStream("Added Users.txt", FileMode.Append);

            //enable you to write in the text
            StreamWriter sw = new StreamWriter(fs);

            //write the infos in the text file
            sw.WriteLine("FullName: {0} {1}",Firstname, Lastname);
            sw.WriteLine("Contact Number: "+ContacNum);
            sw.WriteLine("User Email: "+UserEmail);
            sw.WriteLine("----------------------\n");
            //close the file
            sw.Close();
            fs.Close();


            //show the inputted infos
            Console.Clear();
            Console.WriteLine("FullName: {0} {1}", Firstname, Lastname);
            Console.WriteLine("Contact Number: "+ ContacNum);
            Console.WriteLine("User Email: "+ UserEmail);
            Console.WriteLine("Press any key to exit, thankyou!");
            Console.ReadKey();





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