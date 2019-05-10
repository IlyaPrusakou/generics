using Audioplayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Video: ItemPlaying
    {
        public Videoformate Formate { get; set; }
        public List<Artist> Artist { get; set; }
        public GenericPlayer<Video> Player { get; set; }
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
