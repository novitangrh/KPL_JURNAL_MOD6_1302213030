using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213030
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public String username;

        public SayaTubeUser(String username)
        {
            Contract.Requires(username.Length <= 100);
            Contract.Requires(username != null);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();

        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                total += uploadedVideos[i].getPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo newVideo)
        {
            Debug.Assert(newVideo != null);
            Debug.Assert(newVideo.getPlayCount() < 1000000000000);
            uploadedVideos.Add(newVideo);
        }

        public void PrintAllVideoPlaycount()
        {
            try
            {
                Console.WriteLine("User: " + username);
                Debug.Assert(uploadedVideos.Count <= 8);
                for (int i = 0; i < uploadedVideos.Count; i++)
                {
                    Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].getTitle());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

       
        }
    }

}
