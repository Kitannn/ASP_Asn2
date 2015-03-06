# ASP_Asn2
GoodSamaritan Seeding:
update-database -ConfigurationTypeName Asn_23.Migrations.GoodSamaritan.Configuration

User Seeding:
update-database -ConfigurationTypeName Asn_23.Migrations.Users.Configuration

Delete Database and reseed:
sqllocaldb.exe stop v11.0
sqllocaldb.exe delete v11.0
