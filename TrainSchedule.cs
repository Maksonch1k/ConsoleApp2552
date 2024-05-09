using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TrainSchedule
    {
        // Приватное поле для хранения списка поездов. 

        private List<Train> trains = new List<Train>();



        // Метод для добавления поезда в начало списка. 

        public void AddTrainAtBeginning(Train train)

        {

            trains.Insert(0, train);

        }

        // Метод для добавления поезда в конец списка. 

        public void AddTrainAtEnd(Train train)

        {

            trains.Add(train);

        }

        // Метод для добавления поезда перед определенным поездом. 

        public void AddTrainBefore(int trainNumber, Train train)

        {

            // Поиск индекса поезда по его номеру. 

            int index = trains.FindIndex(t => t.TrainNumber == trainNumber);

            // Если поезд найден, вставить новый поезд перед ним. 

            if (index >= 0)

                trains.Insert(index, train);

            else

                Console.WriteLine("Поезд с таким номером не найден.");

        }

        // Метод для добавления поезда после определенного поезда. 

        public void AddTrainAfter(int trainNumber, Train train)

        {

            // Поиск индекса поезда по его номеру. 

            int index = trains.FindIndex(t => t.TrainNumber == trainNumber);

            if (index >= 0)

                trains.Insert(index + 1, train);

            else

                Console.WriteLine("Поезд с таким номером не найден.");

        }

        // Метод для удаления поезда по его номеру. 

        public void RemoveTrain(int trainNumber)

        {

            // Поиск поезда по его номеру. 

            Train trainToRemove = trains.Find(train => train.TrainNumber == trainNumber);

            if (trainToRemove != null)

                trains.Remove(trainToRemove);

            else

                Console.WriteLine("Поезд с таким номером не найден.");

        }

        // Метод для вывода всего списка поездов. 

        public void PrintTrainSchedule()

        {

            Console.WriteLine("Информация о поездах дальнего следования:");

            foreach (var train in trains)

            {

                Console.WriteLine(train);

            }

        }

        // Метод для получения информации о поезде по его номеру. 

        public Train GetTrainByNumber(int trainNumber)

        {

            return trains.Find(train => train.TrainNumber == trainNumber);

        }

        // Метод для получения списка поездов по станции назначения. 

        public List<Train> GetTrainsByDestination(string destinationStation)

        {

            return trains.FindAll(train => train.DestinationStation == destinationStation);

        }

        // Метод для сортировки списка поездов по станции назначения. 

        public void SortByDestination()

        {

            trains.Sort((x, y) => string.Compare(x.DestinationStation, y.DestinationStation));

        }

    }
}

