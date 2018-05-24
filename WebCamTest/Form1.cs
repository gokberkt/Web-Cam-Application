using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebCamTest
{
    public partial class Form1 : Form
    {

        public static Bitmap _latestFrame;

        public Form1()
        {
            InitializeComponent();
        }

        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;
        Bitmap bitmap;

        private void Form1_Load(object sender, EventArgs e)
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                cmbDevices.Items.Add(VideoCaptureDevice.Name);

            }
            cmbDevices.SelectedIndex = 0;
        }


        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            bitmap = (Bitmap)eventArgs.Frame.Clone();

            pbImage.Image = bitmap;


        }

        private void btnStartCam_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[cmbDevices.SelectedIndex].MonikerString);

            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            cam.Start();
        }

        private void btnCapture_Click_1(object sender, EventArgs e)
        {
            Bitmap current = (Bitmap)bitmap.Clone();

            string filepath = "C:/Users/Gokberk/source/repos/WebCamTest/WebCamTest/Resources/";


            string imgname = DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Ticks.ToString();
            string newfoto = imgname + ".bmp";
            current.Save(filepath + newfoto);
        }
    }
}

