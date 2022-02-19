using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
namespace laba10._2
{
    [Serializable]
     class OneRoomFlat
    {
        List<FlatDifferentCity> oneroom;
        public string kitchen;
        public string room;
        public int flat;
        public OneRoomFlat(List<FlatDifferentCity>b/*, string kitchen, string room, int flat*/)
        {
            oneroom = b;
            //this.kitchen = kitchen;
            //this.room = room;
            //this.flat = flat;
        }
        public void RoomDoSomthing()
        {
            foreach(FlatDifferentCity x in oneroom)
            {
                Console.WriteLine(x.DoSomthing());
            }
        }
        public void RoomSearch()
        {
            foreach (FlatDifferentCity x in oneroom)
            {
                Console.WriteLine(x.Search());
                break;
            }
        }


    }
}
