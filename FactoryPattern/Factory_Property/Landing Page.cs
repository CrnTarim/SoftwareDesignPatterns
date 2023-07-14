using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_Property
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picR.ImageLocation = @"realEstate.png";

            cmbFloor.DataSource = MainPageOpt.Floor;
            cmbM2.DataSource = MainPageOpt.M2;
            cmbSecurity.DataSource = MainPageOpt.Security;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int selectedFloor = Convert.ToInt32(cmbFloor.SelectedItem);
            int selectedM2 = Convert.ToInt32(cmbM2.SelectedItem);
            int selectedSecurity = Convert.ToInt32(cmbSecurity.SelectedItem);

            MainPage mainpage = new MainPage(selectedFloor, selectedM2, selectedSecurity);
            mainpage.Show();
        }
    }
}
