using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;

namespace MyFirstProject.VBDenDetails
{
    [ToolboxItemAttribute(false)]
    public partial class VBDenDetails : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public VBDenDetails()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            int intid = (int)Page.Session["VBDetailsID"];
            Congvanden cvd = CongvandenDAL.GetCongvanden(intid);

            ltrNgayNhap.Text = cvd.strngaytao == null ? "n/a" : cvd.strngaytao.Value.ToString("dd/MM/yyyy");
            ltrDonViNhap.Text = cvd.strdonvinhap;
            ltrNgayDen.Text = cvd.strngayden == null ? "n/a" : cvd.strngayden.Value.ToString("dd/MM/yyyy");
            ltrNguoiNhap.Text = cvd.strnguoitao;
            ltrPhanLoaiVB.Text = cvd.intidphanloaicongvanden.ToString();
            ltrSoThuTu.Text = cvd.intsoden.ToString();
            ltrKyHieuVB.Text = cvd.strkyhieu;
            ltrNgayPhatHanh.Text = cvd.strngayky == null ? "n/a" : cvd.strngayky.Value.ToString("dd/MM/yyyy");
            ltrMucDoKhan.Text = cvd.strkhan;
            ltrMucDoMat.Text = cvd.strmat;
            ltrTomTatNoiDung.Text = cvd.strtrichyeu;
            ltrNguoiKy.Text = cvd.strnguoiky;
            ltrNhomCQ.Text = cvd.strNhomcoquan;
            ltrLinhVuc.Text = cvd.strLinhvuc;
            ltrTenCoQuan.Text = cvd.strnoiphathanh;
            ltrDonViChuTri.Text = cvd.strDonvixuly;
            ltrDonViPhoiHop.Text = cvd.strdonviphoihop;
            ltrThoiHanGiaiQuyet.Text = cvd.strhanxuly;
            ltrSoBan.Text = cvd.intsoban.ToString();
            ltrYKienLanhDao.Text = cvd.strykienlanhdao;
            ltrTinhTrangXuLy.Text = cvd.strtinhtrangxuly;
            ltrLoaiVanBan.Text = cvd.strloaivb;
        }
    }
}
