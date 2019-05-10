using AudioPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Audioplayer
{
    public class Player: GenericPlayer<Song>  // GenericPlayerHomework
    {

        public Player(Skin skn) : base(skn) // GenericPlayerHomework
        {

        }
        
        public void LyricsOutput() // GenericPlayerHomework
        {
            foreach (Song item in Items) // GenericPlayerHomework
            {
                SkinForm.Render($"{item.Title} --- {item.Lyrics}"); // GenericPlayerHomework
            }
        }
    }
}