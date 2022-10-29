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
    [XafDisplayName("Giáo viên")]
    [DefaultProperty(nameof(HoTen))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.TeacherMenuItem)]
    public class GiaoVien : BaseObject
    {
        public GiaoVien(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
           
        }

        Lop lop;
        Truong truong;
        TonGiao tonGiao;
        DanToc danToc;
        ChucVu chucVu;
        string diaChi;
        string email;
        string soDienThoai;
        byte[] hinhAnh;
        GioiTinh gioiTinh;
        DateTime ngaySinh;
        string hoTen;

        [XafDisplayName("Họ và tên")]
        [RuleRequiredField("Bắt buộc phải có GiaoVien.HoTen", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string HoTen
        {
            get => hoTen;
            set => SetPropertyValue(nameof(HoTen), ref hoTen, value);
        }

        [XafDisplayName("Ngày sinh")]
        [RuleRequiredField("Bắt buộc phải có GiaoVien.NgaySinh", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public DateTime NgaySinh
        {
            get => ngaySinh;
            set => SetPropertyValue(nameof(NgaySinh), ref ngaySinh, value);
        }

        [XafDisplayName("Giới tính")]
        public GioiTinh GioiTinh
        {
            get => gioiTinh;
            set => SetPropertyValue(nameof(GioiTinh), ref gioiTinh, value);
        }

        [XafDisplayName("Số điện thoại")]
        public string SoDienThoai
        {
            get => soDienThoai;
            set => SetPropertyValue(nameof(SoDienThoai), ref soDienThoai, value);
        }

        [XafDisplayName("Địa chỉ Email")]
        public string Email
        {
            get => email;
            set => SetPropertyValue(nameof(Email), ref email, value);
        }

        [XafDisplayName("Địa chỉ")]
        [RuleRequiredField("Bắt buộc phải có GiaoVien.DiaChi", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
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
        [RuleRequiredField("Bắt buộc phải có GiaoVien.DanToc", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public DanToc DanToc
        {
            get => danToc;
            set => SetPropertyValue(nameof(DanToc), ref danToc, value);
        }

        [XafDisplayName("Tôn giáo")]
        [RuleRequiredField("Bắt buộc phải có GiaoVien.TonGiao", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public TonGiao TonGiao
        {
            get => tonGiao;
            set => SetPropertyValue(nameof(TonGiao), ref tonGiao, value);
        }

        [XafDisplayName("Chức vụ")]
        [RuleRequiredField("Bắt buộc phải có GiaoVien.ChucVu", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public ChucVu ChucVu
        {
            get => chucVu;
            set => SetPropertyValue(nameof(ChucVu), ref chucVu, value);
        }
        [XafDisplayName("Chủ nhiệm lớp")]
        [ModelDefault("AllowEdit","False")]
        public Lop Lop
        {
            get => lop;
            set => SetPropertyValue(nameof(Lop), ref lop, value);
        }
        [XafDisplayName("Trường")]
        [Association("Truong-GiaoViens")]
        public Truong Truong
        {
            get => truong;
            set => SetPropertyValue(nameof(Truong), ref truong, value);
        }

        [Association("MonHoc-GiaoVien")]
        [XafDisplayName("Môn học phụ trách")]
        public XPCollection<MonHoc> MonHocs
        {
            get
            {
                return GetCollection<MonHoc>(nameof(MonHocs));
            }
        }

    }
}