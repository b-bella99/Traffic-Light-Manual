using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLightC
{
    public partial class TrafficLightC : Form
    {

        public TrafficLightC()
        {
            InitializeComponent();
        }

        private void mNyala_CheckedChanged(object sender, EventArgs e)
        {
            if (txtIPClient.Text.Equals(""))
            {
                MessageBox.Show("Alamat IP Tujuan belum di set");
                mNyala.Checked = false;
            }
            else
            {
                varGlobal.alamatIPServer = txtIPClient.Text;
                varGlobal.port = Int16.Parse(txtPortClient.Text);
                SocketTCP.StartClient("Merah Hidup ");
            }
        }

        private void mMati_CheckedChanged(object sender, EventArgs e)
        {
            if (txtIPClient.Text.Equals(""))
            {
                MessageBox.Show("Alamat IP Tujuan belum di set");
                mNyala.Checked = false;
            }
            else
            {
                varGlobal.alamatIPServer = txtIPClient.Text;
                varGlobal.port = Int16.Parse(txtPortClient.Text);
                SocketTCP.StartClient("Merah Mati ");
            }
        }

        private void kNyala_CheckedChanged(object sender, EventArgs e)
        {
            if (txtIPClient.Text.Equals(""))
            {
                MessageBox.Show("Alamat IP Tujuan belum di set");
                mNyala.Checked = false;
            }
            else
            {
                varGlobal.alamatIPServer = txtIPClient.Text;
                varGlobal.port = Int16.Parse(txtPortClient.Text);
                SocketTCP.StartClient("Kuning Hidup ");
            }
        }

        private void kMati_CheckedChanged(object sender, EventArgs e)
        {
            if (txtIPClient.Text.Equals(""))
            {
                MessageBox.Show("Alamat IP Tujuan belum di set");
                mNyala.Checked = false;
            }
            else
            {
                varGlobal.alamatIPServer = txtIPClient.Text;
                varGlobal.port = Int16.Parse(txtPortClient.Text);
                SocketTCP.StartClient("Kuning Mati ");
            }
        }

        private void hNyala_CheckedChanged(object sender, EventArgs e)
        {
            if (txtIPClient.Text.Equals(""))
            {
                MessageBox.Show("Alamat IP Tujuan belum di set");
                mNyala.Checked = false;
            }
            else
            {
                varGlobal.alamatIPServer = txtIPClient.Text;
                varGlobal.port = Int16.Parse(txtPortClient.Text);
                SocketTCP.StartClient("Hijau Hidup ");
            }
        }

        private void hMati_CheckedChanged(object sender, EventArgs e)
        {
            if (txtIPClient.Text.Equals(""))
            {
                MessageBox.Show("Alamat IP Tujuan belum di set");
                mNyala.Checked = false;
            }
            else
            {
                varGlobal.alamatIPServer = txtIPClient.Text;
                varGlobal.port = Int16.Parse(txtPortClient.Text);
                SocketTCP.StartClient("Hijau Mati" );
            }
        }

        // SERVER

        private void listenSocket()
        {
            varGlobal.port = Int16.Parse(txtPortServer.Text);
            varGlobal.alamatIPServer = txtIPServer.Text;
            SocketTCP.StartListening();
        }

        private void bListen_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(listenSocket);
            if (txtIPServer.Text != "")
            {
                thr.Start();
                bListen.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lengkapi alamat IP terlebih dahulu !!!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtWarna.Clear();
            //varGlobal.command = varGlobal.terimapesandiserver.Split(',');
            String [] lampu = varGlobal.terimapesandiserver.Split(' ');
            StringBuilder sb = new StringBuilder();
            sb.Append("Lampu ").Append(lampu[0]).Append(" ").Append(lampu[1]);
            //txtWarna.Text = "Lampu " + lampu[0] + " " + lampu[1];
            //lampChanger(varGlobal.command[0], Int16.Parse(varGlobal.command[1]));
            lampChanger(lampu);
            txtWarna.Text = sb.ToString();
            //lamps();
        }

        private void lampChanger(string[] tmp)
        {
            Color color = Color.Black;
            if (tmp[1].Equals("Hidup"))
            {
                color = chooserColor(tmp[0]);
            }
            switch (tmp[0])
            {
                case "Merah":
                    panelMerah.BackColor = color;
                    break;
                case "Kuning":
                    panelKuning.BackColor = color;
                    break;
                case "Hijau":
                    panelHIjau.BackColor = color;
                    break;
            }
        }

        private Color chooserColor(String choose)
        {
            switch (choose)
            {
                case "Merah":
                    return Color.Red;
                case "Kuning":
                    return Color.Yellow;
                case "Hijau":
                    return Color.Green;
                default:
                    return Color.Black;
            }
        }

        /*private void lampChanger(string[] lampu)
        {
            if (lampu[0].Equals("Merah"))
            {
                if (lampu[1].Equals("Hidup"))
                {
                    panelMerah.BackColor = Color.Red;
                }
                else
                    panelMerah.BackColor = Color.Black;
            }

            if (lampu[0].Equals("Kuning"))
            {
                if (lampu[1].Equals("Hidup"))
                {
                    panelKuning.BackColor = Color.Yellow;
                }
                else
                    panelKuning.BackColor = Color.Black;
            }

            if (lampu[0].Equals("Hijau"))
            {
                if (lampu[1].Equals("Hidup"))
                {
                    panelHIjau.BackColor = Color.Green;
                }
                else
                    panelHIjau.BackColor = Color.Black;
            }

            if(lampu[0].Equals(" ") && lampu[1].Equals(" "))
            {
                txtWarna.Text = "Semua Lampu Mati";
                panelMerah.BackColor = Color.Black;
                panelKuning.BackColor = Color.Black;
                panelHIjau.BackColor = Color.Black;
            }

        }*/

        /*private void lamps()
        {
            String[] red = varGlobal.bulb[0].Split(',');
            String[] yellow = varGlobal.bulb[1].Split(',');
            String[] green = varGlobal.bulb[2].Split(',');

            if (red[1].Equals("Nyala"))
            {
                panelMerah.BackColor = Color.Red;
            }
            else
            {
                panelMerah.BackColor = Color.Black;
            }
            if (yellow[1].Equals("Nyala"))
            {
                panelKuning.BackColor = Color.Yellow;
            }
            else
            {
                panelKuning.BackColor = Color.Black;
            }
            if (green[1].Equals("Nyala"))
            {
                panelHIjau.BackColor = Color.Green;
            }
            else
            {
                panelHIjau.BackColor = Color.Black;
            }
        }

        /*private void lampChanger(string command, short pos)
        {
            varGlobal.bulb[pos] = command;
        }*/

    }
}
