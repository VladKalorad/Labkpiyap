using System;
using System.Collections.Generic;
using System.Text;

namespace laba11._2
{
    class OneRoomFlat
    {
        List<FlatDifferentCity> oneroom;
        protected string kitchen;
        protected string room;
        protected int flat;
        public OneRoomFlat(List<FlatDifferentCity> b/*, string kitchen, string room, int flat*/)
        {
            oneroom = b;
            //this.kitchen = kitchen;
            //this.room = room;
            //this.flat = flat;
        }
        public void RoomDoSomthing()
        {
            foreach (FlatDifferentCity x in oneroom)
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
