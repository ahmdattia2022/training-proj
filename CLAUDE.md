# Training Project Guidelines

## Purpose
This is a **study and practice project**, not a production product. The goal is to learn and understand .NET, EF Core, PostgreSQL, and API development. When working with AI assistance, always explain concepts clearly so I can understand what's happening and why.

## Learning Approach
- Explain new concepts when introducing them
- Show examples with brief explanations
- Prioritize understanding over just getting code to work
- When asked, break down complex topics into beginner-friendly steps

## AI Assistance Rules
- **Hints first, not full implementations** — guide me to the solution, don't hand it over
- Only provide complete code when explicitly requested
- Don't add extra features, patterns, or complexity I didn't ask for
- Let me struggle and learn; step in only when I'm stuck
- Ask clarifying questions instead of assuming what I need
- When I make mistakes, point them out and let me fix them

## Code Style

### General Rules
- Keep lambda expressions on one line when possible
- Use short parameter names in lambdas: `opt`, `ctx`, `x`, `p`
- Prefer concise code over verbose multi-line formatting

### Comments
- Minimal and descriptive only
- Ratio: ~1 comment per 10-15 lines of code
- Comment the "why", not the "what"
- No commented-out code
- No obvious comments like `// Get all drivers`

**Good:**
```csharp
// Seed data for testing
modelBuilder.Entity<Driver>().HasData(DriverData.GetSampleDrivers());
```

**Avoid:**
```csharp
// This method returns all drivers from the database
// It uses Entity Framework Core to query the Drivers table
// and returns them as a list
public async Task<List<Driver>> GetDrivers() => await db.Drivers.ToListAsync();

### Examples

**Good:**
```csharp
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql(connectionString));
app.MapGet("/drivers", async (AppDbContext db) => await db.Drivers.ToListAsync());
var drivers = await db.Drivers.Where(d => d.Team == "Ferrari").ToListAsync();
```

**Avoid:**
```csharp
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

app.MapGet("/drivers", async (AppDbContext db) => 
{
    return await db.Drivers.ToListAsync();
});
```

## Project Structure
```
training-proj/
├── Data/           # DbContext
├── Endpoints/      # Extension methods for API endpoints
├── Models/         # Entity classes and DTOs
└── Program.cs      # Entry point, keep minimal
```

## Database
- PostgreSQL via Docker (port 5433)
- Use EF Core with Npgsql provider
- Connection string in appsettings.json

## Conventions
- Extension methods for grouping endpoints: `app.MapDriverEndpoints()`
- One entity per file in Models/
- Seed data as static methods in entity files

## Commit Messages
- One short line, imperative mood, to the point
- Descriptive of what changed, no filler (e.g. `Add CacheService with key validation`)
- No body unless explicitly asked
