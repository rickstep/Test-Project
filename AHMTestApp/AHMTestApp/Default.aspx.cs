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
            }
        }



        protected void viewDataList_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            SpeakerFeeDTO myDTO = (SpeakerFeeDTO)e.Item.DataItem;

            Label viewAmountLbl = (Label)e.Item.FindControl("viewAmountLbl");
            Label viewFeeScheduleTypeID = (Label)e.Item.FindControl("viewFeeScheduleTypeID");
            Label viewContractTypeID = (Label)e.Item.FindControl("viewContractTypeID");
            Label viewGroupIDLbl = (Label)e.Item.FindControl("viewGroupIDLbl");
            Label viewRoleIDLbl = (Label)e.Item.FindControl("viewRoleIDLbl");
            Label viewStartDateLbl = (Label)e.Item.FindControl("viewStartDateLbl");
            Label viewEndDateLbl = (Label)e.Item.FindControl("viewEndDateLbl");
            Button viewEditBtn = (Button)e.Item.FindControl("viewEditBtn");
            Button viewSaveBtn = (Button)e.Item.FindControl("viewSaveBtn");

            viewAmountLbl.Text = myDTO.Amount.ToString();
            viewFeeScheduleTypeID.Text = myDTO.FeeScheduleTypeID.ToString();
            viewContractTypeID.Text = myDTO.ContractTypeID.ToString();
            viewGroupIDLbl.Text = myDTO.SpeakerFeeGroupId.ToString();
            viewRoleIDLbl.Text = myDTO.SpeakerRoleID.ToString();
            viewStartDateLbl.Text = myDTO.StartDate.ToShortDateString();
            viewEndDateLbl.Text = myDTO.EndDate.ToShortDateString();
            viewSaveBtn.Visible = false;
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
