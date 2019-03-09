using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLTV_Heni_4.DTO
{
    class CuonSach_DTO
    {
        private string _MaSach;

        public string MaSach
        {
            get { return _MaSach; }
            set { _MaSach = value; }
        }
        private string _MaLoSach;

        public string MaLoSach
        {
            get { return _MaLoSach; }
            set { _MaLoSach = value; }
        }
        private string _TinhTrangSach;

        public string TinhTrangSach
        {
            get { return _TinhTrangSach; }
            set { _TinhTrangSach = value; }
        }
    }
}
