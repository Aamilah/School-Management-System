CREATE TABLE [dbo].[Exam] (
    [RegNum]     NVARCHAR (50) NOT NULL,
    [StuName]    VARCHAR (50)  NULL,
    [SubName]    VARCHAR (50)  NULL,
    [SubCod]     VARCHAR (50)  NULL,
    [Extype]     VARCHAR (50)  NULL,
    [Session]    INT           NULL,
    [Mark]       INT           NULL,
    [Total]      INT           NULL,
    [Percentage] INT           NULL,
    [Grade]      VARCHAR (2)   NULL,
    [Remark]     VARCHAR (50)  NULL,
    CONSTRAINT [FK_Exam_Student] FOREIGN KEY ([RegNum]) REFERENCES [dbo].[Student] ([RegNum])
);

