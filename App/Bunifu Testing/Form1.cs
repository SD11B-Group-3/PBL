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

        private void bunifuShadowPanel7_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuShadowPanel5_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCircleProgress1_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }

        private void bunifuProgressBar2_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuProgressBar.ProgressChangedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel10_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel8_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuShadowPanel6_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void bunifuChartCanvas1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
       




        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Enter(object sender, EventArgs e)
        {
            
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
 
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Welcome");
        }

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {
                    }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("City");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Region");
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int j = bunifuDropdown1.SelectedIndex;

            if (j == 0)
            {
                bunifuPages2.SetPage("Sinovac");
            }

            else if (j == 1)
            {
                bunifuPages2.SetPage("Astrazeneca");
            }

            else if (j == 2)
            {
                bunifuPages2.SetPage("Sputnik V");
            }

            else
            {
                bunifuPages2.SetPage("Pfizer");
            }
        }

        private void bunifuLabel10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int j = bunifuDropdown1.SelectedIndex;

            if (j == 0)
            {
                bunifuPages2.SetPage("Sinovac");
            }

            else if (j == 1)
            {
                bunifuPages2.SetPage("Astrazeneca");
            }

            else if (j == 2)
            {
                bunifuPages2.SetPage("Sputnik V");
            }

            else
            {
                bunifuPages2.SetPage("Pfizer");
            }

        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int j = bunifuDropdown1.SelectedIndex;
 
            if (j == 1)
            {
                bunifuPages2.SetPage("Astrazeneca");
                
            }

            else if (j == 0)
            {
                bunifuPages2.SetPage("Sinovac");
            }

            else if (j == 2)
            {
                bunifuPages2.SetPage("Sputnik V");
            }

            else
            {
                bunifuPages2.SetPage("Pfizer");
            }
        }

        private void bunifuDropdown3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int j = bunifuDropdown1.SelectedIndex;

            if (j == 0)
            {
                bunifuPages2.SetPage("Sinovac");
            }

            else if (j == 1)
            {
                bunifuPages2.SetPage("Astrazeneca");
            }

            else if (j == 2)
            {
                bunifuPages2.SetPage("Sputnik V");
            }

            else
            {
                bunifuPages2.SetPage("Pfizer");
            }
        }
    }


    }


