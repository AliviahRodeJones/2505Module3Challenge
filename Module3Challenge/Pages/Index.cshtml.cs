using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module3Challenge.Pages
{
    public class IndexModel : PageModel
    {
        
        public string HungerMessage { get; set; } = string.Empty;
        public string SoundMessage { get; set; } = string.Empty;
        public string DayMessage { get; set; } = string.Empty;

        public void OnGet()
        {
            // This runs when the page first loads. Nothing to do yet.
        }

        public void OnPost(int hungerLevel, int dayOfWeek)
        {
            if (hungerLevel >= 8)
            {
                HungerMessage = "Lion: Roar! I need a big meal!";
            } else if (hungerLevel >= 5){
                HungerMessage = "Monkey: Ooh ooh! I'll take some bananas.";
                
            } else
            {
                HungerMessage = "Tortoise: Slow and steady, I'll have some lettuce.";
            }
            // Add your if-else statement here
            // 🦁 If hungerLevel >= 8, set HungerMessage to "Lion: Roar! I need a big meal!"
            // 🐵 If hungerLevel >= 5, set HungerMessage to "Monkey: Ooh ooh! I'll take some bananas."
            // 🐢 If hungerLevel < 5, set HungerMessage to "Tortoise: Slow and steady, I'll have some lettuce."

            SoundMessage = (hungerLevel >= 8) ? "Listen to the Lion: Roar!" : "Listen to the Monkey: Ooh ooh!";
            // Add your ternary operator here
            // If hungerLevel >= 8, set SoundMessage to "Listen to the Lion: Roar!"
            // Else, set SoundMessage to "Listen to the Monkey: Ooh ooh!"

            switch (dayOfWeek){
                case 1:
                    DayMessage = "Today is icecream sunday! All icecream cones are 50% off!";
                    break;
                    // Sets the day message to Sunday's event and breaks out of the switch statement.

                case 2:
                    DayMessage = "Today is monkey monday! At noon, watch zookeepers give the monkeys a special treat!";
                    break;
                    // Sets the day message to Monday's event and breaks out of the switch statement.

                case 3:
                    DayMessage = "Today is turtle tuesday! At noon, watch zookeepers give the turtles a special treat!";
                    break;
                    // Sets the day message to Tuesday's event and breaks out of the switch statement.

                case 4:
                    DayMessage = "Today is waddle wendesday! At noon, watch zookeepers give the penguins a special treat!";
                    break;
                    // Sets the day message to Wendesday's event and breaks out of the switch statement.
                case 5:
                    DayMessage = "Today is thumping thursday! At noon, watch zookeepers give the rabbits a special treat!";
                    break;
                    // Sets the day message to Thursday's event and breaks out of the switch statement.
                case 6: 
                    DayMessage = "Today is free friday! All kids get in for free, and adults at half price!";
                    break;
                    // Sets the day message to Friday's event and breaks out of the switch statement.
                case 7:
                    DayMessage = "Today is silly saturday! Come in your silliest costume and you'll be entered to win a prize!";
                    break;
                    // Sets the day message to Saturday's event and breaks out of the switch statement.
            }
            // A switch statement that defines the DayMessage. 
        }
    }
}
