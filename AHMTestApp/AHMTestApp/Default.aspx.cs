using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using AHMTestApp.DTO;

namespace AHMTestApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Bind Grid Here
                viewDataList.DataSource = GetStubbedDataForDataList();
                viewDataList.DataBind();

                initCreateRecord();
            }
        }

        private void initCreateRecord()
        {
            createFeeScheduleTypeDDL.DataSource = GetFeeScheduleTypeIds();
            createFeeScheduleTypeDDL.DataTextField = "Key";
            createFeeScheduleTypeDDL.DataValueField = "Value";
            createFeeScheduleTypeDDL.DataBind();

            createContractTypeDDL.DataSource = GetContractTypeIds();
            createContractTypeDDL.DataTextField = "Key";
            createContractTypeDDL.DataValueField = "Value";
            createContractTypeDDL.DataBind();

            createGroupDDL.DataSource = GetSpeakerFeeGroupIds();
            createGroupDDL.DataTextField = "Key";
            createGroupDDL.DataValueField = "Value";
            createGroupDDL.DataBind();

            createRoleDDL.DataSource = GetSpeakerRoleIds();
            createRoleDDL.DataTextField = "Key";
            createRoleDDL.DataValueField = "Value";
            createRoleDDL.DataBind();

        }

        protected void viewDataList_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            SpeakerFeeDTO myDTO = (SpeakerFeeDTO)e.Item.DataItem;

            TextBox viewAmountTxtBox = (TextBox)e.Item.FindControl("viewAmountTxtBox");
            DropDownList viewFeeScheduleTypeDDL = (DropDownList)e.Item.FindControl("viewFeeScheduleTypeDDL");
            DropDownList viewContractTypeDDL = (DropDownList)e.Item.FindControl("viewContractTypeDDL");
            DropDownList viewGroupDDL = (DropDownList)e.Item.FindControl("viewGroupDDL");
            DropDownList viewRoleDDL = (DropDownList)e.Item.FindControl("viewRoleDDL");
            TextBox viewStartDateTxtBox = (TextBox)e.Item.FindControl("viewStartDateTxtBox");
            TextBox viewEndDateTxtBox = (TextBox)e.Item.FindControl("viewEndDateTxtBox");
            
            Button viewEditBtn = (Button)e.Item.FindControl("viewEditBtn");
            Button viewSaveBtn = (Button)e.Item.FindControl("viewSaveBtn");

            viewAmountTxtBox.Text = myDTO.Amount.ToString();
            viewAmountTxtBox.Enabled = false;

            viewFeeScheduleTypeDDL.DataSource = GetFeeScheduleTypeIds();
            viewFeeScheduleTypeDDL.DataTextField = "Key";
            viewFeeScheduleTypeDDL.DataValueField = "Value";
            viewFeeScheduleTypeDDL.DataBind();
            viewFeeScheduleTypeDDL.SelectedValue = myDTO.FeeScheduleTypeID.ToString();
            viewFeeScheduleTypeDDL.Enabled = false;

            viewContractTypeDDL.DataSource = GetContractTypeIds();
            viewContractTypeDDL.DataTextField = "Key";
            viewContractTypeDDL.DataValueField = "Value";
            viewContractTypeDDL.DataBind();
            viewContractTypeDDL.SelectedValue = myDTO.ContractTypeID.ToString();
            viewContractTypeDDL.Enabled = false;

            viewGroupDDL.DataSource = GetSpeakerFeeGroupIds();
            viewGroupDDL.DataTextField = "Key";
            viewGroupDDL.DataValueField = "Value";
            viewGroupDDL.DataBind();
            viewGroupDDL.SelectedValue = myDTO.SpeakerFeeGroupId.ToString();
            viewGroupDDL.Enabled = false;

            viewRoleDDL.DataSource = GetSpeakerRoleIds();
            viewRoleDDL.DataTextField = "Key";
            viewRoleDDL.DataValueField = "Value";
            viewRoleDDL.DataBind();
            viewRoleDDL.SelectedValue = myDTO.SpeakerRoleID.ToString();
            viewRoleDDL.Enabled = false;

            viewStartDateTxtBox.Text = myDTO.StartDate.ToShortDateString();
            viewStartDateTxtBox.Enabled = false;
            viewEndDateTxtBox.Text = myDTO.EndDate.ToShortDateString();
            viewEndDateTxtBox.Enabled = false;
            
            viewSaveBtn.Visible = false;
            viewSaveBtn.CommandArgument = viewSaveBtn.ClientID;
            viewEditBtn.Visible = true;
            viewEditBtn.CommandArgument = viewEditBtn.ClientID;
        }

        protected void viewEditBtn_Clicked(object sender, EventArgs e)
        {
            Button senderBtn = (Button)sender;

            string clientId = senderBtn.CommandArgument;

            foreach (DataListItem item in viewDataList.Items)
            {
                Button rowButton = (Button)item.FindControl("viewEditBtn");

                if (rowButton.CommandArgument == clientId)
                {
                    TextBox viewAmountTxtBox = (TextBox)item.FindControl("viewAmountTxtBox");
                    DropDownList viewFeeScheduleTypeDDL = (DropDownList)item.FindControl("viewFeeScheduleTypeDDL");
                    DropDownList viewContractTypeDDL = (DropDownList)item.FindControl("viewContractTypeDDL");
                    DropDownList viewGroupDDL = (DropDownList)item.FindControl("viewGroupDDL");
                    DropDownList viewRoleDDL = (DropDownList)item.FindControl("viewRoleDDL");
                    TextBox viewStartDateTxtBox = (TextBox)item.FindControl("viewStartDateTxtBox");
                    TextBox viewEndDateTxtBox = (TextBox)item.FindControl("viewEndDateTxtBox");
                    Button viewSaveBtn = (Button)item.FindControl("viewSaveBtn");

                    viewAmountTxtBox.Enabled = true;
                    viewFeeScheduleTypeDDL.Enabled = true;
                    viewContractTypeDDL.Enabled = true;
                    viewGroupDDL.Enabled = true;
                    viewRoleDDL.Enabled = true;
                    viewStartDateTxtBox.Enabled = true;
                    viewEndDateTxtBox.Enabled = true;
                    viewSaveBtn.Visible = true;
                    rowButton.Visible = false;
                }

            }

        }

        protected void viewSaveBtn_Clicked(object sender, EventArgs e)
        {
            Button senderBtn = (Button)sender;

            string clientId = senderBtn.CommandArgument;

            foreach (DataListItem item in viewDataList.Items)
            {
                Button rowButton = (Button)item.FindControl("viewSaveBtn");

                if (rowButton.CommandArgument == clientId)
                {
                    TextBox viewAmountTxtBox = (TextBox)item.FindControl("viewAmountTxtBox");
                    DropDownList viewFeeScheduleTypeDDL = (DropDownList)item.FindControl("viewFeeScheduleTypeDDL");
                    DropDownList viewContractTypeDDL = (DropDownList)item.FindControl("viewContractTypeDDL");
                    DropDownList viewGroupDDL = (DropDownList)item.FindControl("viewGroupDDL");
                    DropDownList viewRoleDDL = (DropDownList)item.FindControl("viewRoleDDL");
                    TextBox viewStartDateTxtBox = (TextBox)item.FindControl("viewStartDateTxtBox");
                    TextBox viewEndDateTxtBox = (TextBox)item.FindControl("viewEndDateTxtBox");

                }

            }

        }

        protected void viewCreateBtn_Clicked(object sender, EventArgs e)
        {
            Button senderBtn = (Button)sender;


        }

        private List<SpeakerFeeDTO> GetStubbedDataForDataList()
        {
            List<SpeakerFeeDTO> myList = new List<SpeakerFeeDTO>();

            SpeakerFeeDTO newDto = new SpeakerFeeDTO(1, 51, 100M, 0M, 1, DateTime.Now, DateTime.Now.AddYears(1), 1, 66);
            myList.Add(newDto);

            SpeakerFeeDTO newDto2 = new SpeakerFeeDTO(1, 52, 999M, 0M, 2, DateTime.Now, DateTime.Now.AddYears(1), 2, 67);
            myList.Add(newDto2);

            SpeakerFeeDTO newDto3 = new SpeakerFeeDTO(1, 53, 2000M, 0M, 1, DateTime.Now.AddYears(-1), DateTime.Now, 6, 345);
            myList.Add(newDto3);


            return myList;

        }

        private Dictionary<string, string> GetFeeScheduleTypeIds()
        {

            Dictionary<string, string> myDict = new Dictionary<string, string>();
            myDict.Add(

            "Consumer", "51");
            myDict.Add(

            "eMF Programs", "52");
            myDict.Add(

            "Lecture", "53");
            myDict.Add(

            "Peer Discussion Group", "54");
            return myDict;
        }

        private Dictionary<string, string> GetSpeakerFeeGroupIds()
        {

            Dictionary<string, string> myDict = new Dictionary<string, string>();
            myDict.Add(

            "Standard", "1");
            myDict.Add(

            "Negotiated", "2");
            return myDict;
        }

        private Dictionary<string, string> GetContractTypeIds()
        {

            Dictionary<string, string> myDict = new Dictionary<string, string>();
            myDict.Add(

            "Diabetes Educator", "1");
            myDict.Add(

            "Diabetes Educator - Government Employee", "2");
            myDict.Add(

            "PDG Speaker Agreement", "3");
            myDict.Add(

            "PDG Speaker Agreement - Government Employee", "4");
            myDict.Add(

            "Speaker/Moderator Agreement", "5");
            myDict.Add(

            "Speaker/Moderator Agreement - Government Employee", "6");
            return myDict;
        }

        private Dictionary<string, string> GetSpeakerRoleIds()
        {

            Dictionary<string, string> myDict = new Dictionary<string, string>();
            myDict.Add(

            "Educator", "66");
            myDict.Add(

            "Facilitator", "67");
            myDict.Add(

            "Moderator", "344");
            myDict.Add(

            "Speaker and Moderator", "345");
            return myDict;
        }

    }
}
