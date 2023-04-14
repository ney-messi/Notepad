using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Controls;
using AForge.Video;
using AForge.Video.DirectShow;
using VisioForge.Libs.NAudio.CoreAudioApi;
//using VisioForge.Shared.NAudio.CoreAudioApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace _230414
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
        }

        // 初始化
        public void init()
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            comboBox1.Items.Clear();
            label1.Text = "待检测";
            label2.Text = "待检测";
            textBox2.Text = "";
            textBox1.Text = "";
            isVideo = false;
            comboBox1.Text = "";
        }

        // 设置摄像头参数
        private FilterInfoCollection videoDevices;      // 采集所有摄像头
        public bool isVideo = false;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        // “扫描”按键代码

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isVideo)
            {
                //枚举视频输入设备
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                {
                    comboBox1.Text = "没有检测到视频设备！";
                    videoDevices = null;
                }
                foreach (FilterInfo device in videoDevices)
                {
                    comboBox1.Text = device.Name;
                    isVideo = true;
                }
                comboBox1.SelectedIndex = -1;
                if (isVideo)
                    button2.Enabled = true;
            }          
            button1.Enabled = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // “拍照”按键代码
                Bitmap img = videoSourcePlayer1.GetCurrentVideoFrame();//拍摄
            img.Save(string.Format("D://img.jpg"));
               MessageBox.Show("图片保存成功！");
            //img.Dispose();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // “连接”按键代码
                VideoCaptureDevice videoCapture = new VideoCaptureDevice(videoDevices[comboBox1.SelectedIndex+1].MonikerString);
                videoSourcePlayer1.VideoSource = videoCapture;
                videoSourcePlayer1.Start();
                button2.Enabled = false;
                button3.Enabled = true;
                button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 设置拍照关闭代码
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // “获取麦克风音”按键代码
                label1.Text = Convert.ToString(GetCurrentMicVolume());
        }


        private int GetCurrentMicVolume()
        {
            int volume = 0;
            var enumerator = new MMDeviceEnumerator();

            //获取音频输入设备
            IEnumerable<MMDevice> captureDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active).ToArray();
            if (captureDevices.Count() > 0)
            {
                MMDevice mMDevice = captureDevices.ToList()[0];
                volume = (int)(mMDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
            }
            return volume;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            // “设置麦克风音”按键代码
                string ret = "";
                try
                {
                    int volnum = Convert.ToInt16(textBox1.Text);
                    if (volnum > 100)
                        ret = "音量不能超过100";
                    else
                        ret = SetCurrentMicVolume(volnum);
                }
                catch { ret = "请输入合法数值!"; }
            
        }
        private string SetCurrentMicVolume(int volume)
        {
            var enumerator = new MMDeviceEnumerator();
            IEnumerable<MMDevice> captureDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active).ToArray();
            if (captureDevices.Count() > 0)
            {
                MMDevice mMDevice = captureDevices.ToList()[0];
                mMDevice.AudioEndpointVolume.MasterVolumeLevelScalar = volume / 100.0f;
            }
            return volume.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // “获取扬声器音”按键代码
            
                label2.Text = Convert.ToString( GetCurrentSpeakerVolume());
         }
        private int GetCurrentSpeakerVolume()
        {
            int volume = 0;
            var enumerator = new MMDeviceEnumerator();

            //获取音频输出设备
            IEnumerable<MMDevice> speakDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).ToArray();
            if (speakDevices.Count() > 0)
            {
                MMDevice mMDevice = speakDevices.ToList()[0];
                volume = Convert.ToInt16(mMDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
            }
            return volume;
        }

        private string SetCurrentSpeakerVolume(int volume)
            {
                string ret = "";
                var enumerator = new MMDeviceEnumerator();
                IEnumerable<MMDevice> speakDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).ToArray();
                if (speakDevices.Count() > 0)
                {

                    MMDevice mMDevice = speakDevices.ToList()[0];
                    mMDevice.AudioEndpointVolume.MasterVolumeLevelScalar = volume / 100.0f;
                    ret = "设置扬声器音量为[" + volume + "]成功！";
                }
                else
                    ret = "未检测到扬声器";
                return ret;
            }

        private void button8_Click(object sender, EventArgs e)
        {
            // “设置扬声器音”按键代码
           string ret = "";
               
           int volnum = Convert.ToInt16(textBox2.Text);
           if (volnum > 100)
              ret = "音量不能超过100";
           else
              ret = SetCurrentSpeakerVolume(volnum);
        }

        private void videoSourcePlayer1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
