namespace TraversalProje.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommand
    {
        public CreateDestinationCommand(int id)
        {
            İd = id;
        }

        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
        public int İd { get; }
    }
}
