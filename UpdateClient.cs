using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHMCS_API
{
    /// <summary>
    /// Params info @ https://developers.whmcs.com/api-reference/addclient/
    /// </summary>
    public class UpdateClient
    {
        public readonly NameValueCollection ClientInfo;
        public UpdateClient(int clientId, string Firstname = null, string Lastname = null, string Email = "", string Address1 = null,
            string City = null, string State = null, string PostCode = null, string CountryCode = "", string PhoneNumber = "",
            string Password = "", bool? NoEmail = null, string CompanyName = "", string Address2 = "",
            int SecurityQuestionID = -1, string SecurityQuestionAnswer = "", string CardType = "",
            string CardNumber = "", string ExpiricyDate = "", string StartDate = "",
            string IssueNumber = "", string CVV = "", int Currency = -1, int GroupID = -1,
            string CustomFields = "", string Language = "", string ClientIP = "", string Notes = "")
        {
            ClientInfo = new NameValueCollection()
            {
                { EnumUtil.GetString(APIEnums.UpdateClientParams.ClientId), clientId.ToString() }
            };

            if (Firstname != null)
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.Firstname), Firstname);
            if (Lastname != null)
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.Lastname), Lastname);
            if (Email != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.Email), Email);
            if (Address1 != null)
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.Address1), Address1);
            if (City != null)
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.City), City);
            if (State != null)
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.State), State);
            if (PostCode != null)
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.Postcode), PostCode);
            if (CountryCode != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.CountryCode), CountryCode);
            if (PhoneNumber != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.PhoneNumber), PhoneNumber);
            if (Password != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.Password), Password);
            if (NoEmail.HasValue)
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.NoEmail), NoEmail.ToString());
            if (CompanyName != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.CompanyName), CompanyName);
            if (Address2 != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.Address2), Address2);
            if (SecurityQuestionID != -1)
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.SecurityQuestionID), SecurityQuestionID.ToString());
            if (SecurityQuestionAnswer != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.SecurityQuestionAnswer), SecurityQuestionAnswer);
            if (CardType != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.CardType), CardType);
            if (CardNumber != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.CardNumber), CardNumber);
            if (ExpiricyDate != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.ExpiricyDate), ExpiricyDate);
            if (StartDate != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.StartDate), StartDate);
            if (IssueNumber != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.IssueNumber), IssueNumber);
            if (CVV != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.CVV), CVV);
            if (Currency != -1)
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.Currency), Currency.ToString());
            if (GroupID != -1)
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.GroupID), GroupID.ToString());
            if (CustomFields != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.CustomFields), CustomFields);
            if (Language != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.Language), Language);
            if (ClientIP != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.ClientIP), ClientIP);
            if (Notes != "")
                ClientInfo.Add(EnumUtil.GetString(APIEnums.AddClientParams.Notes), Notes);
        }
    }
}
