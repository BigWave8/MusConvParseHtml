using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using HtmlAgilityPack;

namespace MusConv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Parser parser = new Parser();
            parser.Url = GetUrl(site);
            parser.Web = new HtmlWeb();
            parser.Doc = parser.Web.Load(parser.Url);
            parser.SongListNode = parser.Doc.DocumentNode.SelectNodes("//span[@class='songRow']");
            parser.ListOfSongs = new List<Song>();
            foreach (var node in parser.SongListNode)
            {
                string songName = node.FirstChild.InnerText;
                string artistName = node.LastChild.InnerText;
                parser.ListOfSongs.Add(new Song(songName, artistName));
                songsList.Items.Add(new Song { SongName = songName, ArtistName = artistName });
            }
        }
        
        public string GetUrl(TextBox textBox)
        {
            return textBox.Text;
        }
    }
}
