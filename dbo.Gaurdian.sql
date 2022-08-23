CREATE TABLE [dbo].[Gaurdian] (
    [ParInfoNum] INT           NOT NULL,
    [RegNum]     NVARCHAR (50) NOT NULL,
    [PName]      VARCHAR (50)  NOT NULL,
    [PID]        NVARCHAR (50) NOT NULL,
    [PAddress]   VARCHAR (MAX) NOT NULL,
    [PEmail]     VARCHAR (50)  NOT NULL,
    [PPNum]      NVARCHAR (14) NOT NULL,
    [PRShip]     VARCHAR (20)  NOT NULL,
    [SName]      VARCHAR (50)  DEFAULT (NULL) NULL,
    [SID]        NVARCHAR (50) DEFAULT (NULL) NULL,
    [SAddress]   VARCHAR (MAX) DEFAULT (NULL) NULL,
    [SEmail]     VARCHAR (50)  DEFAULT (NULL) NULL,
    [SPNum]      NVARCHAR (14) DEFAULT (NULL) NULL,
    [SRShip]     VARCHAR (20)  DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([ParInfoNum] ASC),
    CONSTRAINT [FK_Gaurdian_Student] FOREIGN KEY ([RegNum]) REFERENCES [dbo].[Student] ([RegNum])
);

