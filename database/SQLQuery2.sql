USE [QLDT]
GO
/****** Object:  StoredProcedure [dbo].[HienThiDienThoai]    Script Date: 22-Oct-17 12:22:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[HienThiDienThoai]
AS
BEGIN
	Select * From [DienThoai]
END

select * 
from DienThoai
where GiaThanh between '6.000.000' and '11.000.000'