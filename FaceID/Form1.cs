using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace FaceID
{
    public partial class Form1 : Form
    {
        static readonly CascadeClassifier getFace = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        static readonly CascadeClassifier getEyes = new CascadeClassifier("haarcascade_eye.xml");
        static readonly CascadeClassifier getBody = new CascadeClassifier("haarcascade_fullbody.xml");
        public Form1()
        {
            InitializeComponent();
        }

        private void faceDetect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileImage = new OpenFileDialog() { Multiselect = false, Filter = "JPEG|*.jpg" })
            {
                if (fileImage.ShowDialog() == DialogResult.OK)
                {
                    faceFrame.Image = Image.FromFile(fileImage.FileName);
                    Bitmap bitID = new Bitmap(faceFrame.Image);
                    Image<Bgr, byte> image = new Image<Bgr, byte>(bitID);
                    Rectangle[] rec = getFace.DetectMultiScale(image, 1.4, 0);
                    foreach(Rectangle rect in rec)
                    {
                        using(Graphics graphic = Graphics.FromImage(bitID))
                        {
                            using (Pen pen = new Pen(Color.Red, 5))
                            {
                                graphic.DrawRectangle(pen, rect);
                            }
                        }
                    }
                    faceFrame.Image = bitID;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileImage = new OpenFileDialog() { Multiselect = false, Filter = "JPEG|*.jpg" })
            {
                if (fileImage.ShowDialog() == DialogResult.OK)
                {
                    faceFrame.Image = Image.FromFile(fileImage.FileName);
                    Bitmap bitID = new Bitmap(faceFrame.Image);
                    Image<Bgr, byte> image = new Image<Bgr, byte>(bitID);
                    Rectangle[] rec = getEyes.DetectMultiScale(image, 1.4, 0);

                    foreach (Rectangle rect in rec)
                    {
                        using (Graphics graphic = Graphics.FromImage(bitID))
                        {
                            using (Pen pen = new Pen(Color.Red, 5))
                            {
                                graphic.DrawRectangle(pen, rect);
                            }
                        }
                    }
                    faceFrame.Image = bitID;
                }
            }
        }

        private void faceFrame_Click(object sender, EventArgs e)
        {

        }

        private void geyBody_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileImage = new OpenFileDialog() { Multiselect = false, Filter = "JPEG|*.jpg" })
            {
                if (fileImage.ShowDialog() == DialogResult.OK)
                {
                    faceFrame.Image = Image.FromFile(fileImage.FileName);
                    Bitmap bitID = new Bitmap(faceFrame.Image);
                    Image<Bgr, byte> image = new Image<Bgr, byte>(bitID);
                    Rectangle[] rec = getBody.DetectMultiScale(image, 1.4, 0);

                    foreach (Rectangle rect in rec)
                    {
                        using (Graphics graphic = Graphics.FromImage(bitID))
                        {
                            using (Pen pen = new Pen(Color.Red, 5))
                            {
                                graphic.DrawRectangle(pen, rect);
                            }
                        }
                    }
                    faceFrame.Image = bitID;
                }
            }
        }
    }
}
