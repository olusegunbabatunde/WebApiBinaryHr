﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBinaryHr.Entities;

namespace WebApiBinaryHr.Services
{
    public class ProfileServices:IProfileServices
    {

        private BinaryHrDbContext Db;
        public ProfileServices(BinaryHrDbContext _db) => this.Db = _db;
    }
}
