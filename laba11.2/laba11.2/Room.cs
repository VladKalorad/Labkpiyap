using System;
using System.Collections.Generic;
using System.Text;

namespace laba11._2
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace laba10._2
    {
        class Room
        {
            protected double height;
            protected double weight;
            public Room()
            {
                Console.WriteLine("Default");
            }
            public Room(double height, double weight)
            {
                Height = height;
                Weight = weight;
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
        }
    }

}
