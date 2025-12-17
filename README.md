
# Database Setup Guide

## Phase 1: Create the Database Schema
In this phase, we generate the tables without the seed data to ensure the base structure is ready.

1. **Prepare the Context**  
   Temporarily disable the seeding logic in `ApplicationDbContext.cs` by commenting out the relevant lines inside `OnModelCreating`.

2. **Generate Migration**  
   ```bash
   dotnet ef migrations add InitialCreate
3. **Update Database**
   ```bash
   dotnet ef database update
   
## Phase 2: Seed Identity Data
In this phase, we generate the tables without the seed data to ensure the base structure is ready.
1. **Enable Seeding**
   Uncomment the following lines in ApplicationDbContext.cs:
   ```bash
    builder.Entity<ApplicationRole>().HasData(RoleSeed.GetRoles());
    builder.Entity<ApplicationUser>().HasData(UserSeed.GetUsers());
    builder.Entity<ApplicationUserRole>().HasData(UserRoleSeed.GetUserRoles());
2. **Generate Seed Migration**
    ```bash
    dotnet ef migrations add SeedIdentityData;

3. **Generate Seed Migration**
   ```bash
   dotnet ef database update
