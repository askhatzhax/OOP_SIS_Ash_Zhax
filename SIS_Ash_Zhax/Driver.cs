using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Ash_Zhax
{
    class Driver : Person//наследуется от общего класса Person 
    {
        public string WorkExperience { get; set; }//стаж работы водителем 
        public string  Ot { get; set; }// свойство для отличия от других видов водителей 

        public Driver(string name, string gender, string phonenumber, string workexperience, string ot)
        : base(name,gender,phonenumber)//конструктор котороый наследует параметры род класса
        
        {
            WorkExperience = workexperience;
            Ot = ot;

        }
        public override void Hello()// реализация абстрактного метода родительского класса 
        {
            Console.WriteLine("Hello, my name is "+Name+". I'm ready to go");
        }
    }
}
