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
    [XafDisplayName("Chi tiết vi phạm")]
    [DefaultProperty(nameof(ViPham))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.StudentMenuItem)]
    public class ChiTiet_ViPham : BaseObject
    {
        public ChiTiet_ViPham(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }

        DateTime ngayViPham;
        HocSinh hocSinh;
        float diem;
        string tenLoi;
        string maLoi;
        ViPham viPham;
        [XafDisplayName("Vi phạm")]
        [RuleRequiredField("Bắt buộc phải có ChiTiet_ViPham.ViPham", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        [Association("ViPham-ChiTiet_ViPhams")]
        public ViPham ViPham
        {
            get => viPham;
            set => SetPropertyValue(nameof(ViPham), ref viPham, value);
        }
        [XafDisplayName("Vi phạm")]
        [RuleRequiredField("Bắt buộc phải có ChiTiet_ViPham.MaLoi", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string MaLoi
        {
            get => maLoi;
            set => SetPropertyValue(nameof(MaLoi), ref maLoi, value);
        }
        [XafDisplayName("Vi phạm")]
        [RuleRequiredField("Bắt buộc phải có ChiTiet_ViPham.TenLoi", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string TenLoi
        {
            get => tenLoi;
            set => SetPropertyValue(nameof(TenLoi), ref tenLoi, value);
        }
        [XafDisplayName("Điểm")]
        public float Diem
        {
            get => diem;
            set => SetPropertyValue(nameof(Diem), ref diem, value);
        }
        [XafDisplayName("Học Sinh")]
        [RuleRequiredField("Bắt buộc phải có ChiTiet_ViPham.HocSinh", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public HocSinh HocSinh
        {
            get => hocSinh;
            set => SetPropertyValue(nameof(HocSinh), ref hocSinh, value);
        }
        [XafDisplayName("Ngày vi phạm")]
        [RuleRequiredField("Bắt buộc phải có ChiTiet_ViPham.NgayViPham", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public DateTime NgayViPham
        {
            get => ngayViPham;
            set => SetPropertyValue(nameof(NgayViPham), ref ngayViPham, value);
        }
    }
}