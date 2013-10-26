namespace USBMotorController
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
			this.lblInfo = new System.Windows.Forms.Label();
			this.gbServoPosition = new System.Windows.Forms.GroupBox();
			this.gbLeftDCMotor = new System.Windows.Forms.GroupBox();
			this.gbRightDCMotor = new System.Windows.Forms.GroupBox();
			this.gbStepperMotor = new System.Windows.Forms.GroupBox();
			this.tbServo = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rdoLeftMotorCoast = new System.Windows.Forms.RadioButton();
			this.rdoLeftMotorForward = new System.Windows.Forms.RadioButton();
			this.rdoLeftMotorReverse = new System.Windows.Forms.RadioButton();
			this.rdoLeftMotorBrake = new System.Windows.Forms.RadioButton();
			this.rdoRightMotorCoast = new System.Windows.Forms.RadioButton();
			this.rdoRightMotorForward = new System.Windows.Forms.RadioButton();
			this.rdoRightMotorReverse = new System.Windows.Forms.RadioButton();
			this.rdoRightMotorBrake = new System.Windows.Forms.RadioButton();
			this.rdoHoldPosition = new System.Windows.Forms.RadioButton();
			this.rdoStepClockwise = new System.Windows.Forms.RadioButton();
			this.rdoStepCounterclockwise = new System.Windows.Forms.RadioButton();
			this.tmrUSB = new System.Windows.Forms.Timer(this.components);
			this.gbServoPosition.SuspendLayout();
			this.gbLeftDCMotor.SuspendLayout();
			this.gbRightDCMotor.SuspendLayout();
			this.gbStepperMotor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbServo)).BeginInit();
			this.SuspendLayout();
			// 
			// lblInfo
			// 
			this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfo.Location = new System.Drawing.Point(4, 4);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(492, 28);
			this.lblInfo.TabIndex = 0;
			this.lblInfo.Text = "label1";
			this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
			// 
			// gbServoPosition
			// 
			this.gbServoPosition.Controls.Add(this.label3);
			this.gbServoPosition.Controls.Add(this.label2);
			this.gbServoPosition.Controls.Add(this.tbServo);
			this.gbServoPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbServoPosition.Location = new System.Drawing.Point(4, 36);
			this.gbServoPosition.Name = "gbServoPosition";
			this.gbServoPosition.Size = new System.Drawing.Size(156, 328);
			this.gbServoPosition.TabIndex = 1;
			this.gbServoPosition.TabStop = false;
			this.gbServoPosition.Text = "servo position:";
			// 
			// gbLeftDCMotor
			// 
			this.gbLeftDCMotor.Controls.Add(this.rdoLeftMotorBrake);
			this.gbLeftDCMotor.Controls.Add(this.rdoLeftMotorReverse);
			this.gbLeftDCMotor.Controls.Add(this.rdoLeftMotorForward);
			this.gbLeftDCMotor.Controls.Add(this.rdoLeftMotorCoast);
			this.gbLeftDCMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbLeftDCMotor.Location = new System.Drawing.Point(164, 36);
			this.gbLeftDCMotor.Name = "gbLeftDCMotor";
			this.gbLeftDCMotor.Size = new System.Drawing.Size(160, 180);
			this.gbLeftDCMotor.TabIndex = 2;
			this.gbLeftDCMotor.TabStop = false;
			this.gbLeftDCMotor.Text = "left DC motor:";
			// 
			// gbRightDCMotor
			// 
			this.gbRightDCMotor.Controls.Add(this.rdoRightMotorBrake);
			this.gbRightDCMotor.Controls.Add(this.rdoRightMotorReverse);
			this.gbRightDCMotor.Controls.Add(this.rdoRightMotorForward);
			this.gbRightDCMotor.Controls.Add(this.rdoRightMotorCoast);
			this.gbRightDCMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbRightDCMotor.Location = new System.Drawing.Point(332, 36);
			this.gbRightDCMotor.Name = "gbRightDCMotor";
			this.gbRightDCMotor.Size = new System.Drawing.Size(160, 180);
			this.gbRightDCMotor.TabIndex = 3;
			this.gbRightDCMotor.TabStop = false;
			this.gbRightDCMotor.Text = "right DC motor:";
			// 
			// gbStepperMotor
			// 
			this.gbStepperMotor.Controls.Add(this.rdoStepCounterclockwise);
			this.gbStepperMotor.Controls.Add(this.rdoStepClockwise);
			this.gbStepperMotor.Controls.Add(this.rdoHoldPosition);
			this.gbStepperMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbStepperMotor.Location = new System.Drawing.Point(164, 220);
			this.gbStepperMotor.Name = "gbStepperMotor";
			this.gbStepperMotor.Size = new System.Drawing.Size(328, 144);
			this.gbStepperMotor.TabIndex = 4;
			this.gbStepperMotor.TabStop = false;
			this.gbStepperMotor.Text = "stepper motor direction:";
			// 
			// tbServo
			// 
			this.tbServo.AutoSize = false;
			this.tbServo.Location = new System.Drawing.Point(8, 28);
			this.tbServo.Maximum = 180;
			this.tbServo.Name = "tbServo";
			this.tbServo.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.tbServo.Size = new System.Drawing.Size(53, 296);
			this.tbServo.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(56, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "180 deg";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(56, 292);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "0 deg";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// rdoLeftMotorCoast
			// 
			this.rdoLeftMotorCoast.AutoSize = true;
			this.rdoLeftMotorCoast.Checked = true;
			this.rdoLeftMotorCoast.Location = new System.Drawing.Point(16, 32);
			this.rdoLeftMotorCoast.Name = "rdoLeftMotorCoast";
			this.rdoLeftMotorCoast.Size = new System.Drawing.Size(80, 29);
			this.rdoLeftMotorCoast.TabIndex = 0;
			this.rdoLeftMotorCoast.TabStop = true;
			this.rdoLeftMotorCoast.Text = "coast";
			this.rdoLeftMotorCoast.UseVisualStyleBackColor = true;
			// 
			// rdoLeftMotorForward
			// 
			this.rdoLeftMotorForward.AutoSize = true;
			this.rdoLeftMotorForward.Location = new System.Drawing.Point(16, 68);
			this.rdoLeftMotorForward.Name = "rdoLeftMotorForward";
			this.rdoLeftMotorForward.Size = new System.Drawing.Size(97, 29);
			this.rdoLeftMotorForward.TabIndex = 1;
			this.rdoLeftMotorForward.Text = "forward";
			this.rdoLeftMotorForward.UseVisualStyleBackColor = true;
			// 
			// rdoLeftMotorReverse
			// 
			this.rdoLeftMotorReverse.AutoSize = true;
			this.rdoLeftMotorReverse.Location = new System.Drawing.Point(16, 104);
			this.rdoLeftMotorReverse.Name = "rdoLeftMotorReverse";
			this.rdoLeftMotorReverse.Size = new System.Drawing.Size(98, 29);
			this.rdoLeftMotorReverse.TabIndex = 2;
			this.rdoLeftMotorReverse.Text = "reverse";
			this.rdoLeftMotorReverse.UseVisualStyleBackColor = true;
			// 
			// rdoLeftMotorBrake
			// 
			this.rdoLeftMotorBrake.AutoSize = true;
			this.rdoLeftMotorBrake.Location = new System.Drawing.Point(16, 140);
			this.rdoLeftMotorBrake.Name = "rdoLeftMotorBrake";
			this.rdoLeftMotorBrake.Size = new System.Drawing.Size(82, 29);
			this.rdoLeftMotorBrake.TabIndex = 3;
			this.rdoLeftMotorBrake.Text = "brake";
			this.rdoLeftMotorBrake.UseVisualStyleBackColor = true;
			// 
			// rdoRightMotorCoast
			// 
			this.rdoRightMotorCoast.AutoSize = true;
			this.rdoRightMotorCoast.Checked = true;
			this.rdoRightMotorCoast.Location = new System.Drawing.Point(16, 32);
			this.rdoRightMotorCoast.Name = "rdoRightMotorCoast";
			this.rdoRightMotorCoast.Size = new System.Drawing.Size(80, 29);
			this.rdoRightMotorCoast.TabIndex = 0;
			this.rdoRightMotorCoast.TabStop = true;
			this.rdoRightMotorCoast.Text = "coast";
			this.rdoRightMotorCoast.UseVisualStyleBackColor = true;
			// 
			// rdoRightMotorForward
			// 
			this.rdoRightMotorForward.AutoSize = true;
			this.rdoRightMotorForward.Location = new System.Drawing.Point(16, 68);
			this.rdoRightMotorForward.Name = "rdoRightMotorForward";
			this.rdoRightMotorForward.Size = new System.Drawing.Size(97, 29);
			this.rdoRightMotorForward.TabIndex = 1;
			this.rdoRightMotorForward.Text = "forward";
			this.rdoRightMotorForward.UseVisualStyleBackColor = true;
			// 
			// rdoRightMotorReverse
			// 
			this.rdoRightMotorReverse.AutoSize = true;
			this.rdoRightMotorReverse.Location = new System.Drawing.Point(16, 104);
			this.rdoRightMotorReverse.Name = "rdoRightMotorReverse";
			this.rdoRightMotorReverse.Size = new System.Drawing.Size(98, 29);
			this.rdoRightMotorReverse.TabIndex = 2;
			this.rdoRightMotorReverse.Text = "reverse";
			this.rdoRightMotorReverse.UseVisualStyleBackColor = true;
			// 
			// rdoRightMotorBrake
			// 
			this.rdoRightMotorBrake.AutoSize = true;
			this.rdoRightMotorBrake.Location = new System.Drawing.Point(16, 140);
			this.rdoRightMotorBrake.Name = "rdoRightMotorBrake";
			this.rdoRightMotorBrake.Size = new System.Drawing.Size(82, 29);
			this.rdoRightMotorBrake.TabIndex = 3;
			this.rdoRightMotorBrake.Text = "brake";
			this.rdoRightMotorBrake.UseVisualStyleBackColor = true;
			// 
			// rdoHoldPosition
			// 
			this.rdoHoldPosition.AutoSize = true;
			this.rdoHoldPosition.Checked = true;
			this.rdoHoldPosition.Location = new System.Drawing.Point(12, 32);
			this.rdoHoldPosition.Name = "rdoHoldPosition";
			this.rdoHoldPosition.Size = new System.Drawing.Size(142, 29);
			this.rdoHoldPosition.TabIndex = 0;
			this.rdoHoldPosition.TabStop = true;
			this.rdoHoldPosition.Text = "hold position";
			this.rdoHoldPosition.UseVisualStyleBackColor = true;
			// 
			// rdoStepClockwise
			// 
			this.rdoStepClockwise.AutoSize = true;
			this.rdoStepClockwise.Location = new System.Drawing.Point(12, 68);
			this.rdoStepClockwise.Name = "rdoStepClockwise";
			this.rdoStepClockwise.Size = new System.Drawing.Size(159, 29);
			this.rdoStepClockwise.TabIndex = 1;
			this.rdoStepClockwise.Text = "step clockwise";
			this.rdoStepClockwise.UseVisualStyleBackColor = true;
			// 
			// rdoStepCounterclockwise
			// 
			this.rdoStepCounterclockwise.AutoSize = true;
			this.rdoStepCounterclockwise.Location = new System.Drawing.Point(12, 104);
			this.rdoStepCounterclockwise.Name = "rdoStepCounterclockwise";
			this.rdoStepCounterclockwise.Size = new System.Drawing.Size(224, 29);
			this.rdoStepCounterclockwise.TabIndex = 2;
			this.rdoStepCounterclockwise.Text = "step counterclockwise";
			this.rdoStepCounterclockwise.UseVisualStyleBackColor = true;
			// 
			// tmrUSB
			// 
			this.tmrUSB.Interval = 50;
			this.tmrUSB.Tick += new System.EventHandler(this.tmrUSB_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 368);
			this.Controls.Add(this.gbStepperMotor);
			this.Controls.Add(this.gbRightDCMotor);
			this.Controls.Add(this.gbLeftDCMotor);
			this.Controls.Add(this.gbServoPosition);
			this.Controls.Add(this.lblInfo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbServoPosition.ResumeLayout(false);
			this.gbLeftDCMotor.ResumeLayout(false);
			this.gbLeftDCMotor.PerformLayout();
			this.gbRightDCMotor.ResumeLayout(false);
			this.gbRightDCMotor.PerformLayout();
			this.gbStepperMotor.ResumeLayout(false);
			this.gbStepperMotor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbServo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.GroupBox gbServoPosition;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TrackBar tbServo;
		private System.Windows.Forms.GroupBox gbLeftDCMotor;
		private System.Windows.Forms.RadioButton rdoLeftMotorBrake;
		private System.Windows.Forms.RadioButton rdoLeftMotorReverse;
		private System.Windows.Forms.RadioButton rdoLeftMotorForward;
		private System.Windows.Forms.RadioButton rdoLeftMotorCoast;
		private System.Windows.Forms.GroupBox gbRightDCMotor;
		private System.Windows.Forms.RadioButton rdoRightMotorBrake;
		private System.Windows.Forms.RadioButton rdoRightMotorReverse;
		private System.Windows.Forms.RadioButton rdoRightMotorForward;
		private System.Windows.Forms.RadioButton rdoRightMotorCoast;
		private System.Windows.Forms.GroupBox gbStepperMotor;
		private System.Windows.Forms.RadioButton rdoStepCounterclockwise;
		private System.Windows.Forms.RadioButton rdoStepClockwise;
		private System.Windows.Forms.RadioButton rdoHoldPosition;
		private System.Windows.Forms.Timer tmrUSB;
	}
}

