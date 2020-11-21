using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class ProgramUI
    {
        private StreamingContentRepository _contentRepo = new StreamingContentRepository();


        //method that starts the application
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        //menu
        private void Menu()
        {
            bool keeprunning = true;
            while (keeprunning)
            {

                //Display opitons to user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                // get user input
                string input = Console.ReadLine();

                //elvaluate input and act accordingly
                switch (input)
                {
                    case "1":
                        //Create New Content
                        CreateNewContent();
                        break;
                    case "2":
                        //view all content
                        DisplayAllContent();
                        break;
                    case "3":
                        //view content by title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        //update existing content
                        UpdateExisitingContent();
                        break;
                    case "5":
                        //delete existing content
                        DeleteExistingContent();
                        break;
                    case "6":
                        //exit
                        Console.WriteLine("Later Loser!");
                        keeprunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid Number.");
                        break;

                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }
        }
        // Create New StreamingContent

        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //TITLE
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();

            // descript
            Console.WriteLine("Enter the description for the content");
            newContent.Description = Console.ReadLine();

            //rating
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, etc):" );
            newContent.MaturityRating = Console.ReadLine();

            //star rating
            Console.WriteLine("Enter the star count for the content:");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            //fam friend
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if(familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //genre
            Console.WriteLine("Enter the genre Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");
            String genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            _contentRepo.AddContentToList(newContent);
        }

        //View Current StreamingContent that is saved
        private void DisplayAllContent()
        {
            Console.Clear();
            List<StreamingContent> listOfContent = _contentRepo.GetContentList();

            foreach(StreamingContent content in listOfContent)
            {
                Console.WriteLine($"Title: {content.Title}\n " +
                   $"Description: {content.Description}");
            }

        }
        //View Existing content by title
        private void DisplayContentByTitle()
        {
            Console.Clear();
            //ask for title
            Console.WriteLine("Enter the title of the content you would like to see:");
            //input
            string title = Console.ReadLine().ToLower();

            //find it 
            StreamingContent content = _contentRepo.GetContentByTitle(title);

            //display it if it isnt null
            if(content !=null)
            {
                Console.WriteLine($"Title: {content.Title}\n " +
                   $"Description: {content.Description}\n" +
                   $"Maturity Rating: {content.MaturityRating}\n" +
                   $"Stars: {content.StarRating}\n" +
                   $"Is Family Friendly:{content.IsFamilyFriendly}\n" +
                   $"Genre: {content.TypeOfGenre}");
            }
            else
            {
                Console.WriteLine("We don't have that one.");
            }

        }
        //update existing content
        private void UpdateExisitingContent()
        {
            //display all
            DisplayAllContent();
            //ask for the title to update
            Console.WriteLine("Enter the title of teh content youd like to update");
            //gat that title
            string oldTitle = Console.ReadLine();
            //build new object
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //TITLE
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();

            // descript
            Console.WriteLine("Enter the description for the content");
            newContent.Description = Console.ReadLine();

            //rating
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, etc):");
            newContent.MaturityRating = Console.ReadLine();

            //star rating
            Console.WriteLine("Enter the star count for the content:");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            //fam friend
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //genre
            Console.WriteLine("Enter the genre Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");
            String genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //verify the update worked
           bool wasUpdated = _contentRepo.UpdateExistingContent(oldTitle, newContent);

            if(wasUpdated)
            {
                Console.WriteLine("Content succesfully updated");
            }
            else
            {
                Console.WriteLine("Not able to update");
            }
        }
        //delete existing content
        private void DeleteExistingContent()
        {

            DisplayAllContent();
            //get the title
            Console.WriteLine("\nEnter the title of the content youd like to remove:");

            string input = Console.ReadLine();
            //call the delete
            bool wasDeleted = _contentRepo.RemoveContentFromList(input);

            //if deleted
            if (wasDeleted)
            {
                Console.WriteLine("The Content was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The Content could not be deleted");
            }
            //if the cont
        }

        //see method
        private void SeedContentList()
        {
            StreamingContent sharknado = new StreamingContent("Sharknado", "Tornados, but with sharks.", "TV-14", 3.3, true, GenreType.Action);
            StreamingContent theRoom = new StreamingContent("The Room", "Banker's life gets turned upside down.", "R", 5.8, false, GenreType.Drama);
            StreamingContent rubber = new StreamingContent("Rubber", "Car tire comes to life and goes on a killing spree.", "R", 5.8, false, GenreType.Documentary);

            _contentRepo.AddContentToList(sharknado);
            _contentRepo.AddContentToList(theRoom);
            _contentRepo.AddContentToList(rubber);
        }
    }
}