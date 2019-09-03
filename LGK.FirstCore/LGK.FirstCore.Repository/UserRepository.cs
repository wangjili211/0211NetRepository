using LGK.FirstCore.IRepository;
using LGK.FirstCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace LGK.FirstCore.Repository
{

    public class UserRepository :BaseRepository<User>, IUserRepository
    {
       
    }
}
