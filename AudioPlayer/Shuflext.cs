using Audioplayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public static class ShufleExtension
    {
        public static Random rndAA = new Random();
        public static CompareHelper Comp = new CompareHelper();
        public static List<T> ExtenShufle<T>(this List<T> list)
        {

            List<T> newList = new List<T>();

            for (int i = 0; i < list.Count + 1000; i++)
            {
                int index = rndAA.Next(0, list.Count);
                if (!newList.Contains(list[index]))
                {
                    newList.Add(list[index]);
                }
                else if (newList.Contains(list[index]))
                {
                    continue;
                }
            }
            return newList;
        }
        public static List<T> ExtenSortByTitle<T>(this List<T> oldList, GenericPlayer<T> player) where T: ItemPlaying
        {
            List<T> sortedSongsList = new List<T>();
            List<string> titleList = new List<string>();
            foreach (T item in oldList)
            {
                titleList.Add(item.Title);
            }
            titleList.Sort(Comp);
            foreach (string item in titleList) { player.SkinForm.Render("rrr  " + item); } //WriteLine("rrr  " + item)
            for (int i = 0; i < titleList.Count; i++)
            {
                foreach (T t in oldList)
                {
                    if (titleList[i] == t.Title)
                    {
                        sortedSongsList.Add(t);
                    }
                    else if (titleList[i] != t.Title)
                    {
                        continue;
                    }
                }
            }
            return sortedSongsList;
        }
    }
}
