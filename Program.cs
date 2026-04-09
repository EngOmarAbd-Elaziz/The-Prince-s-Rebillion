using System;
using System.Collections.Generic;
using System.Threading;

namespace AdventureGame
{
    // بسم الله نبدأ المدعكة
    // OOP: Abstraction & Inheritance (الله يباركلك يا محمد يا مصطفى)
    // Base class for all living entities in the game
    public abstract class Character
    {
        public string? Name { get; set; }
        public int Health { get; set; }
        public bool IsAlive => Health > 0;

        public abstract void ApplyDamage(int amount);
    }

    // احلى مسا على عم عيالى الرملى 
    // OOP: Encapsulation (الله يباركلك يا محمد يا مصطفى تانى)
    // Player class inheriting from Character
    public class Player : Character
    {
        public int Shield { get; set; } = 0;
        public int Coins { get; set; } = 0;
        public int Ammo { get; set; } = 0;
        public int PrisonersRemaining { get; set; } = 25;

        public Player(string name)
        {
            Name = name;
            Health = 50;
        }

        // Custom damage logic to account for the shield
        public override void ApplyDamage(int amount)
        {
            if (Shield >= amount)
            {
                Shield -= amount;
            }
            else
            {
                amount -= Shield;
                Shield = 0;
                Health -= amount;
            }
        }
    }

    // Enemy class inheriting from Character (الله يباركلك يا محمد يا مصطفى كلاكيت تالت مرة)
    public class Enemy : Character
    {
        // Damage boundaries for scalable combat
        // جوى هو اللى علمنى ال Singleton ده
        public int GunDmgMin { get; set; }
        public int GunDmgMax { get; set; }
        public int SwordDmgMin { get; set; }
        public int SwordDmgMax { get; set; }
        public int DefendDmgMin { get; set; }
        public int DefendDmgMax { get; set; }

        public int PlayerGunMin { get; set; }
        public int PlayerGunMax { get; set; }
        public int PlayerSwordMin { get; set; }
        public int PlayerSwordMax { get; set; }

        public override void ApplyDamage(int amount)
        {
            Health -= amount;
        }
    }
    // يارب اكون فهمت صح عبث الداتا استراكتشر
    // Data Structure for Events
    public class RoomEvent
    {
        public required string Description { get; set; }
        public Action<Player, GameEngine>? ExecuteEvent { get; set; }
    }
    // شبيه يونيتي النسخة المصرى (عمر ايديشن)
    // Main Game Engine
    public class GameEngine
    {
        private Player? player;
        private Random rng = new Random();
        private List<RoomEvent>? eventPool;

        public GameEngine()
        {
            InitializeEvents();
        }


        public static void DisplayText(string text)
        {
            Console.WriteLine(text);
            int delay = 2500;
            if (text.Length >= 80) delay = 5000;
            else if (text.Length >= 60) delay = 4000;
            else if (text.Length >= 50) delay = 3500;
            else if (text.Length >= 40) delay = 3000;

            Thread.Sleep(delay);
        }

        private void PauseAndClear()
        {
            Console.WriteLine("\nPress ANY KEY to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        // يتم لغبطة الغرف عشان انا معقد نفسيا
        // Setup the Data Structure for random room generation
        private void InitializeEvents()
        {
            eventPool = new List<RoomEvent>
            {
                new RoomEvent {
                    Description = "You meet one of the guards. Get ready to confront the guard!",
                    ExecuteEvent = (p, engine) => engine.StartBattle(p, engine.CreateGuard())
                },
                new RoomEvent {
                    Description = "You found a treasure chest containing 50 coins and +10 HP.",
                    ExecuteEvent = (p, engine) => { p.Coins += 50; p.Health += 10; }
                },
                new RoomEvent {
                    Description = "You found 5 prisoners and helped them escape.",
                    ExecuteEvent = (p, engine) => { p.PrisonersRemaining = Math.Max(0, p.PrisonersRemaining - 5); }
                },
                new RoomEvent {
                    Description = "You found +5 ammo and +15 shield.",
                    ExecuteEvent = (p, engine) => { p.Ammo += 5; p.Shield += 15; }
                },
                new RoomEvent {
                    Description = "You meet a wild animal, prepare to fight!",
                    ExecuteEvent = (p, engine) => engine.StartBattle(p, engine.CreateGuard(isAnimal: true))
                }
            };
        }


        // بداية القصة والمقدمة بتاعت اللعبة
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("Queen : Good morning, prince");
            Console.Write("--> Enter Your Name: ");
            string name = Console.ReadLine() ?? "Prince";
            player = new Player(name);

            Console.Clear();
            Console.WriteLine($"{player.Name} : Good morning, mom");
            PauseAndClear();

            Console.WriteLine($"{player.Name} : [A normal day like any other day]");
            Console.WriteLine($"{player.Name} : [Since my father ruled the town]");
            Console.WriteLine($"{player.Name} : [and it has been in a state of destruction and injustice]");
            PauseAndClear();

            Console.WriteLine($"{player.Name} : Today is the promised day");
            PauseAndClear();

            DisplayText("Queen : Keep in mind what you are intending to do, this is very dangerous");
            Console.Clear();
            DisplayText("Queen : If this matter fails, your father will become very angry and may sentence you to death");
            Console.Clear();

            Console.WriteLine($"{player.Name} : I will never accept injustice, and the coup will happen today");
            PauseAndClear();
            // هنا انت بتتعصب وتبدأ القصة تسخن وتحلو
            DisplayText("The prince angrily puts on his uniform and leaves the palace.");
            Console.Clear();
            DisplayText("The king is so cold he doesn't care about Anything.");
            DisplayText("He has a very strong ego, controls the people and does not care about them.");
            DisplayText("The people are angry and ready to sacrifice anything to stop the king.");
            Console.Clear();

            Console.WriteLine($"{player.Name} goes to the hideout to meet the campaign members and the seller.");
            Console.WriteLine(new string('=', 68));
            Console.WriteLine($"{player.Name} : Do you have some dragon fruit?");
            PauseAndClear();

            DisplayText("The Seller : I don't know, come and take a look in the store.");
            Console.Clear();
            Console.WriteLine($"{player.Name} : Well, quickly, because the king is waiting.");
            Thread.Sleep(2000);
            Console.WriteLine($"{player.Name} : [Normally, the seller does not sell Devil Fruits]");
            Console.WriteLine($"{player.Name} : [but it is just a password so that we can enter the hideout]");
            PauseAndClear();

            DisplayText("The prince enters the hideout to meet the organization group.");
            Console.WriteLine(new string('=', 68));
            DisplayText("Ash : This is the first time you've come early. You look so excited today.");
            Console.Clear();
            DisplayText("Loge : We need to talk quickly before anyone comes.");
            Console.Clear();
            Console.WriteLine($"{player.Name} : Of course I am prepared for everything.");
            PauseAndClear();

            DisplayText("Tom : We must wait for all members today, there cannot be any mistake.");
            DisplayText("Tom : Thus the king's assistant remains and we will be complete.");
            Console.Clear();
            Console.WriteLine($"{player.Name} : Okay, but does anyone know why he was late??");
            PauseAndClear();

            DisplayText("King's assistant : Sorry for being late! >:) ");
            DisplayText("I HAVE SOMEONE WHO WANTS TO JOIN US!! >:)");
            Console.Clear();
            DisplayText("Loud noise outside the bunker!!!!");
            Console.Clear();
            DisplayText("Loge : WHAT IS HAPPENING !!!");
            Console.Clear();
            DisplayText("Tom : We are being betrayed.");
            Console.Clear();

            DisplayText("The king enters with his entourage of soldiers.");
            Console.WriteLine(new string('=', 68));
            DisplayText("The King : Well, well, well.");
            DisplayText("I expected that I would be betrayed because of my injustice...");
            DisplayText("but by my son!!");
            DisplayText("I will make an example of you and your group. Soldiers, arrest them!");
            Console.Clear();
            // عشان تعرفوا انا قد ايه Content Creator محترف
            DisplayText("What happened after that was...");
            DisplayText("The king tortured the prince and his group in front of the Public.");
            DisplayText("The people's anger turned into fear.");
            DisplayText("If he did this to his son, what could he do to the general public?");
            DisplayText("The prince was sentenced to death on the Prisoners' Island.");
            Console.Clear();

            DisplayText("\n\n\n\t\t\tBUT THIS IS NOT THE END OF THE STORY");
            Console.Clear();
            DisplayText("\n\n\n\t\t\t\t\tJUST THE START");
            Console.Clear();

            // Transition to Gameplay
            if (ShipGameplay() == 0)
            {
                DisplayText("Jack : So you beat The captain of the ship.");
                DisplayText("Jack : And all of the prisoners have controlled the ship.");
                DisplayText("Jack : You are the Captain right now.");
                Console.WriteLine($"{player.Name} : We have to go back to town to fight the King.");
                PauseAndClear();

                DisplayText("In the end, the Prince made it to the town to fight the King.");
                DisplayText("He succeeded in uniting the people against the king and his soldiers.");
                DisplayText("And he was finally ready to face the king with a new sword and gun.");

                // i wanna die btw
                // Power up for final boss
                player.Health = 100;
                player.Shield = 200;
                player.Ammo = 50;
                Console.Clear();

                StartBattle(player, CreateKing());
            }
        }

        private int ShipGameplay()
        {
            if (player == null) return -1;

            DisplayText("You are on a ship on its way to Prisoner Island.");
            DisplayText("Chained in iron with a stranger.");
            DisplayText("What will you do ??");
            Console.WriteLine(new string('=', 68));

            while (true)
            {
                Console.Clear();
                Console.Write("1- Talk to him, 2- Try to remove the handcuffs ==> ");
                string choice = Console.ReadLine() ?? "";
                Console.Clear();

                if (choice == "1")
                {
                    Console.WriteLine($"{player.Name} : Do you have a Knife ??");
                    PauseAndClear();
                    DisplayText("Prisoner : If YES, I would free myself.");
                    DisplayText("Prisoner : But if we cooperate, we can free ourselves.");
                    DisplayText("Jack : My name is Jack by the way.");
                    Console.WriteLine($"{player.Name} : I'm {player.Name}.");
                    PauseAndClear();
                    DisplayText("You succeeded in breaking the chain.");
                    break;
                }
                else if (choice == "2")
                {
                    DisplayText("There was breaking glass...");
                    DisplayText($"but {player.Name} failed to break the chain.");
                    DisplayText("Prisoner : If we cooperate, we can free ourselves.");
                    DisplayText("Jack : My name is Jack by the way.");
                    Console.WriteLine($"{player.Name} : I'm {player.Name}.");
                    PauseAndClear();
                    DisplayText("You succeeded in breaking the chain.");
                    break;
                }
                else
                {
                    DisplayText("Invalid input. Please try again.");
                    // هقرفكوا عشان انا مش عارف اعمل لوجيك للغلطات دي
                }
            }

            DisplayText("You and Jack found a Sword, it will help in fights.");
            Console.Clear();

            int roomNumber = 0;

            while (player.IsAlive)
            {
                Console.Clear();
                roomNumber++;
                Console.WriteLine($"HP => {player.Health} | Shield => {player.Shield} | Ammo => {player.Ammo} | Coins => {player.Coins} | Tied prisoners => {player.PrisonersRemaining}");
                Console.WriteLine(new string('=', 68));
                DisplayText($"You found room-{roomNumber}!!");

                Console.Write("1- Go to the roof of the ship  2- Enter The Room  3- Skip the room ==> ");
                string choice = Console.ReadLine() ?? "";

                if (choice == "1")
                {
                    if (player.PrisonersRemaining <= 0)
                    {
                        // البوص الكبير (سينيور محمود وانا بهرب منه ومن كورس الجرافيكس)
                        DisplayText("You have to fight the captain of the ship!");
                        bool win = StartBattle(player, CreateCaptain());
                        if (win)
                        {
                            DisplayText("You win the fight!!");
                            return 0; // Success code
                        }
                        return -1; // Loss code
                    }
                    else
                    {
                        DisplayText("Find all Prisoners first!!");
                    }
                }
                else if (choice == "2")
                {
                    if (eventPool != null)
                    {
                        RoomEvent randomEvent = eventPool[rng.Next(eventPool.Count)];

                        // Logic check for empty rooms
                        if (randomEvent.Description.Contains("prisoners") && player.PrisonersRemaining <= 0)
                        {
                            DisplayText("Empty room!!");
                        }
                        else
                        {
                            DisplayText(randomEvent.Description);
                            randomEvent.ExecuteEvent?.Invoke(player, this);
                        }
                    }
                }
                else if (choice == "3")
                {
                    continue;
                }
                else
                {
                    DisplayText("Invalid input. Please try again.");
                }
            }
            return -1;
        }

        // Master Combat System وحسبى الله

        private bool StartBattle(Player p, Enemy e)
        {
            Console.Clear();
            while (p.IsAlive && e.IsAlive)
            {
                DisplayText($"Your HP => {p.Health} | Shield => {p.Shield} | Ammo => {p.Ammo}");
                DisplayText($"{e.Name} HP => {e.Health}");
                Console.WriteLine(new string('=', 68));
                Console.Write("1- Use Gun  2- Use Sword  3- Defend ==> ");
                string choice = Console.ReadLine() ?? "";

                int playerDmg = 0;
                int enemyDmg = 0; //متاخدش فى بالك انا هوظفها قريب

                if (choice == "1")
                {
                    if (p.Ammo <= 0)
                    {
                        DisplayText("You don't have Ammo!!");
                        Console.Clear();
                        continue;
                    }
                    p.Ammo--;
                    playerDmg = rng.Next(e.PlayerGunMin, e.PlayerGunMax + 1);
                    enemyDmg = rng.Next(e.GunDmgMin, e.GunDmgMax + 1);
                }
                else if (choice == "2")
                {
                    playerDmg = rng.Next(e.PlayerSwordMin, e.PlayerSwordMax + 1);
                    enemyDmg = rng.Next(e.SwordDmgMin, e.SwordDmgMax + 1);
                }
                else if (choice == "3")
                {
                    enemyDmg = rng.Next(e.DefendDmgMin, e.DefendDmgMax + 1);
                }
                else { continue; }

                e.ApplyDamage(playerDmg);
                p.ApplyDamage(enemyDmg);

                if (!p.IsAlive)
                {
                    DisplayText("You were defeated in battle. Game over.");
                    return false;
                }
                else if (!e.IsAlive)
                {
                    if (e.Name == "The King")
                    {
                        DisplayText("You defeated the King!");
                        Console.Clear();
                        DisplayText("\n\n\n\t\t\t\t\tYou WIN !!!");
                    }
                    else
                    {
                        DisplayText($"You defeated {e.Name} and gained 5 coins + 3 shield.");
                    }
                    p.Shield += 3;
                    p.Coins += 5;
                    return true;
                }
                Console.Clear();
            }
            return false;
        }

        // Enemy Factory Methods
        private Enemy CreateGuard(bool isAnimal = false) => new Enemy
        {
            Name = isAnimal ? "Wild Animal" : "Guard",
            Health = rng.Next(25, 36),
            GunDmgMin = 5,
            GunDmgMax = 10,
            SwordDmgMin = 8,
            SwordDmgMax = 14,
            DefendDmgMin = 0,
            DefendDmgMax = 4,
            PlayerGunMin = 20,
            PlayerGunMax = 25,
            PlayerSwordMin = 10,
            PlayerSwordMax = 15
        };

        private Enemy CreateCaptain() => new Enemy
        {
            Name = "Ship Captain",
            Health = 80,
            GunDmgMin = 5,
            GunDmgMax = 10,
            SwordDmgMin = 8,
            SwordDmgMax = 14,
            DefendDmgMin = 0,
            DefendDmgMax = 4,
            PlayerGunMin = 20,
            PlayerGunMax = 25,
            PlayerSwordMin = 10,
            PlayerSwordMax = 15
        };

        private Enemy CreateKing() => new Enemy
        {
            Name = "The King",
            Health = 400,
            GunDmgMin = 15,
            GunDmgMax = 30,
            SwordDmgMin = 14,
            SwordDmgMax = 28,
            DefendDmgMin = 0,
            DefendDmgMax = 4,
            PlayerGunMin = 30,
            PlayerGunMax = 50,
            PlayerSwordMin = 20,
            PlayerSwordMax = 40
        };
    }

    // Application Entry Point
    class Program
    {
        static void Main(string[] args)
        {
            GameEngine engine = new GameEngine();
            engine.Start();
        }
    }
}
// 
// 
// 
// 
// 
// لازم 500 سطر عشان انا مبحبش الارقام الكسر دى