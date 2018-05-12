using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;


namespace Moradi_Task_Manager
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process[] proc;

        void GetAllProcess()
        {

            dataGridView1.Rows.Clear();
            Process[] processes = Process.GetProcesses();

            for (int i = 0; i < processes.Length; ++i)
            {

                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["processName"].Value = processes[i].ProcessName + ".exe";
                dataGridView1.Rows[i].Cells["processID"].Value = processes[i].Id;
                dataGridView1.Rows[i].Cells["MemorySize"].Value = processes[i].VirtualMemorySize64;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CpuRamTimer.Start();

            faderLabel1.Text = "PC Name: " + SystemInformation.ComputerName;
            faderLabel2.Text = "User Name: " + SystemInformation.UserName;
            faderLabel3.Text = "Boot Mode: " + SystemInformation.BootMode;
            faderLabel4.Text = "User Domain: " + SystemInformation.UserDomainName;
            faderLabel5.Text = "Network Connection: " + SystemInformation.Network;
            faderLabel6.Text = "Mouse Speed: " + SystemInformation.MouseSpeed;

            
       
        }

        private void TaskmgrTimer_Tick(object sender, EventArgs e)
        {
            GetAllProcess();
            TaskmgrTimer.Stop();

        }

        private void metroTextBox1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CpuRamTimer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            metroProgressBar1.Value = (int)fcpu;
            metroProgressBar2.Value = (int)fram;
            metroLabel4.Text = string.Format("{0:0.00}%", fcpu);
            metroLabel5.Text = string.Format("{0:0.00}%", fram);
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] _proceses = null;
                _proceses = Process.GetProcessesByName(metroTextBox1.Text);
                foreach (Process proces in _proceses)
                {
                    proces.Kill();
                }
                MessageBox.Show("The Task " + metroTextBox1.Text + " Has Been Killed Successfuly", "Killed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroTextBox1.Clear();
                
            }
            catch
            {
                MessageBox.Show("Cannot Kill Task", "CANNOT KILL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SysInfo1_Tick(object sender, EventArgs e)
        {
            
        }

        private void SysInfoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sysinfotimer_Tick(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewTask nt = new NewTask();
            nt.Show();

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {            
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_BalloonTipShown(object sender, EventArgs e)
        {
            
            }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(100, "Moradi Task Manager", "Minimized", ToolTipIcon.Info);
            }
        }

        private void sizeNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Show();
            }
            catch
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            
        }
    }
}


