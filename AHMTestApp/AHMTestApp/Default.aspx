<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AHMTestApp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Page Title</title>
    <style type="text/css">
        body{float:left;margin:0;padding:0;width:100%;height:100%;background-color:#fff;}
        form{float:left;margin:0;padding:0;width:100%;height:100%;text-align:center;}
        .data_wrap{float:none;margin:0 auto;width:770px;}
        .data_body{float:left;width:770px;padding:0;background-color:#f8f8f8;-webkit-border-radius:4px;-moz-border-radius:4px;border-radius:4px;border:1px solid #d6d6d6;margin-top:15px;}
        .data_list{float:left;width:770px;padding:0;background-color:#fff;}
        .data_row{float:left;width:740px;border-bottom:1px solid #d6d6d6;padding:15px;background-color:#fff;}
        .last{border-bottom:none;margin-bottom:3px;}
        .data_item_l{float:left;width:80px; padding:5px;text-align:center;font-family:arial;color:#313131;font-size:14px;}
        .data_item_s{float:left;width:91px;padding:5px;text-align:center;font-family:arial;color:#313131;font-size:14px;}
        .data_item_txtbox{float:left;width:76px;margin-left:5px;margin-right:5px;margin-top:5px;text-align:center;font-family:arial;color:#313131;font-size:14px;background-color:#ffffff;}
        .short1{width:55px;}
        .short2{width:51px;}
        .data_item_ddl{float:left;width:91px;margin-left:5px;margin-right:5px;margin-top:5px;text-align:center;font-family:arial;color:#313131;font-size:14px;}
        .title_row{float:left;width:740px;border-bottom:1px solid #d6d6d6;padding:10px 15px 0px 15px;}
        .long{width:auto;border-bottom:none;}
        .data_title{font-size:12px;}
        .data_btn{float:left;width:80px;height:30px;margin-left:5px;margin-top:0px;cursor:pointer;}
        .data_btn2{float:left;width:40px;height:30px;margin-left:5px;margin-top:0px; font-size:9px;cursor:pointer;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
      <div class="data_wrap">
        <div class="data_body">
            <div class="title_row long">
                <div class="data_item_l long">
                    <strong>Page Title</strong>
                </div>
            </div>
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
                <div class="data_item_s data_title short1">
                    <strong>Amount</strong>
                </div>
            </div>
            <!-- The Grid Of Existing Values Goes Here -->
                <asp:DataList ID="viewDataList" CssClass="data_list" OnItemDataBound="viewDataList_ItemDataBound" RepeatLayout="Flow" runat="server">
                    <ItemTemplate>
                        <div class="data_row">
                            <asp:TextBox ID="viewStartDateTxtBox" CssClass="data_item_txtbox" runat="server"></asp:TextBox>
                            <asp:TextBox ID="viewEndDateTxtBox" CssClass="data_item_txtbox" runat="server"></asp:TextBox>
                            <asp:DropDownList ID="viewFeeScheduleTypeDDL" CssClass="data_item_ddl" runat="server"></asp:DropDownList>
                            <asp:DropDownList ID="viewGroupDDL" CssClass="data_item_ddl"  runat="server"></asp:DropDownList>
                            <asp:DropDownList ID="viewContractTypeDDL" CssClass="data_item_ddl"  runat="server"></asp:DropDownList>
                            <asp:DropDownList ID="viewRoleDDL" CssClass="data_item_ddl" runat="server"></asp:DropDownList>
                            <asp:TextBox ID="viewAmountTxtBox" CssClass="data_item_txtbox short2" runat="server"></asp:TextBox>
                            <asp:Button ID="viewEditBtn" CssClass="data_btn" OnClick="viewEditBtn_Clicked" runat="server" Text="Edit" />
                            <asp:Button ID="viewDeleteBtn" CssClass="data_btn2" OnClick="viewDeleteBtn_Clicked" runat="server" Text="Delete" />
                            <asp:Button ID="viewSaveBtn" CssClass="data_btn2" OnClick="viewSaveBtn_Clicked" runat="server" Text="Save" />
                        </div>
                    </ItemTemplate>
                </asp:DataList>
            <!-- The Cancel Button and Add New Link Button Goes Here -->
            <!-- The Add New Section Goes here -->
            <div class="title_row long">
                <div class="data_item_l long">
                    <strong>Add New Record</strong>
                </div>
            </div>
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
                <div class="data_item_s data_title short1">
                    <strong>Amount</strong>
                </div>
            </div>
            <div class="data_row last">
                <asp:TextBox ID="createStartDateTxtBox" CssClass="data_item_txtbox" runat="server"></asp:TextBox>
                <asp:TextBox ID="createEndDateTxtBox" CssClass="data_item_txtbox" runat="server"></asp:TextBox>
                <asp:DropDownList ID="createFeeScheduleTypeDDL" CssClass="data_item_ddl" runat="server"></asp:DropDownList>
                <asp:DropDownList ID="createGroupDDL" CssClass="data_item_ddl"  runat="server"></asp:DropDownList>
                <asp:DropDownList ID="createContractTypeDDL" CssClass="data_item_ddl"  runat="server"></asp:DropDownList>
                <asp:DropDownList ID="createRoleDDL" CssClass="data_item_ddl" runat="server"></asp:DropDownList>
                <asp:TextBox ID="createAmountTxtBox" CssClass="data_item_txtbox short2" runat="server"></asp:TextBox>
                <asp:Button ID="createEditBtn" CssClass="data_btn" OnClick="viewCreateBtn_Clicked" runat="server" Text="Create" />
             </div>
        </div>
      </div>  
    </form>
</body>
</html>
