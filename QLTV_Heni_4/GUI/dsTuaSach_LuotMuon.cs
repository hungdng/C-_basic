using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTV_Heni_4.BLL;

namespace QLTV_Heni_4.GUI
{
    public partial class dsTuaSach_LuotMuon : UserControl
    {
        private TuaSach_BLL tsBUS = new TuaSach_BLL();
        public dsTuaSach_LuotMuon()
        {
            InitializeComponent();
        }

        private void dsTuaSach_LuotMuon_Load(object sender, EventArgs e)
        {
            grid_tuasach.DataSource = tsBUS.LuotMuonSach();
            txt_tile.Text = tsBUS.demtuaduowc_muon() + "/" + tsBUS.demtuasach();
        }
    }
}
