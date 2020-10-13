USE master;
DROP DATABASE IF EXISTS CSC470Fish;
GO
CREATE DATABASE CSC470Fish;
GO
USE [CSC470Fish]
GO
/****** Object:  Table [dbo].[Fish]    Script Date: 9/20/2018 10:03:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fish](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[WaterType] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Fish] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Fish] ON 

INSERT [dbo].[Fish] ([Id], [Name], [WaterType]) VALUES (1, N'Walleye', N'Fresh')
INSERT [dbo].[Fish] ([Id], [Name], [WaterType]) VALUES (2, N'Perch', N'Fresh')
INSERT [dbo].[Fish] ([Id], [Name], [WaterType]) VALUES (3, N'Northern Pike', N'Fresh')
INSERT [dbo].[Fish] ([Id], [Name], [WaterType]) VALUES (4, N'King Salmon', N'Salt')
INSERT [dbo].[Fish] ([Id], [Name], [WaterType]) VALUES (5, N'Halibut', N'Salt')
INSERT [dbo].[Fish] ([Id], [Name], [WaterType]) VALUES (6, N'Lingcod', N'Salt')
INSERT [dbo].[Fish] ([Id], [Name], [WaterType]) VALUES (7, N'Yellowfin Tuna', N'Salt Water')
SET IDENTITY_INSERT [dbo].[Fish] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Fish]    Script Date: 9/20/2018 10:03:49 AM ******/
ALTER TABLE [dbo].[Fish] ADD  CONSTRAINT [IX_Fish] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[FishAdd]    Script Date: 9/20/2018 10:03:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FishAdd] 
	@Name VARCHAR(50)
	,@WaterType VARCHAR(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	BEGIN TRY
      INSERT INTO Fish (Name, WaterType)
	  VALUES (@Name, @WaterType);
	  RETURN 0; -- Everything is good
	END TRY
	BEGIN CATCH
	  RETURN ERROR_NUMBER();
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[FishAdd]    Script Date: 9/20/2018 10:03:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FishModify]
    @Id INT 
	,@Name VARCHAR(50)
	,@WaterType VARCHAR(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	BEGIN TRY
	  UPDATE Fish
	  SET Name = @Name
	  ,WaterType = @WaterType
	  WHERE Id = @Id;
	  RETURN 0; -- Everything is good
	END TRY
	BEGIN CATCH
	  RETURN ERROR_NUMBER();
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllFish]    Script Date: 9/20/2018 10:03:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Dave Bishop
-- Create date: 9/20/2018
-- Description:	Return all the fish ordered by fish name
-- =============================================
CREATE PROCEDURE [dbo].[GetAllFish]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Id, Name, WaterType
	FROM Fish
	ORDER BY Name;
END

GO
