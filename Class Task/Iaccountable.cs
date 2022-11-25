using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Task
{
    interface IAccountable
    {
        string ShowInfo();
        bool CheckPassword(string password);
    }
}
