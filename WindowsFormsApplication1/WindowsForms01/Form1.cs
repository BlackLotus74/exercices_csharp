using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms01
{
    public partial class m_test : Form
    {
        public m_test()
        {
            InitializeComponent();

            MessageBox.Show(
                "coucou ! tu veux voir ......",
                " Bastien ......",
                 MessageBoxButtons.RetryCancel,
                 MessageBoxIcon.Error);
        }

        private void m_testButton_Click(object sender, EventArgs e)
        {
            m_testButton.Text = "Bouton cliqué !";
        }

        private void m_TestButton2(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            senderButton.Text = "Bouton cliqué";
            m_statusLabel.Text = senderButton.Name + "vient d'être cliqué.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void m_test_MouseClick(object sender, MouseEventArgs e)
        {
            m_statusLabel.Text = "Bouton n°1 cliqué à la position : " + e.Location + ".";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
