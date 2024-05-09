using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Train
    {
        // Свойства для номера поезда, станции назначения и времени отправления. 

        public int TrainNumber { get; set; }

        public string DestinationStation { get; set; }

        public DateTime DepartureTime { get; set; }



        // Конструктор класса для инициализации свойств поезда. 

        public Train(int trainNumber, string destinationStation, DateTime departureTime)

        {

            TrainNumber = trainNumber;

            DestinationStation = destinationStation;

            DepartureTime = departureTime;

        }



        // Переопределение метода ToString для вывода информации о поезде. 

        public override string ToString()

        {

            return $"Поезд {TrainNumber}, станция назначения: {DestinationStation}, время отправления: {DepartureTime}";

        }

    }


}

