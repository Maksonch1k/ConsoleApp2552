using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта расписания поездов. 

            TrainSchedule trainSchedule = new TrainSchedule();

            // Флаг для выхода из цикла. 

            bool exit = false;



            // Основной цикл программы. 

            while (!exit)

            {

                Console.WriteLine("Добро пожаловать на автовокзал!");

                Console.WriteLine("\nМеню:");

                Console.WriteLine("1. Добавить информацию об отправлении поезда в начало списка");

                Console.WriteLine("2. Добавить информацию об отправлении поезда в конец списка");

                Console.WriteLine("3. Добавить информацию об отправлении поезда перед определенным поездом");

                Console.WriteLine("4. Добавить информацию об отправлении поезда после определенного поезда");

                Console.WriteLine("5. Удалить выбранный поезд");

                Console.WriteLine("6. Вывести весь список");

                Console.WriteLine("7. Выйти из программы");



                Console.Write("\nВведите номер выбранного пункта меню: ");

                var choice = int.Parse(Console.ReadLine());



                // Обработка выбора пользователя. 

                switch (choice)

                {

                    case 1:

                        // Добавление поезда в начало списка. 

                        Console.Write("Введите номер поезда: ");

                        int trainNumber1 = int.Parse(Console.ReadLine());

                        Console.Write("Введите станцию назначения: ");

                        string destinationStation1 = Console.ReadLine();

                        Console.Write("Введите время отправления (гггг-мм-дд чч:мм:сс): ");

                        DateTime departureTime1 = DateTime.Parse(Console.ReadLine());

                        trainSchedule.AddTrainAtBeginning(new Train(trainNumber1, destinationStation1, departureTime1));

                        break;

                    case 2:

                        // Добавление поезда в конец списка. 

                        Console.Write("Введите номер поезда: ");

                        int trainNumber2 = int.Parse(Console.ReadLine());

                        Console.Write("Введите станцию назначения: ");

                        string destinationStation2 = Console.ReadLine();

                        Console.Write("Введите время отправления (гггг-мм-дд чч:мм:сс): ");

                        DateTime departureTime2 = DateTime.Parse(Console.ReadLine());

                        trainSchedule.AddTrainAtEnd(new Train(trainNumber2, destinationStation2, departureTime2));

                        break;

                    case 3:

                        // Добавление поезда перед определенным поездом. 

                        Console.Write("Введите номер поезда, перед которым нужно добавить новый поезд: ");

                        int trainNumberBefore = int.Parse(Console.ReadLine());

                        Console.Write("Введите номер нового поезда: ");

                        int newTrainNumberBefore = int.Parse(Console.ReadLine());

                        Console.Write("Введите станцию назначения нового поезда: ");

                        string newDestinationStationBefore = Console.ReadLine();

                        Console.Write("Введите время отправления нового поезда (гггг-мм-дд чч:мм:сс): ");

                        DateTime newDepartureTimeBefore = DateTime.Parse(Console.ReadLine());

                        trainSchedule.AddTrainBefore(trainNumberBefore, new Train(newTrainNumberBefore, newDestinationStationBefore, newDepartureTimeBefore));

                        break;

                    case 4:

                        // Добавление поезда после определенного поезда. 

                        Console.Write("Введите номер поезда, после которого нужно добавить новый поезд: ");

                        int trainNumberAfter = int.Parse(Console.ReadLine());

                        Console.Write("Введите номер нового поезда: ");

                        int newTrainNumberAfter = int.Parse(Console.ReadLine());

                        Console.Write("Введите станцию назначения нового поезда: ");

                        string newDestinationStationAfter = Console.ReadLine();

                        Console.Write("Введите время отправления нового поезда (гггг-мм-дд чч:мм:сс): ");

                        DateTime newDepartureTimeAfter = DateTime.Parse(Console.ReadLine());

                        trainSchedule.AddTrainAfter(trainNumberAfter, new Train(newTrainNumberAfter, newDestinationStationAfter, newDepartureTimeAfter));

                        break;

                    case 5:

                        // Удаление выбранного поезда. 

                        Console.Write("Введите номер поезда для удаления: ");

                        int trainNumberToRemove = int.Parse(Console.ReadLine());

                        trainSchedule.RemoveTrain(trainNumberToRemove);

                        break;

                    case 6:

                        // Вывод всего списка поездов. 

                        trainSchedule.PrintTrainSchedule();

                        break;

                    case 7:

                        // Выход из программы. 

                        exit = true;

                        break;

                    default:

                        Console.WriteLine("Неверный ввод. Попробуйте еще раз.");

                        break;

                }

                Console.ReadKey();

            }

        }

    }

} 
        
    

