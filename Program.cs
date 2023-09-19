// ****** Main *******//

string userInput = GetMenuChoice();

while(userInput != "3"){
    if(userInput == "1"){
        SayHello();
    } else if(userInput == "2"){
        int sum = TwoPlusTwo();
        DisplayMath(sum);
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
    System.Console.WriteLine("1. See joke");
    System.Console.WriteLine("2. Add 2 + 2");
    System.Console.WriteLine("3. Exit");
}

//JOKE

static void SayHello(){
    System.Console.WriteLine("Why can't a bicycle stand on its own? It's two-tired.");
}

//MATH

static int TwoPlusTwo(){
    return 2+2;
}

static void DisplayMath(int answer){
    System.Console.WriteLine("2 + 2 is " + answer);
}

