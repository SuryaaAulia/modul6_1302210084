using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210084
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            this.title = title;
            Random rn = new Random();
            this.id = rn.Next(10000,1000000);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video dengan id "+this.id+" yang memiliki judul "+this.title+" memiliki view counts "+this.playCount);
        }
        public int getplayCount() 
        { 
            return this.playCount;
        }
        public String getTitle()
        {
            return this.title;
        }
    }
}
