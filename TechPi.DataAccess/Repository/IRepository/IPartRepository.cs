using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechPi.Models;

namespace TechPi.DataAccess.Repository.IRepository
{
    public interface IPartRepository : IRepository<Part>
    {
        void Update(Part obj);
    }
}
