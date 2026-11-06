# Car dealership (C#)

Small .NET console app made while learning C# and object oriented programming. It keeps a list of cars and a list of customers (class names and output are in Italian).

## Stack
- C# on .NET 10 (console app)

## Structure
Solution `Csharp.sln`, project in `Csharp/`:

| File | What it is |
|---|---|
| `Program.cs` | entry point: adds four cars, adds kilometres, searches by brand |
| `Models/Automobile.cs` | car (brand, model, year, kilometres) |
| `Models/Cliente.cs` | customer (name, email, phone) |
| `Services/AutomobileService.cs` | list of cars: add, show, search by brand / year, add kilometres |
| `Services/ClienteService.cs` | list of customers: add, show, search, delete (not used by `Program.cs` yet) |

## How to run
    cd Csharp
    dotnet run

## What it shows about learning
- Classes, properties, constructors, a private field with a read-only property
- Services that manage a `List<T>` and LINQ (`Where`, `FirstOrDefault`)
- The comment at the bottom of `Program.cs` is my note comparing OOP and procedural programming

## Known issues
- `ClienteService` and `Cliente` are written but never used in `Main`.
