using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingNewsAndGenericList.Classes
{
    public class Follower
    {
        public string Name { get; set; }

        public Follower(string name)
        {
            Name = name;
        }

        public void Subscribe(Medium medium)
        {
            medium.SendNews += new Medium.SendBrakingNewsHandler(SendNews);
        }

        public void SendNews(string msg)
        {
            Console.WriteLine($"{Name}, {msg}");
        }
    }
}
