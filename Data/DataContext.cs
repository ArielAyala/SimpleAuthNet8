﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SimpleAuthNet8.Data;

public class DataContext: IdentityDbContext 
{
    public DataContext(DbContextOptions options): base(options)
    {
        
    }
}

