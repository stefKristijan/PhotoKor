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
        Image<Bgr, byte> forResetImage;
        Image<Gray, byte> outputGrayImage;

        Image<Gray, byte> grayscaleThumbnail;
        Image<Gray, byte> foggyThumbnail;
        Image<Bgr, byte> histoThumbnail;
        Image<Bgr, byte> autumnThumbnail;
        Image<Bgr, byte> sunnyThumbnail;
        Image<Bgr, byte> winterThumbnail;
        Image<Bgr, byte> normalThumbnail;
        Image<Bgr, byte> forestThumbnail;
        Image<Bgr, byte> summerThumbnail;

        enum Filter {Grayscale, Histogram, Foggy, Forest, Summer, Autumn, Sunny, Winter, Original};

        int currentFilter;


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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files(*.BMP; *.JPG; *.PNG)|*.BMP;*.JPG;*.PNG";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    inputImage = new Image<Bgr, byte>(ofd.FileName);
                    forResetImage = inputImage.Copy();
                    currentFilter = (int)Filter.Original;

                    ibPicture.Image = inputImage;
                    normalThumbnail = inputImage.Resize(90, 75, Emgu.CV.CvEnum.Inter.Linear);
                    Image<Gray, byte> thumbnailGrayColorImage = normalThumbnail.Convert<Gray, byte>();
                
                    btnOriginal.Image = normalThumbnail.Bitmap;
                    setGrayScaleThumbnail(thumbnailGrayColorImage);
                    setHistogramThumbnail(normalThumbnail);
                    setGreyHistogramThumbnail(thumbnailGrayColorImage);
                    setForestThumbnail(normalThumbnail);
                    setSummerThumbnail(normalThumbnail);
                    setAutumnThumbnail(normalThumbnail);
                    setSunnyThumbnail(normalThumbnail);
                    setWinterThumbnail(normalThumbnail);

                    editToolStripMenuItem.Visible = true;
                    saveToolStripMenuItem.Enabled = true;
                    panel4.Visible = true;
                    panel5.Visible = true;
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void setWinterThumbnail(Image<Bgr, byte> img)
        {
            winterThumbnail = img.Copy();
            CvInvoke.ApplyColorMap(img, winterThumbnail, Emgu.CV.CvEnum.ColorMapType.Winter);
            winter_btn.BackgroundImage = winterThumbnail.Bitmap;
        }

        private void setSunnyThumbnail(Image<Bgr, byte> img)
        {
            sunnyThumbnail = img.Copy();
            CvInvoke.ApplyColorMap(img, sunnyThumbnail, Emgu.CV.CvEnum.ColorMapType.Hot);
            sunny_btn.BackgroundImage = sunnyThumbnail.Bitmap;
        }

        private void setAutumnThumbnail(Image<Bgr, byte> img)
        {
            autumnThumbnail = img.Copy();
            CvInvoke.ApplyColorMap(img, autumnThumbnail, Emgu.CV.CvEnum.ColorMapType.Autumn);
            autumn_btn.BackgroundImage = autumnThumbnail.Bitmap;
        }

        private void setSummerThumbnail(Image<Bgr, byte> img)
        {
            summerThumbnail = img.Copy();
            CvInvoke.ApplyColorMap(img, summerThumbnail, Emgu.CV.CvEnum.ColorMapType.Summer);
            summer_btn.BackgroundImage = summerThumbnail.Bitmap;
        }

        private void setForestThumbnail(Image<Bgr, byte> img)
        {
            forestThumbnail = img.Copy();
            CvInvoke.CvtColor(img, forestThumbnail, Emgu.CV.CvEnum.ColorConversion.Bgr2Rgb);
            forest_btn.BackgroundImage = forestThumbnail.Bitmap;
        }

        private void setGreyHistogramThumbnail(Image<Gray, byte> imgGray)
        {
            foggyThumbnail = imgGray.Copy();
            foggyThumbnail._EqualizeHist();
            greyhisto_btn.BackgroundImage = foggyThumbnail.Bitmap;
        }

        private void setGrayScaleThumbnail(Image<Gray, byte> imgGray)
        {
            grayscaleThumbnail = imgGray.Copy();
            grayscale_btn.BackgroundImage = grayscaleThumbnail.Bitmap;
        }

        private void setHistogramThumbnail(Image<Bgr, byte> img)
        {
            histoThumbnail = img.Copy();
            histoThumbnail._EqualizeHist();
            histogram_btn.BackgroundImage = histoThumbnail.Bitmap;
        }

        private void enableDisableRGB(bool enabled)
        {
            tbRed.Enabled = enabled;
            tbBlue.Enabled = enabled;
            tbGreen.Enabled = enabled;
        }

        private Image<Bgr, byte> applyRGBandBrightness(Image<Bgr, byte> temp)
        {
            if (currentFilter != (int)Filter.Grayscale || currentFilter != (int)Filter.Foggy)
            {
                if (tbBrightness.Value > 50)
                    temp._GammaCorrect(((tbBrightness.Value * tbBrightness.Value / 50.0) / 50.0));
                else
                {
                    temp._GammaCorrect(((tbBrightness.Value) / 50.0));
                }
                temp[0] += tbBlue.Value;
                temp[1] += tbGreen.Value;
                temp[2] += tbRed.Value;
            }
            return temp;

        }

        private void grayscale_btn_Click(object sender, EventArgs e)
        {
            currentFilter = (int)Filter.Grayscale;
            applyAllSettings();

            enableDisableRGB(false);
        }

        private void setGrayscaleFilter()
        {
            outputGrayImage = applyRGBandBrightness(inputImage.Copy()).Convert<Gray, byte>();
            ibPicture.Image = outputGrayImage;
        }

        private void histogram_btn_Click(object sender, EventArgs e)
        {
            currentFilter = (int)Filter.Histogram;
            applyAllSettings();

            enableDisableRGB(true);
        }

        private Image<Bgr, byte> setHistogramFilter()
        {
            Image<Bgr, byte> temp = inputImage.Copy();
            temp._EqualizeHist();
            temp = applyRGBandBrightness(temp);
            return temp;

        }

        private void greyhisto_btn_Click(object sender, EventArgs e)
        {
            currentFilter = (int)Filter.Foggy;
            applyAllSettings();
            enableDisableRGB(false);
        }

        private void forest_btn_Click(object sender, EventArgs e)
        {

            currentFilter = (int)Filter.Forest;
            applyAllSettings();
            enableDisableRGB(true);
        }

        private Image<Bgr, byte> setForestFilter()
        {
            Image<Bgr, byte> returnImage = inputImage.Copy();

            CvInvoke.CvtColor(returnImage, returnImage, Emgu.CV.CvEnum.ColorConversion.Bgr2Rgb);
            returnImage = applyRGBandBrightness(returnImage.Copy());
            return returnImage;

        }

        private void summer_btn_Click(object sender, EventArgs e)
        {
            currentFilter = (int)Filter.Summer;
            applyAllSettings();

            enableDisableRGB(true);
        }

        private Image<Bgr, byte> setSummerFilter()
        {
            Image<Bgr, byte> returnImage = inputImage.Copy();
            CvInvoke.ApplyColorMap(returnImage, returnImage, Emgu.CV.CvEnum.ColorMapType.Summer);
            returnImage = applyRGBandBrightness(returnImage.Copy());
            return returnImage;

        }

        private void autumn_btn_Click(object sender, EventArgs e)
        {
            currentFilter = (int)Filter.Autumn;
            applyAllSettings();

            enableDisableRGB(true);
        }

        private Image<Bgr, byte> setAutumnFilter()
        {
            Image<Bgr, byte> returnImage = inputImage.Copy();
            CvInvoke.ApplyColorMap(returnImage, returnImage, Emgu.CV.CvEnum.ColorMapType.Autumn);
            returnImage = applyRGBandBrightness(returnImage.Copy());
            return returnImage;

        }

        private void sunny_btn_Click(object sender, EventArgs e)
        {
            currentFilter = (int)Filter.Sunny;
            applyAllSettings();

            enableDisableRGB(true);
        }

        private Image<Bgr, byte> setSunnyFilter()
        {
            Image<Bgr, byte> returnImage = inputImage.Copy();

            CvInvoke.ApplyColorMap(returnImage, returnImage, Emgu.CV.CvEnum.ColorMapType.Hot);
            returnImage = applyRGBandBrightness(returnImage.Copy());
            return returnImage;

        }
    
        private void winter_btn_Click(object sender, EventArgs e)
        {
            currentFilter = (int)Filter.Winter;
            applyAllSettings();

            enableDisableRGB(true);
        }

        private Image<Bgr, byte> setWinterFilter()
        {
            Image<Bgr, byte> returnImage = inputImage.Copy();

            CvInvoke.ApplyColorMap(returnImage, returnImage, Emgu.CV.CvEnum.ColorMapType.Winter);
            returnImage = applyRGBandBrightness(returnImage.Copy());
            return returnImage;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentFilter = (int)Filter.Original;
            applyAllSettings();

            enableDisableRGB(true);
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputImage = inputImage.Rotate(-90, new Bgr(255, 255, 255), false);
            applyAllSettings();
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputImage._Flip(Emgu.CV.CvEnum.FlipType.Vertical);
            applyAllSettings();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputImage._Flip(Emgu.CV.CvEnum.FlipType.Horizontal);
            applyAllSettings();
        }

        private void leftToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            inputImage = inputImage.Rotate(90, new Bgr(255, 255, 255), false);
            applyAllSettings();
        }

        private void tbBrightness_Scroll(object sender, EventArgs e)
        {
            applyAllSettings();
        }



        private void tbRGB_Scroll(object sender, EventArgs e)
        {
            applyAllSettings();
            
        }

        private void applyAllSettings()
        {
            if (currentFilter == (int)Filter.Grayscale || currentFilter == (int)Filter.Foggy)
            {
                /*Image<Gray, byte> grayTemp = inputImage.Copy().Convert<Gray, byte>();
                if (tbBrightness.Value > 50)
                    grayTemp._GammaCorrect(((tbBrightness.Value * tbBrightness.Value / 50.0) / 50.0));
                else
                {
                    grayTemp._GammaCorrect(((tbBrightness.Value) / 50.0));
                }*/
                switch (currentFilter)
                {
                    case (int)Filter.Grayscale:
                        setGrayscaleFilter();
                        break;
                    case (int)Filter.Foggy:
                        Image<Bgr, byte> temp = inputImage.Copy();
                        temp = applyRGBandBrightness(temp.Copy());
                        Image<Gray, byte> grayTemp = temp.Convert<Gray, byte>();
                        grayTemp._EqualizeHist();
                        if (tbBrightness.Value > 50)
                            grayTemp._GammaCorrect(((tbBrightness.Value * tbBrightness.Value / 50.0) / 50.0));
                        else
                        {
                            grayTemp._GammaCorrect(((tbBrightness.Value) / 50.0));
                        }
                        ibPicture.Image = grayTemp;
                        break;
                }
            }
            else
            {
                Image<Bgr, byte> brightnessImg = inputImage.Copy();
                switch (currentFilter)
                {
                    case (int)Filter.Autumn:
                        brightnessImg = setAutumnFilter();
                        break;
                    case (int)Filter.Forest:
                        brightnessImg = setForestFilter();
                        break;
                    case (int)Filter.Histogram:
                        brightnessImg = setHistogramFilter();
                        break;
                    case (int)Filter.Summer:
                        brightnessImg = setSummerFilter();
                        break;
                    case (int)Filter.Sunny:
                        brightnessImg = setSunnyFilter();
                        break;
                    case (int)Filter.Winter:
                        brightnessImg = setWinterFilter();
                        break;
                    case (int)Filter.Original:
                        brightnessImg[0] += tbBlue.Value;
                        brightnessImg[1] += tbGreen.Value;
                        brightnessImg[2] += tbRed.Value;
                        if (tbBrightness.Value > 50)
                            brightnessImg._GammaCorrect(((tbBrightness.Value * tbBrightness.Value / 50.0) / 50.0));
                        else
                        {
                            brightnessImg._GammaCorrect(((tbBrightness.Value) / 50.0));
                        }
                        break;
                }

                ibPicture.Image = brightnessImg;
            }
        }

        private void ibFlipHor_Click(object sender, EventArgs e)
        {
            inputImage._Flip(Emgu.CV.CvEnum.FlipType.Horizontal);
            applyAllSettings();
        }

        private void ibFlipVer_Click(object sender, EventArgs e)
        {
            inputImage._Flip(Emgu.CV.CvEnum.FlipType.Vertical);
            applyAllSettings();
        }

        private void ibRotateL_Click(object sender, EventArgs e)
        {
            inputImage=inputImage.Rotate(90, new Bgr(255, 255, 255), false);
            applyAllSettings();
        }

        private void ibRotateR_Click(object sender, EventArgs e)
        {
            inputImage = inputImage.Rotate(-90, new Bgr(255, 255, 255), false);
            applyAllSettings();
        }

        private void resetChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentFilter = (int)Filter.Original;
            inputImage = forResetImage.Copy();
            ibPicture.Image = inputImage;
            tbBlue.Value = 0;
            tbRed.Value = 0;
            tbGreen.Value = 0;
            tbBrightness.Value = 50;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveImage())
            {
                MessageBox.Show("Slika uspješno spremljena");
            }else
            {
                MessageBox.Show("Dogodila se pogreška pri spremanju slike");
            }
        }

        public bool saveImage()
        {
            SaveFileDialog SF = new SaveFileDialog();
            SF.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (SF.ShowDialog() == DialogResult.OK)
            {
                ibPicture.Image.Save(SF.FileName);
                return true;
            }
            else return false;

        }
    }
}
