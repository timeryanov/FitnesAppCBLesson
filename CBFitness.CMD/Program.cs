﻿using CBFitness.BL.Controller;
using System;

namespace CBFitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение CBFitness.");
            Console.WriteLine("Введите имя пользователя.");
            var name = Console.ReadLine();

            Console.WriteLine("Введите пол.");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения.");
            var birthdate = DateTime.Parse(Console.ReadLine()); // TODO переписать на tryparse

            Console.WriteLine("Введите вес.");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост.");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthdate, weight, height);
            userController.Save();
        }
    }
}
