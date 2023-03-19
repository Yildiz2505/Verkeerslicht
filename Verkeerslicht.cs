using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoppenLicht
{
    public partial class frmStoppenLicht : Form
    {
        public frmStoppenLicht()
        {
            InitializeComponent();
        }

        private void pbxVerkeerslicht_Click(object sender, EventArgs e)
        {
            try
            {
                pbxVerkeerslicht.Image = Properties.Resources.Rood;
            }
            catch (System.Exception boodschap)

            {
                MessageBox.Show(boodschap.Message);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnRood_Click(object sender, EventArgs e)
        {
            try
            {
                //pbxVerkeerslicht.ImageLocation = @"C:\Source\StoppenLicht\Afbeeldingen\Rood.jpg";
                pbxVerkeerslicht.Image = Properties.Resources.Rood;
            }
            catch (System.Exception boodschap)

            {
                MessageBox.Show(boodschap.Message);
            }
        }


        private void btnGroen_Click(object sender, EventArgs e)
        {
            try
            {
                //pbxVerkeerslicht.ImageLocation = @"C:\Source\StoppenLicht\Afbeeldingen\Groen.jpg";
                pbxVerkeerslicht.Image = Properties.Resources.Groen;
            }
            catch (System.Exception boodschap)

            {
                MessageBox.Show(boodschap.Message);
            }
        }

        private void btnGeel_Click(object sender, EventArgs e)
        {
            try
            {
                //pbxVerkeerslicht.ImageLocation = @"C:\Source\StoppenLicht\Afbeeldingen\Geel.jpg";
                pbxVerkeerslicht.Image = Properties.Resources.Geel;
            }
            catch (System.Exception boodschap)

            {
                MessageBox.Show(boodschap.Message);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnWerk_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            String filePath = openFileDialog1.FileName;
            pbxFoto.Image = Image.FromFile(filePath);
        }

        private void pbxFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
