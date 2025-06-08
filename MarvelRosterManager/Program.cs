using System;

class Program
{
    static void Main(string[] args)
    {
        TeamRoster roster = new TeamRoster();

        // Avengers
        roster.AddHero(new Avenger("Tony Stark", "Iron Man", "Tech Genius", "Iron Suit"));
        roster.AddHero(new Avenger("Steve Rogers", "Captain America", "Super Soldier", "Vibranium Shield"));
        roster.AddHero(new Avenger("Thor Odinson", "Thor", "God of Thunder", "Mjolnir"));
        roster.AddHero(new Avenger("Bruce", "Hulk", "Gamma Strength", "Rage"));
        roster.AddHero(new Avenger("Natasha Romanoff", "Black Widow", "Espionage", "Electro Batons"));
        roster.AddHero(new Avenger("Clint Barton", "Hawkeye", "Master Archer", "Bow & Arrows"));
        roster.AddHero(new Avenger("Wanda Maximoff", "Scarlet Witch", "Chaos Power", "Hex Bolts"));
        roster.AddHero(new Avenger("Sam Wilson", "Falcon", "Flight", "Wings & Drones"));
        roster.AddHero(new Avenger("James Rhodes", "War Machine", "Heavy Firepower", "War Armor"));
        roster.AddHero(new Avenger("Peter Park", "Spider-Man", "Spider-Sense", "Web Shooters"));
        roster.AddHero(new Avenger("Scott lang", "Ant-Man", "Size-Shifting", "Pym Suit"));
        roster.AddHero(new Avenger("Hope Van Dyne", "Wasp", "Flight & Stings", "Wasp Suit"));
        roster.AddHero(new Avenger("Stephen Strange", "Doctor Strange", "Mystic Arts", "Eye of Agamotto"));
        roster.AddHero(new Avenger("T'Challa", "Black Panther", "Enhanced Senses", "Vibranium Suit"));
        roster.AddHero(new Avenger("Carol Denvers", "Captain Marvel", "Cosmic Energy", "Photon Blasts"));

        // X-Men
        roster.AddHero(new XMan("Logan", "Wolverine", "Enhanced Senses", "Regeneration"));
        roster.AddHero(new XMan("Charles Xavier", "Professor X", "Telepathy", "Mind Control"));
        roster.AddHero(new XMan("Erik Lehnsherr", "Magneto", "Magnetism", "Metal Manipulation"));
        roster.AddHero(new XMan("Ororo Munroe", "Storm", "Weather Control", "Lightning Summoning"));
        roster.AddHero(new XMan("Scott Summers", "Cyclops", "Laser Vision", "Optic Blasts"));
        roster.AddHero(new XMan("Jean Grey", "Jean Grey", "Telekinetic Power", "Phoenix Force"));
        roster.AddHero(new XMan("Hank McCoy", "Beast", "Super Agility", "Mutated Strength"));
        roster.AddHero(new XMan("Bobby Drake", "Iceman", "Cryokinesis", "Ice Form"));
        roster.AddHero(new XMan("Raven Darkholme", "Mystique", "Shapeshifting", "Identity Stealing"));
        roster.AddHero(new XMan("Piotr Rasputin", "Colossus", "Metal Skin", "Super Strength"));
        roster.AddHero(new XMan("Wade Wilson", "Deadpool", "Immortality", "Regenerative Mutation"));

        roster.AddHero(new Guardian("Peter Quill", "Star-Lord", "Tactical Leadership", "Quad Blasters"));
        roster.AddHero(new Guardian("Gamora", "Gamora", "Martial Combat", "Daughter of Thanos"));
        roster.AddHero(new Guardian("Drax", "Drax the Destroyer", "Brute Strength", "Skin of Steel"));
        roster.AddHero(new Guardian("Rocket", "Rocket Raccoon", "Eingineering & Weapons", "Cybernetic Raccoon"));
        roster.AddHero(new Guardian("Groot", "Groot", "Regeneration", "Flora Colossus"));
        roster.AddHero(new Guardian("Mantis", "Mantis", "Empathy", "Antenna Sense"));


        roster.DisplayAll();
    }
}