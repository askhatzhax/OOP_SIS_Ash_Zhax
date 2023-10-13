using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Ash_Zhax.Drivers
{
    class Talker : Driver//наследуется от общего класса Driver
    {
        public string Talking { get; set; }//уровень Комуникабельности
        public Talker(string name, string gender, string phonenumber, string workexperience, string ot,  string talking)
        : base(name, gender, phonenumber, workexperience,ot)//конструктор котороый наследует параметры род класса
        {
            Talking = talking;
        }
}
}
