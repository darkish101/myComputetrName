using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerName_1._0._0._0
{
    public partial class My_Computer : Form
    {
        public My_Computer()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void Computer_Name_Load(object sender, EventArgs e)
        {
            Environment.CurrentDirectory = Environment.GetEnvironmentVariable("windir");
            DirectoryInfo info = new DirectoryInfo(".");

            lblOSName.Text = info.Name;
            lblUserName.Text = Environment.UserName;
            lblCompName.Text = Environment.MachineName;
            //var UDN = Environment.UserDomainName;
            lblIPaddress.Text = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
        }
    }
}
