using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace EindProjectTamagotchi
{
    public partial class frmOpdracht : Form
    {
        //Rayan Kreike 3/27/2023
        //variable declareren
        private int _score;
        private bool _scorenu = false;
        private bool _bericht= true;
        public frmOpdracht()
        {
            InitializeComponent();
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void btnEten_Click(object sender, EventArgs e)
        {
            //eten toevoegen met try catch methode
            try
            {
                pbEten.Value = pbEten.Value + 5;
            }
            catch 
            {
                //Als eten vol is

            }
        }

        private void btnDrinken_Click(object sender, EventArgs e)
        {
            //drinken toevoegen met try catch methode
            try
            {
                pbDrinken.Value = pbDrinken.Value + 5;
            }
            catch 
            {
                //Als drinken vol is
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //berekening
            pbEten.Increment(-1);
            pbDrinken.Increment(-1);

            if (pbEten.Value < 1 || pbDrinken.Value < 1)
            {
                pbGezondheid.Increment(-1);
            }

            //Als gezondheid groter is dan 75
            if (pbGezondheid.Value > 75)
            {
                //afbeelding aanpassen
                pbxTwee.Image = Properties.Resources.tamagotchi2;
                pbxTwee.Refresh();
            }
            //Als gezondheid kleiner is dan 75 en groter dan 50
            else if (pbGezondheid.Value < 75 && pbGezondheid.Value > 50)
            {
                //afbeelding aanpassen
                pbxTwee.Image = Properties.Resources.tamagotchi3;
                pbxTwee.Refresh();
            }
            //Als gezondheid kleiner is dan 50 en groter dan 25
            else if (pbGezondheid.Value < 50 && pbGezondheid.Value > 25)
            {
                //afbeelding aanpassen
                pbxTwee.Image = Properties.Resources.tamagotchi4;
                pbxTwee.Refresh();
            }
            //Als gezondheid kleiner is dan 25 en groter dan 1
            else if (pbGezondheid.Value < 25 && pbGezondheid.Value > 1)
            {
                pbxTwee.Image = Properties.Resources.tamagotchi5;
                pbxTwee.Refresh();
            }
            //Als gezondheid 0 is
            else if (pbGezondheid.Value == 0)
            {
                //afbeelding aanpassen
                pbxTwee.Image = Properties.Resources.tamagotchidood;
                _scorenu = true;
                //berich laten zien dat je dood bent
                if (_bericht)
                {
                    _bericht = false;
                    MessageBox.Show("Je bent dood gegaan, jouw score is:" + _score);
                    System.Windows.Forms.Application.Exit();

                }
                //picture box refreshen
                pbxTwee.Refresh();
            }

            //label naar de score zetten
            if (_scorenu != true)
            {
                lblScore.Text = _score++.ToString();
            }
        }

        private void frmOpdracht_Load(object sender, EventArgs e)
        {
            //Timer starten als form word geladen
            timer1.Start();
        }

        private void pbxScore_Click(object sender, EventArgs e)
        {

        }
    }
}
