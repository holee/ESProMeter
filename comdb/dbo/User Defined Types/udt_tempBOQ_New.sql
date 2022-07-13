CREATE TYPE [dbo].[udt_tempBOQ_New] AS TABLE (
    [id]            BIGINT         NULL,
    [ref]           NVARCHAR (50)  NULL,
    [title]         NVARCHAR (50)  NULL,
    [desc]          NVARCHAR (500) NULL,
    [custid]        BIGINT         NULL,
    [boqDate]       DATE           NULL,
    [boqValideDate] DATE           NULL,
    [siteID]        BIGINT         NULL,
    [divID]         BIGINT         NULL,
    [termCond]      NVARCHAR (MAX) NULL,
    [uid]           BIGINT         NULL);

