<img src="https://raw.github.com/adamscott/OInput/gh-pages/images/OInput.png" height="75px" alt="OInput" title="OInput for Unity3d" />
================

One script to ease input issues with Unity's built-in `Input` class.

### C&#35;
```csharp
void Start() {
	OInput.GetDefaultProfile()
		.SetButton("Jump", "space")
		.SetButton("Fireball", "left ctrl");
}

void Update() {
	if (OInput.GetDefaultProfile().GetButton("Jump")) {
		Debug.Log("The plumber jumps.");
	}
	
	if (OInput.GetDefaultProfile().GetButton("Fireball")) {
		Debug.Log("The plumber throws a fireball.");
	}
}
```

### Unity Script
```javascript
function Start () {
	OInput.GetDefaultProfile()
		.SetButton("Jump", "space")
        .SetButton("Fireball", "left ctrl");
}

function Update () {
	if (OInput.GetDefaultProfile().GetButton("Jump")) {
        Debug.Log("The plumber jumps.");
    }
	
    if (OInput.GetDefaultProfile().GetButton("Fireball")) {
        Debug.Log("The plumber throws a fireball.");
    }
}
```

Features
----------------
### Runtime actions
`OInput` class lets you set actions in your own code; no longer tied-up to axes setup in the project settings.

```csharp
public Transform neck;

void Start() {
	OInput.GetDefaultProfile()
		.SetAxis("StretchingNeck", "joystick 1 axis 1");
}

void Update() {
	neck.Rotate(0, OInput.GetDefaultProfile().GetAxis("StretchingNeck") * 90 /* degrees */, 0);
}

```

### Accepts both string parameters and built-in ones
```csharp
// These lines ...
OInput.GetDefaultProfile().SetButton("Jump", "space");
OInput.GetDefaultProfile().SetAxis("Horizontal", "joystick 1 axis 1");
// work as well as ...
OInput.GetDefaultProfile().SetButton("Jump", KeyCode.Space);
OInput.GetDefaultProfile().SetAxis("Horizontal", OInput.Axis.Joystick1Axis1);
```

### Profiles
#### Multiple profiles
Setting up multiple ways to control a character is easy with the OInput's profiles.
```csharp
void Start () {
	// Sets the "Goofy" profile.
	OInput.GetProfile("Goofy")
		.SetButton("UltraMegaFlip", KeyCode.Space);
	
	// Sets the "Regular" profile.
	OInput.GetProfile("Regular")
		.SetButton("UltraMegaFlip", KeyCode.LeftControl);
	
	// Let's say the user chooses the "Goofy" profile.
	OInput.GetProfile("Goofy").SetAsDefault();
}

void Update () {
	// The boarder will shout when the player releases the space key.
	if (OInput.GetDefaultProfile().GetButtonUp("UltraMegaFlip")) {
		Debug.Log("Yeeeaaaaahhhhhhhh!");
	}
}
```

#### Profile persistence
```csharp
void Start() {
	// Checks if the profile has saved data in the preferences (PlayerPrefs)
	if (OInput.GetDefaultProfile().hasSavedData) {
		OInput.GetDefaultProfile()
			.SetAxis("Horizontal", "joystick 1 axis 1")
			.Save(); // Saves through PlayerPrefs settings
		
		OInput.GetDefaultProfile()
			.Clear() // Clear() method clears all actions from a profile
			.SetAxis("NonImportantAxis", "joystick 3 axis 10");
	}
	
	// Loads the saved profile from memory
	OInput.GetDefaultProfile()
		.Load();
}

void Update() {
	// As the default profile is loaded to it's previous state, 
	// joystick 1 will be able to control the translation
	float translation = OInput.GetDefaultProfile().GetAxis("Horizontal") * 10.0f;
}
```

### Controller support
Adding controller buttons and axis to actions has never been simpler. 
```csharp
void Start() {
	// Setting up Player 1
	OInput.GetProfile("SpeedyHedgehog")
		.SetButton("Jump", KeyCode.Joystick1Button0)
		.SetAxis("Run", OInput.Axis.Joystick1Axis1);
		
	// Setting up Player 2
	OInput.GetProfile("FoxWith2Tails")
		.SetButton("Jump", KeyCode.Joystick2Button0)
		.SetAxis("Run", OInput.Axis.Joystick2Axis1);
}
```

### Button and axis detection
Implementing a prompt asking a user to press a key is quite easy with OInput.
```csharp
void Update() {
	if (OInput.DetectAxis() != OInput.Axis.None) {
		Debug.Log(OInput.DetectAxis() + " has been activated.");
	}
	
	if (OInput.DetectKeyDown() != KeyCode.None) {
		Debug.Log(OInput.DetectKeyDown() + " has been just pressed.");
	}
	
	if (OInput.DetectKey() != KeyCode.None) {
		Debug.Log(OInput.DetectKey() + " has been pressed.");
	}
	
	if (OInput.DetectKeyUp() != KeyCode.None) {
		Debug.Log(OInput.DetectKeyUp() + " has been released.");
	}
}
```

### Controller wrappers
The wrappers can help setting up profiles for controller input without worring about axis and button numbers. Why? Because it preprocesses the input to be uniform whatever the platform the game runs.

As there is no consistency across controllers ([not even for the same controller across different platforms](http://wiki.unity3d.com/index.php?title=Xbox360Controller)), wrappers can be used to setup a project fast.

| Controllers wrappers | Code          | Platforms    |
| -------------------- | ------------- | ------------ |
| Xbox 360 controller  | `OInput.Xbox` | Windows, Mac |
| Ouya controller      | `OInput.Ouya` | Android      |

```csharp
void Start() {
	OInput.Xbox.GetWrapper(OInput.GetDefaultProfile())
		.SetJoystick(OInput.Joystick.Joystick1)
		.SetAxis("Horizontal", OInput.Xbox.ControllerAxis.LeftStickX)
		.SetAxis("Vertical", OInput.Xbox.ControllerAxis.LeftStickY)
		.SetAxis("AimHorizontal", OInput.Xbox.ControllerAxis.RightStickX)
		.SetAxis("AimVertical", OInput.Xbox.ControllerAxis.RightStickY)
		.SetButton("Jump", OInput.Xbox.ControllerButton.A)
		.SetButton("Duck", OInput.Xbox.ControllerButton.B);
	
	// Wrappers doesn't change the ability to call a profile which has been wrapped
	OInput.GetDefaultProfile()
		.SetButton("Jump", "space")
		.SetAxis("Duck", "left ctrl");
}

void Update() {
	// When the A button on the controller or the spacebar is pressed...
	if (OInput.GetDefaultProfile().GetButton("Jump")) {
		// The character jumps.
		Debug.Log("Jumpin'!");
	}
}
```

How to install?
----------------
- [Download](https://github.com/adamscott/Unity-OInput/archive/master.zip) or clone the project.
- Put the `OInput` folder in the `Assets/Standard Assets/Scripts` folder of your project. If the folder doesn't exists, create it.
- Replace the `InputManager.asset` file in the `ProjectSettings` of your project by the one you downloaded.

Issues
----------------
Don't forget you can seek and fill issues in the project's [issue tracker](https://github.com/adamscott/Unity-OInput/issues).

### Notable issues
- OInput is **not compatible** with the [Input Manager](http://docs.unity3d.com/Documentation/Manual/Input.html) window.
- `OInput.Profile.GetAxis()` and `OInput.Profile.GetRawAxis()` return the same values, as keyboard smoothing has not been implemented yet.
- `OInput.Ouya` wrapper is not functionnal yet.
- `OInput.Xbox` wrapper works only on Mac and Windows.

Planned features
----------------
- Complete Ouya controller support.
- Keyboard axis smoothing.
- Detect input overlap between profiles.
- Set a joystick axis input as a button.

Version history
----------------
| Version | Release date  | Release notes                                          |
| ------- | ------------- | ------------------------------------------------------ |
| v0.1    | June 1st 2013 | N/A                                                    |

What does OInput stands for?
----------------
Originally intended to be called OpenInput, the project/file has been quickly renamed OInput for the sake of usability.

Notes
----------------
- `InputManager.asset` as been borrowed from the 
[ouya-unity-plugin project](https://github.com/ouya/ouya-unity-plugin) for (the awesome) 
[Ouya](http://ouya.tv/ "I want one!"). Thanks to 
[Tim Graupmann](https://twitter.com/tgraupmann "@tgraupmann on Twitter") and the 
[Ouya Dev Team](https://devs.ouya.tv/developers). Visit the project's website: `https://github.com/ouya/ouya-unity-plugin`
