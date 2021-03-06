﻿namespace WinApp5
{
    partial class frmClient
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.tbHum = new System.Windows.Forms.TextBox();
            this.tbWind = new System.Windows.Forms.TextBox();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.cbInterval = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbKeepAlive = new System.Windows.Forms.CheckBox();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.tbProtocol = new System.Windows.Forms.TextBox();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMemo
            // 
            this.tbMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMemo.BackColor = System.Drawing.Color.LightGray;
            this.tbMemo.Location = new System.Drawing.Point(444, 18);
            this.tbMemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMemo.Size = new System.Drawing.Size(210, 242);
            this.tbMemo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbHum);
            this.groupBox1.Controls.Add(this.tbWind);
            this.groupBox1.Controls.Add(this.tbTemp);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.tbCode);
            this.groupBox1.Controls.Add(this.tbInterval);
            this.groupBox1.Controls.Add(this.cbInterval);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(428, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATA";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 27);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 21);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "Interval(ms)";
            // 
            // tbHum
            // 
            this.tbHum.Location = new System.Drawing.Point(276, 88);
            this.tbHum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHum.Name = "tbHum";
            this.tbHum.Size = new System.Drawing.Size(135, 21);
            this.tbHum.TabIndex = 3;
            this.tbHum.Text = "30.00";
            // 
            // tbWind
            // 
            this.tbWind.Location = new System.Drawing.Point(77, 116);
            this.tbWind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWind.Name = "tbWind";
            this.tbWind.Size = new System.Drawing.Size(135, 21);
            this.tbWind.TabIndex = 3;
            this.tbWind.Text = "02.00";
            // 
            // tbTemp
            // 
            this.tbTemp.Location = new System.Drawing.Point(77, 88);
            this.tbTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(135, 21);
            this.tbTemp.TabIndex = 3;
            this.tbTemp.Text = "10.5";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(276, 55);
            this.tbModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(135, 21);
            this.tbModel.TabIndex = 3;
            this.tbModel.Text = "00000";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(77, 55);
            this.tbCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(135, 21);
            this.tbCode.TabIndex = 3;
            this.tbCode.Text = "10001";
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(276, 116);
            this.tbInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(63, 21);
            this.tbInterval.TabIndex = 3;
            this.tbInterval.Text = "2000";
            // 
            // cbInterval
            // 
            this.cbInterval.AutoSize = true;
            this.cbInterval.Checked = true;
            this.cbInterval.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInterval.Location = new System.Drawing.Point(252, 118);
            this.cbInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbInterval.Name = "cbInterval";
            this.cbInterval.Size = new System.Drawing.Size(15, 14);
            this.cbInterval.TabIndex = 2;
            this.cbInterval.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "상태 H";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "상태 W";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "상태 T";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "모델명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "fCode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "시작 시간";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.cbKeepAlive);
            this.groupBox2.Controls.Add(this.tbServerPort);
            this.groupBox2.Controls.Add(this.tbProtocol);
            this.groupBox2.Controls.Add(this.tbServerIP);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(10, 173);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(428, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication Control";
            // 
            // cbKeepAlive
            // 
            this.cbKeepAlive.AutoSize = true;
            this.cbKeepAlive.Location = new System.Drawing.Point(252, 50);
            this.cbKeepAlive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKeepAlive.Name = "cbKeepAlive";
            this.cbKeepAlive.Size = new System.Drawing.Size(148, 16);
            this.cbKeepAlive.TabIndex = 2;
            this.cbKeepAlive.Text = "Disconnect after Send";
            this.cbKeepAlive.UseVisualStyleBackColor = true;
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(251, 22);
            this.tbServerPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbServerPort.Multiline = true;
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(70, 24);
            this.tbServerPort.TabIndex = 1;
            this.tbServerPort.Text = "9000";
            this.tbServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbProtocol
            // 
            this.tbProtocol.Location = new System.Drawing.Point(11, 50);
            this.tbProtocol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProtocol.Multiline = true;
            this.tbProtocol.Name = "tbProtocol";
            this.tbProtocol.Size = new System.Drawing.Size(235, 24);
            this.tbProtocol.TabIndex = 1;
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(74, 22);
            this.tbServerIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbServerIP.Multiline = true;
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(172, 24);
            this.tbServerIP.TabIndex = 1;
            this.tbServerIP.Text = "192.168.0.127";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Server IP";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStart,
            this.mnuStop,
            this.mnuClose});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 70);
            // 
            // mnuStart
            // 
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.Size = new System.Drawing.Size(203, 22);
            this.mnuStart.Text = "시작 (START)";
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(203, 22);
            this.mnuStop.Text = "종료 (STOP)";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuClose.Size = new System.Drawing.Size(203, 22);
            this.mnuClose.Text = "프로그램 끝내기";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(665, 266);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbMemo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmClient";
            this.Text = "TCP/IP Client Ver.10.30";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.CheckBox cbInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbHum;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbWind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbKeepAlive;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbProtocol;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuStart;
        private System.Windows.Forms.ToolStripMenuItem mnuStop;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.Timer timer1;
    }
}

