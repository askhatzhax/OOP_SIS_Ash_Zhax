using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Ash_Zhax.AI_s
{
    class Navigator<T> : AI//наследуется от общего класса
    {
        public T Location { get; set; }
        public Navigator(string specialization, string name, T location) : base(specialization, name)//конструктор котороый наследует параметры род класса
        {
            Location = location;
        }//если пользователь сам захочет ввести свой адрес
        public override string Move()// реализация абстрактного метода родительского класса 
        {
            string s = "Тайгуль-2 дом 48 подьезд 2";//путем сложных матем и гео вычислений  ИИ опредилил адрес пользователя
            return s;
        }
    }
}
