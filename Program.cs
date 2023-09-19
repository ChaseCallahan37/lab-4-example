// ****** Main *******//

string userInput = GetMenuChoice();

while(userInput != "3"){
    if(userInput == "1"){
        SayHello();
    } else if(userInput == "2"){
        int sum = Sum(2, 2);
        System.Console.WriteLine($"2 + 2 is {sum}");
    }else if(userInput == "3"){
        System.Console.WriteLine("Bye!!!");
    } else{
        System.Console.WriteLine("Wrong input!!!, please try again");
    }

    userInput = GetMenuChoice();
}

// ****** End Main *******//

static string GetMenuChoice(){
    DisplayMenu();
    return Console.ReadLine();
}

static void DisplayMenu(){
    System.Console.WriteLine("1. Say Hello");
    System.Console.WriteLine("2. Add 2 + 2");
    System.Console.WriteLine("3. Exit");
}

static void SayHello(){
    System.Console.WriteLine("Hello There!!!!!");
}

static int Sum(int x, int y){
    int sum = x + y;
    return sum;
}