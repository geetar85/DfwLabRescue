using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DfwLabRescue.Web.Models
{
    class DogBuilder
    {
        internal ICollection<Dog> Build()
        {
            return new List<Dog>() {
                new Dog{Id = 1, Name = "Jerry", DateOfBirth = DateTime.Parse("6/15/2008"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Available, 
                    Summary = @"Hi, my name is Jerry, and I am a sweet, laid back boy. Even though I am 6 years old I still like to bounce around and play like a puppy if you will let me. Or, if you prefer, I’ll just sit with my head in your lap and we can relax. I love to be around people and I am a great companion. Although I am a little stubborn every now and then, the majority of the time I will respond right away to the commands I know, which include: ‘here’, ‘sit’, ‘kennel’, ‘down’, and ‘drop’. I love to be petted, and I like to be near you. Even though I weigh 70 lbs, if you let me I will even lay in your lap!",
                    Story=@"<p>Hi, my name is Jerry, and I am a sweet, laid back boy. Even though I am 6 years old I still like to bounce around and play like a puppy if you will let me. Or, if you prefer, I’ll just sit with my head in your lap and we can relax. I love to be around people and I am a great companion. Although I am a little stubborn every now and then, the majority of the time I will respond right away to the commands I know, which include: ‘here’, ‘sit’, ‘kennel’, ‘down’, and ‘drop’. I love to be petted, and I like to be near you. Even though I weigh 70 lbs, if you let me I will even lay in your lap!</p>
<p>One thing that you should know about me is that I do not do very well around other dogs, as I prefer to be around my human friends instead. I behave well around humans of all ages and sizes. I have lived with a cat before, and I did not mind her at all, but she was smart enough not to run, because if she did I would probably chase her. I have a lot of fun chasing small animals, especially rabbits (and I have caught several of them!). Also, since I think everything is ‘mine’, it is hard for me to remember not to ‘mark’ things that really do not belong to me. I don’t mind spending time in my kennel, and will do so when told, although I would rather be with my humans. (If you do put me in a kennel, it needs to be the sturdy kind, because I am strong enough to break out of the mesh kind!)</p>
<p>I enjoy going for walks, I love to play fetch (even though sometimes I don’t want to give the ball back!), and I can even catch a Frisbee in the air! I am very athletic, and I can jump very high. In fact, all you have to do to get me to jump is say the word ‘outside’, and I will fly to the back door and bounce up and down like a pogo stick! I love the outdoors and I enjoy swimming.</p>", 
                    Photo1 = "/assets/img/dogs/DSC_0005.JPG", 
                    Photo2="/assets/img/dogs/DSC_0004.JPG", 
                    Photo3="/assets/img/dogs/DSC_0006.JPG"},
                new Dog{Id = 2, Name = "Shot Gun", DateOfBirth = DateTime.Parse("7/25/2010"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Available, 
                    Summary=@"Shot Gun here and I am a 4.5 yr old chocolate boy and I am loving my life now.  Well, I am a lucky boy because I have had the opportunity to live with two Foster families since I joined DFWLab Rescue.",
                    Story=@"<p>Shot Gun here and I am a 4.5 yr old chocolate boy and I am loving my life now.  Well, I am a lucky boy because I have had the opportunity to live with two Foster families since I joined DFWLab Rescue.</p>
 
<p>My first foster family nursed me back to health.  You see my family was “Moving” and I really wanted to go with them but it was the shelter for me.  After a few days I started a mild cough so had to be rescued or else.  I was very lucky when DFWLab Rescue came for me.  I went to the vet and became very sick and had to stay with them for a month while fighting for my life.  I am a survivor and fought a hard battle.  I am now very healthy and now I have to watch my diet so I don’t eat too much.  I loved hanging out with the guys to watch football and I will be a great football companion as I love to watch TV and I do pay full attention to what happens in that big box.  Sometimes if the channel is on Animal Planet I try to talk to the barking dogs but they don’t hear me. 
I like to bark at the dogs that are on TV.   I do have a manly loud bark when someone knocks at the door to alarm and protect my favorite people but greet them with excitement and tail wagging.  I love to play ball and swim in the pool but only on warm days.  I have a foster sister (12), who is old so she ignores me and foster brother (6) not interested in playing with me.  I like dogs but I need to be introduced slowly with both of us on leashes.  I don’t like it when they are too excited and bark at me, I like calm.    So before I went to my second Foster family, I got to spend a few weeks at doggie camp aka ‘Training’ where they taught me commands and worked on my socialization skills around other dogs.  Some of the commands I learned; sit, down, come and stay.  
I will need reinforcement because I do forget them when I get a little excited.  I am good on the leash and love to go for rides in the car.   I am fully potty trained and love my crate but have not had to stay in one since I left camp.  I seem to like humans more so than other dogs but my foster mom is working on teaching me that other dogs are ok. </p>
 
<p>I would prefer to be adopted by a family that has older children since I get stressed with too much excitement and be the only dog or have one submissive dog that is not yappy and can slowly be introduced with leashes.  I am a total cuddle bug and love to sleep in my humans’ bed and keep them warm or cuddle next to you, on the couch, if you’ll let me.  They say I sleep very soundly and don’t move a muscle all night and I have a mild snoring problem and pass occasional gas but it’s all out of love.  Just FYI…I like ice cubes and I am lab so I love food, I will clean your plate for you and I help keep the kitchen floor free from crumbs. </p>", 
                    Photo1 = "/assets/img/dogs/Shot%20Gun%20Update.jpg", 
                    Photo2="/assets/img/dogs/Shotgun%202.jpg", 
                    Photo3="/assets/img/dogs/Shot%20GunA.jpg"},
                new Dog{Id = 3, Name = "Gidget", DateOfBirth = DateTime.Parse("5/20/2011"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Available, 
                    Summary=@"My name is Gidget and I’m a 3.5-year-old, gravity defying 65 pound black lab. I’m house broken and crate trained.  I don’t chew or bother anything that’s not mine.  I get along very well with the giant, twice my size yellow lab named Ellie in my foster home.   I like her a lot more than she likes me. At first, I got the cold shoulder from Ellie. Now she is actively not sharing stuff like bones with me and barking in my face.  That’s a small step away from being bestest buddies.  Next thing you know we will be gossiping about that floozy poodle down the street.  I might even get enough courage to have a frank discussion with Ellie regarding her weight issue-but let’s not get ahead ourselves.",
                    Story=@"<p>My name is Gidget and I’m a 3.5-year-old, gravity defying 65 pound black lab. I’m house broken and crate trained.  I don’t chew or bother anything that’s not mine.  I get along very well with the giant, twice my size yellow lab named Ellie in my foster home.   I like her a lot more than she likes me. At first, I got the cold shoulder from Ellie. Now she is actively not sharing stuff like bones with me and barking in my face.  That’s a small step away from being bestest buddies.  Next thing you know we will be gossiping about that floozy poodle down the street.  I might even get enough courage to have a frank discussion with Ellie regarding her weight issue-but let’s not get ahead ourselves.</p>

<p>I was surrendered by my family of three years to the DFW Lab rescue group for repeatedly jumping the fence and “visiting” the neighbor’s cows.  Although I meant no harm, the neighbor did not like it. The cows didn’t say one way or the other.  Anyway, that’s why I’m here and looking for a new home.  Due to some recent unpleasantness, I’m not at my best right now and it’s too soon to talk about. I’m sort of down in dumps.  However, three or four weeks with a loving and patient new family and I will be back in the pink.</p>

<p>Foster Dad:  Gidget is a sweet and loving dog that will make a wonderful companion- low maintenance, wash and wear. She needs a family with the patience and understanding to restore her confidence and spirit.  She came to us fearful and shy. However, after only a few days at her foster home some of her spark has returned. </p>

<p>She would do well with another dog and kids.  We don’t know about cats, yet.  She treats the pet box turtles in her foster home with indifference, so I guess they are OK.  Her fence jumping prowess is the one thing that will need to be addressed quickly.  The good news is that a few simple fence modifications should prevent her from making good on any escape attempt.  We feel that in the right home, she will eventually lose her wanderlust.</p>

<p>A few less serious issues will need to be ironed out such as minor counter surfing.  Also, she does not seem to know many basic commands such as sit, stay, come, etc.  These things can be overcome by someone who is willing to invest some time in her.</p>

<p>Gidget rides very well in the car. Also, she seems to like , or at least tolerate, foster dad’s guitar and piano playing.  The lab in residence holds a dissenting opinion, but let us not speak of it again.</p>

<p>Gidget is a dog of few barks- very few barks. In fact, she has yet to utter a single bark or whine since a arriving at her foster home.  That’s O.K., because her soft and longing eyes will tell you everything you need to know.  George Carlin said that life is just a series of dogs.  Gidget is ready to share a chapter of some loving family’s life.  Is it you?</p>", 
                    Photo1 = "/assets/img/dogs/Gidget%201.jpg", 
                    Photo2="/assets/img/dogs/Gidget%202.jpg", 
                    Photo3="/assets/img/dogs/Gidget%203.jpg"},
                new Dog{Id = 4, Name = "Harley Jane", DateOfBirth = DateTime.Parse("6/15/2007"), 
                    Gender = Gender.Female,
                    AdoptionStatus = AdoptionStatus.Available, 
                    Summary=@"Bio Coming Soon!", 
                    Story=@"Bio Coming Soon!", 
                    Photo1 = "/assets/img/dogs/photo%201.JPG", 
                    Photo2="/assets/img/dogs/HJ%202.jpg", 
                    Photo3="/assets/img/dogs/HJ%203.jpg"},
                new Dog{Id = 5, Name = "Jackson5", DateOfBirth = DateTime.Parse("4/7/2009"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Available, 
                    Story=@"Hi there.  My name is Jackson and I am 6 yrs old.  I am writing this to you in hopes of finding my new forever home.  My mom was ill and passed away.  She was able to make sure that I was going to be safe if that day came.  So here I am.  I am very thankful that I ended up in just as caring hands.  I am in a wonderful foster home and I have lots of brothers and sisters.  I can be a little shy with people in the beginning, especially men.  I don’t know why really but men are a little suspicious to me.  I’m working on it though.  
I am not aggressive in any way.  I get along well with other animals…dogs, cats, horses, etc.  I’m a pretty mellow guy.  I love to go for rides in the car.  Actually I love to go anywhere you do.  I will stay home if I have to and don’t worry I won’t hesitate to tell you all about my day and how much I missed you when you get home.  I am house broken and I do not chew on things.  I will occasionally counter surf if something looks interesting but I don’t do that very often.  In the morning I will get up with you and rub my face and eyes all over your legs as you brush your teeth and while you finish getting ready I will go belly up and wait for my belly rub when you are done.  I do have a pretty cute personality when I get comfortable with you.  I hope to find a loving family that is patient and can help me through my shyness and love me for me so that I can love you for you.", 
                    Photo1 = "/assets/img/dogs/Jackson1.jpg", 
                    Photo2="/assets/img/dogs/Jackson2.jpg"},
                new Dog{Id = 6, Name = "Torry Bee", DateOfBirth = DateTime.Parse("6/15/2008"), 
                    Gender = Gender.Female,
                    AdoptionStatus = AdoptionStatus.Available, 
                    Story=@"Tory Bee is one sweet little girl. She is housebroken, crates up well and loves her twice a day walks.  She is good on a leash and likes to be near her humans.  She does get along with her current foster brother but is not too interested in play with him. We're not sure how she is around cats, but believe she would do okay as she does not seem bothered by any small animals she sees while on walks.
 
She loves food but does not counter surf.  She will, however, look at you with those pretty brown eyes (kinda begging) while you eat your meal if you let her.  Tory Bee likes spending time outside soaking up the sun and scratching her back in the grass.  She knows basic commandments, is super smart and a fast learner.
 
One lucky family is going to be very fortunate to adopt this little gem.", 
                    Photo1 = "/assets/img/dogs/Tory1.jpg", 
                    Photo2="/assets/img/dogs/Tory2.jpg", 
                    Photo3="/assets/img/dogs/toryBee1.jpg"},
                new Dog{Id = 7, Name = "Beau DT6", DateOfBirth = DateTime.Parse("6/15/2012"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.AdoptionPending, 
                    Story=@"<p>Meet Beau! When Beau was just a pup he was dumped in East Texas and lived his life fending for himself.  He settled in a culvert in a development where an owner noticed him and tried to befriend him.  She regularly set food out for him and their dog would play with him.  When they were moving she called Duck Team 6 in to capture him in the hopes of finding him his forever home and he is now with Lab Rescue.</p>

<p>Beau lived feral for many months on his own, and because of that, he is shy and fearful at first.  It takes time for him to gain trust, especially with humans. He tends to bond and gain trust with pets first and people second.  He loves to romp with his foster lab sister and neighbor poodle.  He loves the ladies and is now in a foster home with two males, and learning that they like to go for walks too.  Even better, when he hears them grab the keys, then it means a truck ride!</p>

<p>When it is bed time, he hops into place and doesn't move until invited off in the morning.  He is potty trained and doggy door trained.   Walking twice a day in the first two weeks were a way to bond and it made him so happy to be outside. Sounds do not scare him, but sudden movements do, and he never met a ceiling fan that he liked.  Beau does have strong prey drive since he had to fend for himself for so long; squirrels and bunnies will get him to stalk and if he sees them at night while walking, he will be mesmerized.  Beau needs a forever family who is patient and can help him learn to trust and love humans even further.</p>

 

<p>Beau's greatest asset is his sweet disposition when you gain his trust.  Through all his fear and being captured, kenneled, fostered, toe nail clippings and twice a month baths, he has never growled or even lifted a lip.  This handsome boy will be a great family dog and would love to have another dog to play with in the house.</p>", 
                    Photo1 = "/assets/img/dogs/Beau%20Face%20Evergreen.jpg", 
                    Photo2="/assets/img/dogs/Beau.jpg", 
                    Photo3="/assets/img/dogs/CouchBeau.jpg"},
                new Dog{Id = 8, Name = "Christian", DateOfBirth = DateTime.Parse("6/15/2009"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Available, 
                    Story=@"Hi guys, my name is Christian.  I am about 5 years old.  I was surrendered to DFW Lab Rescue not too long ago.  I have had a bit of a rough start because I did not know what it was like to live indoors or to be loved on.  My foster parents have really been helpful and patient with me to teach me that I don’t have to be scared anymore and I’m safe with people that really care about me.  They tell me I will never have to live outside again and I will find my very own family who will love me endlessly for the rest of my life.  Don’t get me wrong, I love the outdoors but this whole house thing with my own bed and warm place to sleep when the weather is bad is pretty cool.  I have learned what it is to be loved and I think its really nice when people pet me now.  I’m still a little shy but I am learning very quickly now that life is going to be ok. 
I love my foster brothers and sisters and I get to hang out with them all the time.  They have been very supportive of me have helped me feel very welcome in their family.  I am not a problem in the house whatsoever.  I am house broken and crate trained.  I will bark to let you know if I need to go outside.  I will sometimes bark if I think you are an intruder.  It’s the least I can do for giving me a home and all.  I’m just practicing in case there is ever a real intruder.  I stop when I know its really you.  I think these things call “toys” are the bomb!  I’ve been known to steal an occasional shoe or sock and put it in my crate.  So if you go missing anything you might look there.  I also like to take out my foster brothers bed out of his crate and lay on it in the kitchen.  It’s where I like to hang out a lot of the time.  Why?  Still just a little scared.  I venture through the house when no one is really looking and to find something to comfort me. 
I’m afraid you will have to be very patient with me to help me with my confidence in people.  
My foster parents tell me that I have lots of personality but I just need some help and time to let it come out.  They think the sooner I can find my family and be with them for the rest of my life the better I will be.  I have to say I think they are right.  I’m ready for the next step in my life and would like to find a family that will make me feel safe…and I will make them feel safe.", 
                    Photo1 = "/assets/img/dogs/Christian1.png", 
                    Photo2="/assets/img/dogs/Christian2.jpg", 
                    Photo3="/assets/img/dogs/Christian3.jpg"},
                new Dog{Id = 9, Name = "Joshua", DateOfBirth = DateTime.Parse("1/15/2013"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Available, 
                    Story=@"Hi! My name is Joshua and I am a bundle of excitement. I love playing with my toy hedgehog and rope. When I first got here, there was a lot of snow on the ground and I would run around the backyard as fast as I could. Now that the sun is out, I've just been relaxing in the grass after playing while my mom reads a book on the back porch. They introduced me to a new way to go outside; a doggy door. At first I didn't know what it was but after lots of patience and help from my mom and dad, I am now able to go through it all by myself! I'm still getting used to the crate. I'm okay with staying in there for a little during the day, but after a while, I get a little antsy. Each night, I like to relax with my foster family on the couch and watch TV. They have a pretty comfy couch! I tend to talk a lot when I want to play and I'd like to think that everything in the house is mine. 
I'm working on that with my mom. I love going on walks, but I haven't exactly figured out the whole 'heeling' thing when people are around. I just want to play with everyone! When I'm around other dogs, I get a little scared. Some of them are so big! I haven't been with a cat though. I've only seen them on TV. I love being around people, cuddling, and playing. I can't wait to find my forever home!", 
                    Photo1 = "/assets/img/dogs/Joshua1.jpg", 
                    Photo2="/assets/img/dogs/Joshua2.jpg", 
                    Photo3="/assets/img/dogs/Joshua3.jpg"},
                new Dog{Id = 10, Name = "Linus", DateOfBirth = DateTime.Parse("10/12/2013"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Available, 
                    Story=@"Hi everyone, let me introduce myself! My name is Linus and I’m 9 months of fun loving puppy cuteness!  I’ve been with my foster family now for 12 days and made such great improvements that it’s time to look for my very own forever loving family. 
 
Although I’ve made these great improvements I still have a few puppy things that I need to work on, and with patience and time I know I can do it.  I try very hard not to have accidents in the house but if I do they nearly always happen in my crate (always a #1), especially if you have to leave me alone for a few hours…….(but never a #2).  I do like to go potty often…..puppy bladder!!
I still like my foster mom to hang with me when I’m outside but sometimes I get brave and head out on my own.  After all I do have 2 other dogs in the house to keep me company when I’m out.
 
I like playing with other dogs.  My foster mom says the bigger the better as I like to play hard.  Tender ears are an easy target when you have sharp puppy teeth like me.  I also like to play with the small two legged fosters, I think they call them kids.  They’re so much fun.  I have to be careful not to hurt them with my teeth….but they’re so soft and chewy.  They just laugh…..foster mom doesn’t think it’s funny!!!  I also like to go on the school run in the morning….just to make sure they get there safely!
 
I’m not that keen on the crate but I know it’s a must for someone as young as me.  Anyway, I get a treat every time I have to go in.  And you can’t beat that?  I only use the crate when everyone goes out.  At night I get to sleep on a nice big comfy dog bed.
 
I enjoy a good long walk or even a run.  I’m good on the leash….well as good as you can be when you’re walking with 2 other dogs!  Sometimes it gets a bit disorganized!  I also enjoy playing fetch and chewing on a good Nylabone.
 
I think an ideal family for me would have someone who stays at home for most of the day to love and cuddle with me..  I get a bit lonely when I’m left on my own!  I think it would help me settle in my new home and help with the rest of my house training.", 
                    Photo1 = "/assets/img/dogs/Linus.jpg", 
                    Photo2="/assets/img/dogs/Linus1.jpg", 
                    Photo3="/assets/img/dogs/Linus2.jpg"},
                new Dog{Id = 11, Name = "Carter", DateOfBirth = DateTime.Parse("6/15/2011"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.AdoptionPending, 
                    Story=@"Hi! I'm Carter and even though I'm only 3 years old, the thought of not being with my forever family yet is putting a few gray hairs on my snout! It's okay though, I know someone is waiting to take me in and love on me forever!  I am a perfect mix of puppy and adult. I guess in human speak you would call me your typical teenager.
 
On the puppy side, I am very energetic and I am constantly seeking attention. Sometimes my foster family calls me 'shadow' because I like to go with them wherever they go. I can sit, but I'm not so great at stay yet. My foster family is working with me on 'stay', 'down'  and 'shake'. We are also working on not jumping. I have not yet learned how to keep all four paws on the floor at all times, so I'm not sure I'd be best for families with small children. However, I have not shown any signs of aggression and in addition to what I learn from my foster family, a basic obedience class would be great for me. Because I have a lot of energy, I definitely benefit from daily walks. I would do best with an active family!
 
On the more mature side, I respond to my name and come when I'm called. I am already housebroken and crate trained. I haven't had any accidents in my new foster home. I also sleep great in the crate at night! I walk well on a leash and after my walk, I love to snuggle. If you let me on the sofa, I'll be so happy! I love getting my ears rubbed more than anything in the world and when you're training me to do a trick, I will take treats from you gently. 
 
Basically, I'm an affectionate guy, who loves to be near people and let ou pet my soft, thick coat.  I'm a pretty handsome, happy-go-lucky fella, just looking for my forever family.  Is it you?", 
                    Photo1 = "/assets/img/dogs/Carter1.jpg", 
                    Photo2="/assets/img/dogs/Carter2.jpg", 
                    Photo3="/assets/img/dogs/Carter%203.jpg"},
                new Dog{Id = 12, Name = "Zack", DateOfBirth = DateTime.Parse("6/15/2011"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.ComingSoon, 
                    Story=@"Hold on to your hearts ladies and gentlemen, Zack is in town. This handsome blockhead is such a charmer. He is the best combination of puppy and more mature dog. Zach loves to chase a tennis ball. He is great about bringing it back for you to throw again, but still learning to drop it. He knows sit, stay, (sometimes) down.  He jumped right in our pool and swam around as soon as he saw it.  Zack has great manners and reminds his foster family everyday about the power of a positive attitude. That happy boy wags his tail and smiles no matter what.  He goes in his crate without any hesitation (still wagging that tail). No accidents, no chewing. He needs some more leash practice, but he is a pleaser.
One thing you need to know about Zack is that he does have some allergy issues.  Probably not a huge deal.  He will just require a little extra vet attention, possibly some diet issues.  It will take some time and diligence to figure it out.  Nobody can be completely perfect, right? 
 He gets along with other dogs and is indifferent to our cat (still wagging), but his favorite thing is people. Big, small, it doesn't matter to him. He loves everyone and rewards you with kisses, affection, and did I mention the tail wagging? Zach is one happy, sweet, angel dog.", 
                    Photo1 = "/assets/img/dogs/Zack.jpg", 
                    Photo2="/assets/img/dogs/Zack5.jpg", 
                    Photo3="/assets/img/dogs/Zack3.jpg"},
                new Dog{Id = 13, Name = "Duane", DateOfBirth = DateTime.Parse("6/15/2008"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Adopted, 
                    AdoptionDate = DateTime.Now},
                new Dog{Id = 14, Name = "Jack", DateOfBirth = DateTime.Parse("6/15/2008"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Adopted, 
                    AdoptionDate = DateTime.Now},
                new Dog{Id = 15, Name = "Rufus", DateOfBirth = DateTime.Parse("6/15/2008"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Adopted, 
                    AdoptionDate = DateTime.Now},
                new Dog{Id = 16, Name = "Sonny", DateOfBirth = DateTime.Parse("6/15/2008"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Adopted, 
                    AdoptionDate = DateTime.Now},
                new Dog{Id = 17, Name = "Shadow", DateOfBirth = DateTime.Parse("6/15/2008"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Adopted, 
                    AdoptionDate = DateTime.Now},
                new Dog{Id = 18, Name = "Brenna", DateOfBirth = DateTime.Parse("6/15/2008"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Adopted, 
                    AdoptionDate = DateTime.Now},
                new Dog{Id = 19, Name = "Sparky", DateOfBirth = DateTime.Parse("6/15/2008"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Adopted, 
                    AdoptionDate = DateTime.Now},
                new Dog{Id = 20, Name = "Molly", DateOfBirth = DateTime.Parse("6/15/2008"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Adopted, 
                    AdoptionDate = DateTime.Now},
                new Dog{Id = 21, Name = "Maxwell", DateOfBirth = DateTime.Parse("6/15/2008"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Adopted, 
                    AdoptionDate = DateTime.Now},
                new Dog{Id = 22, Name = "Sasha", DateOfBirth = DateTime.Parse("6/15/2008"), 
                    Gender = Gender.Male,
                    AdoptionStatus = AdoptionStatus.Adopted, 
                    AdoptionDate = DateTime.Now},
            };
        }
    }
}
