CREATE TABLE [dbo].[Vehicle] (
    [ID]     INT             IDENTITY (1, 1) NOT NULL,
    [Make]   NVARCHAR (MAX)  NOT NULL,
    [Model]  NVARCHAR (MAX)  NOT NULL,
    [Body]   NVARCHAR (MAX)  NOT NULL,
    [Engine] NVARCHAR (MAX)  NOT NULL,
    [Gear]   NVARCHAR (MAX)  NOT NULL,
    [Stock]  INT             NOT NULL,
    [Price]  DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED ([ID] ASC)
);

