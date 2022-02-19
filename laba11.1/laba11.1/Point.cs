using System;
using System.Collections.Generic;
using System.Text;

namespace laba11._1
{
    class Point : IComparer<Point>, IShowInfo, IComparable
    {
        private string name;
        private double coordinate;
        private string color;
        public Point()
        {

        }
        public Point(string name, double coordinate, string color)
        {
            this.name = name;
            this.coordinate = coordinate;
            this.color = color;
        }
        public double Coordinate
        {
            get { return coordinate; }
            private set
            {
                coordinate = value;
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                color = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public override string ToString()
        {
            return "Название: " + name + "Координата: " + coordinate + "Цвет: " + color;
        }
        public void Print()
        {
            Console.WriteLine($"Название: {name} Координата: {coordinate} Цвет: {color}");
        }
        
        void IShowInfo.ShowInfo()
        {
            Console.WriteLine($"Название: {name} Координата: {coordinate} Цвет: {color}");
        }
        public int Compare(Point A, Point B)
        {
            if (A.Coordinate > B.Coordinate)
                return 1;
            else if (A.Coordinate < B.Coordinate)
                return -1;
            else
                return 0;
        }
        public object Clone()
        {
            return new Point(this.name, this.coordinate, this.color);
        }
        public int CompareTo(object p)
        {
            Point c = p as Point;
            return this.Coordinate.CompareTo(c.Coordinate); 
        }

    }
    
}
