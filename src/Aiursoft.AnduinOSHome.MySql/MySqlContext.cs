using System.Diagnostics.CodeAnalysis;
using Aiursoft.AnduinOSHome.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aiursoft.AnduinOSHome.MySql;

[ExcludeFromCodeCoverage]

public class MySqlContext(DbContextOptions<MySqlContext> options) : AnduinOSHomeDbContext(options);
