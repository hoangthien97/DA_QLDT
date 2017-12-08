Create PROCEDURE XoaDienThoai
@MaDT char(50),
@Status int out,
@Message nvarchar(50) out,
@MaLDT char(5)
AS
BEGIN
	begin transaction
		begin try
			set @Status=1
			set @Message='Đã Xóa'
			if exists (Select 1 From DienThoai Where @MaDT=MaDT 
						and @MaLDT=MaLDT)
				begin
					delete from DienThoai where @MaDT=MaDT 
								and @MaLDT=MaLDT
				end
			else
				begin
					set @Status=0
					set @Message='Không Có Điện Thoại Này'
				end
		COMMIT
		end try
		begin catch
			set @Status=-1
			RAISERROR(@Message,16,1)
			ROLLBACK
		end catch
	
END

