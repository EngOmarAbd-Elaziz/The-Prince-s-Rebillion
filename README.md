🎮 The Prince’s Rebellion

A text-based adventure RPG built in Python & C#, focusing on story-driven gameplay, turn-based combat, and object-oriented design.

📖 About the Game

The Prince’s Rebellion is a narrative-driven RPG where you play as a prince who rises against an oppressive king.

After being betrayed and imprisoned, the prince must survive a dangerous journey on a prison ship, fight guards, rescue prisoners, and eventually face the king himself in an epic final battle.

Every decision matters — and every room could be your last.

⚔️ Gameplay Features
🎭 Story-driven progression with immersive narrative
⚔️ Turn-based combat system (Gun / Sword / Defend)
🎲 Random event generation per room
🧠 Resource management:
Health
Shield
Ammo
Coins
👥 Prisoner rescue mechanic
🧩 Multiple enemy types:
Guards
Wild animals
Ship captain
The King (Final Boss)
🏗️ Architecture Highlights
Python Version
Procedural design
Global state management
Event-based room system
Randomized combat mechanics
C# Version
Fully OOP-based design
Clean separation of responsibilities:
Character (Abstract Base Class)
Player
Enemy
GameEngine
RoomEvent
Encapsulation of combat logic
Scalable enemy factory system
🔥 Combat System

Each battle is turn-based:

Players can choose:

🪖 Gun attack (uses ammo, high damage)
⚔️ Sword attack (balanced damage)
🛡️ Defend (reduces incoming damage)

Enemies respond with randomized damage based on type and difficulty.

🧭 Game Flow
Intro story (betrayal & imprisonment)
Prison ship survival phase
Room exploration system (random events)
Captain boss fight
Liberation of prisoners
Final return to the kingdom
Epic battle vs The King
🧪 Tech Stack
Python 3.x (CLI Game Version)
C# (.NET Console Application)
Randomized procedural logic
Console-based UI system
🚀 How to Run
Python Version
python main.py
C# Version
dotnet run
🎯 Learning Goals

This project was built to practice:

Object-Oriented Programming (OOP)
Game loop design
State management
Random event systems
Console-based game development
Clean architecture thinking
💡 Future Improvements
Add inventory system
Add save/load system
Add UI (Unity or WPF version)
Add sound effects & animations
Add multiple endings
Upgrade combat to skill-based system
🧠 Notes

This project started as a simple idea and evolved into a full narrative-driven game experiment combining storytelling + programming logic.

🏁 Status

🚧 Work in progress — but fully playable core loop implemented.
