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
        String targetPath;
        String sourceFile;

        public mainWindow()
        {
            InitializeComponent();
        }

        //Copy mp3 file and cropped png to target path
        private void Confirmar_Click(object sender, EventArgs e)
        {
            //hardcoded
            String pngName = "bg.png";
            String pngFolder = "C:\\Users\\Larcho\\Documents\\osu!\\Songs\\3mplify - Dead to Me\\bg.png";
            //hardcoded




            int i = -1;

            //Outputs penultimate index value of the array created by slpitting sourceFile path by '\'
            String fileValue = sourceFile;
            string[] substrings = fileValue.Split(new string[] { "\\" }, StringSplitOptions.None);
            foreach (var substring in substrings)
            {
                i++;
            }

            //Creating a folder on the target path if necessary
            String folderName = substrings[i - 1];
            String fullTargetPath = targetPath + '\\' + folderName;
            Directory.CreateDirectory(fullTargetPath);

            //Copy the mp3 file
            String mp3File = substrings[i];
            String fullDestFileMp3 = targetPath + '\\' + folderName + '\\' + mp3File;
            System.IO.File.Copy(sourceFile, fullDestFileMp3, true);

            //Copy and resize the png file
            String fullDestFilePng = targetPath + '\\' + folderName + '\\' + pngName;

            //resize thumbnail
            Bitmap portraitBmp = new Bitmap(pngFolder);
            portraitBmp = ResizeImage(portraitBmp, 300, 168);
            
            //combine square with thumbnail
            Bitmap finalImage = new Bitmap(300, 300);
            using (Graphics g = Graphics.FromImage(finalImage))
            {
                g.Clear(Color.White);
                g.DrawImage(portraitBmp, new Rectangle(0, 66, portraitBmp.Width, portraitBmp.Height));
            }

            //save bmp as png
            finalImage.Save(fullDestFilePng);

            //modify the mp3
            modifyMp3(fullDestFileMp3, fullDestFilePng);
        }

        //Modify the previously copied Mp3
        private void modifyMp3(String fullDestFileMp3, String fullDestFilePng)
        {
            //Create Song Object
            var file = TagLib.File.Create(fullDestFileMp3);

            //Setting variables for the mods (hardcoded for now)
            String title = "My own song";
            String artist = "im the artist";
            String picturePath = fullDestFilePng;

            //Applying the modifications
            file.Tag.Title = title;                                         //title
            file.Tag.Album = "osu!";                                        //album
            file.Tag.Performers = artist.Split(new char[] { '&' });         //artist

            List<Picture> pics = new List<Picture>();                       //picture
            if (!string.IsNullOrEmpty(picturePath))
            {
                foreach (string path in picturePath.Split(new char[] { ';' }))
                {
                    pics.Add(new Picture(path));
                }
                file.Tag.Pictures = pics.ToArray();
            }

            //Save the mp3
            file.Save();
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        //Visual Window Stuff
        private void Examinar1_Click(object sender, EventArgs e)
        {
            sourceFile = seekFile();
            textBoxBefore.Text = sourceFile;
        }

        private void Examinar2_Click(object sender, EventArgs e)
        {
            targetPath = seekFolder();
            textBoxAfter.Text = targetPath;
        }

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
    }
}
