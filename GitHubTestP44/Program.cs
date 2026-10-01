namespace GitHubTestP44
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Group group = new(){ Name = "P44" };
            group.AddPerson(new Person() { Name = "Vasya", Age = 17 });
            group.PrintInfo();
        }
    }
}
