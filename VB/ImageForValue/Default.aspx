<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="ImageForValue._Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=B88D1754D700E49A"
	Namespace="DevExpress.Web" TagPrefix="dxe" %>

<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=B88D1754D700E49A"
	Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dxwtl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dxwtl:ASPxTreeList ID="ASPxTreeList1" runat="server" AutoGenerateColumns="False" OnHtmlDataCellPrepared="ASPxTreeList1_HtmlDataCellPrepared">
			<Columns>
				<dxwtl:TreeListTextColumn FieldName="Status" Name="colStatus" VisibleIndex="0">
					<DataCellTemplate>
		<dxe:ASPxImage ID="ASPxImage1" runat="server">
		</dxe:ASPxImage>
					</DataCellTemplate>
				</dxwtl:TreeListTextColumn>
				<dxwtl:TreeListTextColumn FieldName="Message" Name="colMessage" VisibleIndex="1">
				</dxwtl:TreeListTextColumn>
			</Columns>
		</dxwtl:ASPxTreeList>
		&nbsp;
	</div>
	</form>
</body>
</html>
