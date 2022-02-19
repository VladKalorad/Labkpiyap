using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace laba10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Room A = new Room(20, 30);
            Room B = new Room(25, 35);
            Room C = new Room(25, 35);
            FlatDifferentCity a1 = new FlatDifferentCity("Minsk", A.Height, A.Weight);
            FlatDifferentCity a2 = new FlatDifferentCity("vitbsk", B.Height, B.Weight);
            OneRoomFlat X = new OneRoomFlat(new List<FlatDifferentCity> { a1, a2 });

            Room[] D = { A, B, C };

            X.RoomDoSomthing();
            X.RoomSearch();
            Room G = (Room)A.Clone();
            Console.WriteLine(G);
            Array.Sort(D);
            foreach (var obj in D)
            {
                ((IShowInfo)obj).ShowInfo();
            }
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("room.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, A);
                formatter.Serialize(fs, B);
                formatter.Serialize(fs, C);
                formatter.Serialize(fs, a1);
                formatter.Serialize(fs, a2);
                Console.WriteLine("Объекты сериализован");
            }
            //SoapFormatter formatter2 = new SoapFormatter();
            //using (FileStream fss = new FileStream("room.soap", FileMode.OpenOrCreate))
            //{
            //    formatter2.Serialize(fss, A);
            //    formatter2.Serialize(fss, B);
            //    formatter2.Serialize(fss, C);
            //    Console.WriteLine("Объекты сериализован");
            //}
            XmlSerializer formatter3 = new XmlSerializer(typeof(Room));
            using (FileStream fs = new FileStream("rooms.xml", FileMode.OpenOrCreate))
            {
                formatter3.Serialize(fs, A);
                formatter3.Serialize(fs, B);
                formatter3.Serialize(fs, C);
                Console.WriteLine("Объект сериализован");
            }

            Console.ReadKey();
        }
    }
}
