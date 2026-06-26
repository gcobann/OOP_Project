# OOP Polygon Generator

## About The Project
This is a C# Windows Forms application developed to practice and demonstrate Object-Oriented Programming (OOP) principles. The program allows users to dynamically generate, draw, and animate custom polygons on a canvas using mathematical coordinate calculations. 

It was built as a student project to bridge theoretical OOP concepts (such as Inheritance, Interfaces, and Encapsulation) with practical geometry and UI design.

## Features
* **Dynamic Drawing:** Create custom polygons by specifying the center coordinates (X, Y), edge length, and the number of edges.
* **Custom Colors:** Adjust RGB values to change the color of the shape.
* **Animated Rotation:** Rotate the generated polygon clockwise or counter-clockwise with a dynamic timer and adjustable speed.
* **Save & Load:** Export the current shape's data to a `.txt` file and load it back onto the canvas later.
* **Coordinate Math:** Calculates both Cartesian (X, Y) and Polar (r, θ) coordinates behind the scenes to render the vertices.

## Technologies Used
* **Language:** C#
* **Framework:** .NET Windows Forms
* **Core Concepts:** Object-Oriented Programming (Classes, Interfaces, Abstract Classes, Encapsulation, Inheritance)

## How to Run
1. Clone this repository to your local machine.
2. Open the `OOP_Project.sln` or `OOP_Project.csproj` file in Visual Studio.
3. Click the **Start** button (or press `F5`) to build and run the application.

## Project Structure
* `IShape.cs` & `Shape.cs`: The foundational interface and abstract base class.
* `Polygon.cs`: Inherits from `Shape`, handles the core math for calculating the corners (vertices) of the polygon.
* `Point2D.cs` & `ColorRGB.cs`: Custom helper classes showcasing encapsulation for coordinates and color management.
* `Form1.cs`: The main user interface, handling button clicks, timers, and drawing graphics on the screen.
