using System;
using System.Collections.Generic;

namespace laba11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Room A = new Room(20, 30);
            Room B = new Room(25, 35);
            FlatDifferentCity a1 = new FlatDifferentCity("Minsk", A.Height, A.Weight);
            FlatDifferentCity a2 = new FlatDifferentCity("vitbsk", B.Height, B.Weight);
            OneRoomFlat X = new OneRoomFlat(new List<FlatDifferentCity> { a1, a2 });

            X.RoomDoSomthing();
            X.RoomSearch();

            //FlatDifferentCity[] flats = new FlatDifferentCity[3];
            //flats[0] = first;
            //flats[1] = second;
            //flats[2] = third;
            //FlatDifferentCity.Whereroom(flats);
            Console.ReadKey();
        }
    }
}
