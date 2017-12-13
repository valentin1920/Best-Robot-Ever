using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EV3MessengerLib;
using System.IO.Ports;

namespace Remote
{
    public partial class Form : System.Windows.Forms.Form
    {
        private EV3Messenger messenger;
        public Form()
        {
            InitializeComponent();
            messenger = new EV3Messenger();
            fillSerialPortSelectionBoxWithAvailablePorts();
            updateFormGUI();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void portsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void fillSerialPortSelectionBoxWithAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            portsListBox.Items.Clear();
            foreach (String port in ports)
            {
                portsListBox.Items.Add(port);
            }
        }
        private void updateFormGUI()
        {
            if (messenger.IsConnected)
            {
                refreshPortsBtn.Enabled = false;
                connectBtn.Enabled = false;
                inputBox.Enabled = true;
                outputBox.Enabled = true;
                controlsBox.Enabled = true;
                dissconnectBtn.Enabled = true;
                outputListBox.Items.Clear();
            }
            else
            {
                refreshPortsBtn.Enabled = true;
                connectBtn.Enabled = true;
                inputBox.Enabled = false;
                controlsBox.Enabled = false;
                outputBox.Enabled = false;
                dissconnectBtn.Enabled = false;
            }
        }

        private void refreshPortsBtn_Click(object sender, EventArgs e)
        {
            fillSerialPortSelectionBoxWithAvailablePorts();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            // Check if a port has been selected
            if (portsListBox.SelectedIndex > -1)
            {
                // Get the selected port from the ListBox
                string port = portsListBox.SelectedItem.ToString().ToUpper();
                // Try to connect with the Brick via the selected port
                if (messenger.Connect(port))
                {
                    updateFormGUI();
                }
                else
                {
                    MessageBox.Show("Failed to connect to serial port '" + port + "'.\n"
                        + "Make sure your robot is connected to that serial port and try again.");
                }
            }
            else
            {
                MessageBox.Show("Please select a port for the bluetooth connection");
            }
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            string msg = inputTextBox.Text;
            // Make sure a message has been typed
            if (!String.IsNullOrWhiteSpace(msg))
            {
                // Send a message to the Brick with title: MESSAGE and the message
                if (messenger.SendMessage("MESSAGE", msg))
                {
                    inputTextBox.Text = "";
                    MessageBox.Show("The message has been send to the Brick");
                }
                else
                {
                    MessageBox.Show("Unable to send the message to the Brick. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please type a message in the above textbox for the Brick");
            }
        }

        private void receiveButton_Click(object sender, EventArgs e)
        {
            // Try to get a message
            EV3Message message = messenger.ReadMessage();
            // Check if there is a message received from the Brick
            if (message != null)
            {
                outputListBox.Items.Add("Message: " + message.ValueAsText);
                // Auto scroll the listbox
                outputListBox.TopIndex = outputListBox.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("No message recieved from the Brick");
            }
        }

        private void dissconnectBtn_Click(object sender, EventArgs e)
        {
            messenger.Disconnect();
            updateFormGUI();
        }
        private void startDrivingButton_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "Start");
        }
        private void stopDrivingButton_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "Stop");
        }
        private void updateStatusButton_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "Status");
        }
        private void updateStatusButton2_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "Status");
        }

        private void startPickupButton_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "Pick");
        }

        private void stopPickupButton_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "Drop");
        }
    }
}