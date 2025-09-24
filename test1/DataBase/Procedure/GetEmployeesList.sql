USE test1;
GO

IF OBJECT_ID('dbo.GetEmployeesList','P') IS NOT NULL
    DROP PROCEDURE dbo.GetEmployeesList;
GO

CREATE PROCEDURE dbo.GetEmployeesList
  @StatusId     INT           = NULL,
  @DepId        INT           = NULL,
  @PostId       INT           = NULL,
  @LastNamePart VARCHAR(100)  = NULL,
  @SortColumn   VARCHAR(50)   = NULL,
  @SortDir      VARCHAR(4)    = NULL
AS
BEGIN
  SET NOCOUNT ON;
  SELECT
    p.last_name + ' ' + LEFT(p.first_name,1) + '. ' + LEFT(p.second_name,1) + '.'
      AS FullName,
    s.name    AS StatusName,
    d.name    AS DepName,
    po.name   AS PostName,
    p.date_employ  AS DateEmploy,
    p.date_uneploy AS DateUneploy
  FROM dbo.persons p
  JOIN dbo.status s  ON p.status  = s.id
  JOIN dbo.deps   d  ON p.id_dep  = d.id
  JOIN dbo.posts  po ON p.id_post = po.id
  WHERE (@StatusId     IS NULL OR p.status     = @StatusId)
    AND (@DepId        IS NULL OR p.id_dep      = @DepId)
    AND (@PostId       IS NULL OR p.id_post     = @PostId)
    AND (@LastNamePart IS NULL OR p.last_name LIKE '%' + @LastNamePart + '%')
  ORDER BY
    CASE WHEN @SortColumn = 'FullName'    AND @SortDir = 'ASC'  THEN p.last_name END ASC,
    CASE WHEN @SortColumn = 'FullName'    AND @SortDir = 'DESC' THEN p.last_name END DESC,
    CASE WHEN @SortColumn = 'StatusName'  AND @SortDir = 'ASC'  THEN s.name      END ASC,
    CASE WHEN @SortColumn = 'StatusName'  AND @SortDir = 'DESC' THEN s.name      END DESC,
    CASE WHEN @SortColumn = 'DepName'     AND @SortDir = 'ASC'  THEN d.name      END ASC,
    CASE WHEN @SortColumn = 'DepName'     AND @SortDir = 'DESC' THEN d.name      END DESC,
    CASE WHEN @SortColumn = 'PostName'    AND @SortDir = 'ASC'  THEN po.name     END ASC,
    CASE WHEN @SortColumn = 'PostName'    AND @SortDir = 'DESC' THEN po.name     END DESC,
    CASE WHEN @SortColumn = 'DateEmploy'  AND @SortDir = 'ASC'  THEN p.date_employ  END ASC,
    CASE WHEN @SortColumn = 'DateEmploy'  AND @SortDir = 'DESC' THEN p.date_employ  END DESC,
    CASE WHEN @SortColumn = 'DateUneploy' AND @SortDir = 'ASC'  THEN p.date_uneploy END ASC,
    CASE WHEN @SortColumn = 'DateUneploy' AND @SortDir = 'DESC' THEN p.date_uneploy END DESC;
END;
GO
