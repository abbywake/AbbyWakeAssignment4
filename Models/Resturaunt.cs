using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWakeAssignment4.Models
{
    public class Resturaunt
        //making a class so I can enter information and then it will stay 
    {
        [Required]
       public int Rank { get; set; }

        [Required]
       public string ResName { get; set; }

        //if it's a null, make sure it says, "it's all yummy"
        public string? FavDish { get; set; } = "It's all yummy";
        [Required]
        public string Address { get; set; }

        [Phone]
        public string ResPhone { get; set; }
        //same theory thinking with the if it's a null
        public string? Link { get; set; } = "Coming soon!";


        public static Resturaunt[] GetResturaunts()
        {
            //this is where we made all of the information to store it on the page instead of through p tags or whatever
            Resturaunt r2 = new Resturaunt
            {
                Rank = 2,
                ResName = "Rockwell",
                FavDish = "Muddy Buddy Ice Cream",
                Address = "43 N University Ave, Provo, UT 84601",
                ResPhone = " (801) 318-5950",
                Link = "https://www.rockwellicecream.com/"
            };

            Resturaunt r1 = new Resturaunt
            {
                Rank = 1,
                ResName = "Cubby's",
                FavDish = "Trip-tip Steak Sandwich",
                Address = "1258 N State St, Provo, UT 84604",
                ResPhone = "(801) 919-3023",
                Link = "https://cubbys.co/"
            };

            Resturaunt r3 = new Resturaunt
            {
                Rank = 3,
                ResName = "Sam Hawk",
                FavDish = "Bibimbab",
                Address = "684 N Freedom Blvd, Provo, UT 84601",
                ResPhone = "(801) 377-7766"
            };

            Resturaunt r4 = new Resturaunt
            {
                Rank = 4,
                ResName = "Bowls Superfoods",
                FavDish = "Anything Peanut Butter ",
                Address = "1161 N Canyon Rd, Provo, UT 84604",
                ResPhone = "(801) 960-9918",
                Link = "https://www.facebook.com/bowlssuperfoods/"
            };

            Resturaunt r5 = new Resturaunt
            {
                Rank = 5,
                ResName = "Don Joaquin",
              
                Address = "150 W 1230 N St, Provo, UT 84604",
                ResPhone = "(801) 400-2894",
                Link = "https://stdonjoaquin.com/"
            };

       

            //making sure we can return these bad bois
            return new Resturaunt[] { r1, r2, r3, r4, r5 };
        }

        //ALSO DISCLAIMER. I LEARNED HOW TO SPELL RESTAURANT IN THE MIDDLE OF THIS PROJECT BUT THERE WAS NO WAY I WAS GOING TO TAKE THE TIME TO CHANGE ALL OF THEM


    }
}
