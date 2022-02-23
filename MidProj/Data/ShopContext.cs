using Microsoft.EntityFrameworkCore;
using MidProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidProj.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().HasData(
                new { AnimalId = 1, PictureName = "Great-Bustard.jpg", Name = "Great-Bustard", Age = 7, Description = "Clocking in at around 35 pounds, the great bustard is often referred to as the “flying fortress,” Bird says, because it’s the heaviest flying bird. The largest great bustard recorded tipped the scales at more than 46 pounds—that’s slightly heavier than a full-size border collie.", CatagoryId = 1 },
                new { AnimalId = 2, PictureName = "Wanderalbatross-Spannweite.jpg", Name = "Wandering-Albatross", Age = 6, Description = "Wandering albatrosses have the largest wingspan of any bird, at more than 11 feet across. Adults have white plumage, black wings, and webbed feet, along with tubular nostrils on either side of their hooked, pink bills. They weigh 17 to 25 pounds and they’re about three-and-a-half feet from bill to tail.", CatagoryId = 1 },
                new { AnimalId = 3, PictureName = "Golden-Eagle.jpg", Name = "Golden-Eagle", Age = 8, Description = "The golden eagle (Aquila chrysaetos) is a bird of prey living in the Northern Hemisphere. It is the most widely distributed species of eagle. Like all eagles, it belongs to the family Accipitridae. They are one of the best-known birds of prey in the Northern Hemisphere.", CatagoryId = 1 },
                new { AnimalId = 4, PictureName = "Peregrine-Falcon.jfif", Name = "Peregrine-Falcon", Age = 6, Description = "The largest falcon over most of North America, peregrine falcons are crow-sized raptors with long, pointed wings and a long tail. They are the fastest moving bird in the world[320kmh], but not to be confused with the fastest flying bird, Bird says. That title belongs to the red-breasted merganser.", CatagoryId = 1 },
                new { AnimalId = 5, PictureName = "White-throated-needletail.jpg", Name = "White-throated-needletail", Age = 4, Description = "The white-throated needletail (Hirundapus caudacutus), also known as needle-tailed swift or spine-tailed swift, is a large swift in the genus Hirundapus. It is reputed to reach speeds of up to 170 km/h (105 mph) in horizontal flight, but this is unverified because the methods used to measure its speed have not been published", CatagoryId = 1 },
                new { AnimalId = 6, PictureName = "Black-marlin.jfif", Name = "Black-marlin", Age = 2, Description = "The black marlin (Istiompax indica) is a species of marlin found in tropical and subtropical areas of the Indian and Pacific Oceans.[2] With a maximum published length of 4.65 m (15.3 ft) and weight of 750 kg (1,650 lb),[2] it is one of the largest marlins and also one of the largest bony fish", CatagoryId = 2 },
                new { AnimalId = 7, PictureName = "Sailfish.jpg", Name = "Sailfish", Age = 1, Description = "A sailfish is a fish of the genus Istiophorus of billfish living in colder areas of all Earth's seas, which holds the record for the fastest speed of any of Earth's marine animals. They are predominantly blue to gray in colour and have a characteristic dorsal fin known as a sail, which often stretches the entire length of the back", CatagoryId = 2 },
                new { AnimalId = 8, PictureName = "Striped-marlin.jpeg", Name = "Striped-marlin", Age = 4, Description = "The striped marlin (Kajikia audax) is a species of marlin found in tropical to temperate Indo-Pacific oceans not far from the surface. It is a desirable commercial and game fish with a record weight (in 1982) of over 200 kg (440 lb) and a maximum length of 4.2 m (13.8 ft)", CatagoryId = 2 },
                new { AnimalId = 9, PictureName = "Wahoo.png", Name = "Wahoo", Age = 7, Description = "Wahoo (Acanthocybium solandri) is a scombrid fish found worldwide in tropical and subtropical seas. It is best known to sports fishermen, as its speed and high-quality flesh makes it a prized and valued game fish. In Hawaii, the wahoo is known as ono.[4] The species is sometimes called hoo in the United States", CatagoryId = 2 },
                new { AnimalId = 10, PictureName = "Mako-shark.jpg", Name = "Mako-shark", Age = 3, Description = "The shortfin mako shark /ˈmɑːkoʊ/ (Isurus oxyrinchus), also known as the blue pointer or bonito shark, is a large mackerel shark. It is commonly referred to as the mako shark, as is the longfin mako shark (Isurus paucus).[1][2][3] The shortfin mako can reach a size of 4 m (13 ft) in length", CatagoryId = 2 },
                new { AnimalId = 12, PictureName = "Saltwater-crocodile.jpg", Name = "Saltwater-crocodile", Age = 9, Description = "The saltwater crocodile (Crocodylus porosus) is a crocodilian native to saltwater habitats and brackish wetlands from India's east coast across Southeast Asia and the Sundaic region to northern Australia and Micronesia. It has been listed as Least Concern on the IUCN Red List since 1996. It was hunted for its skin throughout its range up to the 1970s, and is threatened by illegal killing and habitat loss", CatagoryId = 3 },
                new { AnimalId = 13, PictureName = "malayan-water.jpg", Name = "Asian-water-monitor", Age = 5, Description = "The Asian water monitor (Varanus salvator) is a large varanid lizard native to South and Southeast Asia. It is one of the most common monitor lizards in Asia, ranging from coastal northeast India, Sri Lanka, mainland Southeast Asia to Indonesian islands where it lives close to water", CatagoryId = 3 },
                new { AnimalId = 14, PictureName = "green-sea-turtle.jpg", Name = "Green-Sea-Turtle", Age = 2, Description = "The green sea turtle (Chelonia mydas), also known as the green turtle, black (sea) turtle or Pacific green turtle,[3] is a species of large sea turtle of the family Cheloniidae. It is the only species in the genus Chelonia.[4] Its range extends throughout tropical and subtropical seas around the world, with two distinct populations in the Atlantic and Pacific Oceans, but it is also found in the Indian Ocean.", CatagoryId = 3 },
                new { AnimalId = 15, PictureName = "pig-nosed-turtle.jpg", Name = "pig-nosed-turtle", Age = 6, Description = "The pig-nosed turtle (Carettochelys insculpta), also known as the pitted-shelled turtle or Fly River turtle, is a species of turtle native to northern Australia and southern New Guinea.", CatagoryId = 3 },
                new { AnimalId = 16, PictureName = "Mary-river-turtle.jpg", Name = "Mary-river-turtle", Age = 7, Description = "This strange turtle is one of several species of cloaca-breathing turtles, which breathe underwater using specialised glands in their reproductive organs. This allows individuals to remain submerged for up to 72 hours.", CatagoryId = 3 },
                new { AnimalId = 17, PictureName = "Black-footed-Ferret.jpg", Name = "Black-footed-Ferret", Age = 8, Description = "The black-footed ferret is roughly the size of a mink and is similar in appearance to the European polecat and the Asian steppe polecat. It is largely nocturnal and solitary, except when breeding or raising litters.[4][5] Up to 90% of its diet is composed of prairie dogs.", CatagoryId = 4 },
                new { AnimalId = 18, PictureName = "Addax.jpg", Name = "Addax", Age = 7, Description = "The addax (Addax nasomaculatus), also known as the white antelope and the screwhorn antelope, is an antelope native to the Sahara Desert. The only member of the genus Addax, it was first described scientifically by Henri de Blainville in 1816. As suggested by its alternative name, the pale antelope has long, twisted horns – typically 55 to 80 cm (22 to 31 in) in females and 70 to 85 cm (28 to 33 in) in males.", CatagoryId = 4 },
                new { AnimalId = 19, PictureName = "Saola.jpg", Name = "Saola", Age = 9, Description = "The saola (Pseudoryx nghetinhensis), also called spindlehorn, Asian unicorn, or infrequently, Vu Quang bovid, is one of the world's rarest large mammals, a forest-dwelling bovine native to the Annamite Range in Vietnam and Laos. It was described in 1993 following a discovery of remains in Vũ Quang Nature Reserve by a joint survey of the Vietnamese Ministry of Forestry and the World Wide Fund for Nature.", CatagoryId = 4 },
                new { AnimalId = 20, PictureName = "Northern-Bald-Ibis.jpg", Name = "Northern-Bald-Ibis", Age = 5, Description = "The northern bald ibis, hermit ibis, or waldrapp (Geronticus eremita) is a migratory bird found in barren, semi-desert or rocky habitats, often close to running water. This 70–80 cm (28–31 in) glossy black ibis, which, unlike many members of the ibis family, is non-wading, has an unfeathered red face and head, and a long, curved red bill.", CatagoryId = 4 },
                new { AnimalId = 21, PictureName = "American-bison.jpg", Name = "American-bison", Age = 1, Description = "This animal's true name is the American bison, but most people call them buffalo. Bison are the largest terrestrial animal in North America. They can stand up to six feet (1.8 meters) tall. A male can weigh upwards of a ton (900 kilograms), and a female can weigh about 900 pounds (400 kilograms).", CatagoryId = 4 }


            );
            modelBuilder.Entity<Catagory>().HasData(
                new { CatagoryId = 1, Name = "Birds"},
                new { CatagoryId = 2, Name = "Fish"},
                new { CatagoryId = 3, Name = "Reptiles" },
                new { CatagoryId = 4, Name = "Mammals" }
               
                );
            modelBuilder.Entity<Comment>().HasData(
            new { CommentId = 1, AnimalId = 4, CommentText = "fast and amazing BEAST !!!!" },
            new { CommentId = 2, AnimalId = 4, CommentText = "love it." },
            new { CommentId = 3, AnimalId = 4, CommentText = "i wish i was fast like him :/" },
            new { CommentId = 4, AnimalId = 4, CommentText = "just beautiful" },
            new { CommentId = 5, AnimalId = 4, CommentText = "<3333333333" },
            new { CommentId = 6, AnimalId = 1, CommentText = "amazing and friendly!!" },
            new { CommentId = 7, AnimalId = 1, CommentText = "Incredible specie." },
            new { CommentId = 8, AnimalId = 1, CommentText = "ITS SO CHARMING!!!" },
            new { CommentId = 9, AnimalId = 1, CommentText = "how much it costs??" },
            new { CommentId = 10, AnimalId = 1, CommentText = "where i can get me one of those?!" },
            new { CommentId = 12, AnimalId = 2, CommentText = "Mission accomplished. It's classic!" },
            new { CommentId = 13, AnimalId = 2, CommentText = "Slate grey. Trying it now." },
            new { CommentId = 14, AnimalId = 2, CommentText = "Radiant. So magnificent." },
            new { CommentId = 15, AnimalId = 2, CommentText = "Such experience, many background, so magnificent" },
            new { CommentId = 16, AnimalId = 2, CommentText = "Good work you have here." },
            new { CommentId = 17, AnimalId = 2, CommentText = "This notification has navigated right into my heart." },
            new { CommentId = 18, AnimalId = 3, CommentText = "It's engaging not just graceful!" },
            new { CommentId = 19, AnimalId = 3, CommentText = "Let me take a nap... great experience, anyway." },
            new { CommentId = 21, AnimalId = 3, CommentText = "Very thought out! Everything feels nice." },
            new { CommentId = 22, AnimalId = 3, CommentText = "That's radiant and sick =)" },
            new { CommentId = 23, AnimalId = 3, CommentText = "Hero, type, type, shot – cool m8" },
            new { CommentId = 24, AnimalId = 3, CommentText = "I want to learn this kind of gradient! Teach me." },
            new { CommentId = 25, AnimalId = 3, CommentText = "Nice use of turquoise in this spaces :-)" },
            new { CommentId = 26, AnimalId = 3, CommentText = "Please stop!" },
            new { CommentId = 27, AnimalId = 4, CommentText = "Super fabulous concept dude" },
            new { CommentId = 28, AnimalId = 4, CommentText = "I adore your shot :)" },
            new { CommentId = 29, AnimalId = 4, CommentText = "My 32 year old parent rates this animal very strong!!" },
            new { CommentId = 30, AnimalId = 4, CommentText = "You are so inspiring!" },
            new { CommentId = 31, AnimalId = 4, CommentText = "I think I'm crying. It's that strong." },
            new { CommentId = 32, AnimalId = 5, CommentText = "Good m8 I want to make love to the use of shape and layers!" },
            new { CommentId = 33, AnimalId = 5, CommentText = "Killer camera angle!" },
            new { CommentId = 34, AnimalId = 5, CommentText = "Engaging notification :-)" },
            new { CommentId = 35, AnimalId = 5, CommentText = "My 47 year old cousin rates this type very fabulous :)" },
            new { CommentId = 36, AnimalId = 5, CommentText = "Mission accomplished. It's admirable!" },
            new { CommentId = 37, AnimalId = 5, CommentText = "It's magical not just engaging!" },
            new { CommentId = 38, AnimalId = 5, CommentText = "Slick. So incredible." },
            new { CommentId = 39, AnimalId = 5, CommentText = "Designgasmed all over this!" },
            new { CommentId = 40, AnimalId = 6, CommentText = "I admire your design!" },
            new { CommentId = 41, AnimalId = 6, CommentText = "Nice use of contrast in this atmosphere mate" },
            new { CommentId = 42, AnimalId = 6, CommentText = "Such slick." },
            new { CommentId = 43, AnimalId = 6, CommentText = "Style, shape, idea, animation – delightful =)" },
            new { CommentId = 44, AnimalId = 6, CommentText = "These are beastly and admirable dude" },
            new { CommentId = 45, AnimalId = 6, CommentText = "Splendid work you have here." },
            new { CommentId = 46, AnimalId = 6, CommentText = "Yes yes yes yes yes yes." },
            new { CommentId = 47, AnimalId = 6, CommentText = "I want to learn this kind of illustration! Teach me." },
            new { CommentId = 48, AnimalId = 9, CommentText = "Incredibly delightful dude" },
            new { CommentId = 49, AnimalId = 9, CommentText = "This is magical work m8" },
            new { CommentId = 50, AnimalId = 9, CommentText = "Contrast. Designgasmed all over this!" },
            new { CommentId = 51, AnimalId = 9, CommentText = "Truly neat colours dude" },
            new { CommentId = 52, AnimalId = 9, CommentText = "I think I'm crying. It's that good." },
            new { CommentId = 53, AnimalId = 9, CommentText = "Extra thought out! It makes me laugh..." },
            new { CommentId = 54, AnimalId = 9, CommentText = "Let me take a nap... great shot, anyway." },
            new { CommentId = 55, AnimalId = 9, CommentText = "Slick mate I like the use of gradient and layout!" },
            new { CommentId = 56, AnimalId = 14, CommentText = "This spaces has navigated right into my heart." },
            new { CommentId = 57, AnimalId = 14, CommentText = "This job blew my mind." },
            new { CommentId = 58, AnimalId = 14, CommentText = "Just radiant." },
            new { CommentId = 59, AnimalId = 14, CommentText = "Yup." },
            new { CommentId = 60, AnimalId = 14, CommentText = "Such shot, many type, so simple" },
            new { CommentId = 61, AnimalId = 14, CommentText = "Gorgeous colour!!" },
            new { CommentId = 62, AnimalId = 20, CommentText = "I admire your shot dude" },
            new { CommentId = 63, AnimalId = 20, CommentText = "Simple work you have here." },
            new { CommentId = 64, AnimalId = 20, CommentText = "I think I'm crying. It's that admirable." },
            new { CommentId = 65, AnimalId = 20, CommentText = "This is new school." },
            new { CommentId = 66, AnimalId = 20, CommentText = "Navigation, shape, spaces, work – appealing, friend." },
            new { CommentId = 67, AnimalId = 20, CommentText = "Flat design is going to die." }

        );
        }
    }
}
