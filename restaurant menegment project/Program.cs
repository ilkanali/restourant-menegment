using System;

namespace restaurant_menegment_project
{


   static void Main(string[] args)
    {
        MenuItem menuitem1 = new MenuItem("PZ100", "vegeterianPizza", 12, Category.mainfood);
        MenuItem menuitem2 = new MenuItem("PZ101", "MiksPizza", 17, Category.mainfood);
        MenuItem menuitem3 = new MenuItem("PZ102", "SezerPizza", 12, Category.mainfood);
        MenuItem menuitem4 = new MenuItem("PZ104", "PobesPierPizza", Category.mainfood);

        MenuItem menuitem5 = new MenuItem("SO100", "Vegetablesoup", 6, Category.soup);
        MenuItem menuitem6 = new MenuItem("SO101", "chikensoup", 6, Category.soup);
        MenuItem menuitem7 = new MenuItem("SO102", "mashroom", 6, Category.soup);
        MenuItem menuitem8 = new MenuItem("SO103", "tomatosoup", 6, Category.soup);

        MenuItem menuitem9 = new MenuItem("DR100", "Fresh juice", 8, Category.drink);
        MenuItem menuitem10 = new MenuItem("DR101", "Lemonade", 7, Category.drink);
        MenuItem menuitem11 = new MenuItem("DR102", "sprite", 5, Category.drink);
        MenuItem menuitem12 = new MenuItem("DR103", "coca-cola", 5, Category.drink);


        MenuItem menuitem13 = new MenuItem("DS100", "Tiramisu", 8, Category.desert);
        MenuItem menuitem14 = new MenuItem("DS101", "cheesecake", 7, Category.desert);
        MenuItem menuitem15 = new MenuItem("DS102", "fruit cake", 6, Category.desert);
        MenuItem menuitem16 = new MenuItem("DS103", "lemon cheesecake", 7, Category.desert);

        Console.WriteLine($"{menuitem1.No}-{menuitem1.Name}-{menuitem1.Price}-{menuitem1.Category}");
        Console.WriteLine($"{menuitem2.No}-{menuitem1.Name}-{menuitem1.Price}-{menuitem1.Category}");
        Console.WriteLine($"{menuitem3.No}-{menuitem1.Name}-{menuitem1.Price}-{menuitem1.Category}");
        Console.WriteLine($"{menuitem4.No}-{menuitem1.Name}-{menuitem1.Price}-{menuitem1.Category}");

        Console.WriteLine($"{menuitem5.No}-{menuitem5.Name}-{menuitem5.Price}-{menuitem5.Category}");
        Console.WriteLine($"{menuitem6.No}-{menuitem6.Name}-{menuitem6.Price}-{menuitem6.Category}");
        Console.WriteLine($"{menuitem7.No}-{menuitem7.Name}-{menuitem7.Price}-{menuitem7.Category}");
        Console.WriteLine($"{menuitem8.No}-{menuitem8.Name}-{menuitem8.Price}-{menuitem8.Category}");

        Console.WriteLine($"{menuitem9.No}-{menuitem9.Name}-{menuitem9.Price}-{menuitem9.Category}");
        Console.WriteLine($"{menuitem10.No}-{menuitem10.Name}-{menuitem10.Price}-{menuitem10.Category}");
        Console.WriteLine($"{menuitem11.No}-{menuitem11.Name}-{menuitem11.Price}-{menuitem11.Category}");
        Console.WriteLine($"{menuitem12.No}-{menuitem12.Name}-{menuitem12.Price}-{menuitem12.Category}");

        Console.WriteLine($"{menuitem13.No}-{menuitem13.Name}-{menuitem13.Price}-{menuitem13.Category}");
        Console.WriteLine($"{menuitem14.No}-{menuitem14.Name}-{menuitem14.Price}-{menuitem14.Category}");
        Console.WriteLine($"{menuitem15.No}-{menuitem15.Name}-{menuitem15.Price}-{menuitem15.Category}");
        Console.WriteLine($"{menuitem16.No}-{menuitem16.Name}-{menuitem16.Price}-{menuitem16.Category}");






        {


        }

            

        
            
        }
    }

