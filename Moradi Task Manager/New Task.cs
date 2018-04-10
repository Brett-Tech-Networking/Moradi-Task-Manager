using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moradi_Task_Manager
{
    public partial class NewTask : MetroFramework.Forms.MetroForm
    {
        public NewTask()
        {
            InitializeComponent();
        }

        private void New_Task_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(metroTextBox1.Text))
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = metroTextBox1.Text;
                    proc.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
