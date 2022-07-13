CREATE TYPE [dbo].[udt_Item_New] AS TABLE (
    [itemName] NVARCHAR (50)   NULL,
    [itemDesc] NVARCHAR (250)  NULL,
    [itemType] NVARCHAR (50)   NULL,
    [uomID]    BIGINT          NULL,
    [cost]     NUMERIC (18, 5) NULL,
    [isRate]   TINYINT         NULL);

