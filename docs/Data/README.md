
## AppDbContext.cs

- Configures EF Core for PostgreSQL
- DbSets: Users, Videos, VideoAnalyses
- Relationships:
  - Unique index on User.Email
- Connection string stored in `.env`
- Registered in Program.cs with DI

## Migrations

- Initial migration: `InitialCreate`
- Applied to PostgreSQL via `dotnet ef database update`
- Tables created:
  - Users
  - Videos
  - VideoAnalysis
