
using System;

class Book
{
    public string Title;
    public int Pages;

    public override string ToString()
    {
        return "Title: " + Title + ", Pages: " + Pages;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Question 1
        Book myBook = new Book();
        myBook.Title = "Tale of two cities";
        myBook.Pages = 700;

        object book = myBook;

        Console.WriteLine("Question 1:");
        Console.WriteLine(book);


        // Question 2
        Console.WriteLine("\nQuestion 2:");
        Console.WriteLine(book.ToString());
        Console.WriteLine(book.Equals(book));
        Console.WriteLine(book.GetHashCode());
        Console.WriteLine(book.GetType());


        // Question 3
        Console.WriteLine("\nQuestion 3:");
        int pages = 464;
        Console.WriteLine(pages);


        // Question 4
        Console.WriteLine("\nQuestion 4:");

        try
        {
            int num = 10;
            int zero = 0;

            int result = num / zero;

            Console.WriteLine(result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Done");
        }


        // Question 5
        Console.WriteLine("\nQuestion 5:");

        int pages5 = 300;
        double number = pages5;

        Console.WriteLine(number);


        // Question 6
        Console.WriteLine("\nQuestion 6:");

        double price = 49.99;
        int newPrice = (int)price;

        Console.WriteLine(newPrice);


        // Question 7
        Console.WriteLine("\nQuestion 7:");

        string pagesText = "464";
        int convertedPages = Convert.ToInt32(pagesText);

        Console.WriteLine(convertedPages);


        // Question 8
        Console.WriteLine("\nQuestion 8:");

        string yearText = "2023";
        int year = int.Parse(yearText);

        Console.WriteLine(year);

        string badText = "abc";
        int parsedNumber;

        if (int.TryParse(badText, out parsedNumber))
        {
            Console.WriteLine(parsedNumber);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }

        // Question 9
        Console.WriteLine("\nQuestion 9:");

        int pageCount = 464;
        string text = pageCount.ToString();

        Console.WriteLine(text);
        Console.WriteLine(text.GetType());


        // Question 10
        Console.WriteLine("\nQuestion 10:");

        int copies = 100;

        object boxedObject = copies;  // Boxing

        int newCopies = (int)boxedObject;  // Unboxing

        Console.WriteLine(boxedObject);
        Console.WriteLine(newCopies);


        // Question 11
        Console.WriteLine("\nQuestion 11:");

        int? yearValue = null;

        Console.WriteLine(yearValue.HasValue);

        yearValue = 2023;

        Console.WriteLine(yearValue.HasValue);
        Console.WriteLine(yearValue.Value);


        // Question 12
        Console.WriteLine("\nQuestion 12:");

        string? reviewer = null;

        Console.WriteLine(reviewer == null);


        // Question 13
        Console.WriteLine("\nQuestion 13:");

        Book? nullableBook = null;

        string? title = nullableBook?.Title;

        Console.WriteLine(title);


        // Question 14
        Console.WriteLine("\nQuestion 14:");

        Console.WriteLine(title ?? "Untitled");

        title ??= "Untitled";

        Console.WriteLine(title);


        // Question 15
        Console.WriteLine("\nQuestion 15:");

        string? name = "Mariam";

        string confirmedName = name!;

        Console.WriteLine(confirmedName);
    }
}
