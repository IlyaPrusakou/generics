using AudioPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Audioplayer
{
    public class Player: GenericPlayer<Song> 
    {

        public Player(Skin skn) : base(skn)
        {

        }
        
        public void LyricsOutput()
        {
            foreach (Song item in Items)
            {
                SkinForm.Render($"{item.Title} --- {item.Lyrics}");
            }
        }
    }
}