Console.Clear();
MainMenu();

static void MainMenu()
    {
        Console.WriteLine("What kind of pizza would you like?");
        Console.WriteLine("1) Plain topping-less pizza");
        Console.WriteLine("2) Cheese pizza");
        Console.WriteLine("3) Pepperoni pizza");
        Console.WriteLine("4) Exit");
        Console.Write("\nSelect an option: ");

        // Read the user input
        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                plainPizza();
                break;
            case "2":
                cheesePizza();
                break;
            case "3":
                pepperoniPizza();
                break;
            case "4":
                Console.WriteLine("Exiting...");
                return;
            default:
                Console.Clear();
                Console.WriteLine("Invalid choice, please try again.\n");
                MainMenu();
                break;
        }
    }




static void plainPizza(){
    Random rnd = new Random();
    int rows = rnd.Next(8,13);

    for (int i = rows; i > 0; i--){
        for (int j = 0; j < i; j++){
            Console.Write("* ");
        }
        Console.WriteLine();
    }
    
}

static void cheesePizza(){
    Random rnd = new Random();
    int rows = rnd.Next(8,13);
//Top row
    for (int i = rows; i > 0; i--){
        Console.Write("* ");
    }
    Console.WriteLine();

//rest of the rows
    for (int i = rows - 1; i > 0; i--){
        for (int j = 0; j < i; j++){
            if(j == 0 || j == i - 1){
                Console.Write("* ");
            }
            else{
                Console.Write("# ");
            }
        }
        Console.WriteLine();
    }
    
}

static void pepperoniPizza(){
    Random rnd = new Random();
    int rows = rnd.Next(8,13);
//Top row
    for (int i = rows; i > 0; i--){
        Console.Write("* ");
    }
    Console.WriteLine();

//rest of the rows
    for (int i = rows - 1; i > 0; i--){
        for (int j = 0; j < i; j++){
            if(j == 0 || j == i - 1){
                Console.Write("* ");
            }
            else{
                string toppings = rnd.Next(2) == 1 ? "# " : "[]";
                Console.Write(toppings);
            }
        }
        Console.WriteLine();
    }
    
}


