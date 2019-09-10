
using System;
using System.Collections.Generic;
using System.Text;

using LGK.FirstCore.Model;
using Microsoft.EntityFrameworkCore;
using LGK.FirstCore.IRepository;

namespace LGK.FirstCore.Repository
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {

    }
}
