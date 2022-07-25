//SEQUENCE------------------------
public class Apartment
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

public class Desk : Furniture
{
}

public class Monitor : Furniture
{
}

public class Bike : Furniture
{
}
public class Bed : Furniture
{
}

// SELECTION---------------------------
namespace Solver
{
    class SpaceSolver
    {


        public static string DoseFurnitureFit(List<Apartment> rooms, List<Furniture> furnitures)
        {
            int roomSizes = 0;

            foreach (Apartment room in rooms)
            {
                roomSizes = roomSizes + room.Size;
            }

            List<Furniture> furnituresItems = new List<Furniture>();


            int furnitureSizes = 0;
            foreach (Furniture furniture in furnitures)
            {
                furnitureSizes = furnitureSizes + furniture.Size;


                //ITERATION--------------------------
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
                    return "Could not fit all the items";
                }
            }
            return $"items will fit you only have {furnitureSizes} Available space and total number of items  {furnitures.Count}";
        }

        //LOOKING FOR THE WHAT ITEM WILL NOT FIT---
        //SEQUENCE------------------------
        public static void Main(string[] args)
        {


            Apartment livingRoom = new Apartment();
            livingRoom.Size = 500;


            Apartment bedRoom = new Apartment();
            bedRoom.Size = 500;


            Apartment BathRoom = new Apartment();
            BathRoom.Size = 500;


            var allRooms = new List<Apartment>
                {
                livingRoom,
                bedRoom,
                BathRoom
                };


            Chair razerChair = new Chair();
            razerChair.Size = 20;
            razerChair.Name = "razerChair";

            Desk CodingDesk = new Desk();
            CodingDesk.Size = 500;
            CodingDesk.Name = "SmartDesk Core";


            Monitor Ultrawide = new Monitor();
            Ultrawide.Size = 34;
            Ultrawide.Name = "Gigabyte M34WQ";


            Bike Peloton = new Bike();
            Peloton.Size = 11;
            Peloton.Name = "Peloton";

            Bed KingSize = new Bed();
            KingSize.Size = 150;
            KingSize.Name = "Bed";


            var allFurniture = new List<Furniture>
            {
                razerChair,
                CodingDesk,
                Ultrawide,
                Peloton,
                KingSize
            };



            string doseFurnitureFit = DoseFurnitureFit(allRooms, allFurniture);

            Console.WriteLine(doseFurnitureFit);

            Console.ReadKey();
        }
    }
}
