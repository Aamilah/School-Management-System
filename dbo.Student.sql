CREATE TABLE [dbo].[Student] (
    [RegNum]     NVARCHAR (50)  NOT NULL,
    [FName]      NVARCHAR (50)  NOT NULL,
    [LName]      NVARCHAR (50)  NOT NULL,
    [OName]      NVARCHAR (50)  NULL,
    [DOB]        DATE           NOT NULL,
    [Gender]     NVARCHAR (50)  NOT NULL,
    [Class]      NVARCHAR (50)  NOT NULL,
    [FeeStat]    NVARCHAR (50)  NOT NULL,
    [ParInfoNum] INT            NOT NULL,
    [Address]    NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([RegNum] ASC),
    CONSTRAINT [FK_Student_Gaurdian] FOREIGN KEY ([ParInfoNum]) REFERENCES [dbo].[Gaurdian] ([ParInfoNum])
);

