// ****** Main *******//

System.Console.WriteLine("Welcome to my timer, where we count down from 24 hours to 0 as fast as possible");
System.Console.WriteLine("Press enter to continue...");
Console.ReadLine();

for(int i = 24; i >= 0; i--){
    for(int j = 60; j >= 0; j--){
        System.Console.WriteLine($"Hour: {i} Minute: {j}");
    }
}

System.Console.WriteLine("Thank you!");

// ****** End Main *******//
