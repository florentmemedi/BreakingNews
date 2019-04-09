using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingNewsAndGenericList.Classes
{
    public class Medium
    {
        public delegate void SendBrakingNewsHandler(string msg);

        public event SendBrakingNewsHandler SendNews;

        public void SendBreakingNews(string title, string content, DateTime date)
        {
            var NewsToSend = $"{title}. {content} published on: {date}";
            SendNews(NewsToSend);
        }
    }
}
