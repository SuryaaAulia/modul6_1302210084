using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
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
            Contract.Requires(title != null);
            Contract.Requires(title.Length <= 200);
            this.title = title;
            Random rn = new Random();
            this.id = rn.Next(10000,1000000);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount > 0, "Jumlah playcount negativ");
            Debug.Assert(playCount > 25000000, "Jumlah playcount kebanyakan");
            try { 
                this.playCount = checked(playCount + this.playCount);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
