﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFirstProject.VisualWebPart2 {
    using System.Web;
    using System.Text.RegularExpressions;
    using Microsoft.SharePoint.WebPartPages;
    using Microsoft.SharePoint.WebControls;
    using System.Web.Security;
    using Microsoft.SharePoint.Utilities;
    using System.Web.UI;
    using System;
    using System.Web.UI.WebControls;
    using System.Collections.Specialized;
    using Microsoft.SharePoint;
    using System.Collections;
    using System.Web.Profile;
    using System.Text;
    using System.Web.Caching;
    using System.Configuration;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.SessionState;
    using System.Web.UI.HtmlControls;
    using System.CodeDom.Compiler;
    
    
    public partial class VisualWebPart2 {
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::Microsoft.SharePoint.WebControls.CssRegistration CssRegistration1;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.TreeView TreeView1;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.GridView GridView1;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Label LabelTableInfo;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Repeater RepeaterPaging;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.UpdatePanel UpdatePanel1;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebPartCodeGenerator", "14.0.0.0")]
        public static implicit operator global::System.Web.UI.TemplateControl(VisualWebPart2 target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::Microsoft.SharePoint.WebControls.CssRegistration @__BuildControlCssRegistration1() {
            global::Microsoft.SharePoint.WebControls.CssRegistration @__ctrl;
            @__ctrl = new global::Microsoft.SharePoint.WebControls.CssRegistration();
            this.CssRegistration1 = @__ctrl;
            @__ctrl.ID = "CssRegistration1";
            @__ctrl.Name = "/_layouts/MyFirstProject/StyleSheet1.css";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control3(System.Web.UI.WebControls.TreeNodeStyle @__ctrl) {
            @__ctrl.ImageUrl = "/_layouts/images/MyFirstProject/folder_icon.png";
            @__ctrl.HorizontalPadding = new System.Web.UI.WebControls.Unit(5, System.Web.UI.WebControls.UnitType.Pixel);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control4(System.Web.UI.WebControls.TreeNodeStyle @__ctrl) {
            @__ctrl.ImageUrl = "/_layouts/images/MyFirstProject/file_icon.png";
            @__ctrl.HorizontalPadding = new System.Web.UI.WebControls.Unit(5, System.Web.UI.WebControls.UnitType.Pixel);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.TreeNode @__BuildControl__control8() {
            global::System.Web.UI.WebControls.TreeNode @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TreeNode();
            @__ctrl.Text = "BỘ KẾ HOẠCH VÀ ĐẦU TƯ";
            @__ctrl.Value = "1";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.TreeNode @__BuildControl__control9() {
            global::System.Web.UI.WebControls.TreeNode @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TreeNode();
            @__ctrl.Text = "Lớp học";
            @__ctrl.Value = "2";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.TreeNode @__BuildControl__control10() {
            global::System.Web.UI.WebControls.TreeNode @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TreeNode();
            @__ctrl.Text = "Trung tâm Tin học";
            @__ctrl.Value = "3";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control7(System.Web.UI.WebControls.TreeNodeCollection @__ctrl) {
            global::System.Web.UI.WebControls.TreeNode @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control8();
            @__ctrl.Add(@__ctrl1);
            global::System.Web.UI.WebControls.TreeNode @__ctrl2;
            @__ctrl2 = this.@__BuildControl__control9();
            @__ctrl.Add(@__ctrl2);
            global::System.Web.UI.WebControls.TreeNode @__ctrl3;
            @__ctrl3 = this.@__BuildControl__control10();
            @__ctrl.Add(@__ctrl3);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.TreeNode @__BuildControl__control6() {
            global::System.Web.UI.WebControls.TreeNode @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TreeNode();
            @__ctrl.Expanded = new System.Nullable<bool>(false);
            @__ctrl.Text = "Đơn vị đến";
            @__ctrl.Value = "donvinhap";
            @__ctrl.SelectAction = System.Web.UI.WebControls.TreeNodeSelectAction.None;
            this.@__BuildControl__control7(@__ctrl.ChildNodes);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.TreeNode @__BuildControl__control13() {
            global::System.Web.UI.WebControls.TreeNode @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TreeNode();
            @__ctrl.Text = "Thường";
            @__ctrl.Value = "8";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.TreeNode @__BuildControl__control14() {
            global::System.Web.UI.WebControls.TreeNode @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TreeNode();
            @__ctrl.Text = "Hoả tốc";
            @__ctrl.Value = "9";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.TreeNode @__BuildControl__control15() {
            global::System.Web.UI.WebControls.TreeNode @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TreeNode();
            @__ctrl.Text = "Khẩn";
            @__ctrl.Value = "10";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.TreeNode @__BuildControl__control16() {
            global::System.Web.UI.WebControls.TreeNode @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TreeNode();
            @__ctrl.Text = "Thượng khẩn";
            @__ctrl.Value = "15";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control12(System.Web.UI.WebControls.TreeNodeCollection @__ctrl) {
            global::System.Web.UI.WebControls.TreeNode @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control13();
            @__ctrl.Add(@__ctrl1);
            global::System.Web.UI.WebControls.TreeNode @__ctrl2;
            @__ctrl2 = this.@__BuildControl__control14();
            @__ctrl.Add(@__ctrl2);
            global::System.Web.UI.WebControls.TreeNode @__ctrl3;
            @__ctrl3 = this.@__BuildControl__control15();
            @__ctrl.Add(@__ctrl3);
            global::System.Web.UI.WebControls.TreeNode @__ctrl4;
            @__ctrl4 = this.@__BuildControl__control16();
            @__ctrl.Add(@__ctrl4);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.TreeNode @__BuildControl__control11() {
            global::System.Web.UI.WebControls.TreeNode @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TreeNode();
            @__ctrl.Expanded = new System.Nullable<bool>(false);
            @__ctrl.Text = "Tính chất văn bản";
            @__ctrl.Value = "khan";
            @__ctrl.SelectAction = System.Web.UI.WebControls.TreeNodeSelectAction.None;
            this.@__BuildControl__control12(@__ctrl.ChildNodes);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control5(System.Web.UI.WebControls.TreeNodeCollection @__ctrl) {
            global::System.Web.UI.WebControls.TreeNode @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control6();
            @__ctrl.Add(@__ctrl1);
            global::System.Web.UI.WebControls.TreeNode @__ctrl2;
            @__ctrl2 = this.@__BuildControl__control11();
            @__ctrl.Add(@__ctrl2);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.TreeView @__BuildControlTreeView1() {
            global::System.Web.UI.WebControls.TreeView @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TreeView();
            this.TreeView1 = @__ctrl;
            @__ctrl.TemplateControl = this;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "TreeView1";
            this.@__BuildControl__control3(@__ctrl.RootNodeStyle);
            this.@__BuildControl__control4(@__ctrl.LeafNodeStyle);
            this.@__BuildControl__control5(@__ctrl.Nodes);
            @__ctrl.SelectedNodeChanged -= new System.EventHandler(this.TreeView1_SelectedNodeChanged);
            @__ctrl.SelectedNodeChanged += new System.EventHandler(this.TreeView1_SelectedNodeChanged);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control17(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(System.Drawing.Color.FromArgb(238, 238, 238)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control19() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "strngayden";
            @__ctrl.DataFormatString = "{0:dd/MM/yyyy}";
            @__ctrl.HeaderText = "Ngày đến";
            @__ctrl.SortExpression = "strngayden";
            @__ctrl.ItemStyle.HorizontalAlign = System.Web.UI.WebControls.HorizontalAlign.Center;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control20() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "intsoden";
            @__ctrl.HeaderText = "Số đến";
            @__ctrl.SortExpression = "intsoden";
            @__ctrl.ItemStyle.HorizontalAlign = System.Web.UI.WebControls.HorizontalAlign.Center;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control21() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "strnoigui";
            @__ctrl.HeaderText = "Nơi gửi";
            @__ctrl.SortExpression = "strnoigui";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control22() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "strkyhieu";
            @__ctrl.HeaderText = "Số, ký hiệu";
            @__ctrl.SortExpression = "strkyhieu";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control23() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "strtrichyeu";
            @__ctrl.HeaderText = "Trích yếu";
            @__ctrl.SortExpression = "strtrichyeu";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control24() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "strDonvixuly";
            @__ctrl.HeaderText = "Đơn vị xử lý ";
            @__ctrl.SortExpression = "strDonvixuly";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control18(System.Web.UI.WebControls.DataControlFieldCollection @__ctrl) {
            global::System.Web.UI.WebControls.BoundField @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control19();
            @__ctrl.Add(@__ctrl1);
            global::System.Web.UI.WebControls.BoundField @__ctrl2;
            @__ctrl2 = this.@__BuildControl__control20();
            @__ctrl.Add(@__ctrl2);
            global::System.Web.UI.WebControls.BoundField @__ctrl3;
            @__ctrl3 = this.@__BuildControl__control21();
            @__ctrl.Add(@__ctrl3);
            global::System.Web.UI.WebControls.BoundField @__ctrl4;
            @__ctrl4 = this.@__BuildControl__control22();
            @__ctrl.Add(@__ctrl4);
            global::System.Web.UI.WebControls.BoundField @__ctrl5;
            @__ctrl5 = this.@__BuildControl__control23();
            @__ctrl.Add(@__ctrl5);
            global::System.Web.UI.WebControls.BoundField @__ctrl6;
            @__ctrl6 = this.@__BuildControl__control24();
            @__ctrl.Add(@__ctrl6);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control25(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.CssClass = "rowStyle";
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control26(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = System.Drawing.Color.White;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control27(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(System.Drawing.Color.FromArgb(238, 238, 238)));
            @__ctrl.Font.Bold = true;
            @__ctrl.Wrap = false;
            @__ctrl.CssClass = "fixedHeader";
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control28(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = System.Drawing.Color.DarkSlateBlue;
            @__ctrl.ForeColor = System.Drawing.Color.GhostWhite;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.GridView @__BuildControlGridView1() {
            global::System.Web.UI.WebControls.GridView @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.GridView();
            this.GridView1 = @__ctrl;
            @__ctrl.TemplateControl = this;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "GridView1";
            @__ctrl.CssClass = "gridview";
            @__ctrl.AllowPaging = true;
            @__ctrl.PageSize = 50;
            @__ctrl.AutoGenerateColumns = false;
            @__ctrl.BackColor = System.Drawing.Color.White;
            @__ctrl.ForeColor = System.Drawing.Color.Black;
            @__ctrl.GridLines = System.Web.UI.WebControls.GridLines.None;
            this.@__BuildControl__control17(@__ctrl.AlternatingRowStyle);
            this.@__BuildControl__control18(@__ctrl.Columns);
            this.@__BuildControl__control25(@__ctrl.RowStyle);
            this.@__BuildControl__control26(@__ctrl.FooterStyle);
            this.@__BuildControl__control27(@__ctrl.HeaderStyle);
            this.@__BuildControl__control28(@__ctrl.SelectedRowStyle);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabelTableInfo() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.LabelTableInfo = @__ctrl;
            @__ctrl.TemplateControl = this;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "LabelTableInfo";
            @__ctrl.Font.Bold = true;
            @__ctrl.ForeColor = System.Drawing.Color.Black;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.LinkButton @__BuildControl__control30() {
            global::System.Web.UI.WebControls.LinkButton @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.LinkButton();
            @__ctrl.TemplateControl = this;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "pagingLinkButton";
            @__ctrl.CssClass = "pagingLinkbutton";
            @__ctrl.ForeColor = System.Drawing.Color.Black;
            @__ctrl.DataBinding += new System.EventHandler(this.@__DataBinding__control30);
            @__ctrl.Click -= new System.EventHandler(this.linkButton_Click);
            @__ctrl.Click += new System.EventHandler(this.linkButton_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        public void @__DataBinding__control30(object sender, System.EventArgs e) {
            System.Web.UI.WebControls.LinkButton dataBindingExpressionBuilderTarget;
            System.Web.UI.WebControls.RepeaterItem Container;
            dataBindingExpressionBuilderTarget = ((System.Web.UI.WebControls.LinkButton)(sender));
            Container = ((System.Web.UI.WebControls.RepeaterItem)(dataBindingExpressionBuilderTarget.BindingContainer));
            dataBindingExpressionBuilderTarget.Text = System.Convert.ToString(Eval("Text") , System.Globalization.CultureInfo.CurrentCulture);
            dataBindingExpressionBuilderTarget.CommandArgument = System.Convert.ToString( Eval("Value") , System.Globalization.CultureInfo.CurrentCulture);
            dataBindingExpressionBuilderTarget.Enabled = ((bool)( Eval("Enabled") ));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control29(System.Web.UI.Control @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                                "));
            global::System.Web.UI.WebControls.LinkButton @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control30();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                            "));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Repeater @__BuildControlRepeaterPaging() {
            global::System.Web.UI.WebControls.Repeater @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Repeater();
            this.RepeaterPaging = @__ctrl;
            @__ctrl.TemplateControl = this;
            @__ctrl.ItemTemplate = new System.Web.UI.CompiledTemplateBuilder(new System.Web.UI.BuildTemplateMethod(this.@__BuildControl__control29));
            @__ctrl.ID = "RepeaterPaging";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control2(System.Web.UI.Control @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        <div id=\"parentDiv\">\r\n            <div id=\"treeviewDiv\">\r\n             " +
                        "   "));
            global::System.Web.UI.WebControls.TreeView @__ctrl1;
            @__ctrl1 = this.@__BuildControlTreeView1();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            </div>\r\n            <div id=\"tableDiv\">\r\n                <div id=\"h" +
                        "eaderDiv\"></div>\r\n                <div id=\"gridViewDiv\">\r\n                    "));
            global::System.Web.UI.WebControls.GridView @__ctrl2;
            @__ctrl2 = this.@__BuildControlGridView1();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                </div>\r\n\r\n                <div id=\"tableFooterDiv\">\r\n          " +
                        "          <div id=\"labelDiv\">\r\n                        "));
            global::System.Web.UI.WebControls.Label @__ctrl3;
            @__ctrl3 = this.@__BuildControlLabelTableInfo();
            @__parser.AddParsedSubObject(@__ctrl3);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                    </div>\r\n                    <div id=\"pagerDiv\">\r\n          " +
                        "              "));
            global::System.Web.UI.WebControls.Repeater @__ctrl4;
            @__ctrl4 = this.@__BuildControlRepeaterPaging();
            @__parser.AddParsedSubObject(@__ctrl4);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n       " +
                        " </div>\r\n    "));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.UpdatePanel @__BuildControlUpdatePanel1() {
            global::System.Web.UI.UpdatePanel @__ctrl;
            @__ctrl = new global::System.Web.UI.UpdatePanel();
            this.UpdatePanel1 = @__ctrl;
            @__ctrl.ContentTemplate = new System.Web.UI.CompiledTemplateBuilder(new System.Web.UI.BuildTemplateMethod(this.@__BuildControl__control2));
            @__ctrl.ID = "UpdatePanel1";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControlTree(global::MyFirstProject.VisualWebPart2.VisualWebPart2 @__ctrl) {
            global::Microsoft.SharePoint.WebControls.CssRegistration @__ctrl1;
            @__ctrl1 = this.@__BuildControlCssRegistration1();
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(@__ctrl1);
            global::System.Web.UI.UpdatePanel @__ctrl2;
            @__ctrl2 = this.@__BuildControlUpdatePanel1();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__ctrl.SetRenderMethodDelegate(new System.Web.UI.RenderMethod(this.@__Render__control1));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__Render__control1(System.Web.UI.HtmlTextWriter @__w, System.Web.UI.Control parameterContainer) {
            parameterContainer.Controls[0].RenderControl(@__w);
            @__w.Write("\r\n\r\n<script src=\"http://ajax.microsoft.com/ajax/jquery/jquery-1.4.2.js\" type=\"tex" +
                    "t/javascript\"></script>\r\n<script type=\"text/javascript\">\r\n    function pageLoad(" +
                    ") {\r\n        // Code to copy the gridview header with style\r\n        var gridHea" +
                    "der = $(\'#");
                     @__w.Write( GridView1.ClientID);

            @__w.Write("\').clone(true).attr(\'id\', \'clonedGrid\');\r\n        //Code to remove all rows excep" +
                    "t the header row\r\n        $(gridHeader).find(\"tr:gt(0)\").remove();\r\n        $(\'#" +
                    "");
    @__w.Write( GridView1.ClientID);

            @__w.Write(@" tr th').each(function (i) {
            //Dealing with annoyinng JQuery's Chrome bug
            var headerWidth = $(this).width();
            var isChrome = !!window.chrome && !!window.chrome.webstore;
            if (isChrome) {
                headerWidth += parseInt($(this).css('border-left-width'), 10);
            }
            // Here Set Width of each th from gridview to new table th
            $(""th:nth-child("" + (i + 1) + "")"", gridHeader).css('width', headerWidth.toString() + ""px"");
            // Here Set height of each th from gridview to new table th
            $(""th:nth-child("" + (i + 1) + "")"", gridHeader).css('height', ($(this).height()).toString() + ""px"");
        });
        // Append Header to the div controlHead
        $(""#headerDiv"").append(gridHeader);
        // Set its position to be fixed
        $('#headerDiv').css('position', 'absolute');
        // Bring the header in front of everything else
        $('#headerDiv').css('z-index', '200');
        // Put it on top
        //$('#headerDiv').css('top', '-10');
    }
</script>


");
            parameterContainer.Controls[1].RenderControl(@__w);
            @__w.Write("\r\n");
        }
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}
