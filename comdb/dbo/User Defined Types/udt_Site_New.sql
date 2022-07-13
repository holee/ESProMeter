CREATE TYPE [dbo].[udt_Site_New] AS TABLE (
    [siteName] NVARCHAR (50)  NOT NULL,
    [siteDesc] NVARCHAR (250) NULL,
    [addrID]   BIGINT         NULL,
    [custID]   BIGINT         NULL);

