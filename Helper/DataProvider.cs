using ModalAndCheckox.Models;

namespace ModalAndCheckox.Helper
{
    public static class DataProvider
    {
        public static List<Employer> GetAllEmployer()
        {
            return new List<Employer>()
            {
                new Employer{Id=1,Name="John",SurName="Doe",Email="employer@gmail.com"},
                new Employer{Id=2,Name="Esosa",SurName="imbruglie",Email="b@gmail.com"},
                new Employer{Id=3,Name="Espinoza",SurName="Durhme",Email="c@gmail.com"},
                new Employer{Id=4,Name="Marvin",SurName="Wagner",Email="d@gmail.com"},
                new Employer{Id=5,Name="Kristina",SurName="Arambasic",Email="e@gmail.com"},
                new Employer{Id=6,Name="Yusuf",SurName="Esmer",Email="f@gmail.com"},
                new Employer{Id=7,Name="Davis",SurName="Dathe",Email="g@gmail.com"},

            };


        }
    }
}
