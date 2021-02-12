using System;

namespace SecondConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MainMenu();
        }

        static void MainMenu()
        {
            RestaurantManager restaurantManager = new RestaurantManager();
            while (true)
            {
                Console.WriteLine("-1 Menu uzerinde emeliyyat aparmaq");
                Console.WriteLine("-2 Sifarisler uzerinde emeliyyat aparmaq");
                Console.WriteLine("-0 Sistemden cixmaq");
                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        // OperationsOnMenu();           // Menu uzerinde emeliyyat aparmaq
                        AddMenu(ref restaurantManager);
                        break;
                    case "2":
                        //OperationsOnOrders();        // Sifarisler uzerinde emeliyyat aparmaq
                        ShowMenu(ref restaurantManager);
                        break;
                    case "0":
                        return;
                    default:
                        break;
                }
            }
        }
        
        static void OperationsOnMenu()
        {
            while (true)
            {
                Console.WriteLine("- 1 Yeni item elave et");
                Console.WriteLine("- 2 Item uzerinde duzelis et");
                Console.WriteLine("- 3 Item sil");
                Console.WriteLine("- 4 Butun Item-lari goster");
                Console.WriteLine("- 5 Categoriyasina gore menu item-lari goster");
                Console.WriteLine("- 6 Qiymet araligina gore menu item-lar goster");
                Console.WriteLine("- 7 Menu item-lar arasinda ada gore axtaris et (search)");
                Console.WriteLine("- 0 Evveki menuya qayit");
                string input = Console.ReadLine();
                
                switch (input)
                {
                    case "1":
                        //
                        break;
                    case "2":
                        //
                        break;
                    case "3":
                        //
                        break;
                    case "4":
                        //
                        break;
                    case "5":
                        //
                        break;
                    case "6":
                        //
                        break;
                    case "7":
                        //
                        break;
                    case "0":
                        MainMenu();
                        return;
                    default:
                        break;
                }
            }
        }

        static void OperationsOnOrders()
        {
            while (true)
            {
                Console.WriteLine("- 1 Yeni sifaris elave etmek");
                Console.WriteLine("- 2 Sifarisin legvi");
                Console.WriteLine("- 3 Butun sifarislerin ekrana cixarilmasi");
                Console.WriteLine("- 4 Verilen tarix araligina gore sifarislrein gosterilmesi");
                Console.WriteLine("- 5 Verilen mebleg araligina gore sifarislerin gosterilmesi");
                Console.WriteLine("- 6 Verilmis bir tarixde olan sifarislerin gosterilmesi");
                Console.WriteLine("- 7 Verilmis nomreye esasen hemin nomreli sifarisin melumatlarinin gosterilmesi");
                Console.WriteLine("- 0 Evveli menuya qayit");
                string inputuser = Console.ReadLine();

                switch (inputuser)
                {
                    case "1":
                        //
                        break;
                    case "2":
                        //
                        break;
                    case "3":
                        //
                        break;
                    case "4":
                        //
                        break;
                    case "5":
                        //
                        break;
                    case "6":
                        //
                        break;
                    case "7":
                        //
                        break;
                    case "0":
                        MainMenu();
                        return;
                    default:
                        break;
                }
            }
        }

        static void AddMenu(ref RestaurantManager restaurantManager)
        {
            
            string name;
            double price;
            string category;
            
            Console.Write("Itemin Adi: ");
            name = Console.ReadLine();
            Console.Write("Itemin qiymeti: ");
            price = Convert.ToDouble(Console.ReadLine());         // bunu sonra tryparsa deyish!
            Console.Write("Itemin kateqoriyasi: ");
            category = Console.ReadLine();

            restaurantManager.AddMenuItem(name, price, category);
        }

        static void ShowMenu(ref RestaurantManager restaurantManager)
        {
            foreach (var item in restaurantManager.GetMenuItems())
            {
                Console.WriteLine($"Menu Itemin adi: {item.Name} || qiymeti: {item.Price} || kateqoriyasi: {item.Category}");
            }
        }
    }
}
