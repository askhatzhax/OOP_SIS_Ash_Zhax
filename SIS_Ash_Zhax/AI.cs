using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Ash_Zhax
{
    abstract class AI// абстракный класс ИИ
    {
        public string Specialization { get; set; }//Специализация ИИ
        public string Name { get; set; }//Имя

        public AI(string specialization, string name)//конструктор
        {
            this.Name = name;
            this.Specialization = specialization;
        }
        public abstract string Move();// Абстрактный метод который показывает действие определенного ИИ
    }
}
