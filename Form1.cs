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



namespace ECE_501_Front_End
{
    public partial class Form1 : Form
    {
        private readonly BackgroundWorker worker;
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
            Device1.Checked = false;
            Device2.Checked = false;
            Device3.Checked = false;
            Device4.Checked = false;
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
        private void Device1_CheckedChanged(object sender, EventArgs e)
        {
            Command.Items.Clear();
            Command.Items.Add("Please Select a Command");
            Command.Items.Add("Device 1 Command A");
            Command.Items.Add("Device 1 Command B");
            Command.Text = "Please Select a Command";
        }

        private void Device2_CheckedChanged(object sender, EventArgs e)
        {
            Command.Items.Clear();
            Command.Items.Add("Please Select a Command");
            Command.Items.Add("Device 2 Command A");
            Command.Items.Add("Device 2 Command B");
            Command.Text = "Please Select a Command";
        }

        private void Device3_CheckedChanged(object sender, EventArgs e)
        {
            Command.Items.Clear();
            Command.Items.Add("Please Select a Command");
            Command.Items.Add("Device 3 Command A");
            Command.Items.Add("Device 3 Command B");
            Command.Text = "Please Select a Command";
        }
        private void Device4_CheckedChanged(object sender, EventArgs e)
        {
            Command.Items.Clear();
            Command.Items.Add("Please Select a Command");
            Command.Items.Add("Device 4 Command A");
            Command.Items.Add("Device 4 Command B");
            Command.Text = "Please Select a Command";
        }
        // Main chuck of the program, 
        // Run command found in Command combobox
        // Not very scalable however, find way to make more scalable
        private void Send_Click(object sender, EventArgs e)
        {
            switch (Command.Text)
            {
                case "Device 1 Command A":
                    {
                        writeOutput("1");
                        worker.RunWorkerAsync();
                        Send.Enabled = false;
                        break;
                    }
                case "Device 1 Command B":
                    {
                        writeOutput("2");
                        break;
                    }
                case "Device 2 Command A":
                    {
                        writeOutput("3");
                        break;
                    }
                case "Device 2 Command B":
                    {
                        writeOutput("4");
                        break;
                    }
                case "Device 3 Command A":
                    {
                        writeOutput("5");
                        break;
                    }
                case "Device 3 Command B":
                    {
                        writeOutput("6");
                        break;
                    }
                case "Device 4 Command A":
                    {
                        writeOutput("7");
                        break;
                    }
                case "Device 4 Command B":
                    {
                        writeOutput("8");
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
    }
}
