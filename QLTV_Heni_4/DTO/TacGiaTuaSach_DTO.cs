using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLTV_Heni_4.DTO
{
    class TacGiaTuaSach_DTO
    {
        private string _id_tgs;

        public string id_tgs
        {
            get { return _id_tgs; }
            set { _id_tgs = value; }
        }

        private string _MaTuaSach;

        public string MaTuaSach
        {
            get { return _MaTuaSach; }
            set { _MaTuaSach = value; }
        }
        private string _MaTG;

        public string MaTG
        {
            get { return _MaTG; }
            set { _MaTG = value; }
        }
        public TuaSach_DTO _TuaSach_DTO { get; set; }
        public TacGia_DTO _TacGia_DTO { get; set; }
    }
}
