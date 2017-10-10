using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fwit.Genone.Infrastructure.Database.Context
{
	public class GenoneDbContext : IdentityDbContext<IdentityUser>
	{
		public GenoneDbContext(DbContextOptions options) : base(options) { }
	}
}
