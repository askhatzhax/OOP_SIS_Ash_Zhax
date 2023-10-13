using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Ash_Zhax
{
    public class User : Person//наследуется от общего класса Person 
    {   

        private string adress ;  //Адресс
        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                if(value!=null)
                {
                    adress = value;
                }
            }
        }
        public double Balance { get; private set; }//Баланс денюжег
        public double Spent { get; private set; }//количество потраченных средств

        public User(string name, string gender, string phonenumber, string adress, int balance, int spent)
            : base(name, gender, phonenumber)//конструктор котороый наследует параметры род класса
        {
            Name = name;
            Adress = adress;
            Balance = balance;
            Spent = spent;
        }

        public void ReduceBalance(double price)// вычитание затрат с карты и прибоавления к тратам
        {
            Balance -= price;
            Spent += price;
        }
        
        public override void Hello()// реализация абстрактного метода родительского класса 
        {
            Console.WriteLine("Hello, my name is " + Name + ". I'm ready to go");
        }
    }
}
