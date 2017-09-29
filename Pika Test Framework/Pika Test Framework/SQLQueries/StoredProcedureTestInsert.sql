USE [PikaDB]
GO
/****** Object:  StoredProcedure [dbo].[InsertTest]    Script Date: 9/29/2017 12:28:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Brett Berens
-- Create date: 9/28/2017
-- Description:	
-- =============================================
ALTER PROCEDURE [dbo].[InsertTest] 
	-- Add the parameters for the stored procedure here
	@Name VARCHAR(1000), 
	@Type VARCHAR(50),
	@FileName VARCHAR(1000),
	--@Description VARBINARY(MAX),
	@DateCreated SMALLDATETIME,
	@DateModified SMALLDATETIME,
	@baseline INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- increment baseline.TestCounter for appropriate Baseline row
	-- and store the new value in @count
	DECLARE @count int;
	DECLARE @prefix VARCHAR(5);
	DECLARE @TestID VARCHAR(10);


	UPDATE dbo.Baselines
		SET @count = TestCounter += 1
	WHERE ID = @baseline;

	SET @prefix = (SELECT ShortName FROM Baselines 
		WHERE ID = @baseline);

	SET @TestID = @prefix + @count;

	INSERT INTO dbo.Tests
	  (TestID, Name, Type, FileName, DateCreated, DateModified, Baseline)
	VALUES
	  (@TestID, @Name, @Type, @FileName, @DateCreated, @DateModified, @baseline);
	

END
