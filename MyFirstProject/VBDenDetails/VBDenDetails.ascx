<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VBDenDetails.ascx.cs" Inherits="MyFirstProject.VBDenDetails.VBDenDetails" %>

<SharePoint:CssRegistration ID="CssRegistration2" runat="server" Name="/_layouts/MyFirstProject/StyleSheet2.css" After="corev4.css" />

<style type="text/css">
    table {
        width: 100%;
    }

    /*Fix annoying cellpadding=4 in table in some ContentDiv*/ 
    table td {
        padding: 0;
    }

    #parentDiv {
    }

    #printDiv {
        background-color: #EEEEEE;
        border: 1px solid #959595;
        padding: 5px;
    }

    #tableDiv {
        color: black;
        padding: 10px;
    }

    .tableClass td {
        font-size: 8pt;
        font-family: Arial;
        padding: 3px;
    }

    .boldFont {
        font-weight: bold;
    }

    .titleFont {
        font-weight: bold;
        font-size: 18px;
    }

    .btnPrint {
        border: 1px solid #CDCDCD;
        padding: 5px 10px 5px 25px;
        font-weight: bold;
        background: url(/_layouts/images/MyFirstProject/printer_icon.png) left 3px top 5px no-repeat #F0F0F0;
    }
</style>

<script>
    function printPage() {
        var printDiv = document.getElementById("printDiv");
        printDiv.style.display = "none";
        window.print();
        printDiv.style.display = "block";
    }
</script>
<div id="parentDiv">
    <div id="printDiv">
        <asp:Button ID="printButton" runat="server" Text="In" OnClientClick="printPage(); return false" CssClass="btnPrint" />
    </div>
    <div id="tableDiv">
        <table class="tableClass" >
            <tr>
                <td><span class="boldFont">Ngày, giờ nhập:</span>
                    <asp:Literal ID="ltrNgayNhap" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td><span class="boldFont">BỘ KẾ HOẠCH VÀ ĐẦU TƯ</span></td>
            </tr>
            <tr>
                <td>
                    <span class="boldFont">
                        <asp:Literal ID="ltrDonViNhap" runat="server"></asp:Literal></span>
                </td>
            </tr>
            <tr>
                <td style="text-align: center;"><span class="titleFont">CÔNG VĂN ĐẾN</span></td>
            </tr>
            <tr>
                <td>
                    <table style="width: 100%;">
                        <tr>
                            <td><span class="boldFont">Ngày đến:</span>
                                <asp:Literal ID="ltrNgayDen" runat="server"></asp:Literal>
                            </td>
                            <td><span class="boldFont">Người nhập:</span>
                                <asp:Literal ID="ltrNguoiNhap" runat="server"></asp:Literal>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table class="tableClass">
                        <tr>
                            <td><span class="boldFont">Phân loại:</span>
                                <asp:Literal ID="ltrPhanLoaiVB" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Số thứ tự:</span>
                                <asp:Literal ID="ltrSoThuTu" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Ký hiệu văn bản:</span>
                                <asp:Literal ID="ltrKyHieuVB" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Ngày phát hành:</span>
                                <asp:Literal ID="ltrNgayPhatHanh" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Mức độ mật:</span>
                                <asp:Literal ID="ltrMucDoMat" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Mức độ khẩn:</span>
                                <asp:Literal ID="ltrMucDoKhan" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Tóm tắt nội dung:</span>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Literal ID="ltrTomTatNoiDung" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Người ký:</span>
                                <asp:Literal ID="ltrNguoiKy" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Nơi gửi</span></td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Nhóm cơ quan:</span>
                                <asp:Literal ID="ltrNhomCQ" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Tên cơ quan:</span>
                                <asp:Literal ID="ltrTenCoQuan" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Đơn vị chủ trì:</span>
                                <asp:Literal ID="ltrDonViChuTri" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Đơn vị phối hợp:</span>
                                <asp:Literal ID="ltrDonViPhoiHop" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Thời hạn giải quyết:</span>
                                <asp:Literal ID="ltrThoiHanGiaiQuyet" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Số bản:</span>
                                <asp:Literal ID="ltrSoBan" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Ý kiến của lãnh đạo:</span>
                                <asp:Literal ID="ltrYKienLanhDao" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Tình trạng xử lý:</span>
                                <asp:Literal ID="ltrTinhTrangXuLy" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Loại văn bản:</span>
                                <asp:Literal ID="ltrLoaiVanBan" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Số trả lời:</span>
                                <asp:Literal ID="ltrSoTraLoi" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Danh sách Đơn vị/cán bộ nhận văn bản để biết:</span>
                                <asp:Literal ID="ltrDSCanBo" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Lĩnh vực:</span>
                                <asp:Literal ID="ltrLinhVuc" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Tình trạng xử lý văn bản</span></td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Hồ sơ phân xử lý:</span>
                                <asp:Literal ID="ltrHosoxl" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Hồ sơ liên quan:</span></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Literal ID="ltrHosolq" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><span class="boldFont">Toàn văn nội dung</span></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Literal ID="ltrDinhKem" runat="server"></asp:Literal>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</div>
