using System;
using System.Linq;

namespace SafariAdventure
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      var db = new safariormsContext();
      var myFavoriteAnimal = new SeenAnimals
      {
        Species = "bear",
        CountOfTimesSeen = 5,
        LocationOfLastSeen = "On Jungle"

      };
      // my insert
      //   db.SeenAnimals.Add(myFavoriteAnimal);
      //   db.SaveChanges();

      //   Display all animals the user has seen
      //   var myAnimal = db.SeenAnimals;
      //   foreach (var item in myAnimal)
      //   {
      //     Console.WriteLine("I saw " + item.Species);
      //   }

      //  Update the CountOfTimesSeen and LocationOfLastSeen for an animal
      //   var updateMyAnimal = db.SeenAnimals.Where(animal => animal.Id == 2);
      //   foreach (var item in updateMyAnimal)
      //   {
      //     item.CountOfTimesSeen = 4;
      //     item.LocationOfLastSeen = "on the ground";
      //     item.Species = "Rino";
      //   }
      //   db.SaveChanges();

      //   Display all animals seen in the Jungle
      //   var myAnimalOnGround = db.SeenAnimals.Where(animal => animal.LocationOfLastSeen.Contains("On ground"));

      //   foreach (var item in myAnimalOnGround)
      //   {
      //     Console.WriteLine(item.LocationOfLastSeen + " I saw " + item.Species);
      //   }
      //  Remove all animals that I have seen in the Desert
      //   var myAnimalOnDesert = db.SeenAnimals.Where(animal => animal.LocationOfLastSeen.Contains("Desert"));
      //   db.SeenAnimals.RemoveRange(myAnimalOnDesert);
      //   db.SaveChanges();

      // Add all the CountOfTimesSeen and get a total number of animals seen
      //   var mySumAnimal = db.SeenAnimals.Sum(animal => animal.CountOfTimesSeen);
      //   Console.WriteLine("I saw " + mySumAnimal + " animals");

      //   Get the CountOfTimesSeen of lions, tigers and bears
      var mytlbAnimals = db.SeenAnimals.Where(animal => animal.Species == "tiger" || animal.Species == "lion" || animal.Species == "bear");
      var totalSeenTlb = mytlbAnimals.Sum(item => item.CountOfTimesSeen);
      Console.WriteLine("My total of Tigers, Lions ans Bears " + totalSeenTlb);
    }
  }
}
