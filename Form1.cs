using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;



namespace ECE_501_Front_End
{
    public partial class Form1 : Form
    {
        private readonly BackgroundWorker worker;
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        TcpClient client = new TcpClient();
        int port = 65432;

        public Form1()
        {
            InitializeComponent();

            // Testing with BackgroundWorker
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += StartCounting;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.WorkerSupportsCancellation = true;

        }
        public void localRecord()
        {
            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);
            writeOutput("Recording...\nClick in the Output Box and Press Space to stop and save...\n");
        }
        public void localPlay()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string audioPath = "";
            ofd.Title = "Select result.wav";
            ofd.Filter = "Wav files (result.wav)|result.wav";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                audioPath = ofd.FileName;
            }
            else
            {
                writeOutput("No file was selected...\n\n");
                return;
            }
            SoundPlayer player = new SoundPlayer(audioPath);
            player.PlaySync();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Command.Text = "Please Select a Command";
        }
        // Testing with BackgroundWorker
        private void StartCounting(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgWorker = (BackgroundWorker)sender;
            for (var i = 1; i <= 100; i++)
            {
                if(worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                bgWorker.ReportProgress(i);
                Thread.Sleep(1000);
            }
        }
        // Testing with BackgroundWorker
        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            writeOutput(e.ProgressPercentage.ToString() + "\n");
        }
        // Testing with BackgroundWorker
        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Send.Enabled = true;
        }

        // Clear all fields to start fresh
        private void Clear_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            localLoop.Checked = false;
            LED.Checked = false;
            Buzzer.Checked = false;
            Microphone.Checked = false;
            Command.Items.Clear();
            Command.Items.Add("Please Select a Device");
            Command.Text = "Please Select a Device";
            ipAddressBox.Text = "";
            ipAddressBox.BackColor = Color.White;
            connectivityBox.Text = "Check Connection";
            connectivityBox.BackColor = Color.White;
            worker.CancelAsync();

        }

        // Changing the List of Commands based upon the Device Selected
        private void localLoop_CheckedChanged(object sender, EventArgs e)
        {
            Command.Items.Clear();
            Command.Items.Add("Please Select a Command");
            Command.Items.Add("Locally Record Audio");
            Command.Items.Add("Locally Play Audio");
            Command.Text = "Please Select a Command";
        }

        private void LED_CheckedChanged(object sender, EventArgs e)
        {
            Command.Items.Clear();
            Command.Items.Add("Please Select a Command");
            Command.Items.Add("Turn On LED");
            Command.Items.Add("Turn Off LED");
            Command.Items.Add("Toggle LED");
            Command.Text = "Please Select a Command";
        }

        private void Buzzer_CheckedChanged(object sender, EventArgs e)
        {
            Command.Items.Clear();
            Command.Items.Add("Please Select a Command");
            Command.Items.Add("Turn On Buzzer");
            Command.Items.Add("Turn Off Buzzer");
            Command.Items.Add("Toggle Buzzer");
            Command.Text = "Please Select a Command";
        }
        private void Microphone_CheckedChanged(object sender, EventArgs e)
        {
            Command.Items.Clear();
            Command.Items.Add("Please Select a Command");
            Command.Items.Add("Record Audio");
            Command.Items.Add("Play Audio");
            Command.Text = "Please Select a Command";
        }
        // Main chuck of the program, 
        // Run command found in Command combobox
        // Not very scalable however, find way to make more scalable
        private void Send_Click(object sender, EventArgs e)
        {

            switch (Command.Text)
            {
                case "Locally Record Audio":
                    {
                        localRecord();
                        Send.Enabled = false;
                        break;
                    }
                case "Locally Play Audio":
                    {
                        writeOutput("Playing Previously Recorded sound...\n\n");
                        localPlay();
                        break;
                    }
                case "Turn On LED":
                    {
                        NetworkStream nwStream = client.GetStream();
                        byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(Command.Text);
                        writeOutput("Sending: " + Command.Text + "\n");
                        nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                        break;
                    }
                case "Turn Off LED":
                    {
                        NetworkStream nwStream = client.GetStream();
                        byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(Command.Text);
                        writeOutput("Sending: " + Command.Text + "\n");
                        nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                        break;
                    }
                case "Toggle LED":
                    {
                        NetworkStream nwStream = client.GetStream();
                        byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(Command.Text);
                        writeOutput("Sending: " + Command.Text + "\n");
                        nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                        break;
                    }
                case "Turn On Buzzer":
                    {
                        NetworkStream nwStream = client.GetStream();
                        byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(Command.Text);
                        writeOutput("Sending: " + Command.Text + "\n");
                        nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                        break;
                    }
                case "Turn Off Buzzer":
                    {
                        NetworkStream nwStream = client.GetStream();
                        byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(Command.Text);
                        writeOutput("Sending: " + Command.Text + "\n");
                        nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                        break;
                    }
                case "Toggle Buzzer":
                    {
                        NetworkStream nwStream = client.GetStream();
                        byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(Command.Text);
                        writeOutput("Sending: " + Command.Text + "\n");
                        nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                        break;
                    }
                case "Record Audio":
                    {
                        NetworkStream nwStream = client.GetStream();
                        byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(Command.Text);
                        writeOutput("Sending: " + Command.Text + "\n");
                        nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                        break;
                    }
                case "Play Audio":
                    {
                        NetworkStream nwStream = client.GetStream();
                        byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(Command.Text);
                        writeOutput("Sending: " + Command.Text + "\n");
                        nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                        ReadFile(nwStream);
                        break;
                    }

                default:
                    {
                        writeOutput("Please Select a Device and Command\n");
                        break;
                    }

            }    
        }
        // Send out a ping to the IPv4 address to see if it is reachable
        private void Ping_Click(object sender, EventArgs e)
        {
            // Make sure IP is a valid IPv4 address, if so Green, if not Red
            IPAddress ip;
            bool validIP = IPAddress.TryParse(ipAddressBox.Text, out ip);

            if (validIP)
            {
                ipAddressBox.BackColor = Color.LightGreen;
            }
            else
            {
                ipAddressBox.BackColor = Color.White;
                connectivityBox.Text = "Enter Valid IP Address";
                connectivityBox.BackColor = Color.Red;
                return;
            }

            // Send a ping out, update connectivityBox based on Ping Status
            Ping myPing = new Ping();
            PingReply reply = myPing.Send(ip, 1000);
            writeOutput("Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address + "\n");

            if (reply.Status == IPStatus.Success)
            {
                connectivityBox.Text = reply.Status.ToString();
                connectivityBox.BackColor = Color.LightGreen;
            }
            else
            {
                connectivityBox.Text = reply.Status.ToString();
                connectivityBox.BackColor = Color.Red;
            }
        }
        // Save text that's in the Output textbox to a .txt file
        private void Save_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            string logPath = "";
            fbd.Description = "Choose Location of Log";
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                 logPath = fbd.SelectedPath + "\\UMD.txt";
            }
            else
            {
                return;
            }
            TextWriter log = new StreamWriter(logPath);
            log.Write(outputBox.Text);
            log.Close();
            if (File.Exists(logPath))
            {
                writeOutput("Log saved to: " + logPath + "\n");
            }
        }

        // Write data to Output Box and scroll with new data 
        private void writeOutput(string data)
        {
            outputBox.AppendText(data);
            outputBox.SelectionStart = outputBox.Text.Length;
            outputBox.ScrollToCaret();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect(ipAddressBox.Text, port);
                connectivityBox.Text = "Connected!";
                connectivityBox.BackColor = Color.LightGreen;
            }
            catch 
            {
                connectivityBox.Text = "Can't Connect";
                connectivityBox.BackColor = Color.Red;
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            client.Close();
            connectivityBox.Text = "Disconnected!";
            connectivityBox.BackColor = Color.Red;
        }

        private void outputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            string audioPath = "";
            fbd.Description = "Choose Location of result.wav";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                audioPath = fbd.SelectedPath + "\\result.wav";
            }
            else
            {
                return;
            }
            writeOutput("Recording Saved to: " + audioPath + "\n\n");
            mciSendString("save recsound " + audioPath, "", 0, 0);
            mciSendString("close recsound ", "", 0, 0);
            Send.Enabled = true;
        }

        public void ReadFile(NetworkStream ns)
        {
            Int64 bytesReceived = 0;
            int count;
            var buffer = new byte[1024 * 8];
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            string audioPath = "";
            fbd.Description = "Choose Location of output.wav";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                audioPath = fbd.SelectedPath + "\\output.wav";
            }
            else
            {
                return;
            }
            // Read length - Int64
            ns.Read(buffer, 0, 8);
            Int64 numberOfBytes = BitConverter.ToInt64(buffer, 0);

            using (var fileIO = File.Create(audioPath))
                while (bytesReceived < numberOfBytes && (count = ns.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fileIO.Write(buffer, 0, count);
                    bytesReceived += count;
                }

            SoundPlayer player = new SoundPlayer(audioPath);
            player.PlaySync();
        }
    }
}
