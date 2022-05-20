CREATE TABLE [dbo].[tblForecasts] (
    [City_Name]     NVARCHAR(50) NOT NULL,
    [Date]          DATE          NOT NULL,
    [Min_Temp]      INT           NOT NULL,
    [Max_Temp]      INT           NOT NULL,
    [Precipitation] INT           NOT NULL,
    [Humidity]      INT           NOT NULL,
    [Wind_Speed]    INT           NOT NULL
);

