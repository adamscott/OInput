<img src="https://raw.github.com/adamscott/Unity-OInput/gh-pages/images/OInput.png" height="75px" alt="OInput" title="OInput for Unity3d" />
================

One script to ease input issues with Unity's built-in InputManager.

How to use?
----------------

```csharp
void Start() {
	OInput.GetDefaultProfile()
		.SetAxis("Horizontal", "a", "d")
		.SetAxis("Vertical", "w", "d")
		.SetButton("Jump", "space");
}

void Update() {
	transform.position += Time.deltaTime * new Vector3(
		OInput.GetDefaultProfile().GetAxis("Horizontal"),
		0,
		OInput.GetDefaultProfile().GetAxis("Vertical"));
        
	if (OInput.GetDefaultProfile().GetButton("Jump")) {
		rigidbody.AddForce(Vector3.up * speed, ForceMode.Impulse);
	}
}
```

Features
----------------
### Profiles
```csharp
void Start() {
	OInput.GetProfile("Player1").SetButton("Jump", KeyCode.Space);
	OInput.GetProfile("Player2").SetButton("Jump", KeyCode.Z);
}
```

### Controller support
```csharp
void Start() {
	OInput.GetDefaultProfile()
		.SetButton("Jump", KeyCode.Joystick1Button0)
		.SetAxis("Horizontal", OInput.Axis.Joystick1Axis1);
}
```

### Button and axis detection
Always wanted to implement a prompt asking a user to press a key?
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
The wrappers can help setting up profiles for controller input without worring about axis and button numbers. As there is no consistency across controllers ([not even for the same controller across different platforms](http://wiki.unity3d.com/index.php?title=Xbox360Controller)), wrappers can be used to setup a project fast.

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
}
```

### Accepts both `string` parameters and built-in ones
```csharp
// These lines ...
OInput.GetDefaultProfile().SetButton("Jump", "space");
OInput.GetDefaultProfile().SetAxis("Horizontal", "joystick 1 axis 1");
// work as well as ...
OInput.GetDefaultProfile().SetButton("Jump", KeyCode.Space);
OInput.GetDefaultProfile().SetAxis("Horizontal", OInput.Axis.Joystick1Axis1);
```

How to install?
----------------
- Put the `OInput` folder in the `Assets/Standard Assets/Scripts` folder of your project. If the folder doesn't exists, create it.
- Replace the `InputManager.asset`[1] file in the `ProjectSettings` of your project by the one of OInput.

Issues
----------------
- `OInput.Profile.GetAxis()` and `OInput.Profile.GetRawAxis()` return the same values, as keyboard smoothing has not been implemented yet.
- `OInput.Ouya` wrapper is not functionnal yet.
- `OInput.Xbox` wrapper works only on Mac and Windows.

Notes
----------------
- [1] "InputManager.asset" as been borrowed from the 
[ouya-unity-plugin project](https://github.com/ouya/ouya-unity-plugin) for (the awesome) 
[Ouya](http://ouya.tv/ "I want one!"). Thanks to 
[Tim Graupmann](https://twitter.com/tgraupmann "@tgraupmann on Twitter") and the 
[Ouya Dev Team](https://devs.ouya.tv/developers). Visit the project's website: `https://github.com/ouya/ouya-unity-plugin`
