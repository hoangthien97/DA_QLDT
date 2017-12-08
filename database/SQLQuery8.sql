CREATE PROCEDURE SuaDienThoai
@MaDT char(10),
@MaDTNew char(50),
@MaLDTNew char(50),
@TenDTNew nvarchar(200),
@ManHinhNew nvarchar(50),
@CameraSauNew nvarchar(50),
@CamereTruocNew nvarchar(50),
@RAMNew nvarchar(50),
@ROMNew nvarchar(50),
@SystemNew nvarchar(100),
@KichThuocNew nvarchar(50),
@PinNew nvarchar(50),
@GiaThanhNew float,
@Status int out,
@Message nvarchar(50) out
AS
BEGIN
	begin transaction
		begin try
			set @Status=1
			set @Message='Đã Sửa'
			if exists(select 1 from DienThoai where @MaDTNew=MaDT )
				begin
					set @Status=0
					set @Message='Điện Thoại Da co '
				end	
				else
				begin
					Update DienThoai
					set MaDT=@MaDTNew,TenDT=@TenDTNew,ManHinh=@ManHinhNew,
						MaLDT=@MaLDTNew,CameraSau=@CameraSauNew,
						CameraTruoc=@CamereTruocNew,RAM=@RAMNew,ROM=@ROMNew, [System]=@SystemNew,
						KichThuoc=@KichThuocNew,Pin=@PinNew,GiaThanh=@GiaThanhNew
					where MaDT=@MaDT 		
				end	
		COMMIT
		end try
		begin catch
			set @Status=-1
			RAISERROR(@Message,16,1)
		end catch	
END
 
 execute SuaDienThoai()