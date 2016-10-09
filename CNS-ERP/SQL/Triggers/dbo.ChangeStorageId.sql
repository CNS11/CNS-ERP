CREATE TRIGGER [InsertStorageDescription]
	ON [dbo].[StoragesDbSet]
	After  INSERT
	AS
	BEGIN
	SET NOCOUNT ON;

update [dbo].[StoragesDbSet] set  StoragesDbSet.Name=i.City
+'/'+i.Street+'/'+i.Street_address from  [StoragesDbSet]
inner join  inserted i on i.StorageId=StoragesDbSet.StorageId;



		
	END