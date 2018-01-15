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
    public class AddCredit
    {
        public readonly NameValueCollection CreditInfo;
        public AddCredit(int clientId, string description, float amount)
        {
            CreditInfo = new NameValueCollection()
            {
                { EnumUtil.GetString(APIEnums.AddCreditParams.ClientId), clientId.ToString() },
                { EnumUtil.GetString(APIEnums.AddCreditParams.Description), description },
                { EnumUtil.GetString(APIEnums.AddCreditParams.Amount), amount.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) },
            };
        }
    }
}
