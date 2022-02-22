using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_12._2
{
    class Train
    {
        private string city;
        private int number;
        private double time;
        public Train(string city, int number, double time)
        {
            Create += PrintA;
            Create(this, new TrainEventArgs("Объект создан"));
            this.city = city;
            this.number = number;
            this.time = time;
        }
        delegate void TrainEvent(object obj, TrainEventArgs m);
        event TrainEvent Create;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public int Number
        {
            get { return number; }
            set
            {
                if (value > 0 || value < 120)
                {
                    number = value;
                }
                else
                {
                    throw new FunctionsExeption("Максимум 120 номер поездов");
                }
            }
        }
        public double Time
        {
            get { return time; }
            set
            {
                if (value < 0.0 || value > 24.60)
                {
                    time = value;
                }
                else
                {
                    throw new FunctionsExeption("Время введено неправильно");
                }
            }
        }
        static void PrintA(object obj, TrainEventArgs s)
        {
            Console.WriteLine(s.message);
        }
        public override string ToString()
        {
            return "Город: " + city + "Номер поезда: " + number + "Время: " + Time;
        }
        public void Input()
        {
            Console.WriteLine("Введите номер поезда");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 1 || number > 300) throw new FunctionsExeption("Номер невернный");
            Console.WriteLine("Введите время");
            time = Convert.ToInt32(Console.ReadLine());
            if (time < 0 || time > 24.59) throw new FunctionsExeption("Номер невернный");
        }
     }
}
