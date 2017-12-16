using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace PhotoKor
{
    public partial class Form1 : Form
    {

        Image<Bgr, byte> inputImage;
        Image<Gray, byte> outputGrayImage;
        Image<Bgr, byte> outputColorImage;
        Image<Bgr, byte> thumbnailNormalColorImage;
        Image<Gray, byte> thumbnailGrayColorImage;

        public Form1()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.Yellow; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Orange; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Yellow; }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    inputImage = new Image<Bgr, byte>(ofd.FileName);
                    ibPicture.Image = inputImage;
                    setGrayScaleThumbnail(inputImage);
                    setHistogramThumbnail(inputImage);
                    setGreyHistogramThumbnail(inputImage);
                    setForestThumbnail(inputImage);
                    setSummerThumbnail(inputImage);
                    setAutumnThumbnail(inputImage);
                    setSunnyThumbnail(inputImage);
                    setWinterThumbnail(inputImage);
                    setVerticalFlipThumbnail(inputImage);
                    setHorizontalFlipThumbnail(inputImage);
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void setVerticalFlipThumbnail(Image<Bgr, byte> inputImage)
        {
            thumbnailNormalColorImage = inputImage.Resize(90, 75, Emgu.CV.CvEnum.Inter.Linear); ;
            thumbnailNormalColorImage._Flip(Emgu.CV.CvEnum.FlipType.Vertical);
            vertical_flip_btn.BackgroundImage = thumbnailNormalColorImage.Bitmap;
        }

        private void setHorizontalFlipThumbnail(Image<Bgr, byte> inputImage)
        {
            thumbnailNormalColorImage = inputImage.Resize(90, 75, Emgu.CV.CvEnum.Inter.Linear); ;
            thumbnailNormalColorImage._Flip(Emgu.CV.CvEnum.FlipType.Horizontal);
            horizontal_flip_btn.BackgroundImage = thumbnailNormalColorImage.Bitmap;
        }

        private void setWinterThumbnail(Image<Bgr, byte> inputImage)
        {
            thumbnailNormalColorImage = inputImage.Resize(90, 75, Emgu.CV.CvEnum.Inter.Linear);
            CvInvoke.ApplyColorMap(thumbnailNormalColorImage, thumbnailNormalColorImage, Emgu.CV.CvEnum.ColorMapType.Winter);
            winter_btn.BackgroundImage = thumbnailNormalColorImage.Bitmap;
        }

        private void setSunnyThumbnail(Image<Bgr, byte> inputImage)
        {
            thumbnailNormalColorImage = inputImage.Resize(90, 75, Emgu.CV.CvEnum.Inter.Linear);
            CvInvoke.ApplyColorMap(thumbnailNormalColorImage, thumbnailNormalColorImage, Emgu.CV.CvEnum.ColorMapType.Hot);
            sunny_btn.BackgroundImage = thumbnailNormalColorImage.Bitmap;
        }

        private void setAutumnThumbnail(Image<Bgr, byte> inputImage)
        {
            thumbnailNormalColorImage = inputImage.Resize(90, 75, Emgu.CV.CvEnum.Inter.Linear);
            CvInvoke.ApplyColorMap(thumbnailNormalColorImage, thumbnailNormalColorImage, Emgu.CV.CvEnum.ColorMapType.Autumn);
            autumn_btn.BackgroundImage = thumbnailNormalColorImage.Bitmap;
        }

        private void setSummerThumbnail(Image<Bgr, byte> inputImage)
        {
            thumbnailNormalColorImage = inputImage.Resize(90, 75, Emgu.CV.CvEnum.Inter.Linear);
            CvInvoke.ApplyColorMap(thumbnailNormalColorImage, thumbnailNormalColorImage, Emgu.CV.CvEnum.ColorMapType.Summer);
            summer_btn.BackgroundImage = thumbnailNormalColorImage.Bitmap;
        }

        private void setForestThumbnail(Image<Bgr, byte> inputImage)
        {
            thumbnailNormalColorImage = inputImage.Resize(90, 75, Emgu.CV.CvEnum.Inter.Linear);
            CvInvoke.CvtColor(thumbnailNormalColorImage, thumbnailNormalColorImage, Emgu.CV.CvEnum.ColorConversion.Bgr2Rgb);
            forest_btn.BackgroundImage = thumbnailNormalColorImage.Bitmap;
        }

        private void setGreyHistogramThumbnail(Image<Bgr, byte> inputImage)
        {
            thumbnailGrayColorImage = new Image<Gray, byte>(inputImage.Width, inputImage.Height);
            thumbnailGrayColorImage = inputImage.Convert<Gray, byte>().Resize(90, 75, Emgu.CV.CvEnum.Inter.Linear);
            thumbnailGrayColorImage._EqualizeHist();
            greyhisto_btn.BackgroundImage = thumbnailGrayColorImage.Bitmap;
        }

        private void setGrayScaleThumbnail(Image<Bgr, byte> inputImage)
        {
            thumbnailGrayColorImage = new Image<Gray, byte>(inputImage.Width, inputImage.Height);
            thumbnailGrayColorImage = inputImage.Convert<Gray, byte>().Resize(90, 75, Emgu.CV.CvEnum.Inter.Linear);
            grayscale_btn.BackgroundImage = thumbnailGrayColorImage.Bitmap;
        }

        private void setHistogramThumbnail(Image<Bgr, byte> inputImage)
        {
            thumbnailNormalColorImage = inputImage.Resize(90, 75, Emgu.CV.CvEnum.Inter.Linear);
            thumbnailNormalColorImage._EqualizeHist();
            histogram_btn.BackgroundImage = thumbnailNormalColorImage.Bitmap;
        }

        private void grayscale_btn_Click(object sender, EventArgs e)
        {
            outputGrayImage = inputImage.Convert<Gray, byte>();
            ibPicture.Image = outputGrayImage; 
        }

        private void histogram_btn_Click(object sender, EventArgs e)
        {
            outputColorImage = inputImage;
            outputColorImage._EqualizeHist();
            ibPicture.Image = outputColorImage;
        }

        private void greyhisto_btn_Click(object sender, EventArgs e)
        {
            outputGrayImage = inputImage.Convert<Gray, byte>();
            outputGrayImage._EqualizeHist();
            ibPicture.Image = outputGrayImage;
        }

        private void forest_btn_Click(object sender, EventArgs e)
        {
            outputColorImage = inputImage;
            CvInvoke.CvtColor(inputImage, outputColorImage, Emgu.CV.CvEnum.ColorConversion.Bgr2Rgb);
            ibPicture.Image = outputColorImage;
        }

        private void summer_btn_Click(object sender, EventArgs e)
        {
            outputColorImage = inputImage;
            CvInvoke.ApplyColorMap(inputImage, outputColorImage, Emgu.CV.CvEnum.ColorMapType.Summer);
            ibPicture.Image = outputColorImage;
        }

        private void autumn_btn_Click(object sender, EventArgs e)
        {
            outputColorImage = inputImage;
            CvInvoke.ApplyColorMap(inputImage, outputColorImage, Emgu.CV.CvEnum.ColorMapType.Autumn);
            ibPicture.Image = outputColorImage;
        }

        private void sunny_btn_Click(object sender, EventArgs e)
        {
            outputColorImage = inputImage;
            CvInvoke.ApplyColorMap(inputImage, outputColorImage, Emgu.CV.CvEnum.ColorMapType.Hot);
            ibPicture.Image = outputColorImage;
        }

        private void winter_btn_Click(object sender, EventArgs e)
        {
            outputColorImage = inputImage;
            CvInvoke.ApplyColorMap(inputImage, outputColorImage, Emgu.CV.CvEnum.ColorMapType.Winter);
            ibPicture.Image = outputColorImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //smoothgausian = blur
            //gammacorrect posvijetli, potamni (<1 svjetlije >1 tamnije)
            //erode izgubi granicu
            //dilate isto ko erode, samo posvijetli
            outputColorImage = inputImage;
            outputColorImage._Flip(Emgu.CV.CvEnum.FlipType.Vertical);
            ibPicture.Image = outputColorImage;
        }

        private void vertical_flip_btn_Click(object sender, EventArgs e)
        {
            outputColorImage = inputImage;
            outputColorImage._Flip(Emgu.CV.CvEnum.FlipType.Vertical);
            ibPicture.Image = outputColorImage;
        }

        private void horizontal_flip_btn_Click(object sender, EventArgs e)
        {
            outputColorImage = inputImage;
            outputColorImage._Flip(Emgu.CV.CvEnum.FlipType.Horizontal);
            ibPicture.Image = outputColorImage;
        }
    }
}
