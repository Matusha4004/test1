USE test1;
GO

IF OBJECT_ID('dbo.GetEmployeeStats','P') IS NOT NULL
    DROP PROCEDURE dbo.GetEmployeeStats;
GO

CREATE PROCEDURE dbo.GetEmployeeStats
    @StatusId INT,
    @StartDate DATE,
    @EndDate   DATE,
    @Mode      VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    IF @Mode = 'Employed'
    BEGIN
        SELECT CAST(p.date_employ AS DATE) AS [Date], COUNT(*) AS [Count]
        FROM dbo.persons p
        WHERE p.status = @StatusId
          AND p.date_employ BETWEEN @StartDate AND @EndDate
          AND p.date_employ IS NOT NULL
        GROUP BY CAST(p.date_employ AS DATE)
        ORDER BY [Date];
    END
    ELSE
    BEGIN
        SELECT CAST(p.date_uneploy AS DATE) AS [Date], COUNT(*) AS [Count]
        FROM dbo.persons p
        WHERE p.status = @StatusId
          AND p.date_uneploy BETWEEN @StartDate AND @EndDate
          AND p.date_uneploy IS NOT NULL
        GROUP BY CAST(p.date_uneploy AS DATE)
        ORDER BY [Date];
    END
END;
GO
