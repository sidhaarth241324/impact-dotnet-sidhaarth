using System;
using System.Collections.Generic;
using System.Text;
//An integer indexer to access or update a song by position.
//A string indexer to find a song by its title.
namespace Application
{
    public class Playlist
    {
        private readonly List<string> songs = new List<string>();
        public Playlist(params string[] initialSongs)
        {
            songs.AddRange(initialSongs);
        }
        // Integer indexer: access a song by position
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= songs.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                return songs[index];
            }
            set
            {
                if (index < 0 || index >= songs.Count)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                songs[index] = value;
            }
        }
        // String indexer: find a song by title
        public int this[string title]
        {
            get
            {
                return songs.FindIndex(song => string.Equals(song, title, StringComparison.OrdinalIgnoreCase));
            }
        }
        public int Count => songs.Count;
    }
}
