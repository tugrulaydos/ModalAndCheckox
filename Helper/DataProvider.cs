using ModalAndCheckox.Models;

namespace ModalAndCheckox.Helper
{
    public static class DataProvider
    {
        public static List<Employer> GetAllEmployer()
        {
            return new List<Employer>()
            {
                new Employer{Id=1,Name="JohnrLorem ipsum dolor sit amet, consectetur",SurName="Doe",Email="employer@gmail.com"},
                new Employer{Id=2,Name="EsosarLorem ipsum dolor sit amet, consectetur",SurName="imbruglie",Email="b@gmail.com"},
                new Employer{Id=3,Name="EspinozarLorem ipsum dolor sit amet, consectetur",SurName="Durhme",Email="c@gmail.com"},
                new Employer{Id=4,Name="MarvinrLorem ipsum dolor sit amet, consectetur",SurName="Wagner",Email="d@gmail.com"},
                new Employer{Id=5,Name="KristinarLorem ipsum dolor sit amet, consectetur",SurName="Arambasic",Email="e@gmail.com"},
                new Employer{Id=6,Name="YusufrLorem ipsum dolor sit amet, consectetur",SurName="Esmer",Email="f@gmail.com"},
                new Employer{Id=7,Name="DavisrLorem ipsum dolor sit amet, consectetur",SurName="Dathe",Email="g@gmail.com"},

            };


        }
    }
}
