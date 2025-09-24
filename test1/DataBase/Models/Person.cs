using System;
namespace test1.DataBase.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string First_Name { get; set; }

        public string Second_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime? Date_Employ { get; set; }
        public DateTime? Date_Uneploy { get; set; }

        public int Id_Status { get; set; }
        public int Id_Dep { get; set; }
        public int Id_Post { get; set; }

        public virtual Status StatusRef { get; set; }
        public virtual Dep DepRef { get; set; }
        public virtual Post PostRef { get; set; }
    }
}