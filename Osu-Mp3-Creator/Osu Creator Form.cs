using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;

namespace Osu_Mp3_Creator
{
    public partial class mainWindow : Form
    {
        string targetPath = "";
        string sourcePath = "";

        public mainWindow()
        {
            InitializeComponent();
            textBoxBefore.Text = @"C:\...\osu!\Songs";
            textBoxAfter.Text = @"C:\...\Mp3output";
        }

        //Window triggers
        private void Browse1_Click(object sender, EventArgs e)
        {
            sourcePath = seekFolder();
            textBoxBefore.Text = sourcePath;
            if (targetPath != "" && sourcePath != "")
            {
                songClassConstructor();
            }
        }
        private void Browse2_Click(object sender, EventArgs e)
        {
            targetPath = seekFolder();
            textBoxAfter.Text = targetPath;
            if (targetPath != "" && sourcePath != "")
            {
                songClassConstructor();
            }
        }
        private void Confirmar_Click(object sender, EventArgs e)
        {
            modifyMp3();
        }

        //functions
        private void songClassConstructor()
        {
            int objectamount = 0;

            //for each folder song in \Songs
            foreach (string subfolder in Directory.GetDirectories(sourcePath))
            {
                string osuparam = @".*\.osu";
                string mp3nameparam = @"AudioFilename\: (.*)";
                string titleparam = @"Title\:(.*)";
                string artistparam = @"Artist\:(.*)";
                string imageparam = @"([0,9]+\,[0,9]+)\,\""([^\""]+)\"".*";

                string diffpath = "";
                string foldername = "";
                string folderpath = "";
                string mp3name = "";
                string mp3path = "";
                string imagepath = "";
                string title = "";
                string artist = "";

                bool exitwhile = false;

                // foldername, folderpath ///
                string[] spstring = subfolder.Split(new string[] { "\\Songs\\" }, StringSplitOptions.None);
                foldername = spstring[1];   //foldername
                folderpath = subfolder;    //folderpath

                // diffpath //
                List<string> osufiles = new List<string>();
                string text = "";
                foreach (string file in Directory.GetFiles(subfolder))
                {
                    string[] spfile = file.Split(new string[] { foldername + "\\" }, StringSplitOptions.None);
                    text = spfile[1];

                    // filter files that end with ".osu" //
                    Regex r1 = new Regex(osuparam, RegexOptions.IgnoreCase);
                    Match m1 = r1.Match(text);
                    if (m1.Success)
                    {
                        osufiles.Add(file);
                    }
                }   //creates a list with the .osu files within the songs path
                if (osufiles.Count() > 0)
                {
                    diffpath = osufiles[0];
                }   //choses the 1st .osu file it encountered and sets it as diffpath

                // if C:\...\map.osu exists then
                if (diffpath != "")
                {
                    //  mp3name, mp3path, title, artist, imagepath //
                    int lineNumber = 0;
                    string[] lines = System.IO.File.ReadAllLines(diffpath); //takes .osu file and transform into an array of strings
                    while (!exitwhile)
                    {
                        string text1 = lines[lineNumber];

                        // mp3name, mp3path //
                        Regex r1 = new Regex(mp3nameparam, RegexOptions.IgnoreCase);
                        Match m1 = r1.Match(text1);
                        if (m1.Success)
                        {
                            mp3name = m1.Groups[1].Value;   //mp3name
                            mp3path = subfolder + "\\" + mp3name;   //mp3path
                        }

                        // title //
                        Regex r2 = new Regex(titleparam, RegexOptions.IgnoreCase);
                        Match m2 = r2.Match(text1);
                        if (m2.Success)
                        {
                            title = m2.Groups[1].Value; //title
                        }

                        // artist //
                        Regex r3 = new Regex(artistparam, RegexOptions.IgnoreCase);
                        Match m3 = r3.Match(text1);
                        if (m3.Success)
                        {
                            artist = m3.Groups[1].Value;    //artist
                        }

                        // image //
                        Regex r4 = new Regex(imageparam, RegexOptions.IgnoreCase);
                        Match m4 = r4.Match(text1);
                        if (m4.Success)
                        {
                            string imagename = m4.Groups[2].Value;
                            imagepath = subfolder + "\\" + imagename;   //imagepath
                        }

                        // exit loop //
                        if (text1 == "[TimingPoints]")
                        {
                            exitwhile = true;
                        }

                        lineNumber++;
                    } //filters out the variables using regex on each line

                    // skips songs that dont contain an .mp3 file //
                    if (mp3name != "")
                    {
                        //construct the object
                        song = new Song(folderpath, foldername, imagepath, mp3path, mp3name, diffpath, title, artist);
                        objectamount++;
                    }
                }
            }

            List<Song> songs = new List<Song>();

            foreach (Song song in songs)
            {
                Console.WriteLine(song);
            }

            printSubFolders();
        }   //
        private void printSubFolders()
        {
            //where the objets fron class song are drawn into the window
            //modifyMp3();
        }   //
        private void modifyMp3()
        {
            //foreach (string index in )
            //{
                //Copy the mp3
                System.IO.File.Copy("", targetPath, true);

                //Create Song Object
                var file = TagLib.File.Create("");

                //Applying the modifications
                file.Tag.Title = "";                                        //title
                file.Tag.AlbumArtists = "".Split(new char[] { ';' });       //Artist
                file.Tag.Album = "osu!";                                    //album

                //Save the mp3
                file.Save();
           // }
        }   //
        
        //Window functionalities
        private string seekFolder()
        {
            FolderBrowserDialog search = new FolderBrowserDialog();
            if (search.ShowDialog() == DialogResult.OK)
            {
                string outputVar = search.SelectedPath;
                return outputVar;
            } else { return ""; }
        }   //Browse... function for folder

        //debug
        private void buttonDebug_Click(object sender, EventArgs e)
        {
            //create a button named "buttonDebug"
            //replace sourcePath and targetPath with your own path [dont delete the @ or the "]

            sourcePath = @"C:\Users\Larcho\Documents\osu!\Songs";
            targetPath = @"C:\Users\Larcho\Desktop\Mp3Output";
            songClassConstructor();

            /*sourcePath = @"C:\...\osu!\Songs";
            targetPath = @"C:\...\Mp3output";
            songClassConstructor();*/
        }
    }
}
