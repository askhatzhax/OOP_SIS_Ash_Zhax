using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Ash_Zhax.Cars
{
    public class CargoTaxi : Car//наследуется от общего класса
    {
       
        public string LiftingCapacity { get; set; }
        public CargoTaxi(string name, double price, int year, string liftingcapacity)
        : base(name, price, year)//конструктор котороый наследует параметры род класса
        {
            LiftingCapacity = liftingcapacity;
        }
        public override double Discount(User user)// виртуальный метод для скидки 
        {
            return Price * 0.5;
        }
        public override void Print()// реализация абстрактного метода родительского класса 
        {
    Console.WriteLine("Марка машины :" + Name + "Цена поездки :" + Price + " Год выпуска : " + Year + " Грузоподьемность : " + LiftingCapacity);
}
    }
}
