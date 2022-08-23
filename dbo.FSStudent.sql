CREATE TABLE [dbo].[FSStudent] (
    [RegNum]     NVARCHAR (50) NOT NULL,
    [AmountDue]  NVARCHAR (10) NOT NULL,
    [AmountPaid] NVARCHAR (10) NOT NULL,
    [FeeStat]    VARCHAR (10)  NOT NULL,
    [OutStand]   NVARCHAR (10) NOT NULL,
    [PayForm]    VARCHAR (15)  NOT NULL,
    [Deadline]   DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([RegNum] ASC),
    CONSTRAINT [FK_FSStudent_Student] FOREIGN KEY ([RegNum]) REFERENCES [dbo].[Student] ([RegNum])
);

