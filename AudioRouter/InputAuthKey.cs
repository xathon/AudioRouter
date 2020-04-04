using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioRouter
{
    public partial class InputAuthKey : Form
    {
        public InputAuthKey()
        {
            InitializeComponent();
            string key = "";
            try
            {
                key = File.ReadAllText(String.Format(@"{0}\TS_API_key", Application.StartupPath));
            } catch
            {

            }
            tB_TSKey.Text = key;
        }

        private void tB_TSKey_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Submit_Click(this, new EventArgs());
            }
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string fileName = String.Format(@"{0}\TS_API_key", Application.StartupPath);
            Console.WriteLine(fileName);

           
            File.WriteAllText(fileName, tB_TSKey.Text);
            MessageBox.Show("Saved API Key!", "",MessageBoxButtons.OK);
            this.Visible = false;
            this.Close();
        }
    }
}
