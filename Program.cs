namespace PracticingLamdaExpression
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);
            Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(listPersonInCity);
            Retrieving_AverageAge(listPersonInCity);
            Retrieving_Record_ForAgeIs_Geaterthaneighteenandlessthanthirteen(listPersonInCity);
            RemoveSpecific_Name(listPersonInCity);
            Retrieving_CheckNameIsPresent(listPersonInCity);
            DisplayingGreaterThanSixty(listPersonInCity);

        }
        private static void AddRecords(List<Person>listPersonInCity)
        {
            listPersonInCity.Add(new Person("232433", "charu", "12 main street", 15));
            listPersonInCity.Add(new Person("232434", "chocky", "12 main street", 25));
            listPersonInCity.Add(new Person("232435", "haswika", "12 main street", 35));
            listPersonInCity.Add(new Person("232436", "haswik", "12 main street", 45));
            listPersonInCity.Add(new Person("232437", "john", "12 main street", 55));
            listPersonInCity.Add(new Person("232438", "rita", "12 main street", 65));
            listPersonInCity.Add(new Person("232439", "yasaswi", "12 main street", 75));
            listPersonInCity.Add(new Person("232440", "sew", "12 main street", 85));
        }
        private static void Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(List<Person> listPersonInCity)
        {
            foreach(Person person in listPersonInCity.FindAll(e=>(e.Age<60)).Take(2))
                {
                Console.WriteLine("Name:" + person.Name + "Age:" + person.Age);
            }

        }
        private static void Retrieving_Record_ForAgeIs_Geaterthaneighteenandlessthanthirteen(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 18 && e.Age>13)))
            {
                Console.WriteLine("Name:" + person.Name + "Age:" + person.Age);
            }

        }
        private static void Retrieving_AverageAge(List<Person> listPersonInCity)
        {
            double avgAge = listPersonInCity.Average(x => x.Age);
            {
                Console.WriteLine(avgAge);
            }

        }
        private static void RemoveSpecific_Name(List<Person> listPersonInCity)
        {
            int check = listPersonInCity.RemoveAll(e=>e.Name=="john");
            foreach (Person person in listPersonInCity)
            {
                Console.WriteLine("Name:" + person.Name + "Age:" + person.Age);
            }

        }
        private static void Retrieving_CheckNameIsPresent(List<Person> listPersonInCity)
        {
            bool check = listPersonInCity.Any(x=>x.Name == "charu");
            if(check)
            {
                Console.WriteLine("name is present");
            }
            else
            {
                Console.WriteLine("name is absent");
            }

        }
        private static void DisplayingGreaterThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age > 60)))
            {
                Console.WriteLine("Name:" + person.Name + "Age:" + person.Age);
            }

        }

    }
}