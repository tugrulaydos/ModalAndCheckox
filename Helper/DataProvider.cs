using ModalAndCheckox.Models;

namespace ModalAndCheckox.Helper
{
    public static class DataProvider
    {
        public static List<Student> GetAllStudents()
        {
            List<Student> Students = new List<Student>
            {
                new Student{Id=1,Name="John",Surname="Moltenbrace",Age=22,City="London",StudentNumber=1171},
                new Student{Id=2,Name="Nancy",Surname="Davalio",Age=20,City="Paris",StudentNumber=1053},
                new Student{Id=3,Name="Davis",Surname="Elfjumper",Age=21,City="Ankara",StudentNumber=1253},
                new Student{Id=4,Name="Frank",Surname="Goldbow",Age=18,City="Amsterdam",StudentNumber=53},
                new Student{Id=5,Name="Chelwaru",Surname="Fogspear",Age=23,City="Stockholm",StudentNumber=535},
            };

            return Students;
        }

        public static List<Teacher> GetAllTeahers() 
        {
            List<Teacher> Teachers = new List<Teacher>
            {
                new Teacher{Id=1,Name="Betcuth",Surname="Terravigor",Age=45,City="Ankara"},
                new Teacher{Id=2,Name="Draric", Surname="Grayblood",Age=35,City="Istanbul"}

            };

            return Teachers;

        }
    }
}
