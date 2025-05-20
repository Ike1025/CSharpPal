
// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");
bool running = true;
RequestClient requestClient = new();
MongoDbUtils.Connect();

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

