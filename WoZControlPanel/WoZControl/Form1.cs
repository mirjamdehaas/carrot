using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

namespace WoZControl {
    public partial class Form1 : Form {
        private AsynchronousClient client;
        private Form form_new_child = null;
        private string lastIP = "127.0.0.1";
        private int currentstep = 0;
        private object currentlyLoadedMemory = null;
        private string mObject = "none";
        private bool robotbeh = false;
        private const string SESSION_DIR = "C:\\l2tor\\sessions\\";
        private const string MEMORIE_DIR = "C:\\l2tor\\memories";
        public Dictionary<String, Boolean> moduleStatus = new Dictionary<String, Boolean>();
        public List<string> memoryList = null;

        public Form1() {
            InitializeComponent();
        }

        public AsynchronousClient getTCP() {
            return client;
        }

        private void Form1_Load(object sender, EventArgs e) {
            client = new AsynchronousClient(); //client for TCP connection

            this.cmdIntro.Enabled = false;
        }

        private void BtnConnect_Click(object sender, EventArgs e) {
            lastIP = txtIP.Text;
            if (client.bConnected == true) //close active connections first
                client.CloseSocket();
            client.StartClient(System.Net.IPAddress.Parse(lastIP), this);
            if (client.bConnected == true) {
                //register the client
                System.Threading.Thread.Sleep(1000);
                client.Send("register:ControlPanel");
                btnConnect.Enabled = txtIP.Enabled = !client.bConnected;
                btnDisconnect.Enabled = btnVAD.Enabled = btn_kill_all_bhvs.Enabled = btnVADFalse.Enabled = btn_eng_1.Enabled = btn_eng_2.Enabled = btn_eng_3.Enabled = btn_eng_4.Enabled = cmdFinish.Enabled = cmdPause.Enabled = cmdResume.Enabled = btncrouch.Enabled = btnQi.Enabled = btnSay.Enabled = client.bConnected; 
            } else {
                btnConnect.Enabled = btnVAD.Enabled = btnVADFalse.Enabled = btn_kill_all_bhvs.Enabled = btn_eng_1.Enabled = btn_eng_2.Enabled = btn_eng_3.Enabled = btn_eng_4.Enabled = cmdIntro.Enabled = cmdFinish.Enabled = cmdPause.Enabled = cmdResume.Enabled = btncrouch.Enabled = btnQi.Enabled = btnSay.Enabled = client.bConnected;
                btnDisconnect.Enabled = txtIP.Enabled = !client.bConnected;
            }
        }

        public void updateReengageCounter(string counter) {
            this.Invoke((MethodInvoker)delegate {
                this.lblReengageCounter.Text = counter;
            });
        }

        private void cmdIntro_Click(object sender, EventArgs e) {
            if (txtChildName.Text != "") {
                Console.WriteLine(txtChildName.Text);
                client.Send("call:tablet.interactionmanager.start|" + txtChildName.Text);
                this.lblReengageCounter.Text = "0";
            } else {
                MessageBox.Show("Please insert a child-name!", "Error detected!", MessageBoxButtons.OK);
            }
        }

        private void cmdFinish_Click(object sender, EventArgs e) {
            client.Send("call:tablet.interactionmanager.exit");
        }

        private void btnDisconnect_Click(object sender, EventArgs e) {
            if (client.bConnected == true) {
                if (currentlyLoadedMemory != null && moduleStatus["interactionmanager"]) {
                    currentlyLoadedMemory = null;
                    txtChildName.Text = "";
                }
                cmdFinish.Enabled = btnVAD.Enabled = btn_kill_all_bhvs.Enabled = cmdPause.Enabled = cmdResume.Enabled = btnVAD.Enabled = btnVADFalse.Enabled = btn_eng_1.Enabled = btn_eng_2.Enabled = btn_eng_3.Enabled = btn_eng_4.Enabled = cmdIntro.Enabled = btncrouch.Enabled = btnQi.Enabled = btnSay.Enabled = false;
                txtIP.Enabled = true;
                client.Send("exit");
                client.CloseSocket();
                btnConnect.Enabled = !client.bConnected;
                btnDisconnect.Enabled = client.bConnected;
            }
        }

        private void btncrouch_Click(object sender, EventArgs e) {
            client.Send("call:nao.BehaviourM.crouch");
        }

        private void btnQi_Click(object sender, EventArgs e) {
            client.Send("call:nao.ALMotion.rest");
        }

        private void btnSay_Click(object sender, EventArgs e) {
            client.Send("call:tablet.outputmanager.say|" + txtSay.Text);
        }

        private void btnResetGaze_Click(object sender, EventArgs e) {
            client.Send("call:tablet.outputmanager.reset_gaze");
        }

        private void cmdPause_Click(object sender, EventArgs e) {
            client.Send("call:tablet.interactionmanager.pause");
        }

        private void cmdResume_Click(object sender, EventArgs e) {
            client.Send("call:tablet.interactionmanager.resume");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            client.Send("exit");
            client.CloseSocket();
            btnConnect.Enabled = !client.bConnected;
            btnDisconnect.Enabled = client.bConnected;
        }

        private void btnVAD_Click(object sender, EventArgs e) {
            client.Send("call:tablet.interactionmanager.vadFake");
        }

        private void btn_eng_1_Click(object sender, EventArgs e) {
            client.Send("call:tablet.interactionmanager.reengage|tired");
        }

        private void btn_eng_2_Click(object sender, EventArgs e) {
            client.Send("call:tablet.interactionmanager.reengage|activity");
        }

        private void btn_eng_3_Click(object sender, EventArgs e) {
            client.Send("call:tablet.interactionmanager.reengage|distractionLow");
        }

        private void btn_eng_4_Click(object sender, EventArgs e) {
            client.Send("call:tablet.interactionmanager.reengage|distractionHigh");
        }

        private void btnVADFalse_Click(object sender, EventArgs e) {
            client.Send("call:tablet.interactionmanager.vadFakeFalse");
        }

        private void btn_kill_all_bhvs_Click(object sender, EventArgs e) {
            client.Send("call:tablet.interactionmanager.stopAllBehaviors");
        }

        private void btnSync_Click(object sender, EventArgs e) {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("ping.wav");
            client.Send("call:tablet.interactionmanager.logPing|");
            player.Play();
            this.cmdIntro.Enabled = true;
        }
    }
}
