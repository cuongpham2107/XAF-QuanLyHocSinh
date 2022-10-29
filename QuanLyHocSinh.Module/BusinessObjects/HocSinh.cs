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
    [XafDisplayName("Học sinh")]
    [DefaultProperty(nameof(HoTen))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.StudentMenuItem)]
    public class HocSinh : BaseObject
    {
        public HocSinh(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();

        }

        bool daNghiHoc;
        string ghiChu;
        Lop lop;
        TonGiao tonGiao;
        DanToc danToc;
        byte[] hinhAnh;
        string diaChi;
        string email;
        string soDienThoai;
        GioiTinh gioiTinh;
        string hoTen;

        [XafDisplayName("Họ và tên")]
        [RuleRequiredField("Bắt buộc phải có HocSinh.HoTen", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string HoTen
        {
            get => hoTen;
            set => SetPropertyValue(nameof(HoTen), ref hoTen, value);
        }
        [XafDisplayName("Giới tính")]
        public GioiTinh GioiTinh
        {
            get => gioiTinh;
            set => SetPropertyValue(nameof(GioiTinh), ref gioiTinh, value);
        }
        [XafDisplayName("Số điện thoại")]
        [RuleRequiredField("Bắt buộc phải có HocSinh.SoDienThoai", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string SoDienThoai
        {
            get => soDienThoai;
            set => SetPropertyValue(nameof(SoDienThoai), ref soDienThoai, value);
        }
        [XafDisplayName("Địa chỉ email")]
        public string Email
        {
            get => email;
            set => SetPropertyValue(nameof(Email), ref email, value);
        }
        [XafDisplayName("Địa chỉ")]
        [RuleRequiredField("Bắt buộc phải có HocSinh.DiaChi", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string DiaChi
        {
            get => diaChi;
            set => SetPropertyValue(nameof(DiaChi), ref diaChi, value);
        }
        [XafDisplayName("Hình ảnh")]
        [ImageEditor(ListViewImageEditorCustomHeight = 75, DetailViewImageEditorFixedHeight = 150)]
        public byte[] HinhAnh
        {
            get => hinhAnh;
            set => SetPropertyValue(nameof(HinhAnh), ref hinhAnh, value);
        }
        [XafDisplayName("Dân tộc")]
        public DanToc DanToc
        {
            get => danToc;
            set => SetPropertyValue(nameof(DanToc), ref danToc, value);
        }
        [XafDisplayName("Tôn giáo")]
        public TonGiao TonGiao
        {
            get => tonGiao;
            set => SetPropertyValue(nameof(TonGiao), ref tonGiao, value);
        }
        [XafDisplayName("Lớp")]
        [Association("Lop-HocSinhs")]
        public Lop Lop
        {
            get => lop;
            set => SetPropertyValue(nameof(Lop), ref lop, value);
        }
        [XafDisplayName("Ghi chú")]
        public string GhiChu
        {
            get => ghiChu;
            set => SetPropertyValue(nameof(GhiChu), ref ghiChu, value);
        }
        [XafDisplayName("Trình trạng học")]
        public bool DaNghiHoc
        {
            get => daNghiHoc;
            set => SetPropertyValue(nameof(DaNghiHoc), ref daNghiHoc, value);
        }
    }
}