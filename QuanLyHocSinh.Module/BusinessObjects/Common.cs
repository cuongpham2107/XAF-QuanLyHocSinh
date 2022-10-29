using DevExpress.ExpressApp.DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Module.BusinessObjects
{
    public enum GioiTinh
    {
        [XafDisplayName("Nam")] Nam = 0,
        [XafDisplayName("Nữ")] Nu = 1
    }
    public enum KhoiLop
    {
        [XafDisplayName("Khối 10")] k10 = 0,
        [XafDisplayName("Khối 11")] k11 = 1,
        [XafDisplayName("Khối 12")] k12 = 2,
    }

}
