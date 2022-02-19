using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
namespace laba10._2
{
    [Serializable]
    public class Room : IShowInfo, ICloneable, IComparable
    {
        public double height;
        public double weight;
        public Room(double height, double weight)
        {
            Height = height;
            Weight = weight;
        }
        public Room()
        {
            Console.WriteLine("Default");
        }
        public double Square()
        {
            double s = height * weight;
            return s;
        }
        public double Height
        {
            set { height = value; }
            get { return height; }
        }
        public double Weight
        {
            set { weight = value; }
            get { return weight; }
        }
        
        ~Room()
        {
            Console.WriteLine("Сработал деструктор");
        }
        void IShowInfo.ShowInfo()
        {
            Console.WriteLine($"Высота: {height} Ширина: {height}");
        }
        public object Clone()
        {
            return new Room(this.height, this.weight);
        }
        public int CompareTo(object p)
        {
            Room c = p as Room;
            return this.height.CompareTo(c.height);
        }
    }
}
