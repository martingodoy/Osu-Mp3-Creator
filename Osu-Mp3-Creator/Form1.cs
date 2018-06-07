using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
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
                //Console.WriteLine(subfolder);

                //split subfolder into folder name and full path











                Song song = new Song();
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
            file.Tag.Title = "";                                         //title
            file.Tag.AlbumArtists = "".Split(new char[] { ';' });       //Artist
            file.Tag.Album = "osu!";                                        //album

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

        //Not in use
        private void buttonDebug_Click(object sender, EventArgs e)
        {

        }
    }
}
