using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Ash_Zhax
{
    public abstract class Person// абстракный класс
    {
        public string Name { get;  set; }//общие свойста для людей 
        public string Gender { get; set; }//общие свойста для людей 
        public string Phonenumber { get; set; }//общие свойста для людей 
        public Person(string name,string gender, string phonenumber)//конструктор
        {
            this.Name = name;
            this.Gender = gender;
            this.Phonenumber = phonenumber;
        }
        public abstract void Hello();// абстракный метод для приветствия других людей , потомучто надо быть вежливым и воспитанным 
    }
}
