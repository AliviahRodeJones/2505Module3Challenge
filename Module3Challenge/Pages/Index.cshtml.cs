using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module3Challenge.Pages
{
    public class IndexModel : PageModel
    {
        
        public string HungerMessage { get; set; } = string.Empty;
        // This string will hold the hunger message that is displayed on the webpage. 
        public string SoundMessage { get; set; } = string.Empty;
        // This string will hold the sound message that is displayed on the webpage. 
        public string DayMessage { get; set; } = string.Empty;
        // This string will hold the day message that is displayed on the webpage. 
        public int HungerLevel { get; set; }
        // This int holds the user entered HungerLevel value after it is passed to the C# file. 
        public int DayOfWeek { get; set; }
        // This int holds the user entered DayofWeek value after it is passed to the C# file.

        public void OnGet()
        {
            // This runs when the page first loads. Nothing to do yet.
        }

        public void OnPost(int hungerLevel, int dayOfWeek){
            HungerLevel = hungerLevel;
            // hungerLevel from the html page is set to HungerLevel in the C# page. 
            DayOfWeek = dayOfWeek;
            // dayOfWeek from the html page is set to DayOfWeek in the C# page.

            if (HungerLevel >= 8)
            {
                HungerMessage = "Lion: Roar! I need a big meal!";
                // Checks if HungerLevel is greater or equal to 8.
                // Then sets the HungerMessage variable to a fitting message. 
            } else if (HungerLevel >= 5){
                // 
                HungerMessage = "Monkey: Ooh ooh! I'll take some bananas.";
                // Checks if HungerLevel is greater or equal to 5. Then sets the HungerMessage variable to a fitting message
                
            } else
            {
                HungerMessage = "Tortoise: Slow and steady, I'll have some lettuce.";
                // This is the default message if the other two don't evaluate to true. Sets the HungerMessage variable to a fitting message.
            }

            SoundMessage = (HungerLevel >= 8) ? "Listen to the Lion: Roar!" : "Listen to the Monkey: Ooh ooh!";
            // This tenerary operator checks if the HungerLevel is greater or equal to 8. 
            // If true it sets the SoundMessage to a message to a lion message. 
            // If false (HungerLevel < 8) it sets the SoundMessage to a monkey message.
            

            switch (DayOfWeek){
            // A switch statement that defines the DayMessage. 
                case 1:
                    DayMessage = "Today is Icecream Sunday! All icecream cones are 50% off!";
                    break;
                    // Sets the day message to Sunday's event and breaks out of the switch statement.

                case 2:
                    DayMessage = "Today is Monkey Monday! At noon, watch zookeepers give the monkeys a special treat!";
                    break;
                    // Sets the day message to Monday's event and breaks out of the switch statement.

                case 3:
                    DayMessage = "Today is Turtle Tuesday! At noon, watch zookeepers give the turtles a special treat!";
                    break;
                    // Sets the day message to Tuesday's event and breaks out of the switch statement.

                case 4:
                    DayMessage = "Today is Waddle Wendesday! At noon, watch zookeepers give the penguins a special treat!";
                    break;
                    // Sets the day message to Wendesday's event and breaks out of the switch statement.
                case 5:
                    DayMessage = "Today is Thumping Thursday! At noon, watch zookeepers give the rabbits a special treat!";
                    break;
                    // Sets the day message to Thursday's event and breaks out of the switch statement.
                case 6: 
                    DayMessage = "Today is Free Friday! All kids get in for free, and adults at half price!";
                    break;
                    // Sets the day message to Friday's event and breaks out of the switch statement.
                case 7:
                    DayMessage = "Today is Silly Saturday! Come in wearing your silliest costume and you'll be entered to win a prize!";
                    break;
                    // Sets the day message to Saturday's event and breaks out of the switch statement.
            }
        }
    }
}
