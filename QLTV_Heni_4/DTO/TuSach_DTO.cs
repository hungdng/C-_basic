using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV_Heni_4.DTO
{
    class TuSach_DTO
    {
        private string _MaTuSach;

        public string MaTuSach
        {
            get { return _MaTuSach; }
            set { _MaTuSach = value; }
        }
        private string _TuSach;

        public string TuSach
        {
            get { return _TuSach; }
            set { _TuSach = value; }
        }
        private string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
    }
}
