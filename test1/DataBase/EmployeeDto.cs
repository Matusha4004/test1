using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using test1.DataBase.Models;

namespace test1.DataBase
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string StatusName { get; set; }
        public string DepName { get; set; }
        public string PostName { get; set; }
        public DateTime? DateEmploy { get; set; }
        public DateTime? DateUneploy { get; set; }
    }

    public class StatDto
    {
        public DateTime Date { get; set; }
        public int Count { get; set; }
    }

    public class EmployeeRepository : IDisposable
    {
        private readonly AppDbContext _db;
        public EmployeeRepository(AppDbContext db) { _db = db; }

        public List<EmployeeDto> GetEmployees(
            int? statusId,
            int? depId,
            int? postId,
            string lastName,
            string sortColumn,
            string sortDir)
        {
            return _db.Database.SqlQuery<EmployeeDto>(
                "EXEC dbo.GetEmployeesList @StatusId,@DepId,@PostId,@LastNamePart,@SortColumn,@SortDir",
                new SqlParameter("@StatusId", statusId ?? (object)DBNull.Value),
                new SqlParameter("@DepId", depId ?? (object)DBNull.Value),
                new SqlParameter("@PostId", postId ?? (object)DBNull.Value),
                new SqlParameter("@LastNamePart", lastName ?? (object)DBNull.Value),
                new SqlParameter("@SortColumn", sortColumn ?? (object)DBNull.Value),
                new SqlParameter("@SortDir", sortDir ?? (object)DBNull.Value)
            ).ToList();
        }

        public List<StatDto> GetStats(int statusId, DateTime startDate, DateTime endDate, bool employed)
        {
            var mode = employed ? "Employed" : "Unemployed";
            return _db.Database.SqlQuery<StatDto>(
                "EXEC dbo.GetEmployeeStats @StatusId,@StartDate,@EndDate,@Mode",
                new SqlParameter("@StatusId", statusId),
                new SqlParameter("@StartDate", startDate.Date),
                new SqlParameter("@EndDate", endDate.Date),
                new SqlParameter("@Mode", mode)
            ).ToList();
        }

        public List<Status> GetStatuses() => _db.Statuses.OrderBy(s => s.Name).ToList();
        public List<Dep> GetDeps() => _db.Deps.OrderBy(d => d.Name).ToList();
        public List<Post> GetPosts() => _db.Posts.OrderBy(p => p.Name).ToList();

        public void Dispose() => _db.Dispose();
    }
}
