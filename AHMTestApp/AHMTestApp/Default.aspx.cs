﻿using System;
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
            //Bind Grid Here
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