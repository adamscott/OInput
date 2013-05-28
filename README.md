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

### Controller support

### Controller wrappers

### Accepts both `string` parameters and built-in ones

How to install?
----------------
- Put the "OInput.cs" file anywhere in the "Assets" folder of your project.
- Replace the "InputManager.asset" file in the "ProjectSettings" of your project by the one of OInput.

Issues
----------------
- `OInput.Profile.GetAxis()` and `OInput.Profile.GetRawAxis()` return the same values, as keyboard smoothing has not been implemented yet.
- `OInput.Ouya` (Ouya controller) is not functionnal yet.

Notes
----------------
* "InputManager.asset" as been borrowed from the 
[ouya-unity-plugin project](https://github.com/ouya/ouya-unity-plugin) for (the awesome) 
[Ouya](http://ouya.tv/ "I want one!"). Thanks to 
[Tim Graupmann](https://twitter.com/tgraupmann "@tgraupmann on Twitter") and the 
[Ouya Dev Team](https://devs.ouya.tv/developers).
        
        https://github.com/ouya/ouya-unity-plugin
