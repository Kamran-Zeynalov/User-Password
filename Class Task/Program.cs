using System;

namespace Class_Task
{
    class Program
    {
        public static bool CheckPassword(string pw)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;
            bool cavab = false;
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            foreach (char charachter in pw)
            {
                if (char.IsDigit(charachter))
                {
                    hasDigit = true;
                }
                else if (char.IsLower(charachter))
                {
                    hasLower = true;
                }
                else if (char.IsUpper(charachter))
                {
                    hasUpper = true;
                }
                cavab = hasDigit && hasLower && hasUpper;
                if (cavab)
                {
                    break;
                }

            }
            return cavab;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" Adini Yaz");
            string name = Console.ReadLine();
            Console.WriteLine("Mailini yaz");
            string email = Console.ReadLine();
            Console.WriteLine("Sifreni yaz");
            string password;

            do
            {
                Console.WriteLine("Duz emelli sifre yaaazz");
                password = Console.ReadLine();
            }
            while (!CheckPassword(password));
           


            Human human = new Human(name, email, password);
            Console.WriteLine(human.ShowInfo());
            Console.WriteLine(human.CheckPassword(password));
        }
       

    }
}

