using System;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using WK.Libraries.BetterFolderBrowserNS;

namespace FrameCoder
{
    public partial class VideoSplitter : Form
    {
        private VideoSplitConfig SplitConfig;
        private VideoCapture Cap;
        private string[] Frames;
        private int[] FrameNums;
        private readonly BackgroundWorker Worker = new BackgroundWorker();

        public VideoSplitter(string srcFile)
        {
            InitializeComponent();
            SplitConfig = new VideoSplitConfig(srcFile);

            // parse video properties (better use ffprobe?)
            Cap = new VideoCapture(SplitConfig.SourceFile);
            SplitConfig.SourceFrameCount = (int)Cap.GetCaptureProperty(CapProp.FrameCount);
            SplitConfig.SourceFPS = (int)Cap.GetCaptureProperty(CapProp.Fps);

            // update UI based on video properties
            startFrameControl.Maximum = new decimal(SplitConfig.SourceFrameCount);
            nFramesControl.Maximum = new decimal(SplitConfig.SourceFrameCount);
            Cap.SetCaptureProperty(CapProp.PosFrames, 0);
            FirstFrame.Image = Cap.QuerySmallFrame();

            // Init background worker for the conversion
            Worker.WorkerReportsProgress = true;
            Worker.WorkerSupportsCancellation = true;
            Worker.DoWork += Worker_DoWork;
            Worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        public class VideoSplitConfig
        {
            // User-specified settings
            public UserPreference UserPref { get; set; }
            public int UserStartFrame { get; set; }
            public int UserEndFrame { get; set; }
            public int UserTimeInterval { get; set; }
            public int UserFrameInterval { get; set; }
            public int UserNFrames { get; set; }
            public string UserTargetFolder { get; set; }

            // How to process the user settings to get frameidx
            public enum UserPreference
            {
                NFrames,
                TimeInterval,
                FrameInterval
            }

            // Source properties
            public string SourceFile { get; set; }
            public int SourceFrameCount { get; set; }
            public double SourceFPS { get; set; }

            // Other properties
            public string Format { get; set; }

            // constructor
            public VideoSplitConfig(string SourceFile)
            {
                Format = ".jpg";
                this.SourceFile = SourceFile;
            }

            // the magical method!
            public int[] GetFrameIDX()
            {
                // TODO
                return new int[] { 1, 2, 3, 4, 5 };
            }
        }


        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            GetFramesFromVideo();
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UseWaitCursor = false;
            Close();
        }

        public string GetFolder()
        {
            return SplitConfig.UserTargetFolder;
        }

        private void GetFramesFromVideo()
        {
            // TODO: work with SplitConfig.GetFrameIDX();
            Frames = new string[SplitConfig.UserNFrames];
            FrameNums = new int[SplitConfig.UserNFrames];
            int width = SplitConfig.SourceFrameCount.ToString().Length;
            int stride = (SplitConfig.SourceFrameCount - SplitConfig.UserStartFrame) / SplitConfig.UserNFrames;
            for (int i = 0; i < SplitConfig.UserNFrames; i++)
            {
                int framenum = i * stride + SplitConfig.UserStartFrame;
                Cap.SetCaptureProperty(CapProp.PosFrames, framenum);
                Mat frame = Cap.QueryFrame();
                LoadFrameInWindow(frame, SplitConfig.UserNFrames, i);
                if (SplitConfig.UserTargetFolder == null) break;
                string imagename = Path.Combine(
                    SplitConfig.UserTargetFolder,
                    (framenum + 1).ToString().PadLeft(width, "0"[0]) + SplitConfig.Format
                );
                Frames[i] = imagename;
                FrameNums[i] = framenum;
                frame.ToImage<Bgr, byte>().Save(imagename);
            }
        }

        private void LoadFrameInWindow(Mat frame, int totalFrames, int currentFrameNum)
        {
            SetFrameLabelText("Frame " + currentFrameNum + " of " + totalFrames + ".");
            LastFrame.Image = frame;
        }

        private delegate void SetFrameLabelTextCallback(string text);

        private void SetFrameLabelText(string text)
        {
            // pattern blatantly stolen from
            // https://stackoverflow.com/a/10775421/8311759
            if (currentFrameLabel.InvokeRequired)
            {
                SetFrameLabelTextCallback d = new SetFrameLabelTextCallback(SetFrameLabelText);
                Invoke(d, new object[] { text });
            }
            else
            {
                currentFrameLabel.Text = text;
            }
        }

        public static string PickVideoFile()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Video files (*.mov;*.avi;*.mp4;*.mkv)|*.mov;*.avi;*.mp4;*.mkv"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }
            else
            {
                return null;
            }
        }
        
        private void convertButton_Click(object sender, EventArgs e)
        {
            BetterFolderBrowser bfb = new BetterFolderBrowser
            {
                Multiselect = false,
                Title = "Subject folder"
            };
            if (bfb.ShowDialog() == DialogResult.OK)
            {
                // Update SplitConfig user settings
                // TODO: allow different settings
                SplitConfig.UserTargetFolder = bfb.SelectedPath;
                SplitConfig.UserPref = VideoSplitConfig.UserPreference.NFrames;
                SplitConfig.UserNFrames = (int)nFramesControl.Value;
                SplitConfig.UserStartFrame = (int)startFrameControl.Value - 1;
                // SplitConfig.UserEndFrame = (int)endFrameControl.Value - 1;
                // SplitConfig.UserFrameInterval = (int)frameIntervalControl.Value;
                // SplitConfig.UserTimeInterval = (int)timeIntervalControl.Value;

                // Do the conversion!
                UseWaitCursor = true;
                if (Worker.IsBusy)
                {
                    Worker.CancelAsync();
                }
                Worker.RunWorkerAsync();
            }
        }

        private void startFrameControl_ValueChanged(object sender, EventArgs e)
        {
            Cap.SetCaptureProperty(CapProp.PosFrames, (int)startFrameControl.Value - 1);
            FirstFrame.Image = Cap.QuerySmallFrame();
            int maxframes = SplitConfig.SourceFrameCount + 1 - (int)startFrameControl.Value;
            nFramesControl.Maximum = new decimal(maxframes);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (Worker.IsBusy)
            {
                Worker.CancelAsync();
            }
            SplitConfig.UserTargetFolder = null;
        }
    }
}
