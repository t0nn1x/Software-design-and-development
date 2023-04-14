# .NET Core Design Patterns Lab

This lab explores various design patterns in the context of a .NET Core application. The goal is to understand the use cases for each pattern and practice implementing them in code.

## Patterns Covered

1. Adapter
2. Decorator
3. Facade
4. Bridge

## Task 1: Adapter

The Adapter pattern is used to create a file logger by creating a `Logger` class with `Log`, `Error`, and `Warn` methods, a `FileWriter` class, and an adapter that allows the logger to write to a file.

## Task 2: Decorator

The Decorator pattern is used to create an RPG game with `Warrior`, `Mage`, and `Paladin` hero classes. Inventory items (`Clothes`, `Weapons`, and `Artifacts`) are implemented as decorators so that they can be added to any hero type. The pattern allows for multiple inventory instances to be used on a hero at the same time.

## Task 3: Facade

The Facade pattern is used to prepare a "BigMac Menu" with separate classes for each dish, packaging, napkins, and prices. A `BigMacMenuFacade` class assembles the entire menu, simplifying the process of preparing and displaying the menu.

## Task 4: Bridge

The Bridge pattern is used in the context of a graphic editor with a base `Shape` class and child classes like `Circle`, `Square`, and `Triangle`. The pattern adds the ability to render each shape as a vector or raster graphic using an `IRenderer` interface.

## How to Run

1. Open the solution in Visual Studio.
2. Set the appropriate project as the startup project (if not already set).
3. Press F5 or click the "Start" button to run the project.
4. Observe the console output to see the results of each task.

## Author

[Anton Khrobust]
