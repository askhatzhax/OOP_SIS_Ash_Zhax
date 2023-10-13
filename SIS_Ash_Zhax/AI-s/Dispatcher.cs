using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Ash_Zhax.AI_s
{
    class Dispatcher : AI//наследуется от общего класса
    {
        public string Rating { get; set; }//рейтинг ИИ
        public Dispatcher(string specialization, string name, string rating) : base(specialization, name)
        {
            Rating = rating;
        }//конструктор котороый наследует параметры род класса
        public override string Move()// реализация абстрактного метода родительского класса 
        {
            string r="Приветствую , в нашем супер современном,\n супер супер удобным онлайн такси. ";
            return r;
        } public void Buy(User user, Car car, Driver drivers)// Метод обработки заказа
        {
            double price = car.Discount(user);
            user.ReduceBalance(price);
            Console.WriteLine("\n***Заказ обрабатывается, время ожидания 3с");
            Console.WriteLine("\n***Заказ обрабатывается, время ожидания 2с");
            Console.WriteLine("\n***Заказ обрабатывается, время ожидания 1с");
            Console.WriteLine("\n ########################## \n");
            Console.WriteLine($"{user.Name} заказал {car.Name} за {price}. Заказ принят, ждите такси\n к вам подьедет {drivers.Name}" );
        }
    }
       
}
