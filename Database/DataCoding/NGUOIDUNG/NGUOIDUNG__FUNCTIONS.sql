USE OCEAN_HOSTEL
GO

CREATE	PROC	PROC__NGUOIDUNG__INSERT
@TENDN		VARCHAR(30),
@MATKHAU	VARCHAR(100),
@HO			NVARCHAR(10),
@TEN		NVARCHAR(30)
AS
BEGIN
	INSERT INTO NGUOIDUNG(TENDN, MATKHAU, HO, TEN)
	VALUES (@TENDN, @MATKHAU, @HO, @TEN)
END 
GO

/*
CREATE	FUNCTION	FUNC__KHU__GETLASTID()
RETURNS	VARCHAR(10)
AS
BEGIN
	DECLARE @ID INT
	
	SELECT @ID = CONVERT(INT, RIGHT(MAX(MAKHU), 7))
				FROM KHU
	
	
	DECLARE @DISTANCE INT
	DECLARE @RESULT VARCHAR(10)
	SET @DISTANCE = 7 - LEN(@ID)
	SET @RESULT = 'KHU'
	
	
	WHILE @DISTANCE <> 0
	BEGIN
		@RESULT = @RESULT + '0'
		@DISTANCE = @DISTANCE / 10
	END
	
	
	RETURN (@RESULT + CAST(@ID AS VARCHAR))
END
GO*/


CREATE	PROC	PROC__KHU__INSERT
@MAKHU		VARCHAR(10),
@TENKHU		NVARCHAR(15)
AS
BEGIN
	INSERT INTO KHU(MAKHU, TENKHU)
	VALUES (@MAKHU, @TENKHU)
END
GO