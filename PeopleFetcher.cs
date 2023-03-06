using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CatWorx.BadgeMaker
{
    class PeopleFetcher
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                string firstName = Console.ReadLine() ?? "";
                if (firstName == "")
                {
                    break;
                }
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine() ?? "";
                Console.Write("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine() ?? "");
                Console.Write("Enter Photo URL:");
                string photoUrl = Console.ReadLine() ?? "";

                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }
            return employees;
        }

        async public static Task<List<Employee>> GetFromApi()
        {
            List<Employee> employees = new List<Employee>();
            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync(
                    "https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture"
                );
                var data = JsonConvert.DeserializeObject<Person>(response);

                for (int i = 0; i < data?.Results?.Count; i++)
                {
                    var firstName = data?.Results?[i].Name?.First ?? "";
                    var lastName = data?.Results?[i].Name?.Last ?? "";
                    var id = Int32.Parse(
                        data?.Results?[i].Id?.Value?.ToString().Replace("-", "") ?? ""
                    );
                    var picture = data?.Results?[i].Picture?.Large ?? "";
                    Employee emp = new Employee(firstName, lastName, id, picture);
                    employees.Add(emp);
                }
            }

            return employees;
        }
    }
}
