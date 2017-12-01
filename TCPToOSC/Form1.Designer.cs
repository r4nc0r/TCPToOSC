namespace TCPToOSC
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.ServerStateLabel = new System.Windows.Forms.Label();
            this.MagnetX = new System.Windows.Forms.Label();
            this.MagnetY = new System.Windows.Forms.Label();
            this.MagnetZ = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GarvityZ = new System.Windows.Forms.Label();
            this.GarvityY = new System.Windows.Forms.Label();
            this.GarvityX = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.QuatnernionZ = new System.Windows.Forms.Label();
            this.QuatnernionY = new System.Windows.Forms.Label();
            this.QuatnernionX = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.AcclerationZ = new System.Windows.Forms.Label();
            this.AcclerationY = new System.Windows.Forms.Label();
            this.AcclerationX = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.RotationZ = new System.Windows.Forms.Label();
            this.RotationY = new System.Windows.Forms.Label();
            this.RotationX = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.RotationRoll = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.RotationYaw = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.QuatnernionW = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.MagnetHeading = new System.Windows.Forms.Label();
            this.oscStopbtn = new System.Windows.Forms.Button();
            this.OSCStatus = new System.Windows.Forms.Label();
            this.oscStartbtn = new System.Windows.Forms.Button();
            this.magnetchk = new System.Windows.Forms.CheckBox();
            this.gravitychk = new System.Windows.Forms.CheckBox();
            this.quaternionchk = new System.Windows.Forms.CheckBox();
            this.acclerationchk = new System.Windows.Forms.CheckBox();
            this.rotationchk = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.RotationPitch = new System.Windows.Forms.Label();
            this.OSCIP = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.OSCIPPort = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.LatencyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OSCIPPort)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Server starten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ServerStateLabel
            // 
            this.ServerStateLabel.AutoSize = true;
            this.ServerStateLabel.BackColor = System.Drawing.Color.Red;
            this.ServerStateLabel.Location = new System.Drawing.Point(122, 32);
            this.ServerStateLabel.Name = "ServerStateLabel";
            this.ServerStateLabel.Size = new System.Drawing.Size(37, 13);
            this.ServerStateLabel.TabIndex = 2;
            this.ServerStateLabel.Text = "Offline";
            // 
            // MagnetX
            // 
            this.MagnetX.AutoSize = true;
            this.MagnetX.Location = new System.Drawing.Point(528, 33);
            this.MagnetX.Name = "MagnetX";
            this.MagnetX.Size = new System.Drawing.Size(13, 13);
            this.MagnetX.TabIndex = 3;
            this.MagnetX.Text = "0";
            // 
            // MagnetY
            // 
            this.MagnetY.AutoSize = true;
            this.MagnetY.Location = new System.Drawing.Point(610, 33);
            this.MagnetY.Name = "MagnetY";
            this.MagnetY.Size = new System.Drawing.Size(13, 13);
            this.MagnetY.TabIndex = 4;
            this.MagnetY.Text = "0";
            // 
            // MagnetZ
            // 
            this.MagnetZ.AutoSize = true;
            this.MagnetZ.Location = new System.Drawing.Point(669, 32);
            this.MagnetZ.Name = "MagnetZ";
            this.MagnetZ.Size = new System.Drawing.Size(13, 13);
            this.MagnetZ.TabIndex = 5;
            this.MagnetZ.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Server stoppen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Magnetometer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Gravity";
            // 
            // GarvityZ
            // 
            this.GarvityZ.AutoSize = true;
            this.GarvityZ.Location = new System.Drawing.Point(669, 95);
            this.GarvityZ.Name = "GarvityZ";
            this.GarvityZ.Size = new System.Drawing.Size(13, 13);
            this.GarvityZ.TabIndex = 13;
            this.GarvityZ.Text = "0";
            // 
            // GarvityY
            // 
            this.GarvityY.AutoSize = true;
            this.GarvityY.Location = new System.Drawing.Point(610, 96);
            this.GarvityY.Name = "GarvityY";
            this.GarvityY.Size = new System.Drawing.Size(13, 13);
            this.GarvityY.TabIndex = 12;
            this.GarvityY.Text = "0";
            // 
            // GarvityX
            // 
            this.GarvityX.AutoSize = true;
            this.GarvityX.Location = new System.Drawing.Point(528, 96);
            this.GarvityX.Name = "GarvityX";
            this.GarvityX.Size = new System.Drawing.Size(13, 13);
            this.GarvityX.TabIndex = 11;
            this.GarvityX.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(669, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Z";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(610, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Y";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(528, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "X";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(407, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Quatnernion";
            // 
            // QuatnernionZ
            // 
            this.QuatnernionZ.AutoSize = true;
            this.QuatnernionZ.Location = new System.Drawing.Point(669, 163);
            this.QuatnernionZ.Name = "QuatnernionZ";
            this.QuatnernionZ.Size = new System.Drawing.Size(13, 13);
            this.QuatnernionZ.TabIndex = 20;
            this.QuatnernionZ.Text = "0";
            // 
            // QuatnernionY
            // 
            this.QuatnernionY.AutoSize = true;
            this.QuatnernionY.Location = new System.Drawing.Point(610, 164);
            this.QuatnernionY.Name = "QuatnernionY";
            this.QuatnernionY.Size = new System.Drawing.Size(13, 13);
            this.QuatnernionY.TabIndex = 19;
            this.QuatnernionY.Text = "0";
            // 
            // QuatnernionX
            // 
            this.QuatnernionX.AutoSize = true;
            this.QuatnernionX.Location = new System.Drawing.Point(528, 164);
            this.QuatnernionX.Name = "QuatnernionX";
            this.QuatnernionX.Size = new System.Drawing.Size(13, 13);
            this.QuatnernionX.TabIndex = 18;
            this.QuatnernionX.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(669, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Z";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(610, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(528, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "X";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(407, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Linear Accleration";
            // 
            // AcclerationZ
            // 
            this.AcclerationZ.AutoSize = true;
            this.AcclerationZ.Location = new System.Drawing.Point(669, 221);
            this.AcclerationZ.Name = "AcclerationZ";
            this.AcclerationZ.Size = new System.Drawing.Size(13, 13);
            this.AcclerationZ.TabIndex = 27;
            this.AcclerationZ.Text = "0";
            // 
            // AcclerationY
            // 
            this.AcclerationY.AutoSize = true;
            this.AcclerationY.Location = new System.Drawing.Point(610, 222);
            this.AcclerationY.Name = "AcclerationY";
            this.AcclerationY.Size = new System.Drawing.Size(13, 13);
            this.AcclerationY.TabIndex = 26;
            this.AcclerationY.Text = "0";
            // 
            // AcclerationX
            // 
            this.AcclerationX.AutoSize = true;
            this.AcclerationX.Location = new System.Drawing.Point(528, 222);
            this.AcclerationX.Name = "AcclerationX";
            this.AcclerationX.Size = new System.Drawing.Size(13, 13);
            this.AcclerationX.TabIndex = 25;
            this.AcclerationX.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(669, 260);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Z";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(610, 260);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Y";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(528, 260);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "X";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(407, 278);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Rotation";
            // 
            // RotationZ
            // 
            this.RotationZ.AutoSize = true;
            this.RotationZ.Location = new System.Drawing.Point(669, 278);
            this.RotationZ.Name = "RotationZ";
            this.RotationZ.Size = new System.Drawing.Size(13, 13);
            this.RotationZ.TabIndex = 34;
            this.RotationZ.Text = "0";
            // 
            // RotationY
            // 
            this.RotationY.AutoSize = true;
            this.RotationY.Location = new System.Drawing.Point(610, 279);
            this.RotationY.Name = "RotationY";
            this.RotationY.Size = new System.Drawing.Size(13, 13);
            this.RotationY.TabIndex = 33;
            this.RotationY.Text = "0";
            // 
            // RotationX
            // 
            this.RotationX.AutoSize = true;
            this.RotationX.Location = new System.Drawing.Point(528, 279);
            this.RotationX.Name = "RotationX";
            this.RotationX.Size = new System.Drawing.Size(13, 13);
            this.RotationX.TabIndex = 32;
            this.RotationX.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(528, 310);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "Roll";
            // 
            // RotationRoll
            // 
            this.RotationRoll.AutoSize = true;
            this.RotationRoll.Location = new System.Drawing.Point(528, 329);
            this.RotationRoll.Name = "RotationRoll";
            this.RotationRoll.Size = new System.Drawing.Size(13, 13);
            this.RotationRoll.TabIndex = 39;
            this.RotationRoll.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(610, 310);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 13);
            this.label23.TabIndex = 42;
            this.label23.Text = "Yaw";
            // 
            // RotationYaw
            // 
            this.RotationYaw.AutoSize = true;
            this.RotationYaw.Location = new System.Drawing.Point(610, 329);
            this.RotationYaw.Name = "RotationYaw";
            this.RotationYaw.Size = new System.Drawing.Size(13, 13);
            this.RotationYaw.TabIndex = 41;
            this.RotationYaw.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(732, 145);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(18, 13);
            this.label22.TabIndex = 44;
            this.label22.Text = "W";
            // 
            // QuatnernionW
            // 
            this.QuatnernionW.AutoSize = true;
            this.QuatnernionW.Location = new System.Drawing.Point(732, 163);
            this.QuatnernionW.Name = "QuatnernionW";
            this.QuatnernionW.Size = new System.Drawing.Size(13, 13);
            this.QuatnernionW.TabIndex = 43;
            this.QuatnernionW.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(731, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 13);
            this.label24.TabIndex = 46;
            this.label24.Text = "Heading";
            // 
            // MagnetHeading
            // 
            this.MagnetHeading.AutoSize = true;
            this.MagnetHeading.Location = new System.Drawing.Point(731, 32);
            this.MagnetHeading.Name = "MagnetHeading";
            this.MagnetHeading.Size = new System.Drawing.Size(13, 13);
            this.MagnetHeading.TabIndex = 45;
            this.MagnetHeading.Text = "0";
            // 
            // oscStopbtn
            // 
            this.oscStopbtn.Location = new System.Drawing.Point(14, 166);
            this.oscStopbtn.Name = "oscStopbtn";
            this.oscStopbtn.Size = new System.Drawing.Size(102, 23);
            this.oscStopbtn.TabIndex = 49;
            this.oscStopbtn.Text = "OSC stoppen";
            this.oscStopbtn.UseVisualStyleBackColor = true;
            this.oscStopbtn.Click += new System.EventHandler(this.oscStopbtn_Click);
            // 
            // OSCStatus
            // 
            this.OSCStatus.AutoSize = true;
            this.OSCStatus.BackColor = System.Drawing.Color.Red;
            this.OSCStatus.Location = new System.Drawing.Point(122, 145);
            this.OSCStatus.Name = "OSCStatus";
            this.OSCStatus.Size = new System.Drawing.Size(37, 13);
            this.OSCStatus.TabIndex = 48;
            this.OSCStatus.Text = "Offline";
            // 
            // oscStartbtn
            // 
            this.oscStartbtn.Location = new System.Drawing.Point(13, 118);
            this.oscStartbtn.Name = "oscStartbtn";
            this.oscStartbtn.Size = new System.Drawing.Size(103, 23);
            this.oscStartbtn.TabIndex = 47;
            this.oscStartbtn.Text = "OSC starten";
            this.oscStartbtn.UseVisualStyleBackColor = true;
            this.oscStartbtn.Click += new System.EventHandler(this.oscStartbtn_Click);
            // 
            // magnetchk
            // 
            this.magnetchk.AutoSize = true;
            this.magnetchk.Location = new System.Drawing.Point(386, 31);
            this.magnetchk.Name = "magnetchk";
            this.magnetchk.Size = new System.Drawing.Size(15, 14);
            this.magnetchk.TabIndex = 50;
            this.magnetchk.UseVisualStyleBackColor = true;
            // 
            // gravitychk
            // 
            this.gravitychk.AutoSize = true;
            this.gravitychk.Location = new System.Drawing.Point(386, 96);
            this.gravitychk.Name = "gravitychk";
            this.gravitychk.Size = new System.Drawing.Size(15, 14);
            this.gravitychk.TabIndex = 51;
            this.gravitychk.UseVisualStyleBackColor = true;
            // 
            // quaternionchk
            // 
            this.quaternionchk.AutoSize = true;
            this.quaternionchk.Location = new System.Drawing.Point(386, 166);
            this.quaternionchk.Name = "quaternionchk";
            this.quaternionchk.Size = new System.Drawing.Size(15, 14);
            this.quaternionchk.TabIndex = 52;
            this.quaternionchk.UseVisualStyleBackColor = true;
            // 
            // acclerationchk
            // 
            this.acclerationchk.AutoSize = true;
            this.acclerationchk.Location = new System.Drawing.Point(385, 218);
            this.acclerationchk.Name = "acclerationchk";
            this.acclerationchk.Size = new System.Drawing.Size(15, 14);
            this.acclerationchk.TabIndex = 53;
            this.acclerationchk.UseVisualStyleBackColor = true;
            // 
            // rotationchk
            // 
            this.rotationchk.AutoSize = true;
            this.rotationchk.Location = new System.Drawing.Point(386, 278);
            this.rotationchk.Name = "rotationchk";
            this.rotationchk.Size = new System.Drawing.Size(15, 14);
            this.rotationchk.TabIndex = 54;
            this.rotationchk.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(669, 310);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(31, 13);
            this.label25.TabIndex = 56;
            this.label25.Text = "Pitch";
            // 
            // RotationPitch
            // 
            this.RotationPitch.AutoSize = true;
            this.RotationPitch.Location = new System.Drawing.Point(669, 329);
            this.RotationPitch.Name = "RotationPitch";
            this.RotationPitch.Size = new System.Drawing.Size(13, 13);
            this.RotationPitch.TabIndex = 55;
            this.RotationPitch.Text = "0";
            // 
            // OSCIP
            // 
            this.OSCIP.Location = new System.Drawing.Point(125, 200);
            this.OSCIP.Name = "OSCIP";
            this.OSCIP.Size = new System.Drawing.Size(100, 20);
            this.OSCIP.TabIndex = 57;
            this.OSCIP.Text = "192.168.137.1";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(25, 203);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 13);
            this.label26.TabIndex = 58;
            this.label26.Text = "OSC Server IP";
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(146, 9);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(0, 13);
            this.IPLabel.TabIndex = 59;
            // 
            // OSCIPPort
            // 
            this.OSCIPPort.Location = new System.Drawing.Point(231, 200);
            this.OSCIPPort.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.OSCIPPort.Name = "OSCIPPort";
            this.OSCIPPort.Size = new System.Drawing.Size(120, 20);
            this.OSCIPPort.TabIndex = 61;
            this.OSCIPPort.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(136, 57);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 13);
            this.label27.TabIndex = 62;
            this.label27.Text = "Latency";
            // 
            // LatencyLabel
            // 
            this.LatencyLabel.AutoSize = true;
            this.LatencyLabel.Location = new System.Drawing.Point(201, 57);
            this.LatencyLabel.Name = "LatencyLabel";
            this.LatencyLabel.Size = new System.Drawing.Size(0, 13);
            this.LatencyLabel.TabIndex = 63;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.LatencyLabel);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.OSCIPPort);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.OSCIP);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.RotationPitch);
            this.Controls.Add(this.rotationchk);
            this.Controls.Add(this.acclerationchk);
            this.Controls.Add(this.quaternionchk);
            this.Controls.Add(this.gravitychk);
            this.Controls.Add(this.magnetchk);
            this.Controls.Add(this.oscStopbtn);
            this.Controls.Add(this.OSCStatus);
            this.Controls.Add(this.oscStartbtn);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.MagnetHeading);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.QuatnernionW);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.RotationYaw);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.RotationRoll);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.RotationZ);
            this.Controls.Add(this.RotationY);
            this.Controls.Add(this.RotationX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.AcclerationZ);
            this.Controls.Add(this.AcclerationY);
            this.Controls.Add(this.AcclerationX);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.QuatnernionZ);
            this.Controls.Add(this.QuatnernionY);
            this.Controls.Add(this.QuatnernionX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GarvityZ);
            this.Controls.Add(this.GarvityY);
            this.Controls.Add(this.GarvityX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MagnetZ);
            this.Controls.Add(this.MagnetY);
            this.Controls.Add(this.MagnetX);
            this.Controls.Add(this.ServerStateLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OSCIPPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ServerStateLabel;
        private System.Windows.Forms.Label MagnetX;
        private System.Windows.Forms.Label MagnetY;
        private System.Windows.Forms.Label MagnetZ;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label GarvityZ;
        private System.Windows.Forms.Label GarvityY;
        private System.Windows.Forms.Label GarvityX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label QuatnernionZ;
        private System.Windows.Forms.Label QuatnernionY;
        private System.Windows.Forms.Label QuatnernionX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label AcclerationZ;
        private System.Windows.Forms.Label AcclerationY;
        private System.Windows.Forms.Label AcclerationX;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label RotationZ;
        private System.Windows.Forms.Label RotationY;
        private System.Windows.Forms.Label RotationX;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label RotationRoll;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label RotationYaw;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label QuatnernionW;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label MagnetHeading;
        private System.Windows.Forms.Button oscStopbtn;
        private System.Windows.Forms.Label OSCStatus;
        private System.Windows.Forms.Button oscStartbtn;
        private System.Windows.Forms.CheckBox magnetchk;
        private System.Windows.Forms.CheckBox gravitychk;
        private System.Windows.Forms.CheckBox quaternionchk;
        private System.Windows.Forms.CheckBox acclerationchk;
        private System.Windows.Forms.CheckBox rotationchk;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label RotationPitch;
        private System.Windows.Forms.TextBox OSCIP;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.NumericUpDown OSCIPPort;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label LatencyLabel;
    }
}

