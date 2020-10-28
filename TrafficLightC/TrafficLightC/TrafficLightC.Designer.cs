namespace TrafficLightC
{
    partial class TrafficLightC
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
            this.trafficLight = new System.Windows.Forms.TabControl();
            this.client = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hNyala = new System.Windows.Forms.RadioButton();
            this.hMati = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kNyala = new System.Windows.Forms.RadioButton();
            this.kMati = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mNyala = new System.Windows.Forms.RadioButton();
            this.mMati = new System.Windows.Forms.RadioButton();
            this.txtIPClient = new System.Windows.Forms.TextBox();
            this.txtPortClient = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.panelHIjau = new System.Windows.Forms.Panel();
            this.panelKuning = new System.Windows.Forms.Panel();
            this.panelMerah = new System.Windows.Forms.Panel();
            this.bListen = new System.Windows.Forms.Button();
            this.txtWarna = new System.Windows.Forms.TextBox();
            this.txtIPServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPortServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trafficLight.SuspendLayout();
            this.client.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.server.SuspendLayout();
            this.SuspendLayout();
            // 
            // trafficLight
            // 
            this.trafficLight.Controls.Add(this.client);
            this.trafficLight.Controls.Add(this.server);
            this.trafficLight.Location = new System.Drawing.Point(1, 1);
            this.trafficLight.Name = "trafficLight";
            this.trafficLight.SelectedIndex = 0;
            this.trafficLight.Size = new System.Drawing.Size(524, 416);
            this.trafficLight.TabIndex = 0;
            // 
            // client
            // 
            this.client.Controls.Add(this.groupBox3);
            this.client.Controls.Add(this.groupBox2);
            this.client.Controls.Add(this.groupBox1);
            this.client.Controls.Add(this.txtIPClient);
            this.client.Controls.Add(this.txtPortClient);
            this.client.Controls.Add(this.label11);
            this.client.Controls.Add(this.label10);
            this.client.Controls.Add(this.label9);
            this.client.Controls.Add(this.label8);
            this.client.Controls.Add(this.label7);
            this.client.Controls.Add(this.label6);
            this.client.Controls.Add(this.label5);
            this.client.Controls.Add(this.label4);
            this.client.Location = new System.Drawing.Point(4, 22);
            this.client.Name = "client";
            this.client.Padding = new System.Windows.Forms.Padding(3);
            this.client.Size = new System.Drawing.Size(516, 390);
            this.client.TabIndex = 0;
            this.client.Text = "Client";
            this.client.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hNyala);
            this.groupBox3.Controls.Add(this.hMati);
            this.groupBox3.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox3.Location = new System.Drawing.Point(213, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 35);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // hNyala
            // 
            this.hNyala.AutoSize = true;
            this.hNyala.Location = new System.Drawing.Point(12, 16);
            this.hNyala.Name = "hNyala";
            this.hNyala.Size = new System.Drawing.Size(14, 13);
            this.hNyala.TabIndex = 12;
            this.hNyala.TabStop = true;
            this.hNyala.UseVisualStyleBackColor = true;
            this.hNyala.CheckedChanged += new System.EventHandler(this.hNyala_CheckedChanged);
            // 
            // hMati
            // 
            this.hMati.AutoSize = true;
            this.hMati.Location = new System.Drawing.Point(110, 16);
            this.hMati.Name = "hMati";
            this.hMati.Size = new System.Drawing.Size(14, 13);
            this.hMati.TabIndex = 11;
            this.hMati.TabStop = true;
            this.hMati.UseVisualStyleBackColor = true;
            this.hMati.CheckedChanged += new System.EventHandler(this.hMati_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kNyala);
            this.groupBox2.Controls.Add(this.kMati);
            this.groupBox2.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(213, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 36);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // kNyala
            // 
            this.kNyala.AutoSize = true;
            this.kNyala.Location = new System.Drawing.Point(17, 17);
            this.kNyala.Name = "kNyala";
            this.kNyala.Size = new System.Drawing.Size(14, 13);
            this.kNyala.TabIndex = 11;
            this.kNyala.TabStop = true;
            this.kNyala.UseVisualStyleBackColor = true;
            this.kNyala.CheckedChanged += new System.EventHandler(this.kNyala_CheckedChanged);
            // 
            // kMati
            // 
            this.kMati.AutoSize = true;
            this.kMati.Location = new System.Drawing.Point(110, 17);
            this.kMati.Name = "kMati";
            this.kMati.Size = new System.Drawing.Size(14, 13);
            this.kMati.TabIndex = 11;
            this.kMati.TabStop = true;
            this.kMati.UseVisualStyleBackColor = true;
            this.kMati.CheckedChanged += new System.EventHandler(this.kMati_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mNyala);
            this.groupBox1.Controls.Add(this.mMati);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(213, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 31);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // mNyala
            // 
            this.mNyala.AutoSize = true;
            this.mNyala.Location = new System.Drawing.Point(17, 12);
            this.mNyala.Name = "mNyala";
            this.mNyala.Size = new System.Drawing.Size(14, 13);
            this.mNyala.TabIndex = 10;
            this.mNyala.TabStop = true;
            this.mNyala.UseVisualStyleBackColor = true;
            this.mNyala.CheckedChanged += new System.EventHandler(this.mNyala_CheckedChanged);
            // 
            // mMati
            // 
            this.mMati.AutoSize = true;
            this.mMati.Location = new System.Drawing.Point(110, 12);
            this.mMati.Name = "mMati";
            this.mMati.Size = new System.Drawing.Size(14, 13);
            this.mMati.TabIndex = 11;
            this.mMati.TabStop = true;
            this.mMati.UseVisualStyleBackColor = true;
            this.mMati.CheckedChanged += new System.EventHandler(this.mMati_CheckedChanged);
            // 
            // txtIPClient
            // 
            this.txtIPClient.Location = new System.Drawing.Point(291, 38);
            this.txtIPClient.Name = "txtIPClient";
            this.txtIPClient.Size = new System.Drawing.Size(100, 20);
            this.txtIPClient.TabIndex = 9;
            this.txtIPClient.Text = "192.168.1.";
            // 
            // txtPortClient
            // 
            this.txtPortClient.Location = new System.Drawing.Point(117, 39);
            this.txtPortClient.Name = "txtPortClient";
            this.txtPortClient.Size = new System.Drawing.Size(70, 20);
            this.txtPortClient.TabIndex = 8;
            this.txtPortClient.Text = "16375";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(209, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Client";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Mati";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nyala";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hijau";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Kuning";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Merah";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "IP Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Port";
            // 
            // server
            // 
            this.server.Controls.Add(this.label3);
            this.server.Controls.Add(this.panelHIjau);
            this.server.Controls.Add(this.panelKuning);
            this.server.Controls.Add(this.panelMerah);
            this.server.Controls.Add(this.bListen);
            this.server.Controls.Add(this.txtWarna);
            this.server.Controls.Add(this.txtIPServer);
            this.server.Controls.Add(this.label2);
            this.server.Controls.Add(this.txtPortServer);
            this.server.Controls.Add(this.label1);
            this.server.Location = new System.Drawing.Point(4, 22);
            this.server.Name = "server";
            this.server.Padding = new System.Windows.Forms.Padding(3);
            this.server.Size = new System.Drawing.Size(516, 390);
            this.server.TabIndex = 1;
            this.server.Text = "Server";
            this.server.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Server";
            // 
            // panelHIjau
            // 
            this.panelHIjau.BackColor = System.Drawing.Color.White;
            this.panelHIjau.Location = new System.Drawing.Point(342, 140);
            this.panelHIjau.Name = "panelHIjau";
            this.panelHIjau.Size = new System.Drawing.Size(101, 94);
            this.panelHIjau.TabIndex = 8;
            // 
            // panelKuning
            // 
            this.panelKuning.BackColor = System.Drawing.Color.White;
            this.panelKuning.Location = new System.Drawing.Point(203, 140);
            this.panelKuning.Name = "panelKuning";
            this.panelKuning.Size = new System.Drawing.Size(101, 94);
            this.panelKuning.TabIndex = 7;
            // 
            // panelMerah
            // 
            this.panelMerah.BackColor = System.Drawing.Color.White;
            this.panelMerah.Location = new System.Drawing.Point(66, 140);
            this.panelMerah.Name = "panelMerah";
            this.panelMerah.Size = new System.Drawing.Size(101, 94);
            this.panelMerah.TabIndex = 6;
            // 
            // bListen
            // 
            this.bListen.Location = new System.Drawing.Point(368, 22);
            this.bListen.Name = "bListen";
            this.bListen.Size = new System.Drawing.Size(75, 23);
            this.bListen.TabIndex = 5;
            this.bListen.Text = "Listen";
            this.bListen.UseVisualStyleBackColor = true;
            this.bListen.Click += new System.EventHandler(this.bListen_Click);
            // 
            // txtWarna
            // 
            this.txtWarna.Enabled = false;
            this.txtWarna.Location = new System.Drawing.Point(82, 88);
            this.txtWarna.Name = "txtWarna";
            this.txtWarna.Size = new System.Drawing.Size(334, 20);
            this.txtWarna.TabIndex = 4;
            // 
            // txtIPServer
            // 
            this.txtIPServer.Location = new System.Drawing.Point(240, 24);
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(100, 20);
            this.txtIPServer.TabIndex = 3;
            this.txtIPServer.Text = "192.168.1.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP Address";
            // 
            // txtPortServer
            // 
            this.txtPortServer.Location = new System.Drawing.Point(66, 24);
            this.txtPortServer.Name = "txtPortServer";
            this.txtPortServer.Size = new System.Drawing.Size(67, 20);
            this.txtPortServer.TabIndex = 1;
            this.txtPortServer.Text = "16375";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TrafficLightC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 429);
            this.Controls.Add(this.trafficLight);
            this.Name = "TrafficLightC";
            this.Text = "Traffic Light";
            this.trafficLight.ResumeLayout(false);
            this.client.ResumeLayout(false);
            this.client.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.server.ResumeLayout(false);
            this.server.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl trafficLight;
        private System.Windows.Forms.TabPage client;
        private System.Windows.Forms.TabPage server;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelHIjau;
        private System.Windows.Forms.Panel panelKuning;
        private System.Windows.Forms.Panel panelMerah;
        private System.Windows.Forms.Button bListen;
        private System.Windows.Forms.TextBox txtWarna;
        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPortServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPClient;
        private System.Windows.Forms.TextBox txtPortClient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton hMati;
        private System.Windows.Forms.RadioButton kMati;
        private System.Windows.Forms.RadioButton mMati;
        private System.Windows.Forms.RadioButton hNyala;
        private System.Windows.Forms.RadioButton kNyala;
        private System.Windows.Forms.RadioButton mNyala;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

