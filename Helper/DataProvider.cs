using ModalAndCheckox.Models;

namespace ModalAndCheckox.Helper
{
    public static class DataProvider
    {
        public static List<Student> Students = new List<Student>
        {
                new Student{Id=1,Name="John",Surname="Moltenbrace",Age=22,City="London"},
                new Student{Id=2,Name="Nancy",Surname="Davalio",Age=20,City="Paris"},
                new Student{Id=3,Name="Davis",Surname="Elfjumper",Age=21,City="Ankara"},
                new Student{Id=4,Name="Frank",Surname="Goldbow",Age=18,City="Amsterdam"},
                new Student{Id=5,Name="Chelwaru",Surname="Fogspear",Age=23,City="Stockholm"},
        };


        public static List<Teacher> Teachers = new List<Teacher>
        {
                new Teacher{Id=1,Name="Betcuth",Surname="Terravigor",Age=45,City="Ankara"},
                new Teacher{Id=2,Name="Draric", Surname="Grayblood",Age=35,City="Istanbul"}

        };

        public static List<Student> GetAllStudents()
        {           

            return Students;
        }

        public static List<Teacher> GetAllTeahers() 
        {
            

            return Teachers;

        }

        public static void AddDataToTeacherList(Teacher t1)
        {
            Teachers.Add(t1);

        }

        public static void AddDataToStudentList(Student s1)
        {
            Students.Add(s1);
        }
    }
}
