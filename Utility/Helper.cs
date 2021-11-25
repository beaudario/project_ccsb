using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_ccsb.Utility
{
    public static class Helper
    {
        public static readonly string Admin = "Beheerder";
        public static readonly string Klant = "Klant";
        public static readonly string Medewerker = "Medewerker";

        public static List<SelectListItem> GetRolesForDropDown(bool isAdmin)
        {
            var items = new List<SelectListItem>
            {
                new SelectListItem{Value=Helper.Admin , Text = Helper.Admin},
                new SelectListItem{Value=Helper.Klant , Text = Helper.Klant},
                new SelectListItem{Value=Helper.Medewerker , Text = Helper.Medewerker}
            };
            return items.OrderBy(s => s.Text).ToList();
        }
    }
}
