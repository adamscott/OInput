OInput for Unity
================

Intended to free the developer from the input limitations of Unity.


How to install?
----------------
- Put the "OInput.cs" file anywhere in the "Assets" folder of your project.
- Replace the "InputManager.asset" file in the "ProjectSettings" of your project by the one of OInput.

How to use?
----------------
        
        // In the Start method
        OInput.GetDefaultProfile().SetAxis("Horizontal", "a", "d");
        ...
        // In the update loop
        transform.position += OInput.GetDefaultProfile().GetAxis("Horizontal") * Time.deltaTime * speed;

Notes
----------------
* "InputManager.asset" as been borrowed from the 
[ouya-unity-plugin project](https://github.com/ouya/ouya-unity-plugin) for (the awesome) 
[Ouya](http://ouya.tv/ "I want one!"). Thanks to 
[Tim Graupmann](https://twitter.com/tgraupmann "@tgraupmann on Twitter") and the 
[Ouya Dev Team](https://devs.ouya.tv/developers).
        
        https://github.com/ouya/ouya-unity-plugin
