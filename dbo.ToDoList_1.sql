CREATE TABLE [dbo].[ToDoListTable] (
    [Id]          INT             NOT NULL,
    [Status]      CHAR (1)        NOT NULL,
    [Due Date]    TIME (7)        NOT NULL,
    [Type]        NVARCHAR (20)   NOT NULL,
    [Task]        NVARCHAR (500)  NOT NULL,
    [Course]      NVARCHAR (100)  NOT NULL,
    [Description] NVARCHAR (1000) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

