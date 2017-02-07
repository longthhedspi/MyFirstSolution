using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace MyFirstProject.VisualWebPart2
{
    [ToolboxItemAttribute(false)]
    public partial class VisualWebPart2 : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]

        //Label lblDebug = new Label();

        public VisualWebPart2()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //lblDebug.BorderStyle = BorderStyle.Solid;
            //this.Controls.Add(lblDebug);
            if (GridView1.Rows.Count == 0) MakeTable(0);
        }

        protected void linkButton_Click(object sender, EventArgs e)
        {
            int pageIndex = int.Parse((sender as LinkButton).CommandArgument);
            pageIndex -= 1;
            MakeTable(pageIndex);
        }

        private void MakeTable(int pageIndex)
        {
            int totalRows = 0;
            GridView1.PageIndex = pageIndex;
            GridView1.DataSource = GetDataWithFilters(pageIndex, GridView1.PageSize, out totalRows);
            GridView1.DataBind();
            DatabindRepeater(pageIndex, GridView1.PageSize, totalRows);
            int totalPages = totalRows / GridView1.PageSize;
            if ((totalRows % GridView1.PageSize) != 0)
            {
                totalPages += 1;
            }
            LabelTableInfo.Text = "Có " + totalRows.ToString() + " văn bản trong " + totalPages.ToString() + " trang";
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "fixedHeader", "$(document).ready(fixedHeader());", true);
        }

        private List<Congvanden> GetDataWithFilters(int pageIndex, int pageSize, out int totalRows)
        {
            int selectedTreeViewValue;
            //string userName = SPContext.Current.Web.CurrentUser.LoginName;
            string userName = "nhuson";


            if (int.TryParse(TreeView1.SelectedValue, out selectedTreeViewValue))
            {
                return CongvandenDAL.
                        GetCongvandens(userName, pageIndex, pageSize, out totalRows, int.Parse(TreeView1.SelectedNode.Parent.Value), selectedTreeViewValue);
            }
            else
            {
                return CongvandenDAL.
                    GetCongvandens(userName, pageIndex, pageSize, out totalRows);
            }


        }

        private void DatabindRepeater(int pageIndex, int pageSize, int totalRows)
        {

            int showMax = 10;
            int pageOffset = pageIndex / showMax;

            int startPage = pageOffset * showMax + 1;
            int endPage = showMax * (pageOffset + 1);
            int totalPages = totalRows / pageSize;
            if ((totalRows % pageSize) != 0)
            {
                totalPages += 1;
            }

            List<ListItem> pages = new List<ListItem>();
            if (totalPages > 1)
            {
                if (pageOffset > 0)
                {
                    pages.Add(new ListItem("◀", (startPage - 1).ToString(), true));
                }

                for (int i = startPage; i <= endPage; i++)
                {
                    if (i > totalPages) break;
                    pages.Add(new ListItem(i.ToString(), i.ToString(), i != (pageIndex + 1)));
                    if (i == endPage && totalPages > endPage)
                    {
                        pages.Add(new ListItem("▶", (endPage + 1).ToString(), true));
                    }
                }
            }
            RepeaterPaging.DataSource = pages;
            RepeaterPaging.DataBind();
        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            MakeTable(0);
        }
 
    }
}
