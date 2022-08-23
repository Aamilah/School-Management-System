CREATE TABLE [dbo].[FSTeacher] (
    [SNum]    NVARCHAR (50) NOT NULL,
    [SAmount] NVARCHAR (10) NOT NULL,
    [SStatus] VARCHAR (7)   NOT NULL,
    [PForm]   VARCHAR (15)  NOT NULL,
    [PaidBy]  DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([SNum] ASC),
    CONSTRAINT [FK_FSTeacher_Teacher] FOREIGN KEY ([SNum]) REFERENCES [dbo].[Teacher] ([SNum])
);

