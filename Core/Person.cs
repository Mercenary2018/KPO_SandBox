using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace StaffLibrary
{
   public abstract class Person
    {
        /*
           Фамилия, имя, отчество;
           Дата, место рождения;
           Сведения о гражданстве;
           Паспортные данные;
           Адрес регистрации;
           Адрес фактического места проживания;
         */

    }

    public class Students : Person
    {
        /*
           Сведения о предыдущем образовании;
           Сведения о воинской обязанности;
           Сведения о социальных льготах;
           Сведения о форме обучения;
           Сведения об образовательной программе обучения;
           Сведения об основе обучения (договор);
           Сведения о движении студента (выписки из приказов);
           Сведения об успеваемости студента.
         */
    }

    public class Teacher : Person, IFinance
    {
        public string Salary { get; set; }
        /*
            Кафедра
            Ученая степень
            Должность
         */
    }

    public class Staff : Person, IFinance
    {
        public string Salary { get; set; }
        /*
            Должность
        */
    }
}
