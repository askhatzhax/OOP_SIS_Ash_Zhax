using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Ash_Zhax
{
    public abstract class Car : IMove // // абстракный класс машины в котором реализуется интерфейс Imove
    { 

        public int Year { get; set; }//год выпуска машины
        public string Name { get; set; }//имя
        public double Price { get; set; }//цена поездки
        public int Power  { get; }//реализация свойиства интерфейса Imove
        public int Weight { get; }//реализация свойиства интерфейса Imove
        public void Start()//реализация метода интерфейса Imove
        {
            Console.WriteLine("\nМашина подьехала");
        }
        public void Stop()//реализация метода интерфейса Imove
        {
            Console.WriteLine("\nМашина остановилась");
        }
        public Car(string name, double price , int year)//конструктор
        {
            this.Name = name;
            this.Year = year;
            this.Price = price;
        }
        public virtual double Discount(User user)// виртуальный метод для скидки 
        {
            if (user.Spent < 4700)
            {
                return Price;
            }
            return Price * 0.7;
        }
        public abstract void Print();//абстрактный метод для вывода информации о машине
    }
}
