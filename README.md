# Project 003_EF

This project demonstrates the use of Entity Framework (EF) for working with a database.

## Project Structure

### Planshet

Class representing a tablet.

- **Properties:**
  - *Id*: unique identifier.
  - *Name*: tablet name.
  - *Price*: tablet price.

### Phone

Class representing a phone.

- **Properties:**
  - *ID*: unique identifier.
  - *Name*: phone name.
  - *Price*: phone price.
  - *Manufacter*: navigation property representing the phone manufacturer.

  - **Attributes:**
    - *[NotMapped]*: indicates that the property should not be mapped to the database.

### Company

Class representing a company.

- **Properties:**
  - *Id*: unique company identifier.
  - *Name*: company name.

### AppContext

Database context class for working with EF.

- **Contains:**
  - `DbSet` for working with phones.

- **Database connection parameters:**
  - *DataSource*: server name.
  - *InitialCatalog*: database name.
  - *IntegratedSecurity*: use integrated authentication.
  - *TrustServerCertificate*: trust the server certificate.

- **Using `modelBuilder` for model configuration:**
  ```csharp
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
      modelBuilder.Entity<Planshet>();
      modelBuilder.Ignore<Company>();
  }

## Creating the First Migration and Updating the Database

To create a migration for the initial version (v1) of the database schema, use the following command in the Package Manager Console:

```powershell
Add-Migration v1
Update-Database
