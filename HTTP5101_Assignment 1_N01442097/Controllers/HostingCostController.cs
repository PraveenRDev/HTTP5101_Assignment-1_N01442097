using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment_1_N01442097.Controllers
{
    public class HostingCostController : ApiController
    {
        /* 
        GET /api/HostingCost/0 -> “0 fortnights at $5.50/FN = $5.50 CAD”
                                  “HST 13% = $0.72 CAD”
                                  “Total = $6.22 CAD” 
        */
        public IEnumerable<string> Get(int id)
        {
            const int FORTNIGHT = 14;
            const double FORTNIGHT_CHARGE = 5.50;
            const double HST_CHARGE = 0.13;

            double no_of_fortnight = Math.Floor((double)(id / FORTNIGHT));
            double charge_for_fornights = Math.Round((no_of_fortnight + 1) * FORTNIGHT_CHARGE, 2);
            double hst_charge = Math.Round(charge_for_fornights * HST_CHARGE, 2);
            double total_charge = Math.Round(charge_for_fornights + hst_charge, 2);

            return new string[] {
                $"{no_of_fortnight} fortnights at ${FORTNIGHT_CHARGE:0.00}/FN = ${charge_for_fornights:0.00} CAD",
                $"HST 13% = ${hst_charge:0.00} CAD",
                $"Total = ${total_charge:0.00} CAD"
            };
        }
    }
}
