using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osu_Mp3_Creator
{
    public class Song
    {
        public string FolderPath { get; set; }
        public string FolderName { get; set; }
        public string ImagePath { get; set; }
        public string Mp3Path { get; set; }
        public string Mp3Name { get; set; }
        public string DiffPath { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }

        public Song(string folderpath, string foldername,string imagepath, string mp3path, string mp3name, string diffpath, string title, string artist)
        {
            FolderPath = folderpath;
            FolderName = foldername;
            ImagePath = ImagePath;
            Mp3Path = mp3path;
            Mp3Name = mp3name;
            DiffPath = diffpath;
            Title = title;
            Artist = artist;
        }
    }
}
