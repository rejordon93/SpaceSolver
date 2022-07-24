public class Room
{
  public int Size { get; set; }
}


public class Furniture

{
    public int Size { get; set; }
    public string Name { get; set; }
}

public class Name : Furniture
{   
}
public class Chair : Furniture 
{
}

public class TV : Furniture
{
}

public class BounceHouse : Furniture    
{
}

namespace Solver
{
    class SpaceSolver
    {


        public static string DoseFurnitureFit(List<Room> rooms, List<Furniture> furnitures)
        {
            int roomSizes = 0;

            foreach (Room room in rooms)
            {
                roomSizes = roomSizes + room.Size;
            }

            List<Furniture> furnituresItems = new List<Furniture>();


            int furnitureSizes = 0;
            foreach (Furniture furniture in furnitures)
            {
                furnitureSizes = furnitureSizes + furniture.Size;



                if (roomSizes >= furnitureSizes)
                {
                    roomSizes = roomSizes - furnitureSizes;

                    furnituresItems.Add(furniture);
                }

                else
                {

                    Console.WriteLine("the items did not fit");
                    List<Furniture> NotfittedItems = furnitures.Except(furnituresItems).ToList();
                    foreach (Furniture notfittedItems in NotfittedItems)
                    {
                        Console.WriteLine(notfittedItems.Name);
                    }
                    return "we coukdint fit all items";
                }
            }
            return $"Furniture fits in all rooms";
        }
    

    
        public static void Main(string[] args)
        {
     

            Room livingRoom = new Room();
            livingRoom.Size = 500;


            Room bedRoom = new Room();
            bedRoom.Size = 500;
          

            Room BathRoom = new Room();
            BathRoom.Size = 500;
            

            var allRooms = new List<Room>
                {
                livingRoom,
                bedRoom,
                BathRoom
                };


            Chair razerchair = new Chair();
            razerchair.Size = 2220;
            razerchair.Name = "razerchair";

            Chair kitchenChair = new Chair();
            kitchenChair.Size = 222;
            kitchenChair.Name = "kitchenChair";


            TV sonyTV = new TV();
            sonyTV.Size = 115;
            sonyTV.Name = "SonyTV";


            BounceHouse bounceHouse = new BounceHouse();
            bounceHouse.Size = 1111;
            bounceHouse.Name = "bounceHouse";
         

            var allFurniture = new List<Furniture>
            {
                razerchair,
                kitchenChair,
                sonyTV,
                bounceHouse
            };
      
           

            string doseFurnitureFit = DoseFurnitureFit(allRooms, allFurniture);

            Console.WriteLine(doseFurnitureFit);

            Console.ReadKey();
        }
    }
}
