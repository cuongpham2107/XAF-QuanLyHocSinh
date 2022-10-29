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
    [XafDisplayName("Trường")]
    [DefaultProperty(nameof(TenTruong))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.CategoryMenuItem)]
    public class Truong : BaseObject
    { 
        public Truong(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
           
        }

        string website;
        string diaChi;
        string soDienThoai;
        string email;
        string tenTruong;
        [XafDisplayName("Tên trường")]
        [RuleRequiredField("Bắt buộc phải có Truong.TenTruong", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string TenTruong
        {
            get => tenTruong;
            set => SetPropertyValue(nameof(TenTruong), ref tenTruong, value);
        }
        [XafDisplayName("Số điện thoại")]
        [RuleRequiredField("Bắt buộc phải có NamHoc.SoDienThoai", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string SoDienThoai
        {
            get => soDienThoai;
            set => SetPropertyValue(nameof(SoDienThoai), ref soDienThoai, value);
        }
        [XafDisplayName("Email")]
        public string Email
        {
            get => email;
            set => SetPropertyValue(nameof(Email), ref email, value);
        }
        [XafDisplayName("Địa chỉ")]
        [RuleRequiredField("Bắt buộc phải có NamHoc.DiaChi", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string DiaChi
        {
            get => diaChi;
            set => SetPropertyValue(nameof(DiaChi), ref diaChi, value);
        }
        [XafDisplayName("Website")]
        public string Website
        {
            get => website;
            set => SetPropertyValue(nameof(Website), ref website, value);
        }
        [Association("Truong-Lops")]
        [XafDisplayName("Danh sách lớp học")]
        public XPCollection<Lop> Lops
        {
            get
            {
                return GetCollection<Lop>(nameof(Lops));
            }
        }

        [Association("Truong-GiaoViens")]
        [XafDisplayName("Danh sách giáo viên")]
        public XPCollection<GiaoVien> GiaoViens
        {
            get
            {
                return GetCollection<GiaoVien>(nameof(GiaoViens));
            }
        }

    }
}