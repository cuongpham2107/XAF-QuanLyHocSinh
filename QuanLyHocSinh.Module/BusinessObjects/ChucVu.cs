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
    [XafDisplayName("Chức vụ")]
    [DefaultProperty(nameof(TenChucVu))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.TeacherMenuItem)]
    public class ChucVu : BaseObject
    { 
        public ChucVu(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        string moTa;
        string tenChucVu;
        [XafDisplayName("Tên chức vụ")]
        [RuleRequiredField("Bắt buộc phải có ChucVu.TenChucVu", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string TenChucVu
        {
            get => tenChucVu;
            set => SetPropertyValue(nameof(TenChucVu), ref tenChucVu, value);
        }

        [XafDisplayName("Mô Tả")]
        public string MoTa
        {
            get => moTa;
            set => SetPropertyValue(nameof(MoTa), ref moTa, value);
        }
    }
}