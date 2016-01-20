using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ServiceReference1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
                bool querySql = true;
                client.querySql(out querySql);

                client.Close();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
