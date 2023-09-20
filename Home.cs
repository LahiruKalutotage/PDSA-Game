using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDSA_Game
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnGame1_Click(object sender, EventArgs e)
        {
           Games.Game01 _obj = new Games.Game01();
            _obj.Show();
        }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            Games.Game02 _obj = new Games.Game02();
            _obj.Show();
        }

        private void btnGame3_Click(object sender, EventArgs e)
        {
            Games.Game03 _obj = new Games.Game03();
            _obj.Show();
        }

        private void btnGame4_Click(object sender, EventArgs e)
        {
            Games.Game04 _obj = new Games.Game04();
            _obj.Show();
        }

        private void btnGame5_Click(object sender, EventArgs e)
        {
            Games.Game05 _obj = new Games.Game05();
            _obj.Show();
        }
    }
}
