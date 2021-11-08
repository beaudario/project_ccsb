using project_ccsb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_ccsb.Services
{
    public class AfspraakService: IAfspraakService
    {
        private readonly ApplicationDbContext _db;

        public AfspraakService(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}
