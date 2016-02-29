using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPodEmulator
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            prepareTextBox();
        }

        private void prepareTextBox()
        {
        //    aboutTextBox.SelectionAlignment = HorizontalAlignment.Center;
            //aboutTextBox.SelectedText = aboutText;
            //aboutTextBox.Text = aboutText;
            aboutLabel.Text = aboutText;
        }


        private const string aboutText = "The program gives you an opportunity to view your text right on iPod as after synchronization. It will help you to make some iPod books or crib. ;)";
    }
}
