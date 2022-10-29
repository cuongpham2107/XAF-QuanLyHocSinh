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
    [XafDisplayName("Môn học")]
    [DefaultProperty(nameof(TenMonHoc))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.CategoryMenuItem)]
    public class MonHoc : BaseObject
    { 
        public MonHoc(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }

        int soTiet;
        int heSo;
        string tenMonHoc;
        [XafDisplayName("Tên môn học")]
        [RuleRequiredField("Bắt buộc phải có MonHoc.TenMonHoc", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string TenMonHoc
        {
            get => tenMonHoc;
            set => SetPropertyValue(nameof(TenMonHoc), ref tenMonHoc, value);
        }
        [XafDisplayName("Hệ số")]
        public int HeSo
        {
            get => heSo;
            set => SetPropertyValue(nameof(HeSo), ref heSo, value);
        }
        [XafDisplayName("Số tiết")]
        public int SoTiet
        {
            get => soTiet;
            set => SetPropertyValue(nameof(SoTiet), ref soTiet, value);
        }   

        [Association("MonHoc-GiaoVien")]
        [XafDisplayName("Giáo viên dậy")]
        public XPCollection<GiaoVien> GiaoViens
        {
            get
            {
                return GetCollection<GiaoVien>(nameof(GiaoViens));
            }
        }
    }
}