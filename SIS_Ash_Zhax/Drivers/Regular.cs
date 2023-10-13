using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Ash_Zhax.Drivers
{
    class Regular : Driver//наследуется от общего класса Driver
    {
        public string Politeness { get; set; }//Уровень вежливости
        public Regular(string name, string gender, string phonenumber, string workexperience,string ot, string politeness)
        : base(name, gender, phonenumber, workexperience,ot)//конструктор котороый наследует параметры род класса
        {
            Politeness = politeness;
        }
}
}
