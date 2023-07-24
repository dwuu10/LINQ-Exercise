namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() { "Roblox", "Minecraft", "Hearts of Iron 4", "Team Fortress 2" };
            var descending = games.OrderByDescending(x => x.Length).ToList();
            Console.WriteLine(descending[0]);
        }
    }
}
