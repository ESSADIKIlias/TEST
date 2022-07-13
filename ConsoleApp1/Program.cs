// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

Shape shape1 = new Shape(50, 50, 3, 1, 1, 1, 5, 30, 30, 30) ;
Shape shape2 = new Shape(50, 50, 3, 1, 1, 1, 5, 60, 30, 30);
shape2.setId("abec");
shape1.setScale(74);
shape1.setPositionById("abec", 20, 20, 20);
shape1.setId("abec");
shape1.allShapes();
Console.WriteLine(Shape.idSet.Count);
