namespace aeRobot_wifi
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            
                 base.Dispose(disposing);
          
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.port = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.TextBox();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.self_input = new System.Windows.Forms.Button();
            this.SetOk = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.vs = new System.Windows.Forms.TextBox();
            this.vdown = new System.Windows.Forms.Button();
            this.vup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.J6BOX = new System.Windows.Forms.TextBox();
            this.J5BOX = new System.Windows.Forms.TextBox();
            this.J4BOX = new System.Windows.Forms.TextBox();
            this.J3BOX = new System.Windows.Forms.TextBox();
            this.J2BOX = new System.Windows.Forms.TextBox();
            this.J1BOX = new System.Windows.Forms.TextBox();
            this.J6DOWN = new System.Windows.Forms.Button();
            this.J6UP = new System.Windows.Forms.Button();
            this.J5DOWN = new System.Windows.Forms.Button();
            this.J5UP = new System.Windows.Forms.Button();
            this.J4DOWN = new System.Windows.Forms.Button();
            this.J4UP = new System.Windows.Forms.Button();
            this.J3DOWN = new System.Windows.Forms.Button();
            this.J3UP = new System.Windows.Forms.Button();
            this.J2DOWN = new System.Windows.Forms.Button();
            this.J2UP = new System.Windows.Forms.Button();
            this.J1DOWN = new System.Windows.Forms.Button();
            this.J1UP = new System.Windows.Forms.Button();
            this.J6 = new System.Windows.Forms.Label();
            this.J5 = new System.Windows.Forms.Label();
            this.J4 = new System.Windows.Forms.Label();
            this.J3 = new System.Windows.Forms.Label();
            this.J2 = new System.Windows.Forms.Label();
            this.J1 = new System.Windows.Forms.Label();
            this.SendMess = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-2, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "client";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(261, 55);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(57, 30);
            this.line.TabIndex = 9;
            this.line.Text = "连接";
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(191, 55);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(54, 25);
            this.port.TabIndex = 8;
            this.port.Text = "50000";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(29, 55);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(127, 25);
            this.IP.TabIndex = 7;
            this.IP.Text = "192.168.101.111";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(22, 449);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(223, 34);
            this.tbxMessage.TabIndex = 12;
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(22, 100);
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.Size = new System.Drawing.Size(296, 332);
            this.txtlog.TabIndex = 11;
            // 
            // self_input
            // 
            this.self_input.Location = new System.Drawing.Point(449, 39);
            this.self_input.Name = "self_input";
            this.self_input.Size = new System.Drawing.Size(100, 27);
            this.self_input.TabIndex = 62;
            this.self_input.Text = "self_input";
            this.self_input.UseVisualStyleBackColor = true;
            this.self_input.Click += new System.EventHandler(this.self_input_Click);
            // 
            // SetOk
            // 
            this.SetOk.Location = new System.Drawing.Point(588, 510);
            this.SetOk.Name = "SetOk";
            this.SetOk.Size = new System.Drawing.Size(92, 31);
            this.SetOk.TabIndex = 61;
            this.SetOk.Text = "SetOk";
            this.SetOk.UseVisualStyleBackColor = true;
            this.SetOk.Click += new System.EventHandler(this.SetOk_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(689, 39);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(91, 27);
            this.pause.TabIndex = 60;
            this.pause.Text = "急停";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // vs
            // 
            this.vs.Location = new System.Drawing.Point(531, 441);
            this.vs.Name = "vs";
            this.vs.Size = new System.Drawing.Size(183, 25);
            this.vs.TabIndex = 59;
            this.vs.Text = "5.00";
            this.vs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vdown
            // 
            this.vdown.Location = new System.Drawing.Point(730, 441);
            this.vdown.Name = "vdown";
            this.vdown.Size = new System.Drawing.Size(79, 30);
            this.vdown.TabIndex = 58;
            this.vdown.Text = "-";
            this.vdown.UseVisualStyleBackColor = true;
            this.vdown.Click += new System.EventHandler(this.vdown_Click);
            // 
            // vup
            // 
            this.vup.Location = new System.Drawing.Point(446, 441);
            this.vup.Name = "vup";
            this.vup.Size = new System.Drawing.Size(79, 30);
            this.vup.TabIndex = 57;
            this.vup.Text = "+";
            this.vup.UseVisualStyleBackColor = true;
            this.vup.Click += new System.EventHandler(this.vup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 56;
            this.label1.Text = "speed";
            // 
            // J6BOX
            // 
            this.J6BOX.Location = new System.Drawing.Point(531, 382);
            this.J6BOX.Name = "J6BOX";
            this.J6BOX.Size = new System.Drawing.Size(183, 25);
            this.J6BOX.TabIndex = 55;
            this.J6BOX.Text = "0.00";
            this.J6BOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // J5BOX
            // 
            this.J5BOX.Location = new System.Drawing.Point(531, 323);
            this.J5BOX.Name = "J5BOX";
            this.J5BOX.Size = new System.Drawing.Size(183, 25);
            this.J5BOX.TabIndex = 54;
            this.J5BOX.Text = "0.00";
            this.J5BOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // J4BOX
            // 
            this.J4BOX.Location = new System.Drawing.Point(531, 271);
            this.J4BOX.Name = "J4BOX";
            this.J4BOX.Size = new System.Drawing.Size(183, 25);
            this.J4BOX.TabIndex = 53;
            this.J4BOX.Text = "0.00";
            this.J4BOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // J3BOX
            // 
            this.J3BOX.Location = new System.Drawing.Point(531, 211);
            this.J3BOX.Name = "J3BOX";
            this.J3BOX.Size = new System.Drawing.Size(183, 25);
            this.J3BOX.TabIndex = 52;
            this.J3BOX.Text = "0.00";
            this.J3BOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // J2BOX
            // 
            this.J2BOX.Location = new System.Drawing.Point(531, 146);
            this.J2BOX.Name = "J2BOX";
            this.J2BOX.Size = new System.Drawing.Size(183, 25);
            this.J2BOX.TabIndex = 51;
            this.J2BOX.Text = "0.00";
            this.J2BOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // J1BOX
            // 
            this.J1BOX.Location = new System.Drawing.Point(531, 85);
            this.J1BOX.Name = "J1BOX";
            this.J1BOX.Size = new System.Drawing.Size(183, 25);
            this.J1BOX.TabIndex = 50;
            this.J1BOX.Text = "0.00";
            this.J1BOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // J6DOWN
            // 
            this.J6DOWN.Location = new System.Drawing.Point(730, 382);
            this.J6DOWN.Name = "J6DOWN";
            this.J6DOWN.Size = new System.Drawing.Size(79, 30);
            this.J6DOWN.TabIndex = 49;
            this.J6DOWN.Text = "-";
            this.J6DOWN.UseVisualStyleBackColor = true;
            this.J6DOWN.Click += new System.EventHandler(this.J6DOWN_Click);
            // 
            // J6UP
            // 
            this.J6UP.Location = new System.Drawing.Point(446, 382);
            this.J6UP.Name = "J6UP";
            this.J6UP.Size = new System.Drawing.Size(79, 30);
            this.J6UP.TabIndex = 48;
            this.J6UP.Text = "+";
            this.J6UP.UseVisualStyleBackColor = true;
            this.J6UP.Click += new System.EventHandler(this.J6UP_Click);
            // 
            // J5DOWN
            // 
            this.J5DOWN.Location = new System.Drawing.Point(730, 326);
            this.J5DOWN.Name = "J5DOWN";
            this.J5DOWN.Size = new System.Drawing.Size(79, 30);
            this.J5DOWN.TabIndex = 47;
            this.J5DOWN.Text = "-";
            this.J5DOWN.UseVisualStyleBackColor = true;
            this.J5DOWN.Click += new System.EventHandler(this.J5DOWN_Click);
            // 
            // J5UP
            // 
            this.J5UP.Location = new System.Drawing.Point(446, 326);
            this.J5UP.Name = "J5UP";
            this.J5UP.Size = new System.Drawing.Size(79, 30);
            this.J5UP.TabIndex = 46;
            this.J5UP.Text = "+";
            this.J5UP.UseVisualStyleBackColor = true;
            this.J5UP.Click += new System.EventHandler(this.J5UP_Click);
            // 
            // J4DOWN
            // 
            this.J4DOWN.Location = new System.Drawing.Point(730, 266);
            this.J4DOWN.Name = "J4DOWN";
            this.J4DOWN.Size = new System.Drawing.Size(79, 30);
            this.J4DOWN.TabIndex = 45;
            this.J4DOWN.Text = "-";
            this.J4DOWN.UseVisualStyleBackColor = true;
            this.J4DOWN.Click += new System.EventHandler(this.J4DOWN_Click);
            // 
            // J4UP
            // 
            this.J4UP.Location = new System.Drawing.Point(446, 266);
            this.J4UP.Name = "J4UP";
            this.J4UP.Size = new System.Drawing.Size(79, 30);
            this.J4UP.TabIndex = 44;
            this.J4UP.Text = "+";
            this.J4UP.UseVisualStyleBackColor = true;
            this.J4UP.Click += new System.EventHandler(this.J4UP_Click);
            // 
            // J3DOWN
            // 
            this.J3DOWN.Location = new System.Drawing.Point(730, 206);
            this.J3DOWN.Name = "J3DOWN";
            this.J3DOWN.Size = new System.Drawing.Size(79, 30);
            this.J3DOWN.TabIndex = 43;
            this.J3DOWN.Text = "-";
            this.J3DOWN.UseVisualStyleBackColor = true;
            this.J3DOWN.Click += new System.EventHandler(this.J3DOWN_Click);
            // 
            // J3UP
            // 
            this.J3UP.Location = new System.Drawing.Point(446, 206);
            this.J3UP.Name = "J3UP";
            this.J3UP.Size = new System.Drawing.Size(79, 30);
            this.J3UP.TabIndex = 42;
            this.J3UP.Text = "+";
            this.J3UP.UseVisualStyleBackColor = true;
            this.J3UP.Click += new System.EventHandler(this.J3UP_Click);
            // 
            // J2DOWN
            // 
            this.J2DOWN.Location = new System.Drawing.Point(730, 146);
            this.J2DOWN.Name = "J2DOWN";
            this.J2DOWN.Size = new System.Drawing.Size(79, 30);
            this.J2DOWN.TabIndex = 41;
            this.J2DOWN.Text = "-";
            this.J2DOWN.UseVisualStyleBackColor = true;
            this.J2DOWN.Click += new System.EventHandler(this.J2DOWN_Click);
            // 
            // J2UP
            // 
            this.J2UP.Location = new System.Drawing.Point(446, 146);
            this.J2UP.Name = "J2UP";
            this.J2UP.Size = new System.Drawing.Size(79, 30);
            this.J2UP.TabIndex = 40;
            this.J2UP.Text = "+";
            this.J2UP.UseVisualStyleBackColor = true;
            this.J2UP.Click += new System.EventHandler(this.J2UP_Click);
            // 
            // J1DOWN
            // 
            this.J1DOWN.Location = new System.Drawing.Point(730, 85);
            this.J1DOWN.Name = "J1DOWN";
            this.J1DOWN.Size = new System.Drawing.Size(79, 30);
            this.J1DOWN.TabIndex = 39;
            this.J1DOWN.Text = "-";
            this.J1DOWN.UseVisualStyleBackColor = true;
            this.J1DOWN.Click += new System.EventHandler(this.J1DOWN_Click);
            // 
            // J1UP
            // 
            this.J1UP.Location = new System.Drawing.Point(446, 85);
            this.J1UP.Name = "J1UP";
            this.J1UP.Size = new System.Drawing.Size(79, 30);
            this.J1UP.TabIndex = 38;
            this.J1UP.Text = "+";
            this.J1UP.UseVisualStyleBackColor = true;
            this.J1UP.Click += new System.EventHandler(this.J1UP_Click);
            // 
            // J6
            // 
            this.J6.AutoSize = true;
            this.J6.Location = new System.Drawing.Point(409, 390);
            this.J6.Name = "J6";
            this.J6.Size = new System.Drawing.Size(31, 15);
            this.J6.TabIndex = 37;
            this.J6.Text = "J6:";
            // 
            // J5
            // 
            this.J5.AutoSize = true;
            this.J5.Location = new System.Drawing.Point(409, 326);
            this.J5.Name = "J5";
            this.J5.Size = new System.Drawing.Size(31, 15);
            this.J5.TabIndex = 36;
            this.J5.Text = "J5:";
            // 
            // J4
            // 
            this.J4.AutoSize = true;
            this.J4.Location = new System.Drawing.Point(409, 266);
            this.J4.Name = "J4";
            this.J4.Size = new System.Drawing.Size(31, 15);
            this.J4.TabIndex = 35;
            this.J4.Text = "J4:";
            // 
            // J3
            // 
            this.J3.AutoSize = true;
            this.J3.Location = new System.Drawing.Point(409, 206);
            this.J3.Name = "J3";
            this.J3.Size = new System.Drawing.Size(31, 15);
            this.J3.TabIndex = 34;
            this.J3.Text = "J3:";
            // 
            // J2
            // 
            this.J2.AutoSize = true;
            this.J2.Location = new System.Drawing.Point(409, 146);
            this.J2.Name = "J2";
            this.J2.Size = new System.Drawing.Size(31, 15);
            this.J2.TabIndex = 33;
            this.J2.Text = "J2:";
            // 
            // J1
            // 
            this.J1.AutoSize = true;
            this.J1.Location = new System.Drawing.Point(409, 93);
            this.J1.Name = "J1";
            this.J1.Size = new System.Drawing.Size(31, 15);
            this.J1.TabIndex = 32;
            this.J1.Text = "J1:";
            // 
            // SendMess
            // 
            this.SendMess.Location = new System.Drawing.Point(256, 449);
            this.SendMess.Name = "SendMess";
            this.SendMess.Size = new System.Drawing.Size(62, 34);
            this.SendMess.TabIndex = 63;
            this.SendMess.Text = "发送";
            this.SendMess.UseVisualStyleBackColor = true;
            this.SendMess.Click += new System.EventHandler(this.SendMess_Click);
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(1029, 323);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(72, 32);
            this.Up.TabIndex = 64;
            this.Up.Text = "Z+";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(1029, 211);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(72, 32);
            this.Right.TabIndex = 65;
            this.Right.Text = "Y+";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(911, 211);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(72, 32);
            this.Left.TabIndex = 66;
            this.Left.Text = "Y-";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(911, 326);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(72, 32);
            this.Down.TabIndex = 67;
            this.Down.Text = "Z-";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(953, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 27);
            this.button2.TabIndex = 68;
            this.button2.Text = "开始细调";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1029, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 32);
            this.button3.TabIndex = 69;
            this.button3.Text = "X+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(911, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 32);
            this.button4.TabIndex = 70;
            this.button4.Text = "X-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(965, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 28);
            this.button5.TabIndex = 71;
            this.button5.Text = "结束细调";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 612);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.SendMess);
            this.Controls.Add(this.self_input);
            this.Controls.Add(this.SetOk);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.vs);
            this.Controls.Add(this.vdown);
            this.Controls.Add(this.vup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.J6BOX);
            this.Controls.Add(this.J5BOX);
            this.Controls.Add(this.J4BOX);
            this.Controls.Add(this.J3BOX);
            this.Controls.Add(this.J2BOX);
            this.Controls.Add(this.J1BOX);
            this.Controls.Add(this.J6DOWN);
            this.Controls.Add(this.J6UP);
            this.Controls.Add(this.J5DOWN);
            this.Controls.Add(this.J5UP);
            this.Controls.Add(this.J4DOWN);
            this.Controls.Add(this.J4UP);
            this.Controls.Add(this.J3DOWN);
            this.Controls.Add(this.J3UP);
            this.Controls.Add(this.J2DOWN);
            this.Controls.Add(this.J2UP);
            this.Controls.Add(this.J1DOWN);
            this.Controls.Add(this.J1UP);
            this.Controls.Add(this.J6);
            this.Controls.Add(this.J5);
            this.Controls.Add(this.J4);
            this.Controls.Add(this.J3);
            this.Controls.Add(this.J2);
            this.Controls.Add(this.J1);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.port);
            this.Controls.Add(this.IP);
            this.Name = "Form1";
            this.Text = "5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.Button self_input;
        private System.Windows.Forms.Button SetOk;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.TextBox vs;
        private System.Windows.Forms.Button vdown;
        private System.Windows.Forms.Button vup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox J6BOX;
        private System.Windows.Forms.TextBox J5BOX;
        private System.Windows.Forms.TextBox J4BOX;
        private System.Windows.Forms.TextBox J3BOX;
        private System.Windows.Forms.TextBox J2BOX;
        private System.Windows.Forms.TextBox J1BOX;
        private System.Windows.Forms.Button J6DOWN;
        private System.Windows.Forms.Button J6UP;
        private System.Windows.Forms.Button J5DOWN;
        private System.Windows.Forms.Button J5UP;
        private System.Windows.Forms.Button J4DOWN;
        private System.Windows.Forms.Button J4UP;
        private System.Windows.Forms.Button J3DOWN;
        private System.Windows.Forms.Button J3UP;
        private System.Windows.Forms.Button J2DOWN;
        private System.Windows.Forms.Button J2UP;
        private System.Windows.Forms.Button J1DOWN;
        private System.Windows.Forms.Button J1UP;
        private System.Windows.Forms.Label J6;
        private System.Windows.Forms.Label J5;
        private System.Windows.Forms.Label J4;
        private System.Windows.Forms.Label J3;
        private System.Windows.Forms.Label J2;
        private System.Windows.Forms.Label J1;
        private System.Windows.Forms.Button SendMess;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

