
namespace RS232_Test_Touch_Panel
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
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose ( );
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			this.components = new System.ComponentModel.Container();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chBox_RtsEnable = new System.Windows.Forms.CheckBox();
			this.chBox_DtrErnable = new System.Windows.Forms.CheckBox();
			this.PARTY_BITS_Lbl = new System.Windows.Forms.Label();
			this.STOP_BITS_Lbl = new System.Windows.Forms.Label();
			this.DATA_BITS_Lbl = new System.Windows.Forms.Label();
			this.BUAD_RATE_Lbl = new System.Windows.Forms.Label();
			this.COM_PORT_Lbl = new System.Windows.Forms.Label();
			this.Cbox_PARTY_BITS = new System.Windows.Forms.ComboBox();
			this.Cbox_STOP_BITS = new System.Windows.Forms.ComboBox();
			this.Cbox_DATA_BITS = new System.Windows.Forms.ComboBox();
			this.Cbox_BUAD_RATE = new System.Windows.Forms.ComboBox();
			this.Cbox_COM_PORT = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.lbIStatusCom = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_Open = new System.Windows.Forms.Button();
			this.tBoxDataSend = new System.Windows.Forms.TextBox();
			this.btn_SendData = new System.Windows.Forms.Button();
			this.gBox_TransferControl = new System.Windows.Forms.GroupBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.laIDataSendLength = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.chBox_Write = new System.Windows.Forms.CheckBox();
			this.chBox_WriteLine = new System.Windows.Forms.CheckBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.chBox_UsingEnter = new System.Windows.Forms.CheckBox();
			this.chBox_UsingBtn = new System.Windows.Forms.CheckBox();
			this.btn_ClearDataOUT = new System.Windows.Forms.Button();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.lb_ReeceiverLegth = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tBox_DataIN = new System.Windows.Forms.TextBox();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.chBox_AddToOldData = new System.Windows.Forms.CheckBox();
			this.chBox_AlwaysUpday = new System.Windows.Forms.CheckBox();
			this.btn_ClearDataIn = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.gBox_TransferControl.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.SuspendLayout();
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chBox_RtsEnable);
			this.groupBox1.Controls.Add(this.chBox_DtrErnable);
			this.groupBox1.Controls.Add(this.PARTY_BITS_Lbl);
			this.groupBox1.Controls.Add(this.STOP_BITS_Lbl);
			this.groupBox1.Controls.Add(this.DATA_BITS_Lbl);
			this.groupBox1.Controls.Add(this.BUAD_RATE_Lbl);
			this.groupBox1.Controls.Add(this.COM_PORT_Lbl);
			this.groupBox1.Controls.Add(this.Cbox_PARTY_BITS);
			this.groupBox1.Controls.Add(this.Cbox_STOP_BITS);
			this.groupBox1.Controls.Add(this.Cbox_DATA_BITS);
			this.groupBox1.Controls.Add(this.Cbox_BUAD_RATE);
			this.groupBox1.Controls.Add(this.Cbox_COM_PORT);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(257, 183);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// chBox_RtsEnable
			// 
			this.chBox_RtsEnable.AutoSize = true;
			this.chBox_RtsEnable.Location = new System.Drawing.Point(127, 160);
			this.chBox_RtsEnable.Name = "chBox_RtsEnable";
			this.chBox_RtsEnable.Size = new System.Drawing.Size(85, 17);
			this.chBox_RtsEnable.TabIndex = 0;
			this.chBox_RtsEnable.Text = "RTS TABLE";
			this.chBox_RtsEnable.UseVisualStyleBackColor = true;
			this.chBox_RtsEnable.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
			// 
			// chBox_DtrErnable
			// 
			this.chBox_DtrErnable.AutoSize = true;
			this.chBox_DtrErnable.Location = new System.Drawing.Point(27, 160);
			this.chBox_DtrErnable.Name = "chBox_DtrErnable";
			this.chBox_DtrErnable.Size = new System.Drawing.Size(94, 17);
			this.chBox_DtrErnable.TabIndex = 0;
			this.chBox_DtrErnable.Text = "DTR ENABLE";
			this.chBox_DtrErnable.UseVisualStyleBackColor = true;
			this.chBox_DtrErnable.CheckedChanged += new System.EventHandler(this.chBox_DTRrnable_CheckedChanged);
			// 
			// PARTY_BITS_Lbl
			// 
			this.PARTY_BITS_Lbl.AutoSize = true;
			this.PARTY_BITS_Lbl.Location = new System.Drawing.Point(24, 144);
			this.PARTY_BITS_Lbl.Name = "PARTY_BITS_Lbl";
			this.PARTY_BITS_Lbl.Size = new System.Drawing.Size(70, 13);
			this.PARTY_BITS_Lbl.TabIndex = 6;
			this.PARTY_BITS_Lbl.Text = "PARTY BITS";
			// 
			// STOP_BITS_Lbl
			// 
			this.STOP_BITS_Lbl.AutoSize = true;
			this.STOP_BITS_Lbl.Location = new System.Drawing.Point(24, 117);
			this.STOP_BITS_Lbl.Name = "STOP_BITS_Lbl";
			this.STOP_BITS_Lbl.Size = new System.Drawing.Size(63, 13);
			this.STOP_BITS_Lbl.TabIndex = 6;
			this.STOP_BITS_Lbl.Text = "STOP BITS";
			// 
			// DATA_BITS_Lbl
			// 
			this.DATA_BITS_Lbl.AutoSize = true;
			this.DATA_BITS_Lbl.Location = new System.Drawing.Point(24, 90);
			this.DATA_BITS_Lbl.Name = "DATA_BITS_Lbl";
			this.DATA_BITS_Lbl.Size = new System.Drawing.Size(63, 13);
			this.DATA_BITS_Lbl.TabIndex = 6;
			this.DATA_BITS_Lbl.Text = "DATA BITS";
			// 
			// BUAD_RATE_Lbl
			// 
			this.BUAD_RATE_Lbl.AutoSize = true;
			this.BUAD_RATE_Lbl.Location = new System.Drawing.Point(24, 63);
			this.BUAD_RATE_Lbl.Name = "BUAD_RATE_Lbl";
			this.BUAD_RATE_Lbl.Size = new System.Drawing.Size(69, 13);
			this.BUAD_RATE_Lbl.TabIndex = 6;
			this.BUAD_RATE_Lbl.Text = "BUAD RATE";
			// 
			// COM_PORT_Lbl
			// 
			this.COM_PORT_Lbl.AutoSize = true;
			this.COM_PORT_Lbl.Location = new System.Drawing.Point(24, 36);
			this.COM_PORT_Lbl.Name = "COM_PORT_Lbl";
			this.COM_PORT_Lbl.Size = new System.Drawing.Size(64, 13);
			this.COM_PORT_Lbl.TabIndex = 6;
			this.COM_PORT_Lbl.Text = "COM PORT";
			// 
			// Cbox_PARTY_BITS
			// 
			this.Cbox_PARTY_BITS.FormattingEnabled = true;
			this.Cbox_PARTY_BITS.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
			this.Cbox_PARTY_BITS.Location = new System.Drawing.Point(106, 136);
			this.Cbox_PARTY_BITS.Name = "Cbox_PARTY_BITS";
			this.Cbox_PARTY_BITS.Size = new System.Drawing.Size(121, 21);
			this.Cbox_PARTY_BITS.TabIndex = 4;
			this.Cbox_PARTY_BITS.Text = "none";
			// 
			// Cbox_STOP_BITS
			// 
			this.Cbox_STOP_BITS.FormattingEnabled = true;
			this.Cbox_STOP_BITS.Items.AddRange(new object[] {
            "One",
            "Two"});
			this.Cbox_STOP_BITS.Location = new System.Drawing.Point(106, 109);
			this.Cbox_STOP_BITS.Name = "Cbox_STOP_BITS";
			this.Cbox_STOP_BITS.Size = new System.Drawing.Size(121, 21);
			this.Cbox_STOP_BITS.TabIndex = 3;
			this.Cbox_STOP_BITS.Text = "One";
			// 
			// Cbox_DATA_BITS
			// 
			this.Cbox_DATA_BITS.FormattingEnabled = true;
			this.Cbox_DATA_BITS.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
			this.Cbox_DATA_BITS.Location = new System.Drawing.Point(106, 82);
			this.Cbox_DATA_BITS.Name = "Cbox_DATA_BITS";
			this.Cbox_DATA_BITS.Size = new System.Drawing.Size(121, 21);
			this.Cbox_DATA_BITS.TabIndex = 2;
			this.Cbox_DATA_BITS.Text = "8";
			// 
			// Cbox_BUAD_RATE
			// 
			this.Cbox_BUAD_RATE.FormattingEnabled = true;
			this.Cbox_BUAD_RATE.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9200",
            "115200"});
			this.Cbox_BUAD_RATE.Location = new System.Drawing.Point(106, 55);
			this.Cbox_BUAD_RATE.Name = "Cbox_BUAD_RATE";
			this.Cbox_BUAD_RATE.Size = new System.Drawing.Size(121, 21);
			this.Cbox_BUAD_RATE.TabIndex = 1;
			this.Cbox_BUAD_RATE.Text = "9600";
			// 
			// Cbox_COM_PORT
			// 
			this.Cbox_COM_PORT.FormattingEnabled = true;
			this.Cbox_COM_PORT.Location = new System.Drawing.Point(106, 28);
			this.Cbox_COM_PORT.Name = "Cbox_COM_PORT";
			this.Cbox_COM_PORT.Size = new System.Drawing.Size(121, 21);
			this.Cbox_COM_PORT.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox7);
			this.groupBox2.Controls.Add(this.progressBar1);
			this.groupBox2.Controls.Add(this.btn_Close);
			this.groupBox2.Controls.Add(this.btn_Open);
			this.groupBox2.Location = new System.Drawing.Point(12, 201);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(257, 125);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.lbIStatusCom);
			this.groupBox7.Location = new System.Drawing.Point(87, 13);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(164, 72);
			this.groupBox7.TabIndex = 2;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "COM PORT  STATUS";
			// 
			// lbIStatusCom
			// 
			this.lbIStatusCom.AutoSize = true;
			this.lbIStatusCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lbIStatusCom.Location = new System.Drawing.Point(19, 29);
			this.lbIStatusCom.Name = "lbIStatusCom";
			this.lbIStatusCom.Size = new System.Drawing.Size(35, 17);
			this.lbIStatusCom.TabIndex = 0;
			this.lbIStatusCom.Text = "OFF";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(5, 91);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(246, 23);
			this.progressBar1.TabIndex = 1;
			// 
			// btn_Close
			// 
			this.btn_Close.Location = new System.Drawing.Point(5, 62);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(75, 23);
			this.btn_Close.TabIndex = 0;
			this.btn_Close.Text = "CLOSE";
			this.btn_Close.UseVisualStyleBackColor = true;
			this.btn_Close.Click += new System.EventHandler(this.Close_Btn_Click);
			// 
			// btn_Open
			// 
			this.btn_Open.Location = new System.Drawing.Point(6, 33);
			this.btn_Open.Name = "btn_Open";
			this.btn_Open.Size = new System.Drawing.Size(75, 23);
			this.btn_Open.TabIndex = 0;
			this.btn_Open.Text = "OPEN";
			this.btn_Open.UseVisualStyleBackColor = true;
			this.btn_Open.Click += new System.EventHandler(this.Open_Btn_Click);
			// 
			// tBoxDataSend
			// 
			this.tBoxDataSend.Location = new System.Drawing.Point(6, 19);
			this.tBoxDataSend.Multiline = true;
			this.tBoxDataSend.Name = "tBoxDataSend";
			this.tBoxDataSend.Size = new System.Drawing.Size(283, 98);
			this.tBoxDataSend.TabIndex = 1;
			this.tBoxDataSend.TextChanged += new System.EventHandler(this.tBoxDataSend_TextChanged);
			this.tBoxDataSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxDataSend_KeyDown);
			// 
			// btn_SendData
			// 
			this.btn_SendData.Location = new System.Drawing.Point(6, 24);
			this.btn_SendData.Name = "btn_SendData";
			this.btn_SendData.Size = new System.Drawing.Size(93, 31);
			this.btn_SendData.TabIndex = 0;
			this.btn_SendData.Text = "Send Data";
			this.btn_SendData.UseVisualStyleBackColor = true;
			this.btn_SendData.Click += new System.EventHandler(this.Send_Data_but_Click);
			// 
			// gBox_TransferControl
			// 
			this.gBox_TransferControl.Controls.Add(this.groupBox6);
			this.gBox_TransferControl.Controls.Add(this.groupBox3);
			this.gBox_TransferControl.Controls.Add(this.tBoxDataSend);
			this.gBox_TransferControl.Location = new System.Drawing.Point(275, 14);
			this.gBox_TransferControl.Name = "gBox_TransferControl";
			this.gBox_TransferControl.Size = new System.Drawing.Size(305, 301);
			this.gBox_TransferControl.TabIndex = 2;
			this.gBox_TransferControl.TabStop = false;
			this.gBox_TransferControl.Text = "Transfer Control";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.laIDataSendLength);
			this.groupBox6.Controls.Add(this.label1);
			this.groupBox6.Location = new System.Drawing.Point(6, 238);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(283, 52);
			this.groupBox6.TabIndex = 3;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "groupBox6";
			// 
			// laIDataSendLength
			// 
			this.laIDataSendLength.AutoSize = true;
			this.laIDataSendLength.Location = new System.Drawing.Point(96, 21);
			this.laIDataSendLength.Name = "laIDataSendLength";
			this.laIDataSendLength.Size = new System.Drawing.Size(19, 13);
			this.laIDataSendLength.TabIndex = 0;
			this.laIDataSendLength.Text = "00";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Data OUT Legth :";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.groupBox5);
			this.groupBox3.Controls.Add(this.groupBox4);
			this.groupBox3.Controls.Add(this.btn_SendData);
			this.groupBox3.Controls.Add(this.btn_ClearDataOUT);
			this.groupBox3.Location = new System.Drawing.Point(6, 132);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(293, 100);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "groupBox3";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.chBox_Write);
			this.groupBox5.Controls.Add(this.chBox_WriteLine);
			this.groupBox5.Location = new System.Drawing.Point(205, 20);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(78, 74);
			this.groupBox5.TabIndex = 1;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "groupBox4";
			// 
			// chBox_Write
			// 
			this.chBox_Write.AutoSize = true;
			this.chBox_Write.Location = new System.Drawing.Point(6, 43);
			this.chBox_Write.Name = "chBox_Write";
			this.chBox_Write.Size = new System.Drawing.Size(51, 17);
			this.chBox_Write.TabIndex = 0;
			this.chBox_Write.Text = "Write";
			this.chBox_Write.UseVisualStyleBackColor = true;
			this.chBox_Write.CheckedChanged += new System.EventHandler(this.chBox_Write_CheckedChanged);
			// 
			// chBox_WriteLine
			// 
			this.chBox_WriteLine.AutoSize = true;
			this.chBox_WriteLine.Location = new System.Drawing.Point(7, 20);
			this.chBox_WriteLine.Name = "chBox_WriteLine";
			this.chBox_WriteLine.Size = new System.Drawing.Size(71, 17);
			this.chBox_WriteLine.TabIndex = 0;
			this.chBox_WriteLine.Text = "WriteLine";
			this.chBox_WriteLine.UseVisualStyleBackColor = true;
			this.chBox_WriteLine.CheckedChanged += new System.EventHandler(this.chBox_Writeline_CheckedChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.chBox_UsingEnter);
			this.groupBox4.Controls.Add(this.chBox_UsingBtn);
			this.groupBox4.Location = new System.Drawing.Point(105, 20);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(94, 74);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "groupBox4";
			// 
			// chBox_UsingEnter
			// 
			this.chBox_UsingEnter.AutoSize = true;
			this.chBox_UsingEnter.Location = new System.Drawing.Point(6, 43);
			this.chBox_UsingEnter.Name = "chBox_UsingEnter";
			this.chBox_UsingEnter.Size = new System.Drawing.Size(81, 17);
			this.chBox_UsingEnter.TabIndex = 0;
			this.chBox_UsingEnter.Text = "Using Enter";
			this.chBox_UsingEnter.UseVisualStyleBackColor = true;
			// 
			// chBox_UsingBtn
			// 
			this.chBox_UsingBtn.AutoSize = true;
			this.chBox_UsingBtn.Location = new System.Drawing.Point(7, 20);
			this.chBox_UsingBtn.Name = "chBox_UsingBtn";
			this.chBox_UsingBtn.Size = new System.Drawing.Size(87, 17);
			this.chBox_UsingBtn.TabIndex = 0;
			this.chBox_UsingBtn.Text = "Using Botton";
			this.chBox_UsingBtn.UseVisualStyleBackColor = true;
			this.chBox_UsingBtn.CheckedChanged += new System.EventHandler(this.chBox_UsingBtn_CheckedChanged);
			// 
			// btn_ClearDataOUT
			// 
			this.btn_ClearDataOUT.Location = new System.Drawing.Point(6, 64);
			this.btn_ClearDataOUT.Name = "btn_ClearDataOUT";
			this.btn_ClearDataOUT.Size = new System.Drawing.Size(93, 30);
			this.btn_ClearDataOUT.TabIndex = 0;
			this.btn_ClearDataOUT.Text = "Clear Data OUT";
			this.btn_ClearDataOUT.UseVisualStyleBackColor = true;
			this.btn_ClearDataOUT.Click += new System.EventHandler(this.btn_ClearDataOUT_Click);
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.groupBox12);
			this.groupBox8.Controls.Add(this.tBox_DataIN);
			this.groupBox8.Controls.Add(this.groupBox9);
			this.groupBox8.Location = new System.Drawing.Point(586, 14);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(326, 301);
			this.groupBox8.TabIndex = 3;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Receiver";
			// 
			// groupBox12
			// 
			this.groupBox12.Controls.Add(this.lb_ReeceiverLegth);
			this.groupBox12.Controls.Add(this.label3);
			this.groupBox12.Location = new System.Drawing.Point(6, 238);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(283, 52);
			this.groupBox12.TabIndex = 3;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "groupBox6";
			// 
			// lb_ReeceiverLegth
			// 
			this.lb_ReeceiverLegth.AutoSize = true;
			this.lb_ReeceiverLegth.Location = new System.Drawing.Point(96, 21);
			this.lb_ReeceiverLegth.Name = "lb_ReeceiverLegth";
			this.lb_ReeceiverLegth.Size = new System.Drawing.Size(19, 13);
			this.lb_ReeceiverLegth.TabIndex = 0;
			this.lb_ReeceiverLegth.Text = "00";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Data In Legth :";
			// 
			// tBox_DataIN
			// 
			this.tBox_DataIN.Location = new System.Drawing.Point(6, 19);
			this.tBox_DataIN.Multiline = true;
			this.tBox_DataIN.Name = "tBox_DataIN";
			this.tBox_DataIN.Size = new System.Drawing.Size(283, 98);
			this.tBox_DataIN.TabIndex = 1;
			this.tBox_DataIN.TextChanged += new System.EventHandler(this.tBoxDataSend_TextChanged);
			this.tBox_DataIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxDataSend_KeyDown);
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.groupBox11);
			this.groupBox9.Controls.Add(this.btn_ClearDataIn);
			this.groupBox9.Location = new System.Drawing.Point(6, 132);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(293, 100);
			this.groupBox9.TabIndex = 2;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "groupBox3";
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.chBox_AddToOldData);
			this.groupBox11.Controls.Add(this.chBox_AlwaysUpday);
			this.groupBox11.Location = new System.Drawing.Point(105, 20);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(120, 74);
			this.groupBox11.TabIndex = 1;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "groupBox4";
			// 
			// chBox_AddToOldData
			// 
			this.chBox_AddToOldData.AutoSize = true;
			this.chBox_AddToOldData.Location = new System.Drawing.Point(6, 43);
			this.chBox_AddToOldData.Name = "chBox_AddToOldData";
			this.chBox_AddToOldData.Size = new System.Drawing.Size(106, 17);
			this.chBox_AddToOldData.TabIndex = 0;
			this.chBox_AddToOldData.Text = "Add To Old Data";
			this.chBox_AddToOldData.UseVisualStyleBackColor = true;
			this.chBox_AddToOldData.CheckedChanged += new System.EventHandler(this.chBox_AddToOldData_CheckedChanged);
			// 
			// chBox_AlwaysUpday
			// 
			this.chBox_AlwaysUpday.AutoSize = true;
			this.chBox_AlwaysUpday.Location = new System.Drawing.Point(7, 20);
			this.chBox_AlwaysUpday.Name = "chBox_AlwaysUpday";
			this.chBox_AlwaysUpday.Size = new System.Drawing.Size(93, 17);
			this.chBox_AlwaysUpday.TabIndex = 0;
			this.chBox_AlwaysUpday.Text = "Always Upday";
			this.chBox_AlwaysUpday.UseVisualStyleBackColor = true;
			this.chBox_AlwaysUpday.CheckedChanged += new System.EventHandler(this.chBox_AlwaysUpday_CheckedChanged);
			// 
			// btn_ClearDataIn
			// 
			this.btn_ClearDataIn.Location = new System.Drawing.Point(6, 19);
			this.btn_ClearDataIn.Name = "btn_ClearDataIn";
			this.btn_ClearDataIn.Size = new System.Drawing.Size(93, 75);
			this.btn_ClearDataIn.TabIndex = 0;
			this.btn_ClearDataIn.Text = "Clear Data In";
			this.btn_ClearDataIn.UseVisualStyleBackColor = true;
			this.btn_ClearDataIn.Click += new System.EventHandler(this.btn_ClearDataIn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(936, 450);
			this.Controls.Add(this.groupBox8);
			this.Controls.Add(this.gBox_TransferControl);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.gBox_TransferControl.ResumeLayout(false);
			this.gBox_TransferControl.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.groupBox12.ResumeLayout(false);
			this.groupBox12.PerformLayout();
			this.groupBox9.ResumeLayout(false);
			this.groupBox11.ResumeLayout(false);
			this.groupBox11.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label PARTY_BITS_Lbl;
		private System.Windows.Forms.Label STOP_BITS_Lbl;
		private System.Windows.Forms.Label DATA_BITS_Lbl;
		private System.Windows.Forms.Label BUAD_RATE_Lbl;
		private System.Windows.Forms.Label COM_PORT_Lbl;
		private System.Windows.Forms.ComboBox Cbox_PARTY_BITS;
		private System.Windows.Forms.ComboBox Cbox_STOP_BITS;
		private System.Windows.Forms.ComboBox Cbox_DATA_BITS;
		private System.Windows.Forms.ComboBox Cbox_BUAD_RATE;
		private System.Windows.Forms.ComboBox Cbox_COM_PORT;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Button btn_Open;
		private System.Windows.Forms.TextBox tBoxDataSend;
		private System.Windows.Forms.Button btn_SendData;
		private System.Windows.Forms.GroupBox gBox_TransferControl;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.CheckBox chBox_Write;
		private System.Windows.Forms.CheckBox chBox_WriteLine;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox chBox_UsingEnter;
		private System.Windows.Forms.CheckBox chBox_UsingBtn;
		private System.Windows.Forms.Button btn_ClearDataOUT;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label laIDataSendLength;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chBox_RtsEnable;
		private System.Windows.Forms.CheckBox chBox_DtrErnable;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Label lbIStatusCom;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.Label lb_ReeceiverLegth;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tBox_DataIN;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.CheckBox chBox_AddToOldData;
		private System.Windows.Forms.CheckBox chBox_AlwaysUpday;
		private System.Windows.Forms.Button btn_ClearDataIn;
	}
}

