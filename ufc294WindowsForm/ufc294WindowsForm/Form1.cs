using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace ufc294WindowsForm
{
    public partial class ufc294 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public ufc294()
        {
            InitializeComponent();
        }
        
        private void form1_load(object sender, EventArgs e)
        {
            picChar.Image = Properties.Resources.ufcLogo;
            player.Stream = Properties.Resources.ufc_fight_theme;
            player.Play();
        }
        private void btnFightCard_Click(object sender, EventArgs e)
        {
            txtInfo.Text = Properties.Resources.fightCardTxt;
            picChar.Image = Properties.Resources.fightCard;
            player.Stream = Properties.Resources.its_time_ufc;
            player.Play();
        }

        private void btnMakOlv_Click(object sender, EventArgs e)
        {
            picChar.Image = Properties.Resources.makVsOlv;
        }

        private void btnChiCos_Click(object sender, EventArgs e)
        {
            picChar.Image = Properties.Resources.costa_chimaev_ufc294graphic1_2623243286;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            txtInfo.Text = Properties.Resources.info;
            picChar.Image = Properties.Resources.ufcPoster;
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
