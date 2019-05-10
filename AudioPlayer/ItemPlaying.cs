using Audioplayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public abstract class ItemPlaying // GenericPlayerHomework
    {
        public int Duration { get; set; } // GenericPlayerHomework
        public string Title { get; set; } // GenericPlayerHomework
        public string Path { get; set; } // GenericPlayerHomework
        public Genres Genre { get; set; } // GenericPlayerHomework
        public List<Playlist> playlists = new List<Playlist>(); // GenericPlayerHomework
        public bool IsNext { get; set; } // GenericPlayerHomework
        public bool? Like { get; set; } // GenericPlayerHomework

        public abstract void LikeMethod(); // GenericPlayerHomework

        public abstract void DislikeMethod(); // GenericPlayerHomework

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
