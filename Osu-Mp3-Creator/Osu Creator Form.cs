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
                string osuparam = @".*\.osu";
                string mp3nameparam = @".*\.osu";
                string titleparam = @"AudioFilename\: (.*)\.mp3$";
                string artistparam = @".*\.osu";
                string imageparam = @".*\.osu";

                string diffpath = "";
                string foldername = "";
                string folderpath = "";

                bool noosufile = false;
                bool nomp3file = false;
                bool noimagefile = false;
                bool exitwhile = false;

                //// Set foldername, folderpath ////
                string[] spstring = subfolder.Split(new string[] { "\\Songs\\" }, StringSplitOptions.None);
                foldername = spstring[1];
                folderpath = subfolder;

                //// Set diffpath ////
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
                }//creates a list with the .osu files within the songs path
                if (osufiles.Count() > 0)
                {
                    diffpath = osufiles[0];
                }

                if (diffpath != "")
                {
                    //// Set mp3path, mp3name, artist, title ////
                    string[] lines = System.IO.File.ReadAllLines(diffpath);

                    int lineNumber = 0;
                    while (!exitwhile)
                    {
                        string text1 = lines[lineNumber];

                        // title //
                        Regex r1 = new Regex(titleparam, RegexOptions.IgnoreCase);
                        Match m1 = r1.Match(text1);
                        if (m1.Success)
                        {
                            string mp3name = m1.Groups[1].Value;
                            Console.WriteLine(mp3name);
                        }

                        /*
                        // artist //
                        Regex r2 = new Regex(titleparam, RegexOptions.IgnoreCase);
                        Match m2 = r2.Match(text1);
                        if (m2.Success)
                        {

                        }

                        // mp3name //
                        Regex r3 = new Regex(titleparam, RegexOptions.IgnoreCase);
                        Match m3 = r3.Match(text1);
                        if (m3.Success)
                        {

                        }

                        // image //
                        Regex r4 = new Regex(titleparam, RegexOptions.IgnoreCase);
                        Match m4 = r4.Match(text1);
                        if (m4.Success)
                        {

                        }*/

                        // exit loop//
                        if (text1 == "[TimingPoints]")
                        {
                            exitwhile = true;
                        }


                        lineNumber++;
                    }
                }

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
