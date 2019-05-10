using AudioPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audioplayer
{
    public class Song: ItemPlaying
    {
        public string Lyrics { get; set; }
        public Album Album { get; set; }
        public Artist Artist { get; set; }
        public GenericPlayer<Song> Player { get; set; }
 
        public override void LikeMethod()
        {
            base.Like = true;
        }
        public override void DislikeMethod()
        {
            base.Like = false;
        }
    }
}