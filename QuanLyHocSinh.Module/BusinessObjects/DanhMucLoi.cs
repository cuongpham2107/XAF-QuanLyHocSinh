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
    [XafDisplayName("Danh mục lỗi")]
    [DefaultProperty(nameof(TenLoi))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.CategoryMenuItem)]
    public class DanhMucLoi : BaseObject
    { 
        public DanhMucLoi(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }

        float diem;
        string ghiChu;
        string tenLoi;
        bool status;
        [XafDisplayName("Lỗi")]
        [RuleRequiredField("Bắt buộc phải có DanhMucLoi.TenLoi", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
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
        [XafDisplayName("Ghi chú")]
        public string GhiChu
        {
            get => ghiChu;
            set => SetPropertyValue(nameof(GhiChu), ref ghiChu, value);
        }
        [XafDisplayName("Trạng thái")]
        public bool Status
        {
            get => status;
            set => SetPropertyValue(nameof(Status), ref status, value);
        }

    }
}