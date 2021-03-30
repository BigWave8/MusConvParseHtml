using System.Collections.Generic;
using HtmlAgilityPack;

namespace MusConv
{
    class Parser
    {
        public string Url { get; set; }
        public HtmlWeb Web { get; set; }
        public HtmlDocument Doc { get; set; }
        public HtmlNodeCollection SongListNode { get; set; }
        public List<Song> ListOfSongs { get; set; }
    }
}
