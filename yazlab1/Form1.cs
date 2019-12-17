using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace yazlab1 {
    public partial class Form1 : Form {
        MainServer ms;

        public Form1() {
            CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
           

            circularProgressBars.Add(circularProgressBar2);

            circularProgressBars.Add(circularProgressBar3);

            circularProgressBars.Add(circularProgressBar4);

            circularProgressBars.Add(circularProgressBar5);

            circularProgressBars.Add(circularProgressBar6);

            circularProgressBars.Add(circularProgressBar7);

            circularProgressBar1.Value = 0;

            foreach (var bar in circularProgressBars) {
                bar.Value = 0;
            }


            ms = new MainServer(this);

        }

        public void resetCircle(int index)
        {

            circularProgressBars[index].Invoke((MethodInvoker)delegate {
                circularProgressBars[index].Value = 0;
                circularProgressBars[index].Text = 0 + "";
            });
        }


       public List<CircularProgressBar.CircularProgressBar> circularProgressBars = new List<CircularProgressBar.CircularProgressBar>();


        public void stateWatcher() {
          

            if (ms.start == false) {

                mainServerRequest.Value = ms.requestSize;
                subServerRequest.Value = ms.subServers[0].requestSize;
                subServerResponse.Value = ms.responseSize;
                mainServerResponse.Value = ms.responseSize;

                mainServerRequest.ValueChanged += new System.EventHandler(mainReqTrackBar_ValueChanged);
                mainServerResponse.ValueChanged += new System.EventHandler(mainServerResTrackBar_ValueChanged);

                subServerRequest.ValueChanged += new System.EventHandler(subReqTrackBar_ValueChanged);
                subServerResponse.ValueChanged += new System.EventHandler(subServerResTrackBar_ValueChanged);


                ms.start = true;
            }

        



            int msRequest = mainServerRequest.Value;
            int msResponse = mainServerResponse.Value;
            int subRequest = subServerRequest.Value;
            int subResponse = subServerResponse.Value;

            int totalRequest = ms.totalRequest;
            int totalResponse = ms.totalResponse;
            int totalSubserver = ms.subServers.Count;


            this.totalSubServer.Invoke((MethodInvoker)delegate {

                this.totalSubServer.Text = totalSubserver + "";
            });

            this.totalRequest.Invoke((MethodInvoker)delegate {

                this.totalRequest.Text = totalRequest + "";
            });

            this.totalResponse.Invoke((MethodInvoker)delegate {

                this.totalResponse.Text = totalResponse + "";
            });

            this.requestSize.Invoke((MethodInvoker)delegate {

                this.requestSize.Text = msRequest + "";
            });
            this.mainResponseSize.Invoke((MethodInvoker)delegate {

                this.mainResponseSize.Text = msResponse + "";
            });
            this.subRequestSize.Invoke((MethodInvoker)delegate {

                this.subRequestSize.Text = subRequest + "";
            });
            this.subResponseSize.Invoke((MethodInvoker)delegate {

                this.subResponseSize.Text = subResponse + "";
            });





            circularProgressBar1.Invoke((MethodInvoker)delegate {
                circularProgressBar1.Value = ms.CurrentCapacity;
                circularProgressBar1.Text = ms.CurrentCapacity + "";
            });
            int a = 0;
            for (int i = 0; i < ms.subServers.Count; i++) {
                a = i;
                var ss = ms.subServers[i];


                if (i < circularProgressBars.Count) {

                    circularProgressBars[i].Invoke((MethodInvoker)delegate {
                        circularProgressBars[i].Value = ss.CurrentCapacity;
                        circularProgressBars[i].Text = ss.CurrentCapacity + "";
                    });
                }


            }

            for(int i = a+1; i < circularProgressBars.Count; i++)
            {

                circularProgressBars[i].Invoke((MethodInvoker)delegate {
                    circularProgressBars[i].Value =0;
                    circularProgressBars[i].Text = 0 + "";
                });
            }

        }

        private void mainReqTrackBar_ValueChanged(object sender, System.EventArgs e) {

            ms.requestSize = mainServerRequest.Value;

        }
        private void mainServerResTrackBar_ValueChanged(object sender, System.EventArgs e) {

            ms.responseSize = mainServerResponse.Value;

        }
        private void subReqTrackBar_ValueChanged(object sender, System.EventArgs e) {



            ms.subServers.ForEach(s => {

                s.requestSize = subServerRequest.Value;

            });

        }

        private void subServerResTrackBar_ValueChanged(object sender, System.EventArgs e) {

            ms.subServers.ForEach(s => {

                s.responseSize = subServerResponse.Value;

            });

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {



            backgroundWorker1.ReportProgress(ms.CurrentCapacity);


        }

        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {

            circularProgressBar1.Value = e.ProgressPercentage;


        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void trackBar1_Scroll(object sender, EventArgs e) {

        }
    }
}
