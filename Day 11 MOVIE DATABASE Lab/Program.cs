using Day_10_CIRCLE_LAB;
using Day_11_MOVIE_DATABASE_Lab;
using System.Numerics;
using System.Reflection;

//Console.WriteLine("enter a number");
//int x = Validator.GetPositiveInputInt();

Console.WriteLine("Welcome to the Movie Database!");

List<Movie> MoviesList = new List<Movie>() 
{ 
    new Movie("Forest Gump", "Romance", 142, 1994, 8.8),
    new Movie("The Shawshank Redemption", "Drama", 142, 1994, 9.3),
    new Movie("The Godfather", "Drama", 175, 1972, 9.2),
    new Movie("Jurassic Park", "Sci-Fi", 127, 1993, 8.2),
    new Movie("The Avengers", "Action", 143, 2012, 8),
    new Movie("The Lion King", "Romance", 87, 1997, 9.3),
    new Movie("The Little Mermaid", "Romance", 83, 1989, 9.2),
    new Movie("Avatar", "Action", 262, 2009, 7.9),
    new Movie("Don't Look Up", "Sci-Fi", 245, 2021, 7.2),
    new Movie("Good Will Hunting", "Drama", 126, 1997, 8.3)
};


//search for the movie by category
bool runProgram = true;
while (runProgram)
{
    while (true)
    {
        //program takes user input
        Console.WriteLine($"Select a category: 1. Drama, 2. Romance, 3. Action, 4. Sci-Fi.");
        int categoryChoice = 0;
        while (int.TryParse(Console.ReadLine(), out categoryChoice) == false || categoryChoice < 1 || categoryChoice > 4)
        {
            Console.WriteLine("Invalid response. Try again"); //error message
        }
   
        if (categoryChoice == 1)
        {
            List<Movie> displayCateogryChoice = MoviesList.Where(d => d.Category == "Drama").OrderBy(m => m.Title).ToList();
            foreach (Movie m in displayCateogryChoice)
            {
                Console.WriteLine(m.GetDetails());
            }
            break;
        }
        else if (categoryChoice == 2)
        { 
            List<Movie> displayCateogryChoice = MoviesList.Where(d => d.Category == "Romance").OrderBy(m => m.Title).ToList();
            foreach (Movie m in displayCateogryChoice)
            {
                Console.WriteLine(m.GetDetails());
            }
            break;
        }
        else if (categoryChoice == 3)
        {
            List<Movie> displayCateogryChoice = MoviesList.Where(d => d.Category == "Action").OrderBy(m => m.Title).ToList();
            foreach (Movie m in displayCateogryChoice)
            {
                Console.WriteLine(m.GetDetails());
            }
            break;
        }
        else if (categoryChoice == 4)
        {
            List<Movie> displayCateogryChoice = MoviesList.Where(d => d.Category == "Sci-Fi").OrderBy(m => m.Title).ToList();
            foreach (Movie m in displayCateogryChoice)
            {

                Console.WriteLine(m.GetDetails());
            }
            break;
        }
        else
        {
            Console.WriteLine("That is not a valid choice. Please try again.");
            continue;
        }

        //if ("drama".Contains(categoryChoice))
        //{
        //    List<Movie> displayCategoryChoice = MoviesList.Where(d => d.Category == "Drama").ToList();
        //    foreach (Movie m in displayCategoryChoice)
        //    {
        //        Console.WriteLine(m.GetDetails());
        //    }
        //    break;
        //}
        //else if ("romance".Contains(categoryChoice))
        //{
        //    List<Movie> displayCategoryChoice = MoviesList.Where(d => d.Category == "Romance").ToList();
        //    foreach (Movie m in displayCategoryChoice)
        //    {
        //        Console.WriteLine(m.GetDetails());
        //    }
        //    break;
        //}
        //else if ("action".Contains(categoryChoice))
        //{
        //    List<Movie> displayCategoryChoice = MoviesList.Where(d => d.Category == "Action").ToList();
        //    foreach (Movie m in displayCategoryChoice)
        //    {
        //        Console.WriteLine(m.GetDetails());
        //    }
        //    break;
        //}
        //else if ("sci-fi".Contains(categoryChoice))
        //{
        //    List<Movie> displayCategoryChoice = MoviesList.Where(d => d.Category == "Sci-Fi").ToList();
        //    foreach (Movie m in displayCategoryChoice)
        //    {
        //        Console.WriteLine(m.GetDetails());
        //    }
        //    break;
        //}
        //else
        //{
        //    Console.WriteLine("That is not a valid choice. Please try again.");
        //    continue;
        //}
    }


    //Console.WriteLine(Validator.GetContinue("Do you want to view another category?"));

    while (true)
    {
        Console.WriteLine($"Do you want to view another category? y/n");
        string choice = Console.ReadLine().Trim().ToLower();
        if (choice == "y")
        {
            runProgram = true;
            break;
        }
        else if (choice == "n")
        {
            Console.WriteLine("Bye!");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Try again.");
            continue;
        }
    }
    
}
    







