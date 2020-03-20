using MinimalisticTelnet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoiceMeeterWrapper;


namespace AudioRouter
{
    public partial class Form1 : Form
    {
        private VmClient vm;
        private TelnetConnection ti;
        private String HWInput1_B2, VirtualInput1_A1, VirtualInput2_A1,TS_API_KEY;
        


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            //Closing the VoiceMeeter remote connection
            vm.Dispose();
            //Closing the Telnet TeamSpeak connection
            ti.Write("quit");
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //defaulting to Banana
            setStrings();
            vm = new VmClient();
            ti = new TelnetConnection("localhost", 25639);
            //hardcoding for now
            TS_API_KEY = "TJP8-5MKV-B1DG-HWM2-3X6Z-Q99B";
            ti.WriteLine("auth apikey="+TS_API_KEY);
            Console.WriteLine(ti.Read());
            
            
            if (!(ti.Read().Contains("error id=0 msg=ok")))
            {
                throw new Exception("Couldn't connect to TeamSpeak");
            } else
            {
                Console.WriteLine("Erfolgreich mit TeamSpeak verbunden!");
            }
            
        }

        //Set the commands that are passed on to VoiceMeeter, depending on which Version is used.
        private void setStrings(bool potato = false)
        {
            if(potato)
            {
                HWInput1_B2 = "Strip[0].B2";
                VirtualInput1_A1 = "Strip[5].B2";
                VirtualInput2_A1 = "Strip[6].B2";
            } else
            {
                HWInput1_B2 = "Strip[0].B2";
                VirtualInput1_A1 = "Strip[3].B2";
                VirtualInput2_A1 = "Strip[4].B2";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                
                this.vm.SetParam("Strip[0].A1", 1);
            } else
            {
                this.vm.SetParam("Strip[0].A1", 0);
                
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }

   
}
