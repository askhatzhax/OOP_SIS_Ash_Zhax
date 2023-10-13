using SIS_Ash_Zhax.AI_s;
using SIS_Ash_Zhax.Cars;
using SIS_Ash_Zhax.Drivers;
using System;

namespace SIS_Ash_Zhax
{
    class Program
    {
        static void Main(string[] args)

        {   
            
            Dispatcher D = new Dispatcher("Обслуживание клиентов", "Зинаида Михайловна", "10");//обьявляю обьект и заполняю его 
            Navigator<string> N = new Navigator<string>("Определяет местположние", "Иван Сусанин","Null" );//generic
            Regular R = new Regular("Юрий Дудь",
               "Мужик", "+7 700-249-55-12-55", "15 лет", "Очень вежливый","Обычный");//обьявляю обьект и заполняю его 
            Schumacher S = new Schumacher("Доминик Торрето",
               "Мужик", "+0 000-000-00-02", "с рождения", "Очень^10 быстрый","Шумахер");//обьявляю обьект и заполняю его 
            Talker T = new Talker("Нариман агай",
               "Мужик", "+0 000-000-00-02", "45 лет", "знает все свежие новости и может дать толковый совет ","Разговорчивый");//обьявляю обьект и заполняю его 
            CargoTaxi Gazel = new CargoTaxi("Газель 2017", 3000, 2017, "до 3500 кг");//обьявляю обьект и заполняю его 
            Econom Toyota = new Econom("Toyouta Corolla 2008", 500, 2008, 20);//обьявляю обьект и заполняю его 
            Luxe BMV = new Luxe("BMV M5 F90 competition", 20000,2018, "тачка прост огооонь, поверь мне");//обьявляю обьект и заполняю его 
            Car[] cars = new Car[]//UpCast для удобного и быстрого предоставления интерфеся для пользователя 
            {
                Gazel,
                Toyota,
                BMV
            };
            Driver[] Drivers = new Driver[]//UpCast для удобного и быстрого предоставления интерфеся для пользователя
            {
                R,
                S,
                T
            };
            bool f = true;
            while (f)
            {
                Console.WriteLine(D.Move());//вызов метода Move класса Dispather
                string name, gender, phone, adress;
                int balance;
                Console.WriteLine("Ваше ФИО : ");
                name = Console.ReadLine();
                Console.WriteLine("Ваш пол : ");
                gender = Console.ReadLine();
                Console.WriteLine("Ваш номер телефона : ");
                phone  = Console.ReadLine();
                Console.WriteLine("Ваш адрес : " + N.Move());
                Console.WriteLine("Адресс указан верно? : ");
                adress = Console.ReadLine();
                if (adress == "да") { adress = N.Move(); }//проверка правильного местоположения с помощью вызова метода Move() класса Navigator
                else {
                    Console.WriteLine("Введите адрес : ");
                    adress=Console.ReadLine();
                }
                

             Console.WriteLine("Ваш баланс : ");
                balance = Convert.ToInt32(Console.ReadLine());
                User user = new User(name, gender, phone, adress, balance,0);// создал обьек user класса User
                Console.WriteLine("Куда вы хотите поехать ?");
                string map = Console.ReadLine();
                Console.WriteLine("Отлично, там как раз нету пробок");
                Console.WriteLine("Классы такси  ");
                for (int i = 0; i < cars.Length; i++)//вывод видов машин на выбор
                {
                    Console.WriteLine($"Машина {i} {cars[i].Name} по цене {cars[i].Price}");
                }
                
                    Console.WriteLine("Выберете номер Машины и нажмите Enter:");
                    int Num = Convert.ToInt32(Console.ReadLine());
                    if (Num > 0 && Num < cars.Length)// проверка на наличие такой машины 
                    {

                        if (cars[Num].Price > user.Balance)// проверка на денежные средства
                    {
                            Console.WriteLine("У вас недостаточно средств \n Попробуйте снова ");
                        }
                        
                    }


                    else
                    {

                        Console.WriteLine("Таких машин нет\n Попробуйте снова");
                    }
                
                Console.WriteLine("Виды водителей");
                for (int i = 0; i < Drivers.Length; i++)//вывод видов водилелй на выбор
                {
                    Console.WriteLine($"водителя {i} {Drivers[i].Name} вид водителя  {Drivers[i].Ot}");
                }
                Console.WriteLine("Выберете номер водителя и нажмите Enter:");
                int Number = Convert.ToInt32(Console.ReadLine());
                D.Buy(user, cars[Num], Drivers[Number]);
                
                cars[Num].Start();//вызов метода Интерфейса класса Car
                Console.WriteLine("\nПожалуйста, выходите");

                Console.WriteLine("\n\n\n\nХотите сделать новый заказ   ?  ");
                //выхода из программы нет , потомучто вот так надо делать бизнес!!!
            }
        }
    }
}
