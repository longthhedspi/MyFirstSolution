<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VisualWebPart2.ascx.cs" Inherits="MyFirstProject.VisualWebPart2.VisualWebPart2" %>

<SharePoint:CssRegistration ID="CssRegistration1" runat="server" Name="/_layouts/MyFirstProject/StyleSheet1.css" />

<script
  src="https://code.jquery.com/jquery-1.12.4.min.js"
  integrity="sha256-ZosEbRLbNQzLpnKIkEdrPv7lOy9C27hHQ+Xp8a4MxAQ="
  crossorigin="anonymous"></script>

<script type="text/javascript">
    function pageLoad() {
        // Code to copy the gridview header with style
        var gridHeader = $('#<%= GridView1.ClientID%>').clone(true).attr('id', 'clonedGrid');
        //Code to remove all rows except the header row
        $(gridHeader).find("tr:gt(0)").remove();
        $('#<%= GridView1.ClientID%> tr th').each(function (i) {
            //Dealing with annoyinng JQuery's Chrome bug
            var headerWidth = $(this).width();
            var isChrome = !!window.chrome && !!window.chrome.webstore;
            if (isChrome) {
                headerWidth += parseInt($(this).css('border-left-width'), 10);
            }
            // Here Set Width of each th from gridview to new table th
            $("th:nth-child(" + (i + 1) + ")", gridHeader).css('width', headerWidth.toString() + "px");
            // Here Set height of each th from gridview to new table th
            $("th:nth-child(" + (i + 1) + ")", gridHeader).css('height', ($(this).height()).toString() + "px");
        });
        // Append Header to the div controlHead
        $("#headerDiv").append(gridHeader);
        // Set its position to be fixed
        $('#headerDiv').css('position', 'absolute');
        // Bring the header in front of everything else
        $('#headerDiv').css('z-index', '200');
        // Put it on top
        //$('#headerDiv').css('top', '-10');
    }

    function checkAllVB(checkbox) {
        var GridViewElement = document.getElementById("<%=GridView1.ClientID %>");
        for (i = 1; i < GridViewElement.rows.length; i++) {
            GridViewElement.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = checkbox.checked;
        }
    }
</script>


<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div id="parentDiv">
            <div id="treeviewDiv">
                <asp:TreeView ID="TreeView1" runat="server" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged">
                    <RootNodeStyle ImageUrl="/_layouts/images/MyFirstProject/folder_icon.png" HorizontalPadding="5px" />
                    <LeafNodeStyle ImageUrl="/_layouts/images/MyFirstProject/file_icon.png" HorizontalPadding="5px" />
                    <Nodes>
                        <asp:TreeNode Expanded="False" Text="Đơn vị đến" Value="1" SelectAction="None">
                            <asp:TreeNode Text="BỘ KẾ HOẠCH VÀ ĐẦU TƯ" Value="1"></asp:TreeNode>
                            <asp:TreeNode Text="Lớp học" Value="2"></asp:TreeNode>
                            <asp:TreeNode Text="Trung tâm Tin học" Value="3"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Expanded="False" Text="Tính chất văn bản" Value="2" SelectAction="None">
                            <asp:TreeNode Text="Thường" Value="8"></asp:TreeNode>
                            <asp:TreeNode Text="Hoả tốc" Value="9"></asp:TreeNode>
                            <asp:TreeNode Text="Khẩn" Value="10"></asp:TreeNode>
                            <asp:TreeNode Text="Thượng khẩn" Value="15"></asp:TreeNode>
                        </asp:TreeNode>
                    </Nodes>
                </asp:TreeView>
            </div>
            <div id="tableDiv">
                <div id="headerDiv"></div>
                <div id="gridViewDiv">
                    <asp:GridView ID="GridView1" runat="server"
                        CssClass="gridview"
                        AllowPaging="true" PageSize="50" AutoGenerateColumns="false"
                        BackColor="#FFFFFF" ForeColor="Black" GridLines="None">
                        <AlternatingRowStyle BackColor="#EEEEEE" />
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:CheckBox ID="checkAllVB" runat="server" onclick="checkAllVB(this);" CssClass="bigCheckBox" />
                                </HeaderTemplate>
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                <ItemTemplate>
                                    <asp:CheckBox ID="checkVB" runat="server" CssClass="bigCheckBox" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="btnShowPopup" runat="server" Text="Show"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="intiddonvinhap" HeaderText="iddonvi" SortExpression="intiddonvinhap" />
                            <asp:BoundField DataField="strngayden" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Ngày đến" SortExpression="strngayden" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField DataField="intsoden" HeaderText="Số đến" SortExpression="intsoden" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField DataField="strnoigui" HeaderText="Nơi gửi" SortExpression="strnoigui" />
                            <asp:BoundField DataField="strkyhieu" HeaderText="Số, ký hiệu" SortExpression="strkyhieu" />
                            <asp:BoundField DataField="strtrichyeu" HeaderText="Trích yếu" SortExpression="strtrichyeu" />
                            <asp:BoundField DataField="strDonvixuly" HeaderText="Đơn vị xử lý " SortExpression="strDonvixuly" />
                        </Columns>
                        <RowStyle CssClass="rowStyle" />
                        <FooterStyle BackColor="#FFFFFF" />
                        <HeaderStyle BackColor="#EEEEEE" Font-Bold="True" Wrap="false" CssClass="fixedHeader" />
                        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                    </asp:GridView>
                </div>

                <div id="tableFooterDiv">
                    <div id="labelDiv">
                        <asp:Label ID="LabelTableInfo" runat="server" Font-Bold="true" ForeColor="Black"></asp:Label>
                    </div>
                    <div id="pagerDiv">
                        <asp:Repeater ID="RepeaterPaging" runat="server">
                            <ItemTemplate>
                                <asp:LinkButton ID="pagingLinkButton" runat="server"
                                    CssClass="pagingLinkbutton"
                                    ForeColor="Black"
                                    Text='<%#Eval("Text") %>'
                                    CommandArgument='<%# Eval("Value") %>'
                                    Enabled='<%# Eval("Enabled") %>'
                                    OnClick="linkButton_Click">
                                </asp:LinkButton>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
