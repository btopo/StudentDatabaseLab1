

String[] names = new String[]
{
    "Dan",
    "Jon",
    "Sam",
    "Jill",
    "Rita"
};


string[] homeTown = new string[]
{
    "Bozman, Montana ",
    "Charleston, South Carolina ",
    "Grand Rapids, Michigan ",
    "Columbus, Ohio",
    "Orlando, Florida"
};


string[] favoriteFood = new string[]
{
    "Pizza",
    "Tacos",
    "BBQ pulled pork",
    "Sushi",
    "Mac and Cheese",
};

bool contineLoop = true;

Console.WriteLine("Hi welcome to the student database lab. ");

while (contineLoop)
{
    Console.WriteLine(" Enter a number between 1 and 5 to see which student is what number, where that student's homewtown is, and what their favorite food is! ");
    string userEntry = Console.ReadLine();
    var isNumber = int.TryParse(userEntry, out int userNumber);       // isNumber has to be stored into variable. Tryparse determines if the value can it be returned as an int. Result is true or false
    if (isNumber == true)
    {
        if (userNumber < 1 || userNumber > names.Count())// this is the statement that testing if the users number is out of range
        {
            Console.WriteLine(" Please enter a number in the range of 1 to 5 .");
            contineLoop = true;
        }
        else
        {
            var student = names[userNumber - 1]; // making the variable = to the student number.
            Console.WriteLine($"student number {userNumber} is {student}");
            bool gettingStudentDetails = true;
            while (gettingStudentDetails)
            {
                Console.WriteLine(" would you like to know what their favorite food is or where their hometown is? Enter 'f' for food or 'h' for hometown.");
                var userChoice = Console.ReadLine().ToLower();
                if (userChoice == "f")
                {
                    var studentFavoriteFood = favoriteFood [userNumber - 1];
                    Console.WriteLine($"student number {userNumber}'s  favorite food is {studentFavoriteFood}. ");
                    gettingStudentDetails = false; // stops from asking again.
                }
                else if (userChoice == "h")
                {
                    var studentHomeTown = homeTown[userNumber - 1];
                    Console.WriteLine($"student number {userNumber}'s  hometown is {studentHomeTown}. ");
                    gettingStudentDetails = false; // stops from asking again.
                }
                else
                {
                    Console.WriteLine("Please enter 'f' or 'h'. ");

                }
            }
            bool askUser = true;
            while (askUser)
            {
                Console.WriteLine("would you like to know more about a different student? Enter Y for yes or N for no. ");
                var userDecision = Console.ReadLine().ToLower();
                if(userDecision == "y")
                {
                    askUser = false;  // stops asking if they want to go again.
                    contineLoop = true; // brings them back to the start.
                }
                else if (userDecision == "n")
                {
                    askUser = false;
                    contineLoop = false;
                }
                else
                {
                    Console.WriteLine("not a vaild response try again please.");
                }
            }
            
        }

    }
    else
    {
        Console.WriteLine("please enter a valid number between 1 and 5. "); // ;line to let user know to try again. brings back to start 
        contineLoop = true;
    }
    

}

Console.WriteLine("Thank you come again.");




