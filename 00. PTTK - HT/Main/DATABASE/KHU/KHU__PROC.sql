USE OCEAN_HOSTEL
GO



---------------------------------
CREATE	PROC	PROC__KHU__INSERT
@TENKHU		NVARCHAR(15)
AS
BEGIN
	DECLARE @NEXTID VARCHAR(10)
	SELECT @NEXTID = dbo.FUNC__KHU__GetNextID()	--	Tự động lấy mã tiếp theo
	
	INSERT INTO KHU(MAKHU, TENKHU)
	VALUES (@NEXTID, @TENKHU)
END
GO


---------------------------------
CREATE	PROC	PROC__KHU__DETELE
@MAKHU		VARCHAR(10)
AS
BEGIN
	DELETE FROM KHU
	WHERE MAKHU = @MAKHU
END
GO

---------------------------------
CREATE	PROC	PROC__KHU__UPDATE
@MAKHU		VARCHAR(10),
@TENKHU		VARCHAR(15)
AS
BEGIN
	UPDATE	KHU
	SET TENKHU = @TENKHU
	WHERE MAKHU = @MAKHU
END
GO