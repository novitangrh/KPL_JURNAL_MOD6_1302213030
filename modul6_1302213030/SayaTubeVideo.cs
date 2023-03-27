using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
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
            Contract.Requires(title.Length <= 200);
            Contract.Requires(title != null);
            this.title = title;
            Random random = new Random();
            id = random.Next(10000, 99999);
            playCount = 0;
        }

        public void increasePlayCount(int playCount)
        {
            Contract.Requires(playCount < 25000000);
            Contract.Requires(playCount < 0);
            try
            {
                checked
                {
                    this.playCount += playCount;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Maximum");
            }
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
