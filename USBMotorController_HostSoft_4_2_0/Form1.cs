using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

///////////////////////////////////////////////////////////////////////////////////////////////////
namespace USBMotorController {

	/////////////////////////////////////////////////////////////////////////////////////////////////
	public partial class Form1 : Form {

		// constants //////////////////////////////////////////////////////////////////////////////////
		const int LEFT_DC_MOTOR_COAST = 0x00;
		const int LEFT_DC_MOTOR_FORWARD = 0x01;
		const int LEFT_DC_MOTOR_REVERSE = 0x02;
		const int LEFT_DC_MOTOR_BRAKE = 0x03;

		const int RIGHT_DC_MOTOR_COAST = 0x00;
		const int RIGHT_DC_MOTOR_FORWARD = 0x01;
		const int RIGHT_DC_MOTOR_REVERSE = 0x02;
		const int RIGHT_DC_MOTOR_BRAKE = 0x03;

		const int HOLD_POSITION = 0x00;
		const int STEP_CLOCKWISE = 0x01;
		const int STEP_COUNTERCLOCKWISE = 0x02;

		// member variables ///////////////////////////////////////////////////////////////////////////
		public USBClass USBObject;

		///////////////////////////////////////////////////////////////////////////////////////////////
		public Form1() {
			InitializeComponent();
			USBObject = new USBClass();
		}

		///////////////////////////////////////////////////////////////////////////////////////////////
		private void Form1_Load(object sender, EventArgs e) {
			attemptUSBConnectionFrontEnd();						// attempt USB connection
		}

		///////////////////////////////////////////////////////////////////////////////////////////////
		private void lblInfo_Click(object sender, EventArgs e) {
			if (USBObject.connectionState == USBClass.CONNECTION_NOT_SUCCESSFUL)
			{				// verify not already connected . . .
				attemptUSBConnectionFrontEnd();														// then attempt to connect again
			}
		}

		///////////////////////////////////////////////////////////////////////////////////////////////////
		void attemptUSBConnectionFrontEnd()
		{
			lblInfo.Text = "connecting . . . ";

			USBObject.connectionState = USBObject.attemptUSBConnection();												// attempt to connect to USB board

			if (USBObject.connectionState == USBClass.CONNECTION_SUCCESSFUL)
			{								// if connection was successful
				lblInfo.BackColor = System.Drawing.Color.LimeGreen;
				lblInfo.Text = "connection successful";
				tmrUSB.Enabled = true;
			}
			else if (USBObject.connectionState == USBClass.CONNECTION_NOT_SUCCESSFUL)
			{		// else if connection was not successful
				lblInfo.BackColor = System.Drawing.Color.Red;
				lblInfo.Text = "connection not successful, click here to try again";
			}
		}

		///////////////////////////////////////////////////////////////////////////////////////////////
		private void tmrUSB_Tick(object sender, EventArgs e) {

			//			USBObject.receiveViaUSB();

			USBObject.fromHostToDeviceBuffer[1] = (byte)tbServo.Value;

			if (rdoLeftMotorCoast.Checked == true)
			{
				USBObject.fromHostToDeviceBuffer[2] = LEFT_DC_MOTOR_COAST;
			}
			else if (rdoLeftMotorForward.Checked == true)
			{
				USBObject.fromHostToDeviceBuffer[2] = LEFT_DC_MOTOR_FORWARD;
			}
			else if (rdoLeftMotorReverse.Checked == true)
			{
				USBObject.fromHostToDeviceBuffer[2] = LEFT_DC_MOTOR_REVERSE;
			}
			else if (rdoLeftMotorBrake.Checked == true)
			{
				USBObject.fromHostToDeviceBuffer[2] = LEFT_DC_MOTOR_BRAKE;
			}
			else
			{
				// should never get here
			}

			if (rdoRightMotorCoast.Checked == true)
			{
				USBObject.fromHostToDeviceBuffer[3] = RIGHT_DC_MOTOR_COAST;
			}
			else if (rdoRightMotorForward.Checked == true)
			{
				USBObject.fromHostToDeviceBuffer[3] = RIGHT_DC_MOTOR_FORWARD;
			}
			else if (rdoRightMotorReverse.Checked == true)
			{
				USBObject.fromHostToDeviceBuffer[3] = RIGHT_DC_MOTOR_REVERSE;
			}
			else if (rdoRightMotorBrake.Checked == true)
			{
				USBObject.fromHostToDeviceBuffer[3] = RIGHT_DC_MOTOR_BRAKE;
			}
			else
			{
				// should never get here
			}

			if (rdoHoldPosition.Checked == true)
			{
				USBObject.fromHostToDeviceBuffer[4] = HOLD_POSITION;
			}
			else if (rdoStepClockwise.Checked == true)
			{
				USBObject.fromHostToDeviceBuffer[4] = STEP_CLOCKWISE;
			}
			else if (rdoStepCounterclockwise.Checked == true)
			{
				USBObject.fromHostToDeviceBuffer[4] = STEP_COUNTERCLOCKWISE;
			}
			else
			{
				// should never get here
			}

			USBObject.sendViaUSB();
		}

	}		// end class
}		// end namespace
