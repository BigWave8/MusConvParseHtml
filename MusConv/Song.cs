namespace MusConv
{
    class Song
    {
        public string SongName { get; set; }
        public string ArtistName { get; set; }
        public Song(){}
        public Song(string song, string artist)
        {
            SongName = song;
            ArtistName = artist;
        }
    }
}
