﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTV_Heni_4.DTO
{
    class TacGia_DTO
    {
        private string _MaTG;

            public string MaTG
            {
              get { return _MaTG; }
              set { _MaTG = value; }
            }

            private string _HoTenTG;

            public string HoTenTG
            {
              get { return _HoTenTG; }
              set { _HoTenTG = value; }
            }

            private int _GioiTinhTG;

            public int GioiTinhTG
            {
                get { return _GioiTinhTG; }
                set { _GioiTinhTG = value; }
            }

            private DateTime _NgaySinhTG;

            public DateTime NgaySinhTG
            {
                get { return _NgaySinhTG; }
                set { _NgaySinhTG = value; }
            }


        private string _DiaChiTG;

        public string DiaChiTG
        {
            get { return _DiaChiTG; }
            set { _DiaChiTG = value; }
        }
        private string _DienThoaiTG;

        public string DienThoaiTG
        {
            get { return _DienThoaiTG; }
            set { _DienThoaiTG = value; }
        }
    }
}
