# KarGame — Car Dodge Game

A Windows Forms car dodge game built in C# where you navigate your car through oncoming traffic for as long as possible. The longer you survive, the higher your score.

---

## Features

- **Splash screen** with a full-screen background and a PLAY button to start
- **Arrow key controls** — move your car Left, Right, Up, and Down
- **3 enemy cars** that spawn from the top and scroll down at increasing speed
- **Progressive difficulty** — speed increases every 10 seconds (up to 3 times)
- **Live HUD** — displays your current score and elapsed time during gameplay
- **Collision detection** — game ends immediately when your car hits an enemy
- **Game Over screen** — shows your final score, duration, timestamp, and a randomly selected snarky message
- **Retry button** — resets and restarts the game instantly
- **Background music** — looping `meow.wav` audio via Windows Media Player

---

## Controls

| Key         | Action        |
|-------------|---------------|
| `Arrow Up`    | Move car up    |
| `Arrow Down`  | Move car down  |
| `Arrow Left`  | Move car left  |
| `Arrow Right` | Move car right |

---

## How to Run

**Requirements:**
- Windows OS
- .NET Framework (4.x or compatible)
- Visual Studio 2017 or later

**Steps:**
1. Open `CarGame.sln` in Visual Studio
2. Build the solution (`Ctrl+Shift+B`)
3. Run (`F5`) or launch `KarGame\bin\Debug\KarGame.exe` directly

---

## Project Structure

```
KarGame/
├── Form1.cs              # Core game logic (movement, collision, scoring, UI states)
├── Form1.Designer.cs     # Auto-generated UI layout
├── Program.cs            # App entry point
├── Resources/
│   ├── urkarr.png        # Player car image
│   ├── urkarr1.png       # Player car alternate image
│   ├── enemykarr.png     # Enemy car image
│   ├── enemykarr1.png    # Enemy car alternate image
│   ├── sakura.jpg        # Game background
│   ├── StartBG.png       # Splash screen background
│   ├── meow.wav          # Background music
│   └── Levi.mp3          # Additional audio asset
packages/
├── Guna.UI2.WinForms     # UI component library
└── Guna.Charts.WinForms  # Chart library (included as dependency)
CarGame.sln               # Visual Studio solution file
```

---

## Gameplay Output

```
╔══════════════════════════════════════════╗
║  Car Game        Time: 12.4s   Score: 12 ║
╠══════════════════════════════════════════╣
║                                          ║
║         [enemy]                          ║
║                   [enemy]                ║
║                                          ║
║       [enemy]                            ║
║                                          ║
║              [YOU]                       ║
╚══════════════════════════════════════════╝

        --- On collision ---

╔══════════════════════════════════════════╗
║               Car Game                   ║
║               Game Over                  ║
║                                          ║
║           Duration: 12.4s                ║
║           Your Score: 12                 ║
║                                          ║
║       "Please get a Driver's License"    ║
║                                          ║
║        Lost at: 2026-06-19 14:32:07      ║
║                                          ║
║              [ Retry ]                   ║
╚══════════════════════════════════════════╝
```

---

## Speed Progression

| Time Elapsed | Enemy Speed |
|-------------|-------------|
| 0 – 9s      | 5 px/tick   |
| 10 – 19s    | 10 px/tick  |
| 20 – 29s    | 15 px/tick  |
| 30s+        | 20 px/tick  |

---

## Dependencies

| Package | Version | Purpose |
|---------|---------|---------|
| `Guna.UI2.WinForms` | 2.0.4.7 | UI components |
| `Guna.Charts.WinForms` | 1.1.0 | Charting library |
| `WMPLib` (COM) | — | Background music playback |
