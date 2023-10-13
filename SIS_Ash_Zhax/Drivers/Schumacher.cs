using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Ash_Zhax.Drivers
{
    class Schumacher : Driver//наследуется от общего класса Driver
    {
        public string Speed { get; set; }//Уровень скорости
        public Schumacher(string name, string gender, string phonenumber, string workexperience, string ot, string speed)
        : base(name, gender, phonenumber, workexperience,ot)
        {
            Speed = speed;
        }
    }
}
