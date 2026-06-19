# Resources Folder

This folder holds all the **media files** (images, audio) used by the game. Think of it as the game's art and sound cabinet.

---

## What's Inside

| File | Type | Used For |
|------|------|----------|
| `urkarr.png` | Image | The **player's car** displayed on screen |
| `urkarr1.png` | Image | Alternate/background layer of the player's car |
| `enemykarr.png` | Image | Enemy car sprite |
| `enemykarr1.png` | Image | Enemy car sprite used as the background layer |
| `sakura.jpg` | Image | The **main game background** (a sakura/cherry blossom scene) |
| `StartBG.png` | Image | The **splash/start screen background** shown before you click PLAY |
| `meow.wav` | Audio | **Background music** that loops while you play |
| `Levi.mp3` | Audio | Additional audio asset |

---

## How These Files Get Into the Game

You don't load these files manually with a file path. Instead, Visual Studio **embeds them directly into the program** when you build it. That means the images and sounds travel with the `.exe` file — no loose files needed at runtime.

### How to add a resource in Visual Studio:

1. Right-click your project → **Properties**
2. Go to the **Resources** tab
3. Click **Add Resource → Add Existing File**
4. Select your image or audio file

Once added, you can access it in code like this:

```csharp
// Access an image resource
pictureBox1.Image = Properties.Resources.urkarr;

// Access an audio resource (as a stream)
System.IO.Stream audioStream = Properties.Resources.meow;
```

> The `Properties.Resources` class is **auto-generated** by Visual Studio. Every file you add here gets a matching property in `Properties/Resources.Designer.cs` automatically.

---

## How the Game Uses These Files

### Images — assigned to `PictureBox` controls

```csharp
// Player car (in Form1.Designer.cs)
this.pictureBox1.Image = global::KarGame.Properties.Resources.urkarr;

// Enemy car background
this.pictureBox2.BackgroundImage = global::KarGame.Properties.Resources.enemykarr1;

// Game background
this.BackgroundImage = global::KarGame.Properties.Resources.sakura;
```

### Audio — played via Windows Media Player

```csharp
// In Form1.cs — plays meow.wav on loop
WindowsMediaPlayer player = new WindowsMediaPlayer();
player.URL = "meow.wav";
player.settings.setMode("loop", true);
player.controls.play();
```

> Note: `player.URL = "meow.wav"` loads from the **output directory** (`bin/Debug/`), not this Resources folder directly. The file is copied there automatically on build.

---

## Tips for Beginners

- **Replacing an image?** Just add your new `.png` to this folder via the Resources tab and update the property name reference in code.
- **Supported image types:** `.png`, `.jpg`, `.bmp`, `.gif`
- **Supported audio types for WMPLib:** `.wav`, `.mp3`, `.wma`
- **Keep image sizes consistent** with the `PictureBox` size to avoid stretching. The game uses `ImageLayout.Stretch` so it will auto-scale, but the original dimensions still matter for quality.
