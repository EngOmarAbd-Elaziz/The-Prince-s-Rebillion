import numbers
import time
import random
import os

# Global Variables

prisoners = 25
health = 50
shield = 0
coins = 0
ammo = 0


# a Func to help at Telling stories With time
def display_text(text):

    # Commands to see the appropriate time to read the sentence

    if len(text) >= 80:
        print(text)
        time.sleep(5)
    elif len(text) >= 60:
        print(text)
        time.sleep(4)
    elif len(text) >= 50:
        print(text)
        time.sleep(3.5)
    elif len(text) >= 40:
        print(text)
        time.sleep(3)
    else:
        print(text)
        time.sleep(2.5)


# Func that display events
def Data_events():
    events = [
        "You meet one of the guards. Get ready to confront the guard",
        "You found a treasure chest containing 50 coins and +10 HP",
        "You found 5 prisoners and helped them escape",
        "You found a +5 ammo and +15 shield",
        "You meet a wild animal, prepare to fight",
    ]
    return random.choice(events)


# The Game Battle Func
def TheBattle():

    global health
    global shield
    global coins
    global ammo

    # Random so that the enemy's blood changes every time
    Guard_hp = random.randint(25, 35)
    os.system("cls")
    while True:

        display_text(f"Your HP =>{health} ,Shield =>{shield} ,Ammo => {ammo}")
        display_text(f"Anime HP =>{Guard_hp}")
        print("====================================================================")

        choose = input("1- use the gun , 2- use the Sword , 3- Defend ==>")

        if choose == "1":
            if ammo == 0:
                display_text("You don't have Ammo!!")
                os.system("cls")
                continue
            else:
                ammo -= 1
                Guard_hp -= random.randint(20, 25)
                Lose_hp = random.randint(5, 10)
                # Make sure you get a cut from the shield instead of health
                if shield == 0:
                    health -= Lose_hp
                elif shield > Lose_hp:
                    shield -= Lose_hp
                else:
                    Lose_hp -= shield
                    shield = 0
                    health -= Lose_hp

        elif choose == "2":
            Guard_hp -= random.randint(10, 15)
            Lose_hp = random.randint(8, 14)
            # Make sure you get a cut from the shield instead of health
            if shield == 0:
                health -= Lose_hp
            elif shield > Lose_hp:
                shield -= Lose_hp
            else:
                Lose_hp -= shield
                shield = 0
                health -= Lose_hp

        elif choose == "3":
            Lose_hp = random.randint(0, 4)
            # Make sure you get a cut from the shield instead of health
            if shield == 0:
                health -= Lose_hp
            elif shield > Lose_hp:
                shield -= Lose_hp
            else:
                Lose_hp -= shield
                shield = 0
                health -= Lose_hp

        # Chick if you lose or Not
        if health <= 0:
            display_text("You were defeated in battle. Game over.")
            return -1
        elif Guard_hp <= 0:
            display_text("You defeated the monster and gained 5 coins + 3 shield")
            shield += 3
            coins += 5
            break

        os.system("cls")


# Boss Fight Func
def POSS_Fight():

    global health
    global shield
    global coins
    global ammo
    Guard_hp = 80
    os.system("cls")
    while True:

        display_text(f"Your HP =>{health} ,Shield =>{shield} ,Ammo => {ammo}")
        display_text(f"Anime HP =>{Guard_hp}")
        print("====================================================================")

        choose = input("1-use the gun , 2-use the Sword , 3-Defend ==>")

        if choose == "1":
            if ammo == 0:
                display_text("You don't have Ammo!!")
                os.system("cls")
                continue
            else:
                ammo -= 1
                Guard_hp -= random.randint(20, 25)
                Lose_hp = random.randint(5, 10)
                if shield == 0:
                    health -= Lose_hp
                elif shield > Lose_hp:
                    shield -= Lose_hp
                else:
                    Lose_hp -= shield
                    shield = 0
                    health -= Lose_hp

        elif choose == "2":
            Guard_hp -= random.randint(10, 15)
            Lose_hp = random.randint(8, 14)
            if shield == 0:
                health -= Lose_hp
            elif shield > Lose_hp:
                shield -= Lose_hp
            else:
                Lose_hp -= shield
                shield = 0
                health -= Lose_hp

        elif choose == "3":
            Lose_hp = random.randint(0, 4)
            if shield == 0:
                health -= Lose_hp
            elif shield > Lose_hp:
                shield -= Lose_hp
            else:
                Lose_hp -= shield
                shield = 0
                health -= Lose_hp

        # Chick if you lose or Not
        if health <= 0:
            display_text("You were defeated in battle. Game over.")
            return -1
        elif Guard_hp <= 0:
            display_text("You defeated the monster and gained 5 coins + 3 shield")
            shield += 3
            coins += 5
            return 0
            break

        os.system("cls")


# King Boss Fight Func
def King_Fight(health, shield, ammo):

    global coins

    Guard_hp = 400
    os.system("cls")
    while True:

        display_text(f"Your HP =>{health} ,Shield =>{shield} ,Ammo => {ammo}")
        display_text(f"King HP =>{Guard_hp}")
        print("====================================================================")

        choose = input("1-use the gun , 2-use the Sword , 3-Defend ==>")

        if choose == "1":
            if ammo == 0:
                display_text("You don't have Ammo!!")
                os.system("cls")
                continue
            else:
                ammo -= 1
                Guard_hp -= random.randint(30, 50)
                Lose_hp = random.randint(15, 30)
                if shield == 0:
                    health -= Lose_hp
                elif shield > Lose_hp:
                    shield -= Lose_hp
                else:
                    Lose_hp -= shield
                    shield = 0
                    health -= Lose_hp

        elif choose == "2":
            Guard_hp -= random.randint(20, 40)
            Lose_hp = random.randint(14, 28)
            if shield == 0:
                health -= Lose_hp
            elif shield > Lose_hp:
                shield -= Lose_hp
            else:
                Lose_hp -= shield
                shield = 0
                health -= Lose_hp

        elif choose == "3":
            Lose_hp = random.randint(0, 4)
            if shield == 0:
                health -= Lose_hp
            elif shield > Lose_hp:
                shield -= Lose_hp
            else:
                Lose_hp -= shield
                shield = 0
                health -= Lose_hp

        if health <= 0:
            display_text("You were defeated in battle. Game over.")
            return -1
        elif Guard_hp <= 0:
            display_text("You defeated the King")
            os.system("cls")
            display_text("\n\n\n\t\t\t\t\tYou WIN !!!")
            shield += 3
            coins += 5
            return 0
            break

        os.system("cls")


# The DisPlayer of the Game
def game_play(Name):

    global health
    global shield
    global coins
    global ammo
    global prisoners

    display_text("You are on a ship on its way to Prisoner Island")
    display_text("Chained in iron with a stranger")
    display_text("What will you do ??")
    print("====================================================================")
    while True:
        os.system("cls")
        Choose_Game = input("1- Talk to him, 2- Try to remove the handcuffs ==> ")
        os.system("cls")
        if Choose_Game == "1":
            print(Name, " : Do you have a Knife ??")
            os.system("pause")
            os.system("cls")
            display_text("Prisoner : If YES, I would free myself")
            display_text("Prisoner : But if we cooperate, we can free ourselves")
            display_text("Jack : My Name is Jack By the way")
            print(Name, " : I'M ", Name)
            os.system("pause")
            os.system("cls")
            display_text("They succeeded in breaking the chain")
            break
            print(
                "===================================================================="
            )

        elif Choose_Game == "2":
            display_text("There was a braking glass")
            display_text(f"but {Name} failed to break the chain")
            display_text("Prisoner :if we cooperate, we can free ourselves")
            display_text("Jack : My Name is Jack By the way")
            print(Name, " : I'M ", Name)
            os.system("pause")
            os.system("cls")
            display_text("They succeeded in breaking the chain")
            break
            print(
                "===================================================================="
            )
        else:
            display_text("Invalid input. Please try again.")
            os.system("CLS")
    display_text("You and Jack Found Sword , it will help at fight")
    os.system("CLS")

    room_Number = 0
    even_num = 0
    while True:
        os.system("cls")
        room_Number += 1
        print(
            f"Your HP =>{health} ,Shield =>{shield} ,Ammo => {ammo} ,coins => {coins} ,A tied prisoner ==> {prisoners}"
        )
        print("====================================================================")
        if health <= 0:
            return -1
        display_text(f"You found room-{room_Number}!!")
        choose = input(
            "1-Go to the roof of the ship -- 2-Enter The Room -- 3-Skip the room ==> "
        )

        if choose == "1":
            if prisoners == 0:
                display_text("You Have to fight The captain of the ship")
                if POSS_Fight() == 0:
                    display_text("You Win the Fight !!")
                    return 0
            else:
                display_text("Find all Prisoners !!")

        elif choose == "2":
            event = Data_events()
            even_num += 1
            if "prisoners" in event and prisoners == 0:
                display_text("Empty room!!")
            else:
                display_text(event)

            if "guards" in event or "animal" in event:
                TheBattle()

            elif "treasure" in event:
                coins += 50
                health += 10
            elif "ammo" in event:
                ammo += 5
                shield += 15
            elif "prisoners" in event and prisoners != 0:
                prisoners -= 5
            os.system("cls")

        elif choose == 3:
            continue
        else:
            display_text("Invalid input. Please try again.")
            os.system("CLS")
            display_text(f"You found room-{room_Number}!!")
        choose = input(
            "1-Go to the roof of the ship -- 2-Enter The Room -- 3-Skip the room ==> "
        )


# the Story Func
def Story():
    print("Queen : Good morning, prince")
    Name = input("-->Enter Your Name: ")
    os.system("CLS")
    print(Name, " : Good morning, mom")
    os.system("PAUSE")
    os.system("CLS")
    print(Name, " :[A normal day like any other day]")
    print(Name, " :[Since my father ruled the town]")
    print(Name, " :[and it has been in a state of destruction and injustice]")
    os.system("PAUSE")
    print(Name, " : Today is the promised day")
    os.system("PAUSE")
    os.system("CLS")
    display_text(
        "Queen : Keep in mind what you are intending to do, this is very dangerous"
    )
    os.system("CLS")
    display_text(
        "Queen : If this matter fails, your father will become very angry from you and may sentence you to death"
    )
    os.system("CLS")
    print(Name, " : I will never accept injustice, and the coup will happen today")
    os.system("PAUSE")
    display_text("The prince angrily puts on his uniform and leaves the palace")
    os.system("CLS")
    display_text("The king is so cold he doesn't care aboutAnything")
    display_text("he has a very strong ego")
    display_text("he controls the people and does not care about them")
    display_text(
        "and the people are very angry and are ready to sacrifice anything to stop the king."
    )
    os.system("CLS")
    print(
        Name,
        " goes to the hideout to meet the members of the campaign and meet the seller",
    )
    print("====================================================================")
    print(Name, " : Do you have some dragon fruit?")
    os.system("PAUSE")
    os.system("CLS")
    display_text("The Seller : I don't know, come and take a look in the store")
    os.system("CLS")
    print(Name, " : Well, quickly, because the king is waiting")
    time.sleep(2)
    print(Name, " : [Normally, the seller does not sell Devil Fruits]")
    print(Name, " : [but it is just a password so that we can enter the hideout]")

    os.system("PAUSE")
    os.system("CLS")
    display_text("The prince enters the hideout to meet the organization group")
    print("====================================================================")
    display_text("Ash : This is the first time you've come early")
    display_text("Ash : You look so excited today")
    os.system("CLS")
    display_text("Loge : We need to talk quickly before anyone comes")
    os.system("CLS")
    print(Name, " : Of course I am prepared for everything")
    os.system("PAUSE")
    os.system("CLS")
    display_text(
        "Tom : We must wait for all the members of the organization today, there cannot be any mistake"
    )
    display_text("Tom : Thus the king's assistant remains and we will be complete")
    os.system("CLS")
    print(Name, " : Okay, but does anyone know why he was late??")
    os.system("PAUSE")
    os.system("CLS")
    display_text("King assistant : Sorry for being late ! >:) ")
    display_text("I HAVE SOME ONE WHO WANT TO JOIN US !! >:)")
    os.system("CLS")
    display_text("Loud noise outside the bunker!!!!")
    os.system("CLS")
    display_text("Loge : WHAT IS HAPPENING !!!")
    os.system("CLS")
    display_text("tom : We are being betrayed")
    os.system("CLS")
    display_text("The king enters with his entourage of soldiers")
    print("====================================================================")
    display_text("The King : Well,well,well")
    display_text("I expected that I would be betrayed because of my injustice")
    display_text("but by my son!!")
    display_text("will make an example of you and your group.")
    display_text("Soldiers, arrest them")
    os.system("CLS")
    display_text("What happened after that was")
    display_text("the king tortured the prince and his group")
    display_text("in front of the Public")
    display_text("The people's anger turned into fear")
    display_text("If he did this to his son")
    display_text("what could he do to the general public?")
    display_text("The prince was sentenced to death on the Prisoners' Island")
    os.system("CLS")
    display_text("\n\n\n\t\t\tBUT THIS IS NOT THE END OF THE STORY")
    os.system("CLS")
    display_text("\n\n\n\t\t\t\t\tJUST THE START")
    os.system("cls")

    os.system("cls")

    if game_play(Name=Name) == 0:
        display_text("Jack : So you beat The captain of the ship")
        display_text("Jack : and all of the prisoners Have controlled the ship")
        display_text("Jack : You are the Captain Right now")
        print(Name, " : We Have to back to town to fight the King")
        os.system("pause")
        os.system("cls")
        display_text(
            "In the End the Prince have make it to the town and have to fight the King"
        )
        display_text("He succeeded in bringing together the system")
        display_text("and uniting the people against the king and his soldiers")
        display_text(
            "And he was finally ready to face the king with ammo and a new sword and Gun"
        )

        health = 100
        shield = 200
        ammo = 50
        os.system("cls")
        King_Fight(health, shield, ammo)


Story()