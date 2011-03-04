using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace AHMTestApp.DTO
{
    public class SpeakerFeeDTO
    {


        public SpeakerFeeDTO()
        {

        }

        public SpeakerFeeDTO(int personId, int feeScheduleTypeID, decimal amount, decimal oldAmount,
        int speakerFeeGroupId, DateTime startDate, DateTime endDate, int contractTypeID, int speakerRoleID)
        {

            PersonId = personId;

            FeeScheduleTypeID = feeScheduleTypeID;

            Amount = amount;

            OldAmount = oldAmount;

            SpeakerFeeGroupId = speakerFeeGroupId;

            StartDate = startDate;

            EndDate = endDate;

            ContractTypeID = contractTypeID;

            SpeakerRoleID = speakerRoleID;

        }

        //PK
        public int PersonId { get; set; }
        //PK
        public int FeeScheduleTypeID { get; set; }
        public decimal Amount { get; set; }
        public decimal OldAmount { get; set; }
        //PK
        public int SpeakerFeeGroupId { get; set; }
        //PK
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ContractTypeID { get; set; }
        public int SpeakerRoleID { get; set; }


    }
}
