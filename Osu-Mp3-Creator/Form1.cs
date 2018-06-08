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
        String targetPath = "";
        String sourcePath = "";

        public mainWindow()
        {
            InitializeComponent();
            textBoxBefore.Text = "Osu Songs folder";
            textBoxAfter.Text = "Folder in wich your mp3's go";
        }

        private void songClassConstructor()
        {
            foreach (string subfolder in Directory.GetDirectories(sourcePath))
            {
                //// Set foldername, folderpath ////
                string[] spstring = subfolder.Split(new string[] { "\\Songs\\" }, StringSplitOptions.None);

                string foldername = spstring[1];
                string folderpath = subfolder;

                //// Set diffpath ////
                bool noosufile = false;
                string diffpath = "";
                string patosu = @".*\.osu";
                List<string> osufiles = new List<string>();
                foreach (string file in Directory.GetFiles(subfolder))
                {
                    string[] spfile = file.Split(new string[] { foldername + "\\" }, StringSplitOptions.None);
                    string text = spfile[1];

                    //// filter .osu ////
                    Regex r1 = new Regex(patosu, RegexOptions.IgnoreCase);
                    Match m1 = r1.Match(text);
                    if (m1.Success)
                    {
                        osufiles.Add(file);
                    }
                }

                if (osufiles.Count > 0)
                {
                    diffpath = osufiles[0];
                }
                else noosufile = true;

                //// Set mp3path, mp3name, artist, title ////
                bool nomp3file = false;

                string[] lines = System.IO.File.ReadAllLines(diffpath);
                foreach (string line in lines)
                    Console.WriteLine(line);

                if (noosufile == false || nomp3file == false)
                {
                    //Song song = new Song();
                }
            }
            printSubFolders();
        }

        private void printSubFolders()
        {
            //where the objets fron class song are drawn into the window
        }

        private void modifyMp3()
        {
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
        }

        //Window triggers
        private void Examinar1_Click(object sender, EventArgs e)
        {
            sourcePath = seekFolder();
            textBoxBefore.Text = sourcePath;
            if (targetPath != "" && sourcePath != "")
            {
                songClassConstructor();
            }
        }
        private void Examinar2_Click(object sender, EventArgs e)
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

        //Window functionalities
        private String seekFolder()
        {
            FolderBrowserDialog search = new FolderBrowserDialog();
            if (search.ShowDialog() == DialogResult.OK)
            {
                String outputVar = search.SelectedPath;
                return outputVar;
            } else { return ""; }
        }
        private String seekFile()
            {
                OpenFileDialog search = new OpenFileDialog();
                if (search.ShowDialog() == DialogResult.OK)
                {
                    String outputVar = search.FileName;
                    return outputVar;
                }
                else
                {
                    return "";
                }
            }

        //Debugging
        private void buttonDebug_Click(object sender, EventArgs e)
        {
            sourcePath = "C:\\Users\\Larcho\\Documents\\osu!\\Songs";
            targetPath = "C:\\Users\\Larcho\\Desktop\\Test";
            songClassConstructor();
        }
    }
}
