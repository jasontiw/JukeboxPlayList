using JukeboxPlayList.Cosole.Models;

namespace JukeboxPlayList.Console
{

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args">The args.</param>
        static void Main(string[] args)
        {
            List<Song> allSongs = new()
            {
                new Song("Song 1", 120, "image1.jpg", "Artist 1"),
                new Song("Song 2", 150, "image2.jpg", "Artist 2"),
                new Song("Song 3", 140, "image3.jpg", "Artist 3"),
                new Song("Song 4", 160, "image4.jpg", "Artist 4"),
                new Song("Song 5", 170, "image5.jpg", "Artist 5"),
                new Song("Song 6", 170, "image5.jpg", "Artist 5")
            };

            Jukebox jukebox = new(allSongs);
            jukebox.On();

            jukebox.Play();
            jukebox.Pause();
            jukebox.Next();
            jukebox.Previous();

            System.Console.ReadLine();
        }
    }
}