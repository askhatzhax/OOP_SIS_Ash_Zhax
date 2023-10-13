using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Ash_Zhax.Cars
{
    public class Econom : Car//наследуется от общего класса
    {
        
        public double Speed { get; set; }
    public Econom(string name, double price, int year, double speed)
        : base(name, price, year)//конструктор котороый наследует параметры род класса
        {
            Speed = speed;
        }
public override void Print()// реализация абстрактного метода родительского класса 
        {
    Console.WriteLine("Марка машины :" + Name + "Цена поездки :" + Price + " Год выпуска : " + Year + " Скорость: " + Speed);
}
    }
}
