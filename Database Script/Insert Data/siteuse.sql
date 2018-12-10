USE [Courier Management System]
GO

INSERT INTO [dbo].[siteuser]
           ([username]
           ,[emailid]
           ,[password]
           ,[address]
           ,[usertype])
     VALUES
           ('User', 'user@gmail.com', 123, 'Malibagh')
NSERT INTO [dbo].[siteuser]
           ([username]
           ,[emailid]
           ,[password]
           ,[address]
           ,[usertype])
     VALUES
           ('Admin', 'admin@gmail.com', 123, 'Malibagh') 
         
GO

//For user usertype = 1 and for admin usertype = 2 is set by default.  