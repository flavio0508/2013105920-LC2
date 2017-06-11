﻿using _2013105920_ENT.Entities;
using _2013105920_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013105920_PER.Repositories
{
    public class DispensadorEfectivoRepository : Repository<DispensadorEfectivo>, IDispensadorEfectivoRepository
    
    {
        public DispensadorEfectivoRepository(CajeroDbContext context) : base(context)
        {

        }
    }
}
