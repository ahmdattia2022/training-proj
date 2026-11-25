public class Driver
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int RacingNumber { get; set; }
    public string Team { get; set; } = string.Empty;
}

// Sample data (use in DbContext or seeding)
public static class DriverData
{
    public static List<Driver> GetSampleDrivers() =>
    [
        new Driver { Id = 1, Name = "Max Verstappen", RacingNumber = 1, Team = "Red Bull Racing" },
        new Driver { Id = 2, Name = "Lewis Hamilton", RacingNumber = 44, Team = "Ferrari" },
        new Driver { Id = 3, Name = "Charles Leclerc", RacingNumber = 16, Team = "Ferrari" },
        new Driver { Id = 4, Name = "Lando Norris", RacingNumber = 4, Team = "McLaren" },
        new Driver { Id = 5, Name = "Oscar Piastri", RacingNumber = 81, Team = "McLaren" },
        new Driver { Id = 6, Name = "Carlos Sainz", RacingNumber = 55, Team = "Williams" },
        new Driver { Id = 7, Name = "George Russell", RacingNumber = 63, Team = "Mercedes" },
        new Driver { Id = 8, Name = "Sergio Perez", RacingNumber = 11, Team = "Red Bull Racing" },
        new Driver { Id = 9, Name = "Fernando Alonso", RacingNumber = 14, Team = "Aston Martin" },
        new Driver { Id = 10, Name = "Lance Stroll", RacingNumber = 18, Team = "Aston Martin" }
    ];
}
