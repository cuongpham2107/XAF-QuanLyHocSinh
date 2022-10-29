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
    [XafDisplayName("Lớp")]
    [DefaultProperty(nameof(TenLop))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.StudentMenuItem)]
    public class Lop : BaseObject
    { 
        public Lop(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }

        GiaoVien giaoVien;
        string xepLoai;
        string ghiChu;
        KhoiLop khoiLop;
        Truong truong;
        string tenLop;
        [XafDisplayName("Tên lớp học")]
        [RuleRequiredField("Bắt buộc phải có Lop.TenLop", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string TenLop
        {
            get => tenLop;
            set => SetPropertyValue(nameof(TenLop), ref tenLop, value);
        }

        [XafDisplayName("Khối lớp")]
        public KhoiLop KhoiLop
        {
            get => khoiLop;
            set => SetPropertyValue(nameof(KhoiLop), ref khoiLop, value);
        }
        [XafDisplayName("Xếp loại")]
        public string XepLoai
        {
            get => xepLoai;
            set => SetPropertyValue(nameof(XepLoai), ref xepLoai, value);
        }
        [XafDisplayName("Giáo viên chủ nhiệm")]
        public GiaoVien GiaoVien
        {
            get => giaoVien;
            set => SetPropertyValue(nameof(GiaoVien), ref giaoVien, value);
        }
        [XafDisplayName("Trường")]
        [Association("Truong-Lops")]
        public Truong Truong
        {
            get => truong;
            set => SetPropertyValue(nameof(Truong), ref truong, value);
        }
        [XafDisplayName("Ghi chú")]
        public string GhiChu
        {
            get => ghiChu;
            set => SetPropertyValue(nameof(GhiChu), ref ghiChu, value);
        }
        [Association("Lop-HocSinhs")]
        [XafDisplayName("Danh sách học sinh")]
        public XPCollection<HocSinh> HocSinhs
        {
            get
            {
                return GetCollection<HocSinh>(nameof(HocSinhs));
            }
        }
    }
}