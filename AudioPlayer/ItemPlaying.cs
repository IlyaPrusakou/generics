using Audioplayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public abstract class ItemPlaying
    {
        public int Duration { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public Genres Genre { get; set; }
        public List<Playlist> playlists = new List<Playlist>();
        public bool IsNext { get; set; }
        public bool? Like { get; set; }

        public abstract void LikeMethod();

        public abstract void DislikeMethod();
        
        public void Deconstruct(out string str, out bool boo, out int sec, out int min, out int hour) 
        {
            str = Title; 
            boo = IsNext; 
            sec = Duration; 
            min = sec / 60; 
            hour = sec / 3600; 
        }
    }
}
