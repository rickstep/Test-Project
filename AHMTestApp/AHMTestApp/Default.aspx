<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AHMTestApp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        body
        {
            float:left;
            margin:0;
            padding:0;
            width:100%;
            height:100%;
            background-color:#515151;
        }
        
        form
        {
            float:left;
            margin:0;
            padding:0;
            width:100%;
            height:100%;
        }
        
        .data_wrap
        {
            float:left;
            width:770px;
            padding:0;
            background-color:#f8f8f8;
            -webkit-border-radius:4px;
            -moz-border-radius:4px;
            border-radius:4px;
            border:1px solid #313131;
            margin-left:15px;
            margin-top:15px;
            padding-bottom:15px;
        }
        
        .data_list
        {
            float:left;
            width:770px;
            padding:0;
            background-color:#fff;
        }
        
        .data_row
        {
            float:left;
            width:740px;
            border-bottom:1px solid #d6d6d6;
            padding:15px;
        }
        
        .data_item_l
        {
            float:left;
            width:90px;
            padding:10px;
            text-align:center;
            font-family:arial;
            color:#313131;
            font-size:14px;
        }
        
        .data_item_s
        {
            float:left;
            width:60px;
            text-align:center;
            font-family:arial;
            padding:10px;
            color:#313131;
            font-size:14px;
        }
        
        .title_row
        {
            float:left;
            width:740px;
            border-bottom:1px solid #d6d6d6;
            padding:10px 15px 0px 15px;
        }
        
        .data_title
        {
            font-size:12px;
        }
        
        .data_btn
        {
            float:left;
            width:100px;
            height:30px;
            margin-left:15px;
            margin-top:3px;   
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="data_wrap">
            <div class="title_row">
                <div class="data_item_l data_title">
                    <strong>Start Date</strong>
                </div>
                <div class="data_item_l data_title">
                    <strong>End Date</strong>
                </div>
                <div class="data_item_s data_title">
                    <strong>Schedule Type</strong>
                </div>
                <div class="data_item_s data_title">
                    <strong>Fee Group</strong>
                </div>
                <div class="data_item_s data_title">
                    <strong>Contract Type</strong>
                </div>
                <div class="data_item_s data_title">
                    <strong>Speaker Role</strong>
                </div>
                <div class="data_item_s data_title">
                    <strong>Amount</strong>
                </div>
            </div>
            <!-- The Grid Of Existing Values Goes Here -->
                <asp:DataList ID="viewDataList" CssClass="data_list" OnItemDataBound="viewDataList_ItemDataBound" RepeatLayout="Flow" runat="server">
                    <ItemTemplate>
                        <div class="data_row">
                            <asp:Label ID="viewStartDateLbl" CssClass="data_item_l" runat="server" Text="Label"></asp:Label>
                            <asp:Label ID="viewEndDateLbl" CssClass="data_item_l" runat="server" Text="Label"></asp:Label>
                            <asp:Label ID="viewFeeScheduleTypeID" CssClass="data_item_s" runat="server" Text="Label"></asp:Label>
                            <asp:Label ID="viewGroupIDLbl" CssClass="data_item_s" runat="server" Text="Label"></asp:Label>
                            <asp:Label ID="viewContractTypeID" CssClass="data_item_s" runat="server" Text="Label"></asp:Label>
                            <asp:Label ID="viewRoleIDLbl" CssClass="data_item_s" runat="server" Text="Label"></asp:Label>
                            <asp:Label ID="viewAmountLbl" CssClass="data_item_s" runat="server" Text="Label"></asp:Label>
                            <asp:Button ID="viewEditBtn" CssClass="data_btn" runat="server" Text="Edit" />
                            <asp:Button ID="viewSaveBtn" CssClass="data_btn" runat="server" Text="Save" />
                        </div>
                    </ItemTemplate>
                </asp:DataList>
            <!-- The Cancel Button and Add New Link Button Goes Here -->
            <!-- The Add New Section Goes here -->
        </div>
        
    </form>
</body>
</html>
