using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLTV_Heni_4.DTO
{
    class PhieuNhap_DTO
    {
        private string _MaPhieuNhap;

        public string MaPhieuNhap
        {
            get { return _MaPhieuNhap; }
            set { _MaPhieuNhap = value; }
        }
        private DateTime _NgayNhap;

        public DateTime NgayNhap
        {
            get { return _NgayNhap; }
            set { _NgayNhap = value; }
        }
    }
}
