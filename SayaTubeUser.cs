using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210084
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private String Username;

        public SayaTubeUser(String username)
        {
            Contract.Requires(username != null);
            this.Username = username;
            Random rn = new Random();
            this.id = rn.Next(10000, 1000000);
            this.uploadedVideos= new List<SayaTubeVideo>();
        }
        public int GetTotalVideoPlayCount()
        {

            int GTVPC = 0;
            for (int i = 0; i < uploadedVideos.Count;i++)
            {
                GTVPC += uploadedVideos[i].getplayCount();
            }
            return GTVPC;
        }
        public void AddVideo (SayaTubeVideo video) {
            Debug.Assert(video != null, "stringnya NULL");
            Debug.Assert(video.getplayCount() < int.MaxValue, "Jumlah playcount kebanyakan");
            try
            {
                this.uploadedVideos.Add(video);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: "+this.Username);
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].getTitle());
            }
        }
    }
}
