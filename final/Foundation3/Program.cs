using System;

class Program
{
    static void Main(string[] args)
    {

        DateTime lectureStart = new DateTime(2025, 8, 22, 18, 30, 0);
        DateTime lectureEnd = new DateTime(2025, 8, 22, 20, 0, 0);

        DateTime receptionStart = new DateTime(2025, 7, 30, 19, 0, 0);
        DateTime receptionEnd = new DateTime(2025, 7, 30, 21, 30, 0);

        DateTime weatherStart = new DateTime(2025, 8, 3, 9, 0, 0);
        DateTime weatherEnd = new DateTime(2025, 8, 3, 11, 0, 0);

        Address lectureAddress = new Address("45 University Way", "Boston", "MA", "02138");

        Address receptionAddress = new Address("19 Laurel Drive", "San Mateo", "CA", "94401");

        Address weatherAddress = new Address("112 Meadow Loop Rd", "Asheville", "NC", "28804");



        List<Event> events = new List<Event>();

        events.Add(new Lecture(
           "Future Frontiers: AI and Ethics",
           "A thought-provoking lecture on the ethical implications of artifical intelligence, exploring how AI will shape the future of society, work, and privacy",
            lectureStart,
            lectureEnd,
            lectureAddress,
           "Dr. Maya Linden, Professor of AI Ethics at MIT",
           250
        ));

        events.Add(new Reception(
            "Summer Alumni Reception",
            "Join fellow alumni and faculty for a warm summer evening of refreshments, networking, and light entertainment.",
            receptionStart,
            receptionEnd,
            receptionAddress,
            "Yes (by July 24)"
        ));

        events.Add(new Outdoor(
            "Nature & Wellness Walk",
            "Enjoy a guided outdoor nature walk focused on mindfulness, relexation, and reconnecting with the natural world.",
            weatherStart,
            weatherEnd,
            weatherAddress,
            "Sunny 73°F(23°C), light breeze"
        ));

        Console.WriteLine("===Events===");
        foreach (var ev in events)
        {

            ev.GetFullDescription();
            Console.WriteLine();
        }

    }
}