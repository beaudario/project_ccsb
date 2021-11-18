using project_ccsb.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_ccsb.Services
{
    public class IAfspraakService
    {
        public List<KlantViewModel> GetKlantList()
        {
            var klanten = new KlantViewModel
            {
                
            };

            return klanten;
        }

    }
}
