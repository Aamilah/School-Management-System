CREATE TABLE [dbo].[TeacherLogin] (
    [SNum]     NVARCHAR (50) NOT NULL,
    [password] NVARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([SNum] ASC),
    CONSTRAINT [FK_TeacherLogin_Teacher] FOREIGN KEY ([SNum]) REFERENCES [dbo].[Teacher] ([SNum])
);

