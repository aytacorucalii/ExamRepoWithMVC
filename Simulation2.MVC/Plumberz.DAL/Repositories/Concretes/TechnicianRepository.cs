using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plumberz.Core.Models;
using Plumberz.DAL.Contexts;
using Plumberz.DAL.Repositories.Abstractions;

namespace Plumberz.DAL.Repositories.Concretes;

public class TechnicianRepository : GenericRepository<Technician>, ITechnicianRepository
{
    public TechnicianRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
