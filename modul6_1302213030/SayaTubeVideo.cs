using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213030
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            this.title = title;
            Random random = new Random();
            id = random.Next(10000, 99999);
            playCount = 0;
        }

        public void increasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video\t: " + id);
            Console.WriteLine("Title Video\t: " + title);
            Console.WriteLine("Play Count\t: " + playCount);
        }

        public int getPlayCount()
        {
            return this.playCount;
        }
            
        public String getTitle()
        {
            return this.title;
        }
    }
}
