using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Laba_OS_VirtualMemory
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            int FaultFIFO = 0;
            int FaultLRU = 0;
            string[] FIFOElems = null;
            string[] LRUElems = null;
            string Text;
            FifoTextbox.Text = "";
            LruTextbox.Text = "";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string Filename = OpenFileDialog.FileName;
                try
                {
                    using (var Stream = new StreamReader(Filename, Encoding.UTF8))
                    {
                        Text = Stream.ReadToEnd();
                        YourDateTextbox.Text = "Your file:" + Environment.NewLine + Text + Environment.NewLine;
                        FIFOElems = new string[Text.Length];
                        LRUElems = new string[Text.Length];
                        FIFOElems = Text.Split(' ');
                        LRUElems = Text.Split(' ');
                    }
                    
                    for (int i = Decimal.ToInt32(FrameCount.Value); i != FIFOElems.Length; i++) 
                    {
                        bool PageFall = true;
                        for (int j = 0; j != Decimal.ToInt32(FrameCount.Value); j++)
                        {
                            FifoTextbox.Text += FIFOElems[j] + " ";
                            if (FIFOElems[j] == FIFOElems[i])
                            {
                                PageFall = false;
                            }
                        }
                        if (PageFall == false)
                        {
                            FifoTextbox.Text += Environment.NewLine + "No pagefaults found";
                        }
                        FifoTextbox.Text += Environment.NewLine;
                        if (PageFall == true)
                        {
                            FifoTextbox.Text += "Drop: " + FIFOElems[0] + "  Add:" + FIFOElems[i] + Environment.NewLine;
                            FaultFIFO++;
                            for (int k = 0; k < Decimal.ToInt32(FrameCount.Value)-1; k++)
                            {
                                FIFOElems[k] = FIFOElems[k+1];
                            }                       
                            FIFOElems[Decimal.ToInt32(FrameCount.Value) - 1] = FIFOElems[i];
                        }
                    }
                    for (int j = 0; j != Decimal.ToInt32(FrameCount.Value); j++)
                    {
                        FifoTextbox.Text += FIFOElems[j] + " ";
                    }
                    FifoTextbox.Text += Environment.NewLine + "All drops:  " + Convert.ToString(FaultFIFO);

                    for (int i = Decimal.ToInt32(FrameCount.Value); i != LRUElems.Length; i++) 
                    {
                        for (int j = 0; j != Decimal.ToInt32(FrameCount.Value); j++)
                        {
                            LruTextbox.Text += LRUElems[j] + " ";
                        }
                        bool PageFault = true;
                        for (int j = 0; j != Decimal.ToInt32(FrameCount.Value); j++)
                        {
                            if (LRUElems[j] == LRUElems[i])
                            {
                                PageFault = false;
                                for (int k = j; k != Decimal.ToInt32(FrameCount.Value)-1; k++)
                                {
                                    LRUElems[k] = LRUElems[k + 1];
                                }
                                LRUElems[Decimal.ToInt32(FrameCount.Value)-1] = LRUElems[i];
                            }
                        }
                        if (PageFault == false)
                        {
                            LruTextbox.Text += Environment.NewLine + "Move values";
                        }
                        LruTextbox.Text += Environment.NewLine;
                        if (PageFault == true)
                        {
                            LruTextbox.Text += "Drop: " + LRUElems[0] + "  Add:" + LRUElems[i] + Environment.NewLine;
                            FaultLRU++;
                            for (int k = 0; k < Decimal.ToInt32(FrameCount.Value) - 1; k++)
                            {
                                LRUElems[k] = LRUElems[k + 1];
                            }
                            LRUElems[Decimal.ToInt32(FrameCount.Value) - 1] = LRUElems[i];
                        }
                    }
                    for (int j = 0; j != Decimal.ToInt32(FrameCount.Value); j++)
                    {
                        LruTextbox.Text += LRUElems[j] + " ";
                    }
                    LruTextbox.Text += Environment.NewLine + "All drops:  " + Convert.ToString(FaultLRU);
                    YourDateTextbox.Text += "Drops in FIFO: " + Convert.ToString(FaultFIFO) + Environment.NewLine +
                       "Drops in LRU: " + Convert.ToString(FaultLRU) + Environment.NewLine;
                    if (FaultFIFO < FaultLRU)
                    {
                        YourDateTextbox.Text += "FIFO algorithm is better here.";
                    }
                    else
                    {
                        YourDateTextbox.Text += "LRU algorithm is better here.";
                    }
                }
                catch
                {
                    MessageBox.Show("Incorrect data");
                }

            }
            else
            {
                MessageBox.Show("Unable to read file");
            }
        }
  
    }
}
