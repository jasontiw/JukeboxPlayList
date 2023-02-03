namespace JukeboxPlayList.Cosole.Models
{
    /// <summary>
    /// The song.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Gets or Sets the name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets the duration.
        /// </summary>
        public int Duration { get; set; }
        /// <summary>
        /// Gets or Sets the image.
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// Gets or Sets the artist.
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Song"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="image">The image.</param>
        /// <param name="artist">The artist.</param>
        public Song(string name, int duration, string image, string artist)
        {
            Name = name;
            Duration = duration;
            Image = image;
            Artist = artist;
        }
    }
}
