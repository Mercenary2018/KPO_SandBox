using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    interface IFinance
    {
        string Salary { get; set; }


    }

    interface ILogicFinance
    {
        void AddSalary();
        void CalcSalary();
    }
}
