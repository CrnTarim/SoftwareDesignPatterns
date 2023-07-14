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
    public partial class MainPage : Form
    {
        public int Floor;
        public int M2;
        public int Security;
        public MainPage(int floor, int m2, int security)
        {
            InitializeComponent();
            Floor = floor;
            M2 = m2;
            Security = security;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            cmbResidence.DropDownStyle = ComboBoxStyle.DropDownList;

            txtCompany.ReadOnly = true;
            txtInform.ReadOnly = true;
            txtRent.ReadOnly = true;
            txtDuel.ReadOnly = true;
            txtFuel.ReadOnly = true;


            List<ICriteria> residences = new List<ICriteria>
            {
                new TowerBlock(),
                new DetachedHouse(),
                new Apartment()
            };

            cmbResidence.DataSource = residences;
        }

        private void cmbResidence_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ICriteria selectedResidence = cmbResidence.SelectedItem as ICriteria;

            if (selectedResidence != null)
            {
                txtCompany.Text = selectedResidence.Company().ToString();
                txtInform.Text = selectedResidence.Inform().ToString();
                txtRent.Text = selectedResidence.Rent(M2, Floor).ToString();
                txtDuel.Text = selectedResidence.Dues(Security).ToString();
                txtFuel.Text = selectedResidence.Fuel(M2).ToString();
                pctResidence.ImageLocation = selectedResidence.Picture();
            }
        }
    }
}
