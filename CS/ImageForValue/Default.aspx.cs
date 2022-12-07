using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxTreeList;
using DevExpress.Web;

namespace ImageForValue {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            LoadNodes();
        }

        private void LoadNodes() {
            TreeListNode node = ASPxTreeList1.AppendNode(1);
            node.SetValue("Status", "new");
            node.SetValue("Message", "Season greetings!");

            node = ASPxTreeList1.AppendNode(2);
            node.SetValue("Status", "saved");
            node.SetValue("Message", "New Regulations");

            node = ASPxTreeList1.AppendNode(3);
            node.SetValue("Status", "deleted");
            node.SetValue("Message", "Present for yoou");
        }

        protected void ASPxTreeList1_HtmlDataCellPrepared(object sender, TreeListHtmlDataCellEventArgs e) {
            if(e.Column.FieldName == "Status") {
                string fileName = string.Empty;
                switch((string)e.CellValue) {
                    case "deleted":
                        fileName = "~/Images/deleted.png";
                        break;
                    case "saved":
                        fileName = "~/Images/saved.png";
                        break;
                }
                ASPxImage img = (ASPxImage)ASPxTreeList1.FindDataCellTemplateControl(e.NodeKey, e.Column, "ASPxImage1");
                if(fileName != string.Empty) 
                    img.ImageUrl = fileName;
                else
                    img.Visible = false;
            }
        }
    }
}
