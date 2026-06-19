# Properties Folder

This folder contains **auto-generated and configuration files** that Visual Studio manages for you. As a beginner, you rarely need to edit these by hand — but it helps to know what each one does.

---

## What's Inside

| File | Purpose |
|------|---------|
| `AssemblyInfo.cs` | Metadata about your program (name, version, copyright) |
| `Resources.resx` | The list of embedded resources (images, audio) in XML format |
| `Resources.Designer.cs` | Auto-generated C# class that lets you access resources in code |
| `Settings.settings` | App settings configuration (not currently used in this project) |
| `Settings.Designer.cs` | Auto-generated C# class for app settings |

---

## File Breakdown

### `AssemblyInfo.cs` — Your App's ID Card

This file tells Windows and .NET basic facts about your program.

```csharp
[assembly: AssemblyTitle("KarGame")]          // Name of the program
[assembly: AssemblyProduct("KarGame")]        // Product name
[assembly: AssemblyCopyright("Copyright © 2025")]
[assembly: AssemblyVersion("1.0.0.0")]        // Version number: Major.Minor.Build.Revision
[assembly: AssemblyFileVersion("1.0.0.0")]
```

**When would you edit this?**
- When you want to update the **version number** after adding new features
- When you want to add your **name or company** to the copyright
- When you right-click the `.exe` → Properties → Details, the info here is what appears

**Version number format: `Major.Minor.Build.Revision`**

| Part | Meaning |
|------|---------|
| Major | Big release (1.0, 2.0) |
| Minor | Small feature addition (1.1, 1.2) |
| Build | Auto-incremented on each build |
| Revision | Patch or hotfix number |

---

### `Resources.resx` — The Resource List

This is an **XML file** that keeps a list of all embedded resources (images, sounds, etc.). You don't edit this directly — Visual Studio updates it automatically when you add files through the Resources editor.

It looks something like this internally:

```xml
<data name="sakura" type="System.Resources.ResXFileRef">
  <value>..\Resources\sakura.jpg;System.Drawing.Bitmap</value>
</data>
<data name="meow" type="System.Resources.ResXFileRef">
  <value>..\Resources\meow.wav;System.IO.MemoryStream</value>
</data>
```

Each entry maps a **name** (like `sakura`) to a **file path** and its **type**.

---

### `Resources.Designer.cs` — Auto-Generated Resource Accessor

This file is **automatically generated** by Visual Studio based on `Resources.resx`. You should **never edit this file manually** — it gets overwritten every time you rebuild.

It creates a `Resources` class with one property per resource:

```csharp
// You can call these anywhere in your code:
Properties.Resources.sakura      // returns a Bitmap (the sakura.jpg image)
Properties.Resources.urkarr      // returns a Bitmap (player car image)
Properties.Resources.enemykarr1  // returns a Bitmap (enemy car image)
Properties.Resources.meow        // returns a Stream (the audio file)
```

**How the game uses it:**

```csharp
// Assign background image to the form
this.BackgroundImage = global::KarGame.Properties.Resources.sakura;

// Assign player car image to a PictureBox
this.pictureBox1.Image = global::KarGame.Properties.Resources.urkarr;
```

---

### `Settings.settings` / `Settings.Designer.cs` — App Settings

These files are for storing **user preferences or configuration values** that can persist between sessions (like volume level, high score, etc.).

In this project, these files exist but are **not currently used**. In a more advanced version of the game, you could use them to save things like:

```csharp
// Save a high score
Properties.Settings.Default.HighScore = 42;
Properties.Settings.Default.Save();

// Load it back later
int savedScore = Properties.Settings.Default.HighScore;
```

---

## Golden Rule for Beginners

> **Never manually edit `*.Designer.cs` files.** They are auto-generated and will be overwritten. Make changes through Visual Studio's UI (Properties tab, Resource editor) and let it update the designer files for you.

The only file in this folder you should edit by hand is `AssemblyInfo.cs` — and only when you want to update version info or copyright.
