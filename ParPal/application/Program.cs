﻿
// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");
bool running = true;
MongoDbUtils.Connect();
RequestClient requestClient = new();


while(running) {
    
    Console.Write("Enter Command: ");
    
    string? command = Console.ReadLine();

    if (command == null) {
        Console.WriteLine("Null command");
        continue;
    } else if (command.Equals("exit")) {
        running = false;
        continue;
    }

    requestClient.ExecuteCommand(command);
}

