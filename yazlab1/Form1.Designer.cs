namespace yazlab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainServer = new System.Windows.Forms.GroupBox();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.SubServer = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubServer6 = new System.Windows.Forms.GroupBox();
            this.circularProgressBar7 = new CircularProgressBar.CircularProgressBar();
            this.SubServer5 = new System.Windows.Forms.GroupBox();
            this.circularProgressBar6 = new CircularProgressBar.CircularProgressBar();
            this.SubServer4 = new System.Windows.Forms.GroupBox();
            this.circularProgressBar5 = new CircularProgressBar.CircularProgressBar();
            this.SubServer3 = new System.Windows.Forms.GroupBox();
            this.circularProgressBar4 = new CircularProgressBar.CircularProgressBar();
            this.SubServer2 = new System.Windows.Forms.GroupBox();
            this.circularProgressBar3 = new CircularProgressBar.CircularProgressBar();
            this.SubServer1 = new System.Windows.Forms.GroupBox();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.totalSubServer = new System.Windows.Forms.Label();
            this.totalRequest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalResponse = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totaltime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mainServerRequest = new System.Windows.Forms.TrackBar();
            this.subServerRequest = new System.Windows.Forms.TrackBar();
            this.subServerResponse = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.requestSize = new System.Windows.Forms.Label();
            this.mainResponseSize = new System.Windows.Forms.Label();
            this.subRequestSize = new System.Windows.Forms.Label();
            this.subResponseSize = new System.Windows.Forms.Label();
            this.subServerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainServerResponse = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.MainServer.SuspendLayout();
            this.SubServer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SubServer6.SuspendLayout();
            this.SubServer5.SuspendLayout();
            this.SubServer4.SuspendLayout();
            this.SubServer3.SuspendLayout();
            this.SubServer2.SuspendLayout();
            this.SubServer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainServerRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subServerRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subServerResponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subServerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainServerResponse)).BeginInit();
            this.SuspendLayout();
            // 
            // MainServer
            // 
            this.MainServer.Controls.Add(this.label2);
            this.MainServer.Controls.Add(this.mainServerResponse);
            this.MainServer.Controls.Add(this.mainResponseSize);
            this.MainServer.Controls.Add(this.requestSize);
            this.MainServer.Controls.Add(this.lab2);
            this.MainServer.Controls.Add(this.lab);
            this.MainServer.Controls.Add(this.label9);
            this.MainServer.Controls.Add(this.subServerResponse);
            this.MainServer.Controls.Add(this.subServerRequest);
            this.MainServer.Controls.Add(this.mainServerRequest);
            this.MainServer.Controls.Add(this.totaltime);
            this.MainServer.Controls.Add(this.label8);
            this.MainServer.Controls.Add(this.totalResponse);
            this.MainServer.Controls.Add(this.label6);
            this.MainServer.Controls.Add(this.totalRequest);
            this.MainServer.Controls.Add(this.label4);
            this.MainServer.Controls.Add(this.totalSubServer);
            this.MainServer.Controls.Add(this.label1);
            this.MainServer.Controls.Add(this.circularProgressBar1);
            this.MainServer.Location = new System.Drawing.Point(12, 12);
            this.MainServer.Name = "MainServer";
            this.MainServer.Size = new System.Drawing.Size(303, 511);
            this.MainServer.TabIndex = 0;
            this.MainServer.TabStop = false;
            this.MainServer.Text = "Main Server";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(6, 32);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Maximum = 10000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(291, 252);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 1;
            this.circularProgressBar1.Text = "0";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.Value = 68;
            // 
            // SubServer
            // 
            this.SubServer.Controls.Add(this.panel1);
            this.SubServer.Location = new System.Drawing.Point(333, 22);
            this.SubServer.Name = "SubServer";
            this.SubServer.Size = new System.Drawing.Size(558, 501);
            this.SubServer.TabIndex = 1;
            this.SubServer.TabStop = false;
            this.SubServer.Text = "Sub Server";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubServer6);
            this.panel1.Controls.Add(this.SubServer5);
            this.panel1.Controls.Add(this.SubServer4);
            this.panel1.Controls.Add(this.SubServer3);
            this.panel1.Controls.Add(this.SubServer2);
            this.panel1.Controls.Add(this.SubServer1);
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 482);
            this.panel1.TabIndex = 0;
            // 
            // SubServer6
            // 
            this.SubServer6.Controls.Add(this.circularProgressBar7);
            this.SubServer6.Location = new System.Drawing.Point(272, 332);
            this.SubServer6.Name = "SubServer6";
            this.SubServer6.Size = new System.Drawing.Size(237, 144);
            this.SubServer6.TabIndex = 5;
            this.SubServer6.TabStop = false;
            this.SubServer6.Text = "Sub Server #6";
            // 
            // circularProgressBar7
            // 
            this.circularProgressBar7.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar7.AnimationSpeed = 500;
            this.circularProgressBar7.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar7.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar7.InnerMargin = 2;
            this.circularProgressBar7.InnerWidth = -1;
            this.circularProgressBar7.Location = new System.Drawing.Point(0, 28);
            this.circularProgressBar7.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar7.Maximum = 5000;
            this.circularProgressBar7.Name = "circularProgressBar7";
            this.circularProgressBar7.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar7.OuterMargin = -25;
            this.circularProgressBar7.OuterWidth = 26;
            this.circularProgressBar7.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar7.ProgressWidth = 25;
            this.circularProgressBar7.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar7.Size = new System.Drawing.Size(118, 119);
            this.circularProgressBar7.StartAngle = 270;
            this.circularProgressBar7.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar7.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar7.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar7.SubscriptText = "";
            this.circularProgressBar7.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar7.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar7.SuperscriptText = "";
            this.circularProgressBar7.TabIndex = 6;
            this.circularProgressBar7.Text = "0";
            this.circularProgressBar7.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar7.Value = 68;
            // 
            // SubServer5
            // 
            this.SubServer5.Controls.Add(this.circularProgressBar6);
            this.SubServer5.Location = new System.Drawing.Point(6, 332);
            this.SubServer5.Name = "SubServer5";
            this.SubServer5.Size = new System.Drawing.Size(240, 144);
            this.SubServer5.TabIndex = 4;
            this.SubServer5.TabStop = false;
            this.SubServer5.Text = "Sub Server #5";
            // 
            // circularProgressBar6
            // 
            this.circularProgressBar6.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar6.AnimationSpeed = 500;
            this.circularProgressBar6.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar6.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar6.InnerMargin = 2;
            this.circularProgressBar6.InnerWidth = -1;
            this.circularProgressBar6.Location = new System.Drawing.Point(0, 25);
            this.circularProgressBar6.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar6.Maximum = 5000;
            this.circularProgressBar6.Name = "circularProgressBar6";
            this.circularProgressBar6.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar6.OuterMargin = -25;
            this.circularProgressBar6.OuterWidth = 26;
            this.circularProgressBar6.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar6.ProgressWidth = 25;
            this.circularProgressBar6.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar6.Size = new System.Drawing.Size(118, 119);
            this.circularProgressBar6.StartAngle = 270;
            this.circularProgressBar6.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar6.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar6.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar6.SubscriptText = "";
            this.circularProgressBar6.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar6.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar6.SuperscriptText = "";
            this.circularProgressBar6.TabIndex = 1;
            this.circularProgressBar6.Text = "0";
            this.circularProgressBar6.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar6.Value = 68;
            // 
            // SubServer4
            // 
            this.SubServer4.Controls.Add(this.circularProgressBar5);
            this.SubServer4.Location = new System.Drawing.Point(272, 167);
            this.SubServer4.Name = "SubServer4";
            this.SubServer4.Size = new System.Drawing.Size(237, 144);
            this.SubServer4.TabIndex = 3;
            this.SubServer4.TabStop = false;
            this.SubServer4.Text = "Sub Server #4";
            // 
            // circularProgressBar5
            // 
            this.circularProgressBar5.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar5.AnimationSpeed = 500;
            this.circularProgressBar5.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar5.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar5.InnerMargin = 2;
            this.circularProgressBar5.InnerWidth = -1;
            this.circularProgressBar5.Location = new System.Drawing.Point(0, 19);
            this.circularProgressBar5.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar5.Maximum = 5000;
            this.circularProgressBar5.Name = "circularProgressBar5";
            this.circularProgressBar5.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar5.OuterMargin = -25;
            this.circularProgressBar5.OuterWidth = 26;
            this.circularProgressBar5.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar5.ProgressWidth = 25;
            this.circularProgressBar5.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar5.Size = new System.Drawing.Size(118, 119);
            this.circularProgressBar5.StartAngle = 270;
            this.circularProgressBar5.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar5.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar5.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar5.SubscriptText = "";
            this.circularProgressBar5.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar5.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar5.SuperscriptText = "";
            this.circularProgressBar5.TabIndex = 7;
            this.circularProgressBar5.Text = "0";
            this.circularProgressBar5.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar5.Value = 68;
            // 
            // SubServer3
            // 
            this.SubServer3.Controls.Add(this.circularProgressBar4);
            this.SubServer3.Location = new System.Drawing.Point(6, 167);
            this.SubServer3.Name = "SubServer3";
            this.SubServer3.Size = new System.Drawing.Size(240, 144);
            this.SubServer3.TabIndex = 2;
            this.SubServer3.TabStop = false;
            this.SubServer3.Text = "Sub Server #3";
            // 
            // circularProgressBar4
            // 
            this.circularProgressBar4.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar4.AnimationSpeed = 500;
            this.circularProgressBar4.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar4.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar4.InnerMargin = 2;
            this.circularProgressBar4.InnerWidth = -1;
            this.circularProgressBar4.Location = new System.Drawing.Point(0, 19);
            this.circularProgressBar4.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar4.Maximum = 5000;
            this.circularProgressBar4.Name = "circularProgressBar4";
            this.circularProgressBar4.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar4.OuterMargin = -25;
            this.circularProgressBar4.OuterWidth = 26;
            this.circularProgressBar4.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar4.ProgressWidth = 25;
            this.circularProgressBar4.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar4.Size = new System.Drawing.Size(118, 119);
            this.circularProgressBar4.StartAngle = 270;
            this.circularProgressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar4.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar4.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar4.SubscriptText = "";
            this.circularProgressBar4.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar4.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar4.SuperscriptText = "";
            this.circularProgressBar4.TabIndex = 6;
            this.circularProgressBar4.Text = "0";
            this.circularProgressBar4.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar4.Value = 68;
            // 
            // SubServer2
            // 
            this.SubServer2.Controls.Add(this.circularProgressBar3);
            this.SubServer2.Location = new System.Drawing.Point(272, 3);
            this.SubServer2.Name = "SubServer2";
            this.SubServer2.Size = new System.Drawing.Size(240, 144);
            this.SubServer2.TabIndex = 1;
            this.SubServer2.TabStop = false;
            this.SubServer2.Text = "SubServer #2";
            // 
            // circularProgressBar3
            // 
            this.circularProgressBar3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar3.AnimationSpeed = 500;
            this.circularProgressBar3.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar3.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar3.InnerMargin = 2;
            this.circularProgressBar3.InnerWidth = -1;
            this.circularProgressBar3.Location = new System.Drawing.Point(0, 19);
            this.circularProgressBar3.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar3.Maximum = 5000;
            this.circularProgressBar3.Name = "circularProgressBar3";
            this.circularProgressBar3.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar3.OuterMargin = -25;
            this.circularProgressBar3.OuterWidth = 26;
            this.circularProgressBar3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar3.ProgressWidth = 25;
            this.circularProgressBar3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar3.Size = new System.Drawing.Size(118, 119);
            this.circularProgressBar3.StartAngle = 270;
            this.circularProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar3.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar3.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar3.SubscriptText = "";
            this.circularProgressBar3.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar3.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar3.SuperscriptText = "";
            this.circularProgressBar3.TabIndex = 1;
            this.circularProgressBar3.Text = "0";
            this.circularProgressBar3.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar3.Value = 68;
            // 
            // SubServer1
            // 
            this.SubServer1.Controls.Add(this.subResponseSize);
            this.SubServer1.Controls.Add(this.subRequestSize);
            this.SubServer1.Controls.Add(this.circularProgressBar2);
            this.SubServer1.Location = new System.Drawing.Point(6, 3);
            this.SubServer1.Name = "SubServer1";
            this.SubServer1.Size = new System.Drawing.Size(240, 144);
            this.SubServer1.TabIndex = 0;
            this.SubServer1.TabStop = false;
            this.SubServer1.Text = "Sub Server #1";
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar2.AnimationSpeed = 500;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar2.InnerMargin = 2;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.Location = new System.Drawing.Point(6, 19);
            this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar2.Maximum = 5000;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar2.OuterMargin = -25;
            this.circularProgressBar2.OuterWidth = 26;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar2.ProgressWidth = 25;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar2.Size = new System.Drawing.Size(118, 119);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar2.SubscriptText = "";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar2.SuperscriptText = "";
            this.circularProgressBar2.TabIndex = 0;
            this.circularProgressBar2.Text = "0";
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar2.Value = 68;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam Alt-Sunucu:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // totalSubServer
            // 
            this.totalSubServer.AutoSize = true;
            this.totalSubServer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSubServer.Location = new System.Drawing.Point(168, 292);
            this.totalSubServer.Name = "totalSubServer";
            this.totalSubServer.Size = new System.Drawing.Size(19, 21);
            this.totalSubServer.TabIndex = 3;
            this.totalSubServer.Text = "0";
            // 
            // totalRequest
            // 
            this.totalRequest.AutoSize = true;
            this.totalRequest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRequest.Location = new System.Drawing.Point(168, 337);
            this.totalRequest.Name = "totalRequest";
            this.totalRequest.Size = new System.Drawing.Size(19, 21);
            this.totalRequest.TabIndex = 5;
            this.totalRequest.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Toplam İstek: ";
            // 
            // totalResponse
            // 
            this.totalResponse.AutoSize = true;
            this.totalResponse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalResponse.Location = new System.Drawing.Point(168, 383);
            this.totalResponse.Name = "totalResponse";
            this.totalResponse.Size = new System.Drawing.Size(19, 21);
            this.totalResponse.TabIndex = 7;
            this.totalResponse.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Yanıtlanan İstek:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // totaltime
            // 
            this.totaltime.AutoSize = true;
            this.totaltime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltime.Location = new System.Drawing.Point(262, 326);
            this.totaltime.Name = "totaltime";
            this.totaltime.Size = new System.Drawing.Size(41, 21);
            this.totaltime.TabIndex = 9;
            this.totaltime.Text = "0 Sn";
            this.totaltime.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Geçen Süre:";
            // 
            // mainServerRequest
            // 
            this.mainServerRequest.LargeChange = 50;
            this.mainServerRequest.Location = new System.Drawing.Point(10, 418);
            this.mainServerRequest.Maximum = 1000;
            this.mainServerRequest.Name = "mainServerRequest";
            this.mainServerRequest.Size = new System.Drawing.Size(120, 45);
            this.mainServerRequest.TabIndex = 1000;
            this.mainServerRequest.Value = 500;
            // 
            // subServerRequest
            // 
            this.subServerRequest.LargeChange = 50;
            this.subServerRequest.Location = new System.Drawing.Point(10, 463);
            this.subServerRequest.Maximum = 1000;
            this.subServerRequest.Name = "subServerRequest";
            this.subServerRequest.Size = new System.Drawing.Size(120, 45);
            this.subServerRequest.TabIndex = 1001;
            this.subServerRequest.Value = 500;
            // 
            // subServerResponse
            // 
            this.subServerResponse.LargeChange = 50;
            this.subServerResponse.Location = new System.Drawing.Point(177, 460);
            this.subServerResponse.Maximum = 1000;
            this.subServerResponse.Name = "subServerResponse";
            this.subServerResponse.Size = new System.Drawing.Size(120, 45);
            this.subServerResponse.TabIndex = 1002;
            this.subServerResponse.Value = 500;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 1003;
            this.label9.Text = "Ana Sunucu İstek Alma";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(18, 494);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(111, 13);
            this.lab.TabIndex = 1004;
            this.lab.Text = "Alt Sunucu İstek Alma";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(167, 493);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(134, 13);
            this.lab2.TabIndex = 1005;
            this.lab2.Text = "Alt Sunucu İstek Yanıtlama";
            // 
            // requestSize
            // 
            this.requestSize.AutoSize = true;
            this.requestSize.Location = new System.Drawing.Point(17, 259);
            this.requestSize.Name = "requestSize";
            this.requestSize.Size = new System.Drawing.Size(41, 13);
            this.requestSize.TabIndex = 1006;
            this.requestSize.Text = "İstek al";
            // 
            // responseSize
            // 
            this.mainResponseSize.AutoSize = true;
            this.mainResponseSize.Location = new System.Drawing.Point(243, 259);
            this.mainResponseSize.Name = "responseSize";
            this.mainResponseSize.Size = new System.Drawing.Size(55, 13);
            this.mainResponseSize.TabIndex = 1007;
            this.mainResponseSize.Text = "İstek yanıt";
            // 
            // subRequestSize
            // 
            this.subRequestSize.AutoSize = true;
            this.subRequestSize.Location = new System.Drawing.Point(169, 19);
            this.subRequestSize.Name = "subRequestSize";
            this.subRequestSize.Size = new System.Drawing.Size(55, 13);
            this.subRequestSize.TabIndex = 1008;
            this.subRequestSize.Text = "İstek yanıt";
            // 
            // subResponseSize
            // 
            this.subResponseSize.AutoSize = true;
            this.subResponseSize.Location = new System.Drawing.Point(169, 100);
            this.subResponseSize.Name = "subResponseSize";
            this.subResponseSize.Size = new System.Drawing.Size(55, 13);
            this.subResponseSize.TabIndex = 1009;
            this.subResponseSize.Text = "İstek yanıt";
            // 
            // subServerBindingSource
            // 
            this.subServerBindingSource.DataSource = typeof(yazlab1.SubServer);
            // 
            // mainServerResponse
            // 
            this.mainServerResponse.LargeChange = 50;
            this.mainServerResponse.Location = new System.Drawing.Point(181, 418);
            this.mainServerResponse.Maximum = 1000;
            this.mainServerResponse.Name = "mainServerResponse";
            this.mainServerResponse.Size = new System.Drawing.Size(120, 45);
            this.mainServerResponse.TabIndex = 1008;
            this.mainServerResponse.Value = 500;
            this.mainServerResponse.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 1009;
            this.label2.Text = "Ana Sunucu İstek Yanıtlama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 535);
            this.Controls.Add(this.SubServer);
            this.Controls.Add(this.MainServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainServer.ResumeLayout(false);
            this.MainServer.PerformLayout();
            this.SubServer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.SubServer6.ResumeLayout(false);
            this.SubServer5.ResumeLayout(false);
            this.SubServer4.ResumeLayout(false);
            this.SubServer3.ResumeLayout(false);
            this.SubServer2.ResumeLayout(false);
            this.SubServer1.ResumeLayout(false);
            this.SubServer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainServerRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subServerRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subServerResponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subServerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainServerResponse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox MainServer;
        private System.Windows.Forms.GroupBox SubServer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox SubServer6;
        private System.Windows.Forms.GroupBox SubServer5;
        private System.Windows.Forms.GroupBox SubServer4;
        private System.Windows.Forms.GroupBox SubServer3;
        private System.Windows.Forms.GroupBox SubServer2;
        private System.Windows.Forms.GroupBox SubServer1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private CircularProgressBar.CircularProgressBar circularProgressBar7;
        private CircularProgressBar.CircularProgressBar circularProgressBar6;
        private CircularProgressBar.CircularProgressBar circularProgressBar5;
        private CircularProgressBar.CircularProgressBar circularProgressBar4;
        private CircularProgressBar.CircularProgressBar circularProgressBar3;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private System.Windows.Forms.BindingSource subServerBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label totalSubServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totaltime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalResponse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalRequest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar mainServerRequest;
        private System.Windows.Forms.Label mainResponseSize;
        private System.Windows.Forms.Label requestSize;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar subServerResponse;
        private System.Windows.Forms.TrackBar subServerRequest;
        private System.Windows.Forms.Label subResponseSize;
        private System.Windows.Forms.Label subRequestSize;
        private System.Windows.Forms.TrackBar mainServerResponse;
        private System.Windows.Forms.Label label2;
    }
}

