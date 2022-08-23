CREATE TABLE [dbo].[Subject] (
    [SubCod]  INT           NOT NULL,
    [SubNam]  VARCHAR (50)  NULL,
    [CRoom]   VARCHAR (50)  NULL,
    [Day]     VARCHAR (9)   NULL,
    [CStart]  INT           NULL,
    [CEnd]    INT           NULL,
    [SNum]    NVARCHAR (50) NULL,
    [TName]   VARCHAR (50)  NULL,
    [TOffice] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED ([SubCod] ASC)
);

