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
        Image<Bgr, byte> withoutFiltersImage;
        Image<Bgr, byte> withoutRGBImage;
        Image<Bgr, byte> withoutBrightnessImage;


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
                    withoutFiltersImage = inputImage.Copy();
                    withoutRGBImage = inputImage.Copy();
                    withoutBrightnessImage = inputImage.Copy();
                    ibPicture.Image = inputImage;
                    Image<Bgr, byte> thumbnailNormalColorImage = inputImage.Resize(90, 75, Emgu.CV.CvEnum.Inter.Linear);
                    Image<Gray, byte> thumbnailGrayColorImage = thumbnailNormalColorImage.Convert<Gray, byte>();
                    //outputColorImage = inputImage;
                    btnOriginal.Image = thumbnailNormalColorImage.Bitmap;
                    setGrayScaleThumbnail(thumbnailGrayColorImage);
                    setHistogramThumbnail(thumbnailNormalColorImage);
                    setGreyHistogramThumbnail(thumbnailGrayColorImage);
                    setForestThumbnail(thumbnailNormalColorImage);
                    setSummerThumbnail(thumbnailNormalColorImage);
                    setAutumnThumbnail(thumbnailNormalColorImage);
                    setSunnyThumbnail(thumbnailNormalColorImage);
                    setWinterThumbnail(thumbnailNormalColorImage);
                    //setVerticalFlipThumbnail();
                    //setHorizontalFlipThumbnail();
                }
            }
            catch(Exception ex)
            {

            }
        }


        /*private void setVerticalFlipThumbnail()
        {
            thumbnailNormalColorImage = inputImage.Resize(90, 75, Emgu.CV.CvEnum.Inter.Linear); ;
            thumbnailNormalColorImage._Flip(Emgu.CV.CvEnum.FlipType.Vertical);
            vertical_flip_btn.BackgroundImage = thumbnailNormalColorImage.Bitmap;
        }

        private void setHorizontalFlipThumbnail()
        {
            thumbnailNormalColorImage = inputImage.Resize(90, 75, Emgu.CV.CvEnum.Inter.Linear); ;
            thumbnailNormalColorImage._Flip(Emgu.CV.CvEnum.FlipType.Horizontal);
            horizontal_flip_btn.BackgroundImage = thumbnailNormalColorImage.Bitmap;
        }*/

        private void setWinterThumbnail(Image<Bgr, byte> img)
        {
            Image<Bgr, byte> thumbnailNormalColorImage = img.Copy();
            CvInvoke.ApplyColorMap(img, thumbnailNormalColorImage, Emgu.CV.CvEnum.ColorMapType.Winter);
            winter_btn.BackgroundImage = thumbnailNormalColorImage.Bitmap;
        }

        private void setSunnyThumbnail(Image<Bgr, byte> img)
        {
            Image<Bgr, byte> thumbnailNormalColorImage = img.Copy();
            CvInvoke.ApplyColorMap(img, thumbnailNormalColorImage, Emgu.CV.CvEnum.ColorMapType.Hot);
            sunny_btn.BackgroundImage = thumbnailNormalColorImage.Bitmap;
        }

        private void setAutumnThumbnail(Image<Bgr, byte> img)
        {
            Image<Bgr, byte> thumbnailNormalColorImage = img.Copy();
            CvInvoke.ApplyColorMap(img, thumbnailNormalColorImage, Emgu.CV.CvEnum.ColorMapType.Autumn);
            autumn_btn.BackgroundImage = thumbnailNormalColorImage.Bitmap;
        }

        private void setSummerThumbnail(Image<Bgr, byte> img)
        {
            Image<Bgr, byte> thumbnailNormalColorImage = img.Copy();
            CvInvoke.ApplyColorMap(img, thumbnailNormalColorImage, Emgu.CV.CvEnum.ColorMapType.Summer);
            summer_btn.BackgroundImage = thumbnailNormalColorImage.Bitmap;
        }

        private void setForestThumbnail(Image<Bgr, byte> img)
        {
            Image<Bgr, byte> thumbnailNormalColorImage = img.Copy();
            CvInvoke.CvtColor(img, thumbnailNormalColorImage, Emgu.CV.CvEnum.ColorConversion.Bgr2Rgb);
            forest_btn.BackgroundImage = thumbnailNormalColorImage.Bitmap;
        }

        private void setGreyHistogramThumbnail(Image<Gray, byte> imgGray)
        {
            Image<Gray, byte> thumbnailGrayColorImage = imgGray.Copy();
            thumbnailGrayColorImage._EqualizeHist();
            greyhisto_btn.BackgroundImage = thumbnailGrayColorImage.Bitmap;
        }

        private void setGrayScaleThumbnail(Image<Gray, byte> imgGray)
        {
            Image<Gray, byte> thumbnailGrayColorImage = imgGray.Copy();
            grayscale_btn.BackgroundImage = thumbnailGrayColorImage.Bitmap;
        }

        private void setHistogramThumbnail(Image<Bgr, byte> img)
        {
            Image<Bgr, byte> thumbnailNormalColorImage = img.Copy();
            thumbnailNormalColorImage._EqualizeHist();
            histogram_btn.BackgroundImage = thumbnailNormalColorImage.Bitmap;
        }

        private void setFiltersImage(Image<Bgr, byte> histoTemp)
        {
            withoutRGBImage = histoTemp.Copy();
            withoutBrightnessImage = histoTemp.Copy();
        }

        private void grayscale_btn_Click(object sender, EventArgs e)
        {
            outputGrayImage = inputImage.Convert<Gray, byte>();
            ibPicture.Image = outputGrayImage; 
        }

        private void histogram_btn_Click(object sender, EventArgs e)
        {
            using (Image<Bgr, byte> histoTemp = withoutFiltersImage.Copy())
            {
                histoTemp._EqualizeHist();
                ibPicture.Image = histoTemp;
                outputColorImage = histoTemp.Copy();
                setFiltersImage(histoTemp);
            }
                
        }

        private void greyhisto_btn_Click(object sender, EventArgs e)
        {
            outputGrayImage = inputImage.Convert<Gray, byte>();
            outputGrayImage._EqualizeHist();
            ibPicture.Image = outputGrayImage;

        }

        private void forest_btn_Click(object sender, EventArgs e)
        {
            using (Image<Bgr, byte> forestTemp = withoutFiltersImage.Copy())
            {
                CvInvoke.CvtColor(withoutFiltersImage, forestTemp, Emgu.CV.CvEnum.ColorConversion.Bgr2Rgb);
                ibPicture.Image = forestTemp;
                setFiltersImage(forestTemp);
            }
        }

        private void summer_btn_Click(object sender, EventArgs e)
        {
            using (Image<Bgr, byte> summerTemp = withoutFiltersImage.Copy())
            {
                CvInvoke.ApplyColorMap(withoutFiltersImage, summerTemp, Emgu.CV.CvEnum.ColorMapType.Summer);
                ibPicture.Image = summerTemp;
                setFiltersImage(summerTemp);
            }
        }

        private void autumn_btn_Click(object sender, EventArgs e)
        {
            using (Image<Bgr, byte> autmnTemp = withoutFiltersImage.Copy())
            {
                CvInvoke.ApplyColorMap(withoutFiltersImage, autmnTemp, Emgu.CV.CvEnum.ColorMapType.Autumn);
                ibPicture.Image = autmnTemp;
                setFiltersImage(autmnTemp);
            }
        }

        private void sunny_btn_Click(object sender, EventArgs e)
        {
            using (Image<Bgr, byte> sunnyTemp = withoutFiltersImage.Copy())
            {
                CvInvoke.ApplyColorMap(withoutFiltersImage, sunnyTemp, Emgu.CV.CvEnum.ColorMapType.Hot);
                ibPicture.Image = sunnyTemp;
                setFiltersImage(sunnyTemp);
            }
        }

        private void winter_btn_Click(object sender, EventArgs e)
        {
            using (Image<Bgr, byte> winterTemp = withoutFiltersImage.Copy())
            {
                CvInvoke.ApplyColorMap(withoutFiltersImage, winterTemp, Emgu.CV.CvEnum.ColorMapType.Winter);
                ibPicture.Image = winterTemp;
                setFiltersImage(winterTemp);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ibPicture.Image = withoutFiltersImage;
            outputColorImage = withoutFiltersImage.Copy();
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputColorImage=outputColorImage.Rotate(-90, new Bgr(255, 255, 255),false);
            ibPicture.Image = outputColorImage;
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputColorImage._Flip(Emgu.CV.CvEnum.FlipType.Vertical);
            ibPicture.Image = outputColorImage;
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputColorImage._Flip(Emgu.CV.CvEnum.FlipType.Horizontal);
            ibPicture.Image = outputColorImage;
        }

        private void leftToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            outputColorImage = outputColorImage.Rotate(90, new Bgr(255,255,255),false);
            ibPicture.Image = outputColorImage;
        }

        private void tbBrightness_Scroll(object sender, EventArgs e)
        {
            using (Image<Bgr, byte> brightnessImg = withoutBrightnessImage.Copy())
            {
                if (tbBrightness.Value > 50)
                    brightnessImg._GammaCorrect(((tbBrightness.Value * tbBrightness.Value/50.0) / 50.0));
                else
                {
                    brightnessImg._GammaCorrect(((tbBrightness.Value) / 50.0));
                }
                ibPicture.Image = brightnessImg;
                setWithBrightness(brightnessImg);
            }
              
        }

        private void setWithBrightness(Image<Bgr, byte> brightnessImg)
        {
            withoutFiltersImage = brightnessImg.Copy();
            withoutRGBImage = brightnessImg.Copy();
        }

        private void tbRGB_Scroll(object sender, EventArgs e)
        {
            using (Image<Bgr, byte> temp = withoutRGBImage.Copy())
            {
                temp[0] += tbBlue.Value;
                temp[1] += tbGreen.Value;
                temp[2] += tbRed.Value;

                ibPicture.Image = temp;
                setWithRGB(temp);
            }
        }

        private void setWithRGB(Image<Bgr, byte> temp)
        {
            withoutFiltersImage = temp.Copy();
            withoutBrightnessImage = temp.Copy();
        }
    }
}
