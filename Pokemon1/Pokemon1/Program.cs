﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon1
{
    class pokemon
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public string Type { get; set; }


        public pokemon(string name, int hp, int attack, int defense, int specialAttack, int specialDefense, int speed, string type)
        {
            Name = name;
            HP = hp;
            Attack = attack;
            Defense = defense;
            SpecialAttack = specialAttack;
            SpecialDefense = specialDefense;
            Speed = speed;
            Type = type;
            
          
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Тип: {Type}");
            Console.WriteLine($"Очки здоровья: {HP}");
            Console.WriteLine($"Атака: {Attack}");
            Console.WriteLine($"Защита: {Defense}");
            Console.WriteLine($"Специальная атака: {SpecialAttack}");
            Console.WriteLine($"Специальная защита: {SpecialDefense}");
            Console.WriteLine($"Скорость: {Speed}");
            
        }

        public class Sewaddle : pokemon
        {
            public Sewaddle() : base("Sewaddle", 40, 53, 70, 40, 60, 42, "Травяной")
            {
            }
        }
        public class Swadloon : pokemon
        {
            public Swadloon() : base("Swadloon", 55, 63, 90, 50, 80, 42, "Травяной")
            {
            }
        }
        public class Leavanny : pokemon
        {
            public Leavanny() : base("Leavanny", 75, 103, 80, 70, 80, 92, "Травяной")
            {
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Sewaddle sewaddle = new Sewaddle();
        
                Swadloon swadloon = new Swadloon();
                Leavanny leavanny = new Leavanny();

                sewaddle.PrintInfo();
                Console.WriteLine();
                swadloon.PrintInfo();
                Console.WriteLine();
                leavanny.PrintInfo();
            }
        }
    }
}
