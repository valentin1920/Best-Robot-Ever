namespace Remote
{
    partial class Form
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
            this.startDrivingButton = new System.Windows.Forms.Button();
            this.stopDrivingButton = new System.Windows.Forms.Button();
            this.updateStatusButton = new System.Windows.Forms.Button();
            this.startPickupButton = new System.Windows.Forms.Button();
            this.stopPickupButton = new System.Windows.Forms.Button();
            this.updateStatusButton2 = new System.Windows.Forms.Button();
            this.portsListBox = new System.Windows.Forms.ListBox();
            this.refreshPortsBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.dissconnectBtn = new System.Windows.Forms.Button();
            this.receiveButton = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.inputBox = new System.Windows.Forms.GroupBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.GroupBox();
            this.connectionBox = new System.Windows.Forms.GroupBox();
            this.controlsBox = new System.Windows.Forms.GroupBox();
            this.pickupGroupBox = new System.Windows.Forms.GroupBox();
            this.driveGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox.SuspendLayout();
            this.outputBox.SuspendLayout();
            this.connectionBox.SuspendLayout();
            this.controlsBox.SuspendLayout();
            this.pickupGroupBox.SuspendLayout();
            this.driveGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startDrivingButton
            // 
            this.startDrivingButton.Location = new System.Drawing.Point(29, 49);
            this.startDrivingButton.Name = "startDrivingButton";
            this.startDrivingButton.Size = new System.Drawing.Size(114, 29);
            this.startDrivingButton.TabIndex = 0;
            this.startDrivingButton.Text = "Start Driving";
            this.startDrivingButton.UseVisualStyleBackColor = true;
            this.startDrivingButton.Click += new System.EventHandler(this.startDrivingButton_Click);
            // 
            // stopDrivingButton
            // 
            this.stopDrivingButton.Location = new System.Drawing.Point(29, 100);
            this.stopDrivingButton.Name = "stopDrivingButton";
            this.stopDrivingButton.Size = new System.Drawing.Size(114, 29);
            this.stopDrivingButton.TabIndex = 1;
            this.stopDrivingButton.Text = "Stop Driving";
            this.stopDrivingButton.UseVisualStyleBackColor = true;
            this.stopDrivingButton.Click += new System.EventHandler(this.stopDrivingButton_Click);
            // 
            // updateStatusButton
            // 
            this.updateStatusButton.Location = new System.Drawing.Point(29, 156);
            this.updateStatusButton.Name = "updateStatusButton";
            this.updateStatusButton.Size = new System.Drawing.Size(114, 29);
            this.updateStatusButton.TabIndex = 2;
            this.updateStatusButton.Text = "Update Status";
            this.updateStatusButton.UseVisualStyleBackColor = true;
            this.updateStatusButton.Click += new System.EventHandler(this.updateStatusButton_Click);
            // 
            // startPickupButton
            // 
            this.startPickupButton.Location = new System.Drawing.Point(32, 49);
            this.startPickupButton.Name = "startPickupButton";
            this.startPickupButton.Size = new System.Drawing.Size(114, 29);
            this.startPickupButton.TabIndex = 3;
            this.startPickupButton.Text = "Start Pickup";
            this.startPickupButton.UseVisualStyleBackColor = true;
            this.startPickupButton.Click += new System.EventHandler(this.startPickupButton_Click);
            // 
            // stopPickupButton
            // 
            this.stopPickupButton.Location = new System.Drawing.Point(32, 100);
            this.stopPickupButton.Name = "stopPickupButton";
            this.stopPickupButton.Size = new System.Drawing.Size(114, 29);
            this.stopPickupButton.TabIndex = 4;
            this.stopPickupButton.Text = "Stop Pickup";
            this.stopPickupButton.UseVisualStyleBackColor = true;
            this.stopPickupButton.Click += new System.EventHandler(this.stopPickupButton_Click);
            // 
            // updateStatusButton2
            // 
            this.updateStatusButton2.Location = new System.Drawing.Point(32, 156);
            this.updateStatusButton2.Name = "updateStatusButton2";
            this.updateStatusButton2.Size = new System.Drawing.Size(114, 29);
            this.updateStatusButton2.TabIndex = 5;
            this.updateStatusButton2.Text = "Update Status";
            this.updateStatusButton2.UseVisualStyleBackColor = true;
            this.updateStatusButton2.Click += new System.EventHandler(this.updateStatusButton2_Click);
            // 
            // portsListBox
            // 
            this.portsListBox.FormattingEnabled = true;
            this.portsListBox.ItemHeight = 16;
            this.portsListBox.Location = new System.Drawing.Point(25, 40);
            this.portsListBox.Name = "portsListBox";
            this.portsListBox.Size = new System.Drawing.Size(192, 84);
            this.portsListBox.TabIndex = 6;
            this.portsListBox.SelectedIndexChanged += new System.EventHandler(this.portsListBox_SelectedIndexChanged);
            // 
            // refreshPortsBtn
            // 
            this.refreshPortsBtn.Location = new System.Drawing.Point(291, 31);
            this.refreshPortsBtn.Name = "refreshPortsBtn";
            this.refreshPortsBtn.Size = new System.Drawing.Size(95, 29);
            this.refreshPortsBtn.TabIndex = 7;
            this.refreshPortsBtn.Text = "Refresh";
            this.refreshPortsBtn.UseVisualStyleBackColor = true;
            this.refreshPortsBtn.Click += new System.EventHandler(this.refreshPortsBtn_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(291, 71);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(95, 29);
            this.connectBtn.TabIndex = 8;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // dissconnectBtn
            // 
            this.dissconnectBtn.Location = new System.Drawing.Point(291, 113);
            this.dissconnectBtn.Name = "dissconnectBtn";
            this.dissconnectBtn.Size = new System.Drawing.Size(95, 29);
            this.dissconnectBtn.TabIndex = 9;
            this.dissconnectBtn.Text = "Disconnect";
            this.dissconnectBtn.UseVisualStyleBackColor = true;
            this.dissconnectBtn.Click += new System.EventHandler(this.dissconnectBtn_Click);
            // 
            // receiveButton
            // 
            this.receiveButton.Location = new System.Drawing.Point(64, 88);
            this.receiveButton.Name = "receiveButton";
            this.receiveButton.Size = new System.Drawing.Size(75, 25);
            this.receiveButton.TabIndex = 11;
            this.receiveButton.Text = "Receive";
            this.receiveButton.UseVisualStyleBackColor = true;
            this.receiveButton.Click += new System.EventHandler(this.receiveButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 16;
            this.outputListBox.Location = new System.Drawing.Point(6, 30);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(191, 52);
            this.outputListBox.TabIndex = 12;
            // 
            // inputBox
            // 
            this.inputBox.Controls.Add(this.inputTextBox);
            this.inputBox.Controls.Add(this.sendButton);
            this.inputBox.Location = new System.Drawing.Point(13, 196);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(203, 91);
            this.inputBox.TabIndex = 6;
            this.inputBox.TabStop = false;
            this.inputBox.Text = "Input Text";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(20, 30);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(163, 22);
            this.inputTextBox.TabIndex = 14;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(61, 58);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 25);
            this.sendButton.TabIndex = 13;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Controls.Add(this.outputListBox);
            this.outputBox.Controls.Add(this.receiveButton);
            this.outputBox.Location = new System.Drawing.Point(228, 177);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(203, 121);
            this.outputBox.TabIndex = 16;
            this.outputBox.TabStop = false;
            this.outputBox.Text = "Output Text";
            // 
            // connectionBox
            // 
            this.connectionBox.Controls.Add(this.portsListBox);
            this.connectionBox.Controls.Add(this.refreshPortsBtn);
            this.connectionBox.Controls.Add(this.dissconnectBtn);
            this.connectionBox.Controls.Add(this.connectBtn);
            this.connectionBox.Location = new System.Drawing.Point(12, 12);
            this.connectionBox.Name = "connectionBox";
            this.connectionBox.Size = new System.Drawing.Size(419, 159);
            this.connectionBox.TabIndex = 17;
            this.connectionBox.TabStop = false;
            this.connectionBox.Text = "Connection and Ports";
            // 
            // controlsBox
            // 
            this.controlsBox.Controls.Add(this.pickupGroupBox);
            this.controlsBox.Controls.Add(this.driveGroupBox);
            this.controlsBox.Controls.Add(this.label1);
            this.controlsBox.Location = new System.Drawing.Point(12, 304);
            this.controlsBox.Name = "controlsBox";
            this.controlsBox.Size = new System.Drawing.Size(419, 285);
            this.controlsBox.TabIndex = 18;
            this.controlsBox.TabStop = false;
            this.controlsBox.Text = "Controls";
            // 
            // pickupGroupBox
            // 
            this.pickupGroupBox.Controls.Add(this.startPickupButton);
            this.pickupGroupBox.Controls.Add(this.updateStatusButton2);
            this.pickupGroupBox.Controls.Add(this.stopPickupButton);
            this.pickupGroupBox.Location = new System.Drawing.Point(219, 21);
            this.pickupGroupBox.Name = "pickupGroupBox";
            this.pickupGroupBox.Size = new System.Drawing.Size(183, 209);
            this.pickupGroupBox.TabIndex = 8;
            this.pickupGroupBox.TabStop = false;
            this.pickupGroupBox.Text = "Pickup System";
            // 
            // driveGroupBox
            // 
            this.driveGroupBox.Controls.Add(this.updateStatusButton);
            this.driveGroupBox.Controls.Add(this.stopDrivingButton);
            this.driveGroupBox.Controls.Add(this.startDrivingButton);
            this.driveGroupBox.Location = new System.Drawing.Point(20, 21);
            this.driveGroupBox.Name = "driveGroupBox";
            this.driveGroupBox.Size = new System.Drawing.Size(183, 209);
            this.driveGroupBox.TabIndex = 7;
            this.driveGroupBox.TabStop = false;
            this.driveGroupBox.Text = "Drive System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Robot Status: ";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 601);
            this.Controls.Add(this.controlsBox);
            this.Controls.Add(this.connectionBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Name = "Form";
            this.Text = "Robot Control v1";
            this.inputBox.ResumeLayout(false);
            this.inputBox.PerformLayout();
            this.outputBox.ResumeLayout(false);
            this.connectionBox.ResumeLayout(false);
            this.controlsBox.ResumeLayout(false);
            this.controlsBox.PerformLayout();
            this.pickupGroupBox.ResumeLayout(false);
            this.driveGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startDrivingButton;
        private System.Windows.Forms.Button stopDrivingButton;
        private System.Windows.Forms.Button updateStatusButton;
        private System.Windows.Forms.Button startPickupButton;
        private System.Windows.Forms.Button stopPickupButton;
        private System.Windows.Forms.Button updateStatusButton2;
        private System.Windows.Forms.ListBox portsListBox;
        private System.Windows.Forms.Button refreshPortsBtn;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button dissconnectBtn;
        private System.Windows.Forms.Button receiveButton;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.GroupBox inputBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.GroupBox outputBox;
        private System.Windows.Forms.GroupBox connectionBox;
        private System.Windows.Forms.GroupBox controlsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox pickupGroupBox;
        private System.Windows.Forms.GroupBox driveGroupBox;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

