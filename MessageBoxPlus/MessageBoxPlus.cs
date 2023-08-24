using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxPlus
{
    public partial class MessageBoxPlus : Form
    {
        public MessageBoxPlus()
        {
            InitializeComponent();
        }

        private void MessageBoxPlus_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMessage.ShowSimpleMessage(this, "Simple Message", "This is a simple message test", frmMessage.TYPE.INFO, "This is a info message");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMessage.ShowSimpleMessage(this, "Simple Message", "This is a simple message test", frmMessage.TYPE.WARNING, "This is a warning message");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMessage.ShowSimpleMessage(this, "Simple Message", "This is a simple message test", frmMessage.TYPE.ERROR, "This is a error message");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMessage frm = new frmMessage(this, "MessageWith2CustomButton", "This is a message with 2 custom button", frmMessage.TYPE.INFO, "Click 'It is good' or 'It is very good'");
            frm.AddButton("ItIsGood", ItIsGood);
            frm.AddButton("ItIsVeryGood", ItIsVeryGood);
            frm.ShowDialog();
        }

        private void ItIsGood(object sender, EventArgs e)
        {
            frmMessage.ShowSimpleMessage(this, "ItIsGood", "You are good");
        }
        private void ItIsVeryGood(object sender, EventArgs e)
        {
            frmMessage.ShowSimpleMessage(this, "ItIsVeryGood", "You are Very good");
        }
    }
}
