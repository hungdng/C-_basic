using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLTV_Heni_4.DTO
{
    class TuaSach_DTO
    {
        private string _MaTuaSach;

        public string MaTuaSach
        {
            get { return _MaTuaSach; }
            set { _MaTuaSach = value; }
        }
        private string _TuaSach;

        public string TuaSach
        {
            get { return _TuaSach; }
            set { _TuaSach = value; }
        }
        private string _MaTuSach;

        public string MaTuSach
        {
            get { return _MaTuSach; }
            set { _MaTuSach = value; }
        }

        private string _MaTL;

        public string MaTL
        {
            get { return _MaTL; }
            set { _MaTL = value; }
        }
        private string _NDTT;

        public string NDTT
        {
            get { return _NDTT; }
            set { _NDTT = value; }
        }

        public TheLoai_DTO _TheLoai_DTO { get; set; }
        public TuSach_DTO _TuSach_DTO { get; set; }
    }
}
