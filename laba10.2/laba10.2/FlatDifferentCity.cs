using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
namespace laba10._2
{
    [Serializable]

    class FlatDifferentCity : Room
    {
       
        public string city;
        public FlatDifferentCity(string city, double height, double weight):base(height,weight)
        {
            this.city = city;
            
        }
       public string DoSomthing()
        {
            return city + height + weight;
        }
        public string Search()
        {
            if (city == "Minsk")
            {
                return city+height+weight;
            }
            else
            {
                return "0";
            }
        }
        void ShowInfo()
        {
            Console.WriteLine($"Название: {height} Координата: {height} Город: {city} ");
        }
        //public void Fill(FlatDifferentCity flats)
        //{
        //    Console.WriteLine("Введите город");
        //     this.city = Console.ReadLine();
        //    Console.WriteLine("Введите площадь");
        //    this.squareKitchen = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Введите высота");
        //    this.height = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Введите Ширину");
        //    this.weight = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Введите Этаж");
        //    this.floar = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Введите номер квартиры");
        //    this.number = Convert.ToInt32(Console.ReadLine());
        //}
        //static public void Whereroom(FlatDifferentCity[] flats)
        //{
        //    for(int i =0; i < flats.Length; ++i)
        //    {
        //        if (flats[i].city == "Минск")
        //        {
        //            Console.WriteLine($"Номер квартиры: {flats[i].number}");
        //        }
        //        else { Console.WriteLine("Квартира не из Минска"); }
        //    }
        //}

    }
}
