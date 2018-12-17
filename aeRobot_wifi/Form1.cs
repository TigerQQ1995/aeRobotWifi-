using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aeRobot_wifi
{
    public partial class Form1 : Form
    {
        private Socket socket;
        public Form1()
        {
            InitializeComponent();
        }
        #region 连接与通讯
        private void line_Click(object sender, EventArgs e)
        {
            //在客户端创建一个负责通讯socket
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //获取要连接server的IP地址
            IPAddress ip = IPAddress.Parse(IP.Text);
            //获取要连接server的端口号
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(port.Text));
            socket.Connect(point);
            showMessage("连接成功！");
            Thread th = new Thread(Receive);
            th.IsBackground = true;
            th.Start(socket);
        }
        void showMessage(string str)
        {
            txtlog.AppendText(str + "\r\n");
        }
        void Receive(object o)
        {
            Socket ClientRecieve = o as Socket;
            showMessage("开始接收服务端信息");
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 3];
                    int i = ClientRecieve.Receive(buffer);
                    if (i == 0)
                    {
                        break;
                    }
                    string str = Encoding.Default.GetString(buffer, 0, i);
                    showMessage("机器人:" + str);
                }
                catch { }
            }
        }

        private void SendMess_Click(object sender, EventArgs e)
        {
            try
            {
                string str = tbxMessage.Text.Trim();
                PortWrite(str);
                txtlog.AppendText("Client:" + str + "\r\n");
                tbxMessage.Clear();
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        #endregion


        double d = 1;
        double v = 0.5;

        #region 向服务器发送消息的方法
        private void PortWrite(string str)
        {

            try
            {
                byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
                socket.Send(buffer);
            }
            catch { }
        }
        #endregion

        #region 点击关节移动
        private void J1UP_Click(object sender, EventArgs e)
        {
            if (double.Parse(J1BOX.Text) + d < 170)
            {
                PortWrite("0");
                J1BOX.Text = String.Format("{0:F}", (double.Parse(J1BOX.Text) + d));
            }
            else
            {
                MessageBox.Show("j1的范围超出范围(-170~170)，请重新设置");
            }
        }

        private void J1DOWN_Click(object sender, EventArgs e)
        {
            if (double.Parse(J1BOX.Text) - d > -170)
            {
                PortWrite("1");
                J1BOX.Text = String.Format("{0:F}", (double.Parse(J1BOX.Text) - d));
            }
            else
            {
                MessageBox.Show("j1的范围超出范围(-170~170)，请重新设置");
            }
        }

        private void J2UP_Click(object sender, EventArgs e)
        {
            if (double.Parse(J2BOX.Text) + d < 135)
            {
                PortWrite("2");
                J2BOX.Text = String.Format("{0:F}", (double.Parse(J2BOX.Text) + d));
            }
            else
            {
                MessageBox.Show("j2的范围超出范围(-100~-135)，请重新设置");
            }
        }

        private void J2DOWN_Click(object sender, EventArgs e)
        {
            if (double.Parse(J2BOX.Text) - d > -100)
            {
                PortWrite("3");
                J2BOX.Text = String.Format("{0:F}", (double.Parse(J2BOX.Text) - d));
            }
            else
            {
                MessageBox.Show("j2的范围超出范围(-100~-135)，请重新设置");
            }
        }

        private void J3UP_Click(object sender, EventArgs e)
        {
            if (double.Parse(J3BOX.Text) + d < 156)
            {
                PortWrite("4");
                J3BOX.Text = String.Format("{0:F}", (double.Parse(J3BOX.Text) + d));
            }
            else
            {
                MessageBox.Show("j3的范围超出范围(-120~156)，请重新设置");
            }
        }

        private void J3DOWN_Click(object sender, EventArgs e)
        {
            if (double.Parse(J3BOX.Text) - d > -120)
            {
                PortWrite("5");
                J3BOX.Text = String.Format("{0:F}", (double.Parse(J3BOX.Text) - d));
            }
            else
            {
                MessageBox.Show("j3的范围超出范围(-120~156)，请重新设置");
            }
        }

        private void J4UP_Click(object sender, EventArgs e)
        {
            if (double.Parse(J4BOX.Text) + d < 200)
            {
                PortWrite("6");
                J4BOX.Text = String.Format("{0:F}", (double.Parse(J4BOX.Text) + d));
            }
            else
            {
                MessageBox.Show("j4的范围超出范围(-200~200)，请重新设置");
            }
        }

        private void J4DOWN_Click(object sender, EventArgs e)
        {
            if (double.Parse(J4BOX.Text) - d > -200)
            {
                PortWrite("7");
                J4BOX.Text = String.Format("{0:F}", (double.Parse(J4BOX.Text) - d));
            }
            else
            {
                MessageBox.Show("j4的范围超出范围(-200~200)，请重新设置");
            }
        }

        private void J5UP_Click(object sender, EventArgs e)
        {
            if (double.Parse(J5BOX.Text) + d < 135)
            {
                PortWrite("8");
                J5BOX.Text = String.Format("{0:F}", (double.Parse(J5BOX.Text) + d));
            }
            else
            {
                MessageBox.Show("j5的范围超出范围(-135~135)，请重新设置");
            }
        }

        private void J5DOWN_Click(object sender, EventArgs e)
        {
            if (double.Parse(J5BOX.Text) - d > -135)
            {
                PortWrite("9");
                J5BOX.Text = String.Format("{0:F}", (double.Parse(J5BOX.Text) - d));
            }
            else
            {
                MessageBox.Show("j5的范围超出范围(-135~135)，请重新设置");
            }
        }

        private void J6UP_Click(object sender, EventArgs e)
        {
            if (double.Parse(J6BOX.Text) + d < 360)
            {
                PortWrite("A");
                J6BOX.Text = String.Format("{0:F}", (double.Parse(J6BOX.Text) + d));

            }
            else
            {
                MessageBox.Show("j6的范围超出范围(-360~360)，请重新设置");
            }
        }

        private void J6DOWN_Click(object sender, EventArgs e)
        {
            if (double.Parse(J6BOX.Text) - d > -360)
            {
                PortWrite("B");
                J6BOX.Text = String.Format("{0:F}", (double.Parse(J6BOX.Text) - d));

            }
            else
            {
                MessageBox.Show("j6的范围超出范围(-360~360)，请重新设置");
            }
        }

        private void vup_Click(object sender, EventArgs e)
        {
            if (double.Parse(vs.Text) + v < 100)
            {
                PortWrite("C");
                vs.Text = String.Format("{0:F}", (double.Parse(vs.Text) + v));

            }
            else
            {
                MessageBox.Show("速度的范围超出范围(0~100)，请重新设置");
            }
        }

        private void vdown_Click(object sender, EventArgs e)
        {
            if (double.Parse(vs.Text) - v > 0)
            {
                PortWrite("D");
                vs.Text = String.Format("{0:F}", (double.Parse(vs.Text) - v));

            }
            else
            {
                MessageBox.Show("速度的范围超出范围(0~100)，请重新设置");
            }

        }
        #endregion

        #region pause

        private void pause_Click(object sender, EventArgs e)
        {
            PortWrite("p");
            J1BOX.Text = "0.00";
            J2BOX.Text = "0.00";
            J3BOX.Text = "0.00";
            J4BOX.Text = "0.00";
            J5BOX.Text = "0.00";
            J6BOX.Text = "0.00";
            vs.Text = "5.00";
          
        }
        #endregion

        private void SetOk_Click(object sender, EventArgs e)
        {
            if (double.Parse(J1BOX.Text) > -170 && double.Parse(J1BOX.Text) < 170 && double.Parse(J2BOX.Text) > -100 && double.Parse(J2BOX.Text) < 135 && double.Parse(J3BOX.Text) > -120 && double.Parse(J3BOX.Text) < 156 && double.Parse(J4BOX.Text) > -200 && double.Parse(J4BOX.Text) < 200 && double.Parse(J5BOX.Text) > -135 && double.Parse(J5BOX.Text) < 135 && double.Parse(J6BOX.Text) > -360 && double.Parse(J6BOX.Text) < 360 && double.Parse(vs.Text) > 0 && double.Parse(vs.Text) < 100)
            {

                PortWrite(StaticLength(J1BOX.Text));
                PortWrite(StaticLength(J2BOX.Text));
                PortWrite(StaticLength(J3BOX.Text));
                PortWrite(StaticLength(J4BOX.Text));
                PortWrite(StaticLength(J5BOX.Text));
                PortWrite(StaticLength(J6BOX.Text));
                PortWrite(StaticLength(vs.Text));
            }
            else
            {
                MessageBox.Show("设置超出了范围");
            }
        }

        private void self_input_Click(object sender, EventArgs e)
        {
            PortWrite("s");

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            PortWrite("x");
        }
        private string StaticLength(string str)
        {
            str = String.Format("{0:F}", double.Parse(str));
            if (str.Length !=7)
            {
                if (str[0] != '-')
                {
                    for (int i = 0; i <= 8 - str.Length; i++)
                    {
                        str = str.Insert(0, "0");
                    }
                }
                else
                {
                    for (int i = 0; i <= 7 - str.Length; i++)
                    {
                        str = str.Insert(1, "0");
                    }
                }
            }
            return str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PortWrite("I");
        }

        private void Up_Click(object sender, EventArgs e)
        {
            PortWrite("E");
        }

        private void Down_Click(object sender, EventArgs e)
        {
            PortWrite("F");
        }

        private void Left_Click(object sender, EventArgs e)
        {
            PortWrite("G");
        }

        private void Right_Click(object sender, EventArgs e)
        {
            PortWrite("H");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PortWrite("K");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PortWrite("J");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PortWrite("L");
        }
    }
}
