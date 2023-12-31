# Итоговая контрольная работа по основному блоку
## _Александр Воленко_ - [GitHub](https://github.com/Olvo9315)

# String Array Filter 

This is a simple C# program that allows you to create a new string array from an existing array of strings, containing only those strings whose length is less than or equal to 3 characters.

## Usage

To use this program, follow these steps:

1. Run the program in a C# environment.
2. You will be prompted to enter the number of elements in your initial array (`Nº of elements`). Enter a positive integer greater than 0 and press Enter.

3. Next, you will be prompted to enter each element of the array one by one. For each element, you will see a prompt like `Enter 1 element:`. Enter the string you want to add to the array and press Enter. Repeat this step for the specified number of elements you entered in step 2.

4. Once you have entered all the elements, the program will display your original array.

5. After that, the program will create a new array containing only those elements from the original array whose length is less than or equal to 3 characters.

6. The program will display the filtered array, showing only the elements that meet the length criteria.

## Code Overview

Here's a brief overview of the key functions and components in the code:

- `GetElementsNumber`: A function that prompts the user to enter the number of elements in the array and validates the input.

- `GetElement`: A function that prompts the user to enter a single element of the array and returns it as a string.

- `PrintArray`: A function that prints the contents of an array to the console.

- `GetFilteredArray`: A function that filters the original array based on the length of its elements and returns a new array with only the qualifying elements.

- `MainPart`: The main part of the program that orchestrates the entire process. It collects user input, creates the original array, displays it, and then displays the filtered array.

## Example

Here's a sample run of the program:

```
Enter Nº of elements: 5
Enter 1 element: Hello
Enter 2 element: 2
Enter 3 element: :-)
Enter 4 element: world
Enter 5 element: -10
Your array: [Hello, 2, :-), world, -10]
Your filtered array: [2, :-), -10]
```

In this example, the user entered an array with 5 elements, and the program displayed both the original array and the filtered array with elements containing 3 characters or less.