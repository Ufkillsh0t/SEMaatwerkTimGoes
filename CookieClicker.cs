using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class CookieClicker : Form
    {
        //koekjescontroller
        private KoekjesController koekjesController;

        //upgrades
        private Upgrade[] upgrades = new Upgrade[3];

        public CookieClicker()
        {
            koekjesController = new KoekjesController();
            Upgrade Bakker = new Upgrade("Bakker", 10, 100, 150);
            Upgrade Oven = new Upgrade("Oven", 50, 2000, 450);
            Upgrade DeegRoller = new Upgrade("Deegroller", 0, 3500, 700);
            upgrades[0] = Bakker;
            upgrades[1] = Oven;
            upgrades[2] = DeegRoller;

            //Start de timer
            CookieTimer.Start();

            InitializeComponent();
        }

        private void CookieTimer_Tick(object sender, EventArgs e)
        {
            koekjesController.Koekjes += koekjesController.Kps;
            ControleerUpgrades();
            UpdateVelden();
        }

        private void ControleerUpgrades()
        {
            if (koekjesController.Koekjes >= upgrades[0].Prijs) btnBakker.Enabled = true;
            else btnBakker.Enabled = false;

            if(koekjesController.Koekjes >= upgrades[1].Prijs) btnOven.Enabled = true;
            else btnOven.Enabled = false;

            if (koekjesController.Koekjes >= upgrades[2].Prijs) btnDeegroller.Enabled = true;
            else btnDeegroller.Enabled = false;
        }

        private void UpdateVelden()
        {
            lblKoekjes.Text = koekjesController.Koekjes.ToString();
            lblKps.Text = koekjesController.Kps.ToString();
            btnBakker.Text = "Bakker (100) :" + upgrades[0].Aantal;
            btnOven.Text = "Oven (2000) :" + upgrades[1].Aantal;
            btnDeegroller.Text = "Deegroller (3500) :" + upgrades[2].Aantal;
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            koekjesController.Koekjes += 10;
            ControleerUpgrades();
            UpdateVelden();
        }

        private void btnBakker_Click(object sender, EventArgs e)
        {
            upgrades[0].Aantal += 1;
            upgrades[0].Prijs += upgrades[0].PrijsInterval;
            koekjesController.Kps += upgrades[0].Kps;
        }

        private void btnOven_Click(object sender, EventArgs e)
        {
            upgrades[1].Aantal += 1;
            upgrades[1].Prijs += upgrades[1].PrijsInterval;
            koekjesController.Kps += upgrades[1].Kps;
        }

        private void btnDeegroller_Click(object sender, EventArgs e)
        {
            upgrades[2].Aantal += 1;
            upgrades[2].Prijs += upgrades[2].PrijsInterval;
            koekjesController.Kps += upgrades[2].Kps;
        }
    }
}
