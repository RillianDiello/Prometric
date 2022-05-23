# Prometric

1. Define a Shape object, where the object is any two-dimensional figure and has the following characteristics: a name, a perimeter and a surface area.

R: Done

2. Define a Circle object that retains the aforementioned characteristics of a Shape. The calculations for a circle are:
- Area of ​​the circle = Pi*R*R where R=Radius ,Pi=3.14
- Perimeter (circumference) of the circle = 2*Pi*R where R=Radius ,Pi=3.14

R: Done

3. Define a Triangle object that retains the aforementioned characteristics of a Shape. The name of the triangle must take into account whether it is equilateral (all 3 sides are the same length), isosceles (only 2 sides are the same length) or scalene (no 2 sides are the same).
- Area of ​​the triangle = (Height * base) / 2
- Perimeter of the triangle = a + b + c
R: I used a user input approach and used Heron's Formula to calculate the area.

Done

4. Define 2 different quadrilaterals, a Square and a Rectangle that retain the aforementioned characteristics of a Shape. The name must take into account if all sides are the same length.
- Area of ​​square/rectangle = width*length
- Square/Rectangle Perimeter = (width + length) * 2

R: Done

5. We want to be able to sort a collection of Shapes by Area or Perimeter. Define methods/classes/interfaces that support this scenario and provide an example in Main.

R: Done

6. We want to be able to serialize/store shapes in various formats on disk. Define methods/classes/etc that support this scenario and provide an example in Main (xml/json/binary/etc choose one)

R: Todo
  

7. We want to be able to track (in memory) the number of Shape objects created (per class). Define methods/classes/etc that support this scenario and provide an example in Main
R: Done

# Menu:
I created a menu based on user interactions.
Deep validation routines were not created, such as negative values or values that force different types.
The menu is a list of all implemented actions.