public class Room
{
  public int Size { get; set; }
  public string Names { get; set; }
}


public class Furniture

{
    public int Size { get; set; }
    public string Names { get; set; }
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
        public static string DoseFurnitureFit(List<Room> rooms, List<Furniture> furnitures, List<Name> names)
        {
            int roomSizes = 0;

            foreach (Room room in rooms)
            {
                roomSizes = roomSizes + room.Size;
            }
            
            int furnitureSizes = 0;
            foreach (Furniture furniture in furnitures)
            {
                furnitureSizes = furnitureSizes + furniture.Size;
            }

            string furnitureName = "";
            foreach (Name name in names)
            {
                furnitureName = furnitureName + name.Names;
            }

            if (roomSizes >= furnitureSizes)
            {
                return $"Furniture fits in all rooms {furnitureSizes}";
            }
            else
            {
                return $"this {furnitureName} doesn's fit in your room";
            }
        }
        public static void Main(string[] args)
        {

            Room livingRoom = new Room();
            livingRoom.Size = 500;
            livingRoom.Names = "Coolchair";
            livingRoom.Names = "eatingChair";



            Room bedRoom = new Room();
            bedRoom.Size = 500;
            bedRoom.Names = "Sonytv";



            Room BathRoom = new Room();
            BathRoom.Size = 500;
            BathRoom.Names = "BounceHouse1";



            var allRooms = new List<Room>
                {
                livingRoom,
                bedRoom,
                BathRoom
                };


            Chair razerchair = new Chair();
            razerchair.Size = 21200;

            Chair kitchenChair = new Chair();
            kitchenChair.Size = 22;
          
            TV sonyTV = new TV();
            sonyTV.Size = 65;
          
            BounceHouse bounceHouse = new BounceHouse();
            bounceHouse.Size = 10;
         

            var allFurniture = new List<Furniture>
            {
                razerchair,
                kitchenChair,
                sonyTV,
                bounceHouse
            };

            Name coolChair = new Name();
            razerchair.Names = "Coolhair";

            Name eatingChair = new Name();
            kitchenChair.Names = " eatingChair";

            Name sonytv = new Name();
            sonyTV.Names = "Sonytv";

            Name bounceHouse1 = new Name();
            bounceHouse.Names = "BounceHouse1";



            var allNames = new List<Name>
            {
                coolChair,
                eatingChair,
                sonytv,
                bounceHouse1

            };

      
           

            string doseFurnitureFit = DoseFurnitureFit(allRooms, allFurniture, allNames);

            Console.WriteLine(doseFurnitureFit);
        }
    }
}
