using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace QuanLyHocSinh.Module.BusinessObjects
{
    [DefaultClassOptions]
   
    public class KetQua : BaseObject
    { 
        public KetQua(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }
        private string maKQ;
        [XafDisplayName("Mã kết quả")]
        public string MaKQ
        {
            get { return maKQ; }
            set { SetPropertyValue(nameof(MaKQ), ref maKQ, value); }
        }
        private MonHoc monHoc;
        [XafDisplayName("Môn học")]
        public MonHoc MonHoc
        {
            get { return monHoc; }
            set { SetPropertyValue(nameof(MonHoc), ref monHoc, value); }
        }
        private HocSinh hocSinh;
        [XafDisplayName("Học sinh")]
        public HocSinh HocSinh
        {
            get { return hocSinh; }
            set { SetPropertyValue(nameof(HocSinh), ref hocSinh, value); }
        }
        private double mieng1;
        [XafDisplayName("Miệng 1")]
        public double Mieng1
        {
            get { return mieng1; }
            set { SetPropertyValue(nameof(Mieng1), ref mieng1, value); }
        }
        private double mieng2;
        [XafDisplayName("Miệng 2")]
        public double Mieng2
        {
            get { return mieng2; }
            set { SetPropertyValue(nameof(Mieng2), ref mieng2, value); }
        }
        private double mieng3;
        [XafDisplayName("Miệng 3")]
        public double Mieng3
        {
            get { return mieng3; }
            set { SetPropertyValue(nameof(Mieng3), ref mieng3, value); }
        }
        private double kt15_1;
        [XafDisplayName("Kiểm tra 15' L1")]
        public double Kt15_1
        {
            get { return kt15_1; }
            set { SetPropertyValue(nameof(Kt15_1), ref kt15_1, value); }
        }

        private double kt15_2;
        [XafDisplayName("Kiểm tra 15' L2")]
        public double Kt15_2
        {
            get { return kt15_2; }
            set { SetPropertyValue(nameof(Kt15_2), ref kt15_2, value); }
        }
        private double kt1_1;
        [XafDisplayName("Kiểm tra 1 tiết' L1")]
        public double Kt1_1
        {
            get { return kt1_1; }
            set { SetPropertyValue(nameof(Kt1_1), ref kt1_1, value); }
        }

        private double kt1_2;
        [XafDisplayName("Kiểm tra 1 tiết' L2")]
        public double Kt1_2
        {
            get { return kt1_2; }
            set { SetPropertyValue(nameof(Kt1_2), ref kt1_2, value); }
        }
        private double diemThi;
        [XafDisplayName("Điểm thi")]
        public double DiemThi
        {
            get { return diemThi; }
            set { SetPropertyValue(nameof(DiemThi), ref diemThi, value); }
        }
        /// <summary>
        /// ((Tổng miệng và 15) + (1 tiết * 2) + (Điểm thi*3))/ 12
        /// </summary>
        private double diemTB;
        [XafDisplayName("Điểm trung bình")]
        public double DiemTB
        {
            get { return diemTB; }
            set
            {
                SetPropertyValue(nameof(DiemTB), ref diemTB, value);
                if(!IsLoading && !IsSaving)
                {
                    if(Mieng1 >= 0 && Mieng2 >= 0 && Mieng3 >= 0 && Kt15_1 >= 0 && Kt15_2 >= 0 && Kt1_1 >= 0 && Kt1_2 >= 0 && DiemThi >= 0)
                    {
                        DiemTB = ((Mieng1 + Mieng2 + Mieng3 + Kt15_1 + Kt15_2) + (kt1_1 + Kt1_2) * 2 + DiemThi * 3) / 12;
                    }
                    
                }
            }
        }
        private XepLoai xepLoai;
        [XafDisplayName("Xếp loại")]
        public XepLoai XepLoai
        {
            get { return xepLoai; }
            set { SetPropertyValue(nameof(XepLoai), ref xepLoai, value); }
        }
        private NamHoc namHoc;
        [XafDisplayName("Năm học")]
        public NamHoc NamHoc
        {
            get { return namHoc; }
            set { SetPropertyValue(nameof(NamHoc), ref namHoc, value); }
        }
        private HocKy hocKy;
        [XafDisplayName("Học kỳ")]
        public HocKy HocKy
        {
            get { return hocKy; }
            set { SetPropertyValue(nameof(HocKy), ref hocKy, value); }
        }
        private Lop lop;
        [XafDisplayName("Lớp ")]
        public Lop Lop
        {
            get { return lop; }
            set { SetPropertyValue(nameof(Lop), ref lop, value); }
        }


    }
    public enum XepLoai
    {
        [XafDisplayName("Xuất sắc")]
        XuatSac = 0,
        [XafDisplayName("Giỏi")]
        Gioi = 1,
        [XafDisplayName("Khá")]
        Khá = 2,
        [XafDisplayName("Trung bình")]
        TrungBinh = 3,
        [XafDisplayName("Yếu")]
        Yeu = 4,
    }
}