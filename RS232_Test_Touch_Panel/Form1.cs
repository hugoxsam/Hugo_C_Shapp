using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RS232_Test_Touch_Panel
{
	public partial class Form1 : Form
	{
		string dataOut;
		string sendWith;
		string dataIN;
		public Form1 ( )
		{
			InitializeComponent ( );
		}

		private void Send_Data_but_Click ( object sender , EventArgs e )
		{
			if ( serialPort1.IsOpen )
			{
				dataOut= tBoxDataSend.Text;
				if ( sendWith == "WriteLine" )
				{
					serialPort1.WriteLine ( dataOut );
				} else if ( sendWith == "Write" )

				{
					serialPort1.WriteLine ( dataOut );
				}

			}
		}

		private void btn_ClearDataOUT_Click ( object sender , EventArgs e )
		{
			if ( tBoxDataSend.Text !="" )
			{
				tBoxDataSend.Text = "";
			}
		}

		private void Form1_Load ( object sender , EventArgs e )
		{
			string[ ] ports = SerialPort.GetPortNames ( );
			Cbox_COM_PORT.Items.AddRange ( ports );
			btn_Open.Enabled = true;
			btn_Close.Enabled = false;

			chBox_DtrErnable.Checked = false;
			serialPort1.DtrEnable = false;

			chBox_RtsEnable.Checked = false;
			serialPort1.RtsEnable = false;

			btn_SendData.Enabled = false;
			chBox_WriteLine.Checked = false;
			chBox_Write.Checked = true;
			sendWith = "Write";

			chBox_AlwaysUpday.Checked = false;
			chBox_AddToOldData.Checked = true;
		}

		private void Open_Btn_Click ( object sender , EventArgs e )
		{
			try
			{
				serialPort1.PortName = Cbox_COM_PORT.Text;
				serialPort1.BaudRate = Convert.ToInt32 ( Cbox_BUAD_RATE.Text );
				serialPort1.DataBits = Convert.ToInt32 ( Cbox_DATA_BITS.Text );
				serialPort1.StopBits = ( StopBits ) Enum.Parse (typeof (StopBits) , Cbox_STOP_BITS.Text );
				serialPort1.Parity = ( Parity ) Enum.Parse ( typeof ( Parity) , Cbox_PARTY_BITS.Text );
				serialPort1.Open ( );
				progressBar1.Value = 100;
				btn_Close.Enabled= true;
				btn_Open.Enabled= false;
				lbIStatusCom.Text = "ON";
			}
			catch (Exception err)
			{
				MessageBox.Show ( err.Message ,  "Error"   , MessageBoxButtons.OK , MessageBoxIcon.Error );
				btn_Close.Enabled = false;
				btn_Open.Enabled = true;
				lbIStatusCom.Text = "OFF";
			}

		}

		private void Close_Btn_Click ( object sender , EventArgs e )
		{
			if ( serialPort1.IsOpen )
			{
				serialPort1.Close ( );
				progressBar1.Value = 0;
				btn_Open.Enabled = true;
				btn_Close.Enabled = false;
				lbIStatusCom.Text = "OFF";
			}
		}

		private void checkBox6_CheckedChanged ( object sender , EventArgs e )
		{
			if ( chBox_RtsEnable.Checked )
			{
				serialPort1.RtsEnable = true;
			}
			else
			{
				serialPort1.RtsEnable = false;
			}
		}

		private void chBox_DTRrnable_CheckedChanged ( object sender , EventArgs e )
		{
			if ( chBox_DtrErnable.Checked )
			{
				serialPort1.DtrEnable = true;
			}
			else
			{
				serialPort1.DtrEnable = false;
			}
		}

		private void tBoxDataSend_TextChanged ( object sender , EventArgs e )
		{
			int dataOutLength = tBoxDataSend.TextLength;
			laIDataSendLength.Text = string.Format ( "{0:00}" , dataOutLength );
			if ( chBox_UsingEnter.Checked )
			{
				tBoxDataSend.Text = tBoxDataSend.Text.Replace ( Environment.NewLine,"");
			}
		}

		private void chBox_UsingBtn_CheckedChanged ( object sender , EventArgs e )
		{
			if ( chBox_UsingBtn.Checked )
			{
				btn_SendData.Enabled = true;
			}
			else
			{
				btn_SendData.Enabled = false;
			}
		}

		private void tBoxDataSend_KeyDown ( object sender , KeyEventArgs e )
		{
			if ( chBox_UsingEnter.Checked )
			{
				if ( e.KeyCode == Keys.Enter )
				{
					dataOut = tBoxDataSend.Text;

						if ( sendWith == "WriteLine" )
						{
							serialPort1.WriteLine ( dataOut );
						}
						else if ( sendWith == "Write" )
						{
							serialPort1.WriteLine ( dataOut );
						}
				}
			}

		}

		private void chBox_Writeline_CheckedChanged ( object sender , EventArgs e )
		{
			if ( chBox_UsingEnter.Checked )
			{
				sendWith = "WriteLine";
				chBox_Write.Checked = false;
				chBox_WriteLine.Checked = true;
			}

		}

		private void chBox_Write_CheckedChanged ( object sender , EventArgs e )
		{
			if ( chBox_Write.Checked )
			{
				sendWith = "Write";
				chBox_Write.Checked = true;
				chBox_WriteLine.Checked = false;
			}
		}

		private void Form1_FormClosed ( object sender , FormClosedEventArgs e )
		{
			serialPort1.Close ( );
		}

		private void serialPort1_DataReceived ( object sender , SerialDataReceivedEventArgs e )
		{
			dataIN = serialPort1.ReadExisting ( );
			this.Invoke ( new EventHandler ( showDate ) );
		}

		private void showDate ( object sender , EventArgs e )
		{
			int dataLength = dataIN.Length;
			lb_ReeceiverLegth.Text = string.Format ( "{0:00}",dataLength );
							if ( chBox_AddToOldData.Checked )
			{
				tBox_DataIN.Text += dataIN;
			}
			else if (chBox_AlwaysUpday.Checked)
			{
				tBox_DataIN.Text = dataIN;
			}
		}

		private void btn_ClearDataIn_Click ( object sender , EventArgs e )
		{
			if ( tBox_DataIN.Text != "" )
			{
				tBox_DataIN.Text = "";
			}
		}

		private void chBox_AlwaysUpday_CheckedChanged ( object sender , EventArgs e )
		{
			if ( chBox_AlwaysUpday.Checked )
			{
				chBox_AlwaysUpday.Checked = true;
				chBox_AddToOldData.Checked = false;

			}
		}

		private void chBox_AddToOldData_CheckedChanged ( object sender , EventArgs e )
		{
			if ( chBox_AddToOldData.Checked )
			{
				chBox_AlwaysUpday.Checked = false;
				chBox_AddToOldData.Checked = true;
			}
			else
			{
				chBox_AlwaysUpday.Checked = true;
			}
		}
	}
}
