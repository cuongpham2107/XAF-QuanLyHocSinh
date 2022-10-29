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
    [ImageName("BO_Contact")]
    [XafDisplayName("Tổng hợp vi phạm")]
    [DefaultProperty(nameof(TenViPham))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.StudentMenuItem)]
    public class ViPham : BaseObject
    { 
        public ViPham(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
           
        }

        int tongSoLoi;
        string ghiChu;
        HocKy hocKy;
        NamHoc namHoc;
        Lop lop;
        int tongDiem;
        DateTime ngayViPham;
        string tenViPham;
        [XafDisplayName("Tiêu đề")]
        public string TenViPham
        {
            get => tenViPham;
            set => SetPropertyValue(nameof(TenViPham), ref tenViPham, value);
        }
        [XafDisplayName("Ngày vi phạm")]
        public DateTime NgayViPham
        {
            get => ngayViPham;
            set => SetPropertyValue(nameof(NgayViPham), ref ngayViPham, value);
        }
        [XafDisplayName("Tổng số lỗi")]
        public int TongSoLoi
        {
            get => tongSoLoi;
            set => SetPropertyValue(nameof(TongSoLoi), ref tongSoLoi, value);
        }
        [XafDisplayName("Tổng điểm")]
        public int TongDiem
        {
            get => tongDiem;
            set => SetPropertyValue(nameof(TongDiem), ref tongDiem, value);
        }
        [XafDisplayName("Lớp")]
        [RuleRequiredField("Bắt buộc phải có ViPham.Lop", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public Lop Lop
        {
            get => lop;
            set => SetPropertyValue(nameof(Lop), ref lop, value);
        }
        [XafDisplayName("Học kỳ")]
        [RuleRequiredField("Bắt buộc phải có ViPham.HocKy", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public HocKy HocKy
        {
            get => hocKy;
            set => SetPropertyValue(nameof(HocKy), ref hocKy, value);
        }
        [XafDisplayName("Năm học")]
        [RuleRequiredField("Bắt buộc phải có ViPham.NamHoc", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public NamHoc NamHoc
        {
            get => namHoc;
            set => SetPropertyValue(nameof(NamHoc), ref namHoc, value);
        }
        [XafDisplayName("Ghi chú")]
        
        public string GhiChu
        {
            get => ghiChu;
            set => SetPropertyValue(nameof(GhiChu), ref ghiChu, value);
        }
        [XafDisplayName("Danh sách vi phạm")]
        [Association("ViPham-ChiTiet_ViPhams")]
        public XPCollection<ChiTiet_ViPham> ChiTiet_ViPhams
        {
            get
            {
                return GetCollection<ChiTiet_ViPham>(nameof(ChiTiet_ViPhams));
            }
        }


    }
}