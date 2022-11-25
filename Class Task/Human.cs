using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Task
{
    internal class Human : IAccountable
    {
        public string Fullname;
        public string Email;
        private string _password;


        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (CheckPassword(value))
                {
                    _password = value;
                }
            }

        }
        public bool CheckPassword(string pw)
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
        public Human(string name, string mail, string pw)
        {
            Fullname = name;
            Email = mail;
            Password = pw;
        }
        public string ShowInfo()
        {
            return $"Fullname: {Fullname}, Email: {Email}";
        }
    }
}


