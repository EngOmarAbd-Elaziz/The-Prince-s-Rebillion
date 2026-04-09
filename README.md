# 🎮 The Prince’s Rebellion

> A text-based adventure RPG built in **Python & C#**, focusing on story-driven gameplay, turn-based combat, and object-oriented design.

---

## 📖 About the Game

**The Prince’s Rebellion** is a narrative-driven RPG where you play as a prince who rises against an oppressive king.

After being betrayed and imprisoned, the prince must survive a dangerous journey on a prison ship, fight guards, rescue prisoners, and eventually face the king himself in an epic final battle.

> ⚠️ Every decision matters — and every room could be your last.

---

## ⚔️ Gameplay Features

* 🎭 Story-driven progression with immersive narrative
* ⚔️ Turn-based combat system *(Gun / Sword / Defend)*
* 🎲 Random event generation per room

### 🧠 Resource Management

* ❤️ Health
* 🛡️ Shield
* 🔫 Ammo
* 💰 Coins

### 👥 Game Mechanics

* 👥 Prisoner rescue system

### 🧩 Enemy Types

* 🪖 Guards
* 🐺 Wild animals
* 🧑‍✈️ Ship captain
* 👑 The King *(Final Boss)*

---

## 🏗️ Architecture Highlights

### 🐍 Python Version

* Procedural design
* Global state management
* Event-based room system
* Randomized combat mechanics

### 💻 C# Version

* Fully OOP-based design

#### 🔹 Core Components

* `Character` *(Abstract Base Class)*
* `Player`
* `Enemy`
* `GameEngine`
* `RoomEvent`

#### 🔹 Key Concepts

* Encapsulation of combat logic
* Scalable enemy factory system

---

## 🔥 Combat System

Each battle is **turn-based**:

### 🎮 Player Actions

1. 🪖 **Gun Attack** → Uses ammo, high damage
2. ⚔️ **Sword Attack** → Balanced damage
3. 🛡️ **Defend** → Reduces incoming damage

> ⚡ Enemies respond with randomized damage based on their type and difficulty.

---

## 🧭 Game Flow

```text
Intro Story
   ↓
Prison Ship Survival
   ↓
Room Exploration (Random Events)
   ↓
Captain Boss Fight
   ↓
Rescue Prisoners
   ↓
Return to Kingdom
   ↓
Final Battle vs The King
```

---

## 🧪 Tech Stack

* 🐍 Python 3.x *(CLI Game Version)*
* 💻 C# (.NET Console Application)
* 🎲 Randomized procedural logic
* 🖥️ Console-based UI

---

## 🚀 How to Run

### 🐍 Python Version

```bash
python main.py
```

### 💻 C# Version

```bash
dotnet run
```

---

## 🎯 Learning Goals

This project was built to practice:

* 🧠 Object-Oriented Programming (OOP)
* 🔄 Game loop design
* 📊 State management
* 🎲 Random event systems
* 🖥️ Console-based game development
* 🏗️ Clean architecture thinking

---

## 💡 Future Improvements

* 🎒 Add inventory system
* 💾 Add save/load system
* 🎮 Add UI *(Unity or WPF version)*
* 🔊 Add sound effects & animations
* 🧩 Add multiple endings
* ⚔️ Upgrade combat to skill-based system

---

## 🧠 Notes

> This project started as a simple idea and evolved into a full narrative-driven game experiment combining storytelling with programming logic.

---

## 🏁 Status

🚧 **Work in Progress** — but the core gameplay loop is fully playable.

---

## 📄 Documentation

A detailed report explaining the design decisions, architecture, and evolution of the project:

👉 [Download Project Report](./docs/Prince-Rebellion-Report.pdf)
