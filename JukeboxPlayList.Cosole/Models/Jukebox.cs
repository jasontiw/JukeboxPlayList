namespace JukeboxPlayList.Cosole.Models
{
    /// <summary>
    /// The jukebox.
    /// </summary>
    public class Jukebox
    {
        /// <summary>
        /// The all songs.
        /// </summary>
        private List<Song> _allSongs;
        /// <summary>
        /// The current playlist.
        /// </summary>
        private List<Song> _currentPlaylist;
        /// <summary>
        /// The current song index.
        /// </summary>
        private int _currentSongIndex;
        /// <summary>
        /// The is paused.
        /// </summary>
        private bool _isPaused;

        /// <summary>
        /// Initializes a new instance of the <see cref="Jukebox"/> class.
        /// </summary>
        /// <param name="allSongs">The all songs.</param>
        public Jukebox(List<Song> allSongs)
        {
            _allSongs = allSongs;
            _currentPlaylist = new List<Song>();
            _currentSongIndex = -1;
            _isPaused = false;
        }

        /// <summary>
        /// 
        /// </summary>
        public void On()
        {
            // Fill the current playlist with 5 random songs from allSongs
            var random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int randomIndex = random.Next(0, _allSongs.Count);
                _currentPlaylist.Add(_allSongs[randomIndex]);
            }

            // Sort the current playlist by song name
            _currentPlaylist.Sort((a, b) => a.Name.CompareTo(b.Name));
        }

        /// <summary>
        /// 
        /// </summary>
        public void Play()
        {
            if (_isPaused)
            {
                System.Console.WriteLine("Jukebox is paused, cannot play.");
                return;
            }
            if (_currentSongIndex == -1)
            {
                _currentSongIndex = 0;
            }
            System.Console.WriteLine("Now playing: " + _currentPlaylist[_currentSongIndex].Name);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Pause()
        {
            System.Console.WriteLine("Jukebox is paused.");
            _isPaused = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Next()
        {
            if (_isPaused)
            {
                System.Console.WriteLine("Jukebox is paused, cannot play next song.");
                return;
            }
            if (_currentSongIndex < _currentPlaylist.Count - 1)
            {
                _currentSongIndex++;
            }
            else
            {
                _currentSongIndex = 0;
            }

            System.Console.WriteLine("Now playing: " + _currentPlaylist[_currentSongIndex].Name);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Previous()
        {
            if (_isPaused)
            {
                System.Console.WriteLine("Jukebox is paused, cannot play previous song.");
                return;
            }
            if (_currentSongIndex > 0)
            {
                _currentSongIndex--;
            }
            else
            {
                _currentSongIndex = _currentPlaylist.Count - 1;
            }
            System.Console.WriteLine("Now playing: " + _currentPlaylist[_currentSongIndex].Name);
        }
    }

}
