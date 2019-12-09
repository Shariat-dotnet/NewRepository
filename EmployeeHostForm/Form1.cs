using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeHostForm
{
    public partial class Form1 : Form
    {
        private ServiceHost host;
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(EmployeeServiceRepository.EmployeeRepository));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (host.State == CommunicationState.Opened)
                {
                    host.Close();
                    button1.Text = "Start";
                    label1.Text = "Service stopped";
                }
                else if (host.State == CommunicationState.Created || host.State == CommunicationState.Closed)
                {
                    host.Open();
                    button1.Text = "Stop";
                    label1.Text = "Service Started";
                }
                else
                {
                    label1.Text = "Unknown service status";

                }
            }
            catch (Exception exception)
            {
                label1.Text = exception.Message;
            }
        }
    }
}
