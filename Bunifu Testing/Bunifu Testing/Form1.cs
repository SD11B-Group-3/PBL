using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunifu_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(panel1);
            bunifuFormDock1.SubscribeControlToDragEvents(panel2);

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuShadowPanel1_ControlAdded_1(object sender, ControlEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages1.SetPage("Dashboard");
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages1.SetPage("Near You");
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages1.SetPage("Vaccine Info");
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            bunifuPages1.SetPage("About");
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void indicator_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuPages1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dashboardpage_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel2_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        private void bunifuShadowPanel3_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
