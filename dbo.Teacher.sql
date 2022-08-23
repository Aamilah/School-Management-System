CREATE TABLE [dbo].[Teacher] (
    [SNum]       NVARCHAR (50) NOT NULL,
    [FName]      VARCHAR (50)  NOT NULL,
    [LName]      VARCHAR (50)  NOT NULL,
    [OName]      VARCHAR (50)  NULL,
    [Gender]     VARCHAR (6)   NOT NULL,
    [MStatus]    VARCHAR (50)  NOT NULL,
    [Address]    VARCHAR (MAX) NOT NULL,
    [SubCod]     INT           NOT NULL,
    [SalaryStat] VARCHAR (6)   NOT NULL,
    [Amount]     INT           NOT NULL,
    [TOffice]    NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([SNum] ASC)
);

