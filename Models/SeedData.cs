using Microsoft.EntityFrameworkCore;
namespace Lunas_mini_aussies.Models
{
        public static class SeedData
{
         public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PuppyDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<PuppyDbContext>>()))
             {
            
            if (context.Client.Any())
            {
                return;
            }
                context.Client.AddRange(
                new Client {CName = "James", LName = "Zachary", email = "jz20@gmail.com"},
                new Client {CName = "Olivia", LName="Spensor", email="olr220@gmail.com"},
                new Client {CName = "Tucker", LName="Correll", email="tucktuck@yahoo.com", phone = "8061231234"},
                new Client {CName = "Liam", LName="Kade", email = "lkp21@gmail.com"}
                );
            context.SaveChanges();

            if (context.Puppies.Any())
             {
                return; // DB has been seeded
             }
               
            
             context.Puppies.AddRange(

                new Puppy { Name = "Sophie", Height = 15, Weight = 19, Gender = "Female", Temp = "Likes to jump and run, but quiet, listens, loves kids and cats, quick learner.", mom = "Lexie", dad = "Twister"},
                new Puppy{Name = "Sterling", Height =14, Weight =25, Gender = "M", Temp= "Relaxed couch potato, outdoors and alone-territorial, otherwise calm and quiet. Loves children/babies", mom="Dally", dad="Ryder"},
                new Puppy{Name = "Ryder", Height =15, Weight =35, Gender = "M", Temp= "Couch potato when outside energetic loves to run, not a dominant male, calm indoors and around children, prefers adult females. ", mom="Lexi", dad="Rooster"},
                new Puppy{Name = "Raya", Height =17, Weight =42, Gender ="F", Temp= "High energy levels, territorial when outdoors, runs into the walls, intelligent, lets anyone touch her.", mom="Lexi", dad="Rooster"},
                new Puppy{Name = "Raven", Height =18, Weight =45, Gender = "F", Temp= "High energy, does not like being touched by outsiders, good with kids and other dogs, calm indoors.", mom="Dally", dad="Twister"},    
                new Puppy{Name = "Rocky", Height =19, Weight =59, Gender = "M", Temp= "Loves to be outside, high energy levels, eats non-stop, destructive if bored and unattended.", mom="Dally", dad="Ryder"},
                new Puppy{Name = "Velvet", Height =15, Weight =30, Gender = "F", Temp= "Working dog energy levels, herds, playful with kids but not pushing boundardies.", mom="Raya", dad="Twister"},
                new Puppy{Name = "Oakley", Height =20, Weight =65, Gender = "M", Temp= "Fluff ball of cuddles, thinks he's a lap dog, quiet, calm, loves attention whines when he comes second.", mom="Raya", dad="Twister"},
                new Puppy{Name = "Breezy", Height =18, Weight =50, Gender = "M", Temp= "Trouble maker if you turn your back, very playful, has an attitude, not well with other males.", mom="Raya", dad="Twister"},
                new Puppy{Name = "Chestnut", Height =19, Weight =48, Gender = "M", Temp= "Skittish around strangers indoors, territorial outdoors, quick learn, calm, loves to run.", mom="Artemis", dad="Twister"},
                new Puppy{Name = "Smores", Height =15, Weight =32, Gender = "F", Temp= "Food driven, intelligent, play levels of energy outdoors, indoors would rather take a nap.", mom="Artemis", dad="Twister"},
                new Puppy{Name = "Gumbo", Height =16, Weight =51, Gender = "M", Temp= "High energy levels, loves kids and knows no stranger, hogs the bed.", mom="Lexi", dad="Twister"},
                new Puppy{Name = "Clover", Height =14, Weight =36, Gender = "F", Temp= "Sweet, calm, eats everything and anything-hide shoes, rather go for walks.", mom="Lexi", dad="Twister"},
                new Puppy{Name = "Mardi", Height =16.5, Weight =28, Gender = "M", Temp= "Loves car rides, calm indoors, high energy for about 20min, then naptime, great with cats and kids. ", mom="Lexi", dad="Twister"},
                new Puppy{Name = "Lacy", Height =18, Weight =45, Gender = "F", Temp= "High energy levels, outdoors dog, calm with kids but would rather be moving.", mom="Dally", dad="Twister"},
                new Puppy{Name = "Shadow", Height =17, Weight =49, Gender = "M", Temp= "High energy working dog, chases strangers, doesn't like going inside.", mom="Dally", dad="Twister"},
                new Puppy{Name = "Aspen", Height =18.5, Weight =45, Gender = "M", Temp= "Loves to run, fetch, swim, needs activity, chews shoes, and steals sandwiches. ", mom="Dally", dad="Twister"},
                new Puppy{Name = "Cypress", Height =18, Weight =55, Gender = "M", Temp= "Lovable teddy bear, squish you with cuddles, wants his own bed, and loves swimming.", mom="Dally", dad="Twister"},
                new Puppy{Name = "Cookie", Height =18, Weight =50, Gender = "M", Temp= "Very intelligent but prefers naps inside, playful levels of energy, loves to stay out at night. ", mom="Lexi", dad="Rooster"},
                new Puppy{Name = "Hershey", Height =17, Weight =48, Gender = "M", Temp= "Always wants to eat, destructive if bored, working dog mentality, likes to stay outside.", mom="Lexi", dad="Rooster"},
                new Puppy{Name = "Blondie", Height =15.5, Weight =30, Gender = "F", Temp= "Quick learn but will only do things with food as a reward, calm indoors, loves everyone.", mom="Lexi", dad="Rooster"},
                new Puppy{Name = "Thor", Height =13, Weight =30, Gender = "M", Temp= "Lounger, enjoys naps and sunbathing, until water is involved then high energy.", mom="Aurora", dad="Rocky"},
                new Puppy{Name = "Apollo", Height =14, Weight =34, Gender = "M", Temp= "Play energy levels, food driven, loves naps and car rides. ", mom="Aurora", dad="Rocky"},
                new Puppy{Name = "Athena", Height =11, Weight =22, Gender = "F", Temp= "Playful, slight attitude, very intelligent, loves to cuddle.", mom="Aurora", dad="Rocky"},
                new Puppy{Name = "Pearl", Height = 12.5, Weight = 25, Gender = "F", Temp = "Spoiled princess, wants attention when lounging around.", mom = "Lexi", dad="Twister"});
          
             context.SaveChanges();

            }
        }
    }
}
