using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATC24Helper
{
    public partial class PDCModal : Form
    {
        public PDCModal()
        {
            InitializeComponent();
        }

        //PDC
        private void button2_Click(object sender, EventArgs e)
        {
            string PDC = $"!PRE-DEPARTURE CLEARANCE - CALLSIGN: {textBox1.Text} - APPROVED ROUTE: {textBox2.Text} - INITAL FLIGHT LEVEL: {textBox3.Text} - CRUISING FLIGHT LEVEL: {textBox4.Text} - DEPARTURE FREQUENCY: {textBox5.Text} - SQUAWK CODE: {textBox6.Text} - END OF PDC, WHEN READY FOR PUSH, CALL ON FREQUENCY WITH THE CURRENT ATIS. IF YOU HAVE ANY QUESTIONS, CONTACT ME ON THE FREQUENCY!";
            Clipboard.SetText(PDC);

            this.DialogResult = DialogResult.OK;
        }

        //Squawk
        private void button1_Click(object sender, EventArgs e)
        {
            string number1 = new Random().Next(0, 7).ToString();
            string number2 = new Random().Next(0, 7).ToString();
            string number3 = new Random().Next(0, 7).ToString();
            string number4 = new Random().Next(0, 7).ToString();
            string finalSquawk = number1 + number2 + number3 + number4;

            while (Array.IndexOf(Main.usedSquawks, finalSquawk) >= 0)
            {
                number1 = new Random().Next(0, 7).ToString();
                number2 = new Random().Next(0, 7).ToString();
                number3 = new Random().Next(0, 7).ToString();
                number4 = new Random().Next(0, 7).ToString();
                finalSquawk = number1 + number2 + number3 + number4;
            }

            textBox6.Text = finalSquawk;
        }
    }
}
