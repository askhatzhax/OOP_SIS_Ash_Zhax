using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Ash_Zhax.Cars
{
    public class Luxe : Car//наследуется от общего класса
    {
        
        public string Luxury { get; set; }
        public Luxe (string name, double price, int year, string luxury)
        : base(name, price, year)//конструктор котороый наследует параметры род класса
        {
           Luxury  = luxury;
        }
        public override void Print()// реализация абстрактного метода родительского класса
        {
            Console.WriteLine("Марка машины :" + Name + "Цена поездки :" + Price + " Год выпуска : " + Year + " Уровень роскоши : " + Luxury);
        }
    }
}
