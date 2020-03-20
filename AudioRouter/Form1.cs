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
        private int TSConnection1, TSConnection2;
        List<float> defaults;



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
            Console.WriteLine("Connections interrupted");

            
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
            //Console.WriteLine(ti.Read());
            
            
            if (!(ti.Read().Contains("error id=0 msg=ok")))
            {
                throw new Exception("Couldn't connect to TeamSpeak");
            } else
            {
                Console.WriteLine("Successfully connected to TeamSpeak!");
            }
            
            //Get all active TeamSpeak sessions. We'll only be using the first two, but we'll query anyway in case the user has closed tabs before.
            ti.WriteLine("serverconnectionhandlerlist");
            string serverconnectionhandler_result = ti.Read();
            List<int> conn = new List<int>();
            foreach(char c in serverconnectionhandler_result)
            {
                if(Char.GetNumericValue(c) > 0.0 )
                {
                    conn.Add((int)Char.GetNumericValue(c));
                }
            }
            TSConnection1 = conn[0];
            TSConnection2 = conn[1];
            //conn.ForEach(Console.WriteLine);

            //disabled until restore works
            //getDefaultVoiceMeeter();


        }

        //This will only backup Banana values, for now.
        private void getDefaultVoiceMeeter()
        {
            
            List<float> defaults = new List<float>();
            for(int faders = 0; faders < 5; faders++)
            {
               
                defaults.Add(vm.GetParam("Strip[" + faders + "].A1"));
                defaults.Add(vm.GetParam("Strip[" + faders + "].A2"));
                defaults.Add(vm.GetParam("Strip[" + faders + "].A3"));
                defaults.Add(vm.GetParam("Strip[" + faders + "].B1"));
                defaults.Add(vm.GetParam("Strip[" + faders + "].B2"));
                
                

            }
        }

        //Restores the VoiceMeeter Routing settings to the status quo. Not working as of now.
        private void restoreVoiceMeeter()
        {
            for (int faders = 0; faders < 5; faders++)
            {
                vm.SetParam("Strip[" + faders + "].A1", defaults[faders * 5 + 0]);
                vm.SetParam("Strip[" + faders + "].A2", defaults[faders * 5 + 1]);
                vm.SetParam("Strip[" + faders + "].A3", defaults[faders * 5 + 2]);
                vm.SetParam("Strip[" + faders + "].B1", defaults[faders * 5 + 3]);
                vm.SetParam("Strip[" + faders + "].B2", defaults[faders * 5 + 4]);
            }
        }

        //Set the commands that are passed on to VoiceMeeter, depending on which Version is used.
        private void setStrings(bool potato = false)
        {
            if(potato)
            {
                HWInput1_B2 = "Strip[0].B2";
                VirtualInput1_A1 = "Strip[5].A1";
                VirtualInput2_A1 = "Strip[6].A1";
            } else
            {
                HWInput1_B2 = "Strip[0].B2";
                VirtualInput1_A1 = "Strip[3].A1";
                VirtualInput2_A1 = "Strip[4].A1";
            }
        }

        //Since you normally don't need to change this (and doing so on accident can be fatal), it will be locked by default.
        private void cb_enableRadio_Version_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cB_enableRadio_Version.Checked)
            {
                cB_enableRadio_Version.Text = "Lock";
                gB_Version.Enabled = true;
            }
            else
            {
                cB_enableRadio_Version.Text = "Unlock";
                gB_Version.Enabled = false;
            }
        }

        //Toggle VoiceMeeter In / A1
        private void cB_Casters_RX_Headset_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_Casters_RX_Headset.Checked)
            {
                cB_Casters_RX_Headset.BackColor = Color.Green;
                this.vm.SetParam(VirtualInput1_A1, 1);
            } else
            {
                cB_Casters_RX_Headset.BackColor = Color.Red;
                this.vm.SetParam(VirtualInput1_A1, 0);
                
            }
        }

        //Toggle VoiceMeeter HWIn / B2 (or/and TS?) TODO
        private void cB_Casters_TX_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_Casters_TX.Checked)
            {
                cB_Casters_TX.BackColor = Color.Green;
                this.ti.WriteLine("use " + TSConnection1);
                this.ti.Read();
                this.ti.WriteLine("clientupdate client_input_muted=0");
                this.ti.Read();
                //this.vm.SetParam(HWInput1_B2, 1);
            }
            else
            {
                cB_Casters_TX.BackColor = Color.Red;
                this.ti.WriteLine("use " + TSConnection1);
                this.ti.Read();
                this.ti.WriteLine("clientupdate client_input_muted=1");
                this.ti.Read();
                //this.vm.SetParam(HWInput1_B2, 0);

            }
        }




        //Toggle VoiceMeeter Aux In / A1
        private void cB_Observers_RX_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_Observers_RX.Checked)
            {
                cB_Observers_RX.BackColor = Color.Green;
                this.vm.SetParam(VirtualInput2_A1, 1);
            }
            else
            {
                cB_Observers_RX.BackColor = Color.Red;
                this.vm.SetParam(VirtualInput2_A1, 0);

            }
        }

        //Toggle TS Mute for Connection 2
        private void cB_Observers_TX_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_Observers_TX.Checked)
            {
                cB_Observers_TX.BackColor = Color.Green;
                this.ti.WriteLine("use " + TSConnection2);
                this.ti.Read();
                this.ti.WriteLine("clientupdate client_input_muted=0");
                this.ti.Read();
            }
            else
            {
                cB_Observers_TX.BackColor = Color.Red;
                this.ti.WriteLine("use " + TSConnection2);
                this.ti.Read();
                this.ti.WriteLine("clientupdate client_input_muted=1");
                this.ti.Read();

            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }

   
}
