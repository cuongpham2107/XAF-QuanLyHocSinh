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
    [XafDisplayName("Tôn giáo")]
    [DefaultProperty(nameof(TenTonGiao))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.CategoryMenuItem)]
    public class TonGiao : BaseObject
    {
        public TonGiao(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }

        string tenTonGiao;
        [XafDisplayName("Tên tôn giáo")]
        [RuleRequiredField("Bắt buộc phải có TonGiao.TenTonGiao", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string TenTonGiao
        {
            get => tenTonGiao;
            set => SetPropertyValue(nameof(TenTonGiao), ref tenTonGiao, value);
        }
    }
}