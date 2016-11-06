namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dd901cc7-6156-48f4-985e-6c65a4aaaa51', N'admin@library.com', 0, N'AKMkLhyU50k7shaYrQomr/jtM4Sr3yM6TxGcdI+/Fv+A4mr4dVFKfcONnDeKeIRwQA==', N'c7c5c145-df38-49f6-8283-57cf686276e7', NULL, 0, 0, NULL, 1, 0, N'admin@library.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fdcf9a60-22e5-42ad-a39e-1cc361cec77f', N'guest@library.com', 0, N'ALYxRzNdRqdkdwY+UplOLaWV4cOCRN7EGcc7PjO2GFOxNXklYe52LcdOeJzlt/HOSw==', N'592845d7-41a6-4261-a7b1-af634bdb033d', NULL, 0, 0, NULL, 1, 0, N'guest@library.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4680986a-a4f2-41df-b302-debfa520b903', N'CanManageMovies')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dd901cc7-6156-48f4-985e-6c65a4aaaa51', N'4680986a-a4f2-41df-b302-debfa520b903')


            ");
        }
        
        public override void Down()
        {
        }
    }
}
