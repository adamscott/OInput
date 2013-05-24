using UnityEngine;
using System.Collections;
using System.Collections.Generic;

static public class OpenInput {
	
	public enum UnityAxis {
		Horizontal,
		Vertical,
		Fire1,
		Fire2,
		Fire3,
		Jump,
		MouseX,
		MouseY,
		MouseScrollWheel,
		WindowShakeX,
		WindowShakeY,
		Horizontal_Depricated,
		Vertical_Depricated,
		Joystick1Axis1,
		Joystick1Axis2,
		Joystick1Axis3,
		Joystick1Axis4,
		Joystick1Axis5,
		Joystick1Axis6,
		Joystick1Axis7,
		Joystick1Axis8,
		Joystick1Axis9,
		Joystick1Axis10,
		Joystick2Axis1,
		Joystick2Axis2,
		Joystick2Axis3,
		Joystick2Axis4,
		Joystick2Axis5,
		Joystick2Axis6,
		Joystick2Axis7,
		Joystick2Axis8,
		Joystick2Axis9,
		Joystick2Axis10,
		Joystick3Axis1,
		Joystick3Axis2,
		Joystick3Axis3,
		Joystick3Axis4,
		Joystick3Axis5,
		Joystick3Axis6,
		Joystick3Axis7,
		Joystick3Axis8,
		Joystick3Axis9,
		Joystick3Axis10,
		Joystick4Axis1,
		Joystick4Axis2,
		Joystick4Axis3,
		Joystick4Axis4,
		Joystick4Axis5,
		Joystick4Axis6,
		Joystick4Axis7,
		Joystick4Axis8,
		Joystick4Axis9,
		Joystick4Axis10,
		Joystick5Axis1,
		Joystick5Axis2,
		Joystick5Axis3,
		Joystick5Axis4,
		Joystick5Axis5,
		Joystick5Axis6,
		Joystick5Axis7,
		Joystick5Axis8,
		Joystick5Axis9,
		Joystick5Axis10,
		Joystick6Axis1,
		Joystick6Axis2,
		Joystick6Axis3,
		Joystick6Axis4,
		Joystick6Axis5,
		Joystick6Axis6,
		Joystick6Axis7,
		Joystick6Axis8,
		Joystick6Axis9,
		Joystick6Axis10,
		Joystick7Axis1,
		Joystick7Axis2,
		Joystick7Axis3,
		Joystick7Axis4,
		Joystick7Axis5,
		Joystick7Axis6,
		Joystick7Axis7,
		Joystick7Axis8,
		Joystick7Axis9,
		Joystick7Axis10,
		Joystick8Axis1,
		Joystick8Axis2,
		Joystick8Axis3,
		Joystick8Axis4,
		Joystick8Axis5,
		Joystick8Axis6,
		Joystick8Axis7,
		Joystick8Axis8,
		Joystick8Axis9,
		Joystick8Axis10,
		Joystick9Axis1,
		Joystick9Axis2,
		Joystick9Axis3,
		Joystick9Axis4,
		Joystick9Axis5,
		Joystick9Axis6,
		Joystick9Axis7,
		Joystick9Axis8,
		Joystick9Axis9,
		Joystick9Axis10,
		Joystick10Axis1,
		Joystick10Axis2,
		Joystick10Axis3,
		Joystick10Axis4,
		Joystick10Axis5,
		Joystick10Axis6,
		Joystick10Axis7,
		Joystick10Axis8,
		Joystick10Axis9,
		Joystick10Axis10,
		None
	}
	
	struct AxisKeys {
		public KeyCode Positive;
		public KeyCode Negative;
	}
	
	static readonly Dictionary<UnityAxis,string> AxisMap = new Dictionary<UnityAxis, string>(){
		{UnityAxis.Horizontal, "Horizontal"},
		{UnityAxis.Vertical, "Vertical"},
		{UnityAxis.Fire1, "Fire1"},
		{UnityAxis.Fire2, "Fire2"},
		{UnityAxis.Fire3, "Fire3"},
		{UnityAxis.Jump, "Jump"},
		{UnityAxis.MouseX, "Mouse X"},
		{UnityAxis.MouseY, "Mouse Y"},
		{UnityAxis.MouseScrollWheel, "Mouse ScrollWheel"},
		{UnityAxis.WindowShakeX, "Window Shake X"},
		{UnityAxis.WindowShakeY, "Window Shake Y"},
		{UnityAxis.Horizontal_Depricated, "Horizontal_Depricated"},
		{UnityAxis.Vertical_Depricated, "Vertical_Depricated"},
		{UnityAxis.Joystick1Axis1, "Joy1 Axis 1"},
		{UnityAxis.Joystick1Axis2, "Joy1 Axis 2"},
		{UnityAxis.Joystick1Axis3, "Joy1 Axis 3"},
		{UnityAxis.Joystick1Axis4, "Joy1 Axis 4"},
		{UnityAxis.Joystick1Axis5, "Joy1 Axis 5"},
		{UnityAxis.Joystick1Axis6, "Joy1 Axis 6"},
		{UnityAxis.Joystick1Axis7, "Joy1 Axis 7"},
		{UnityAxis.Joystick1Axis8, "Joy1 Axis 8"},
		{UnityAxis.Joystick1Axis9, "Joy1 Axis 9"},
		{UnityAxis.Joystick1Axis10, "Joy1 Axis 10"},
		{UnityAxis.Joystick2Axis1, "Joy2 Axis 1"},
		{UnityAxis.Joystick2Axis2, "Joy2 Axis 2"},
		{UnityAxis.Joystick2Axis3, "Joy2 Axis 3"},
		{UnityAxis.Joystick2Axis4, "Joy2 Axis 4"},
		{UnityAxis.Joystick2Axis5, "Joy2 Axis 5"},
		{UnityAxis.Joystick2Axis6, "Joy2 Axis 6"},
		{UnityAxis.Joystick2Axis7, "Joy2 Axis 7"},
		{UnityAxis.Joystick2Axis8, "Joy2 Axis 8"},
		{UnityAxis.Joystick2Axis9, "Joy2 Axis 9"},
		{UnityAxis.Joystick2Axis10, "Joy2 Axis 10"},
		{UnityAxis.Joystick3Axis1, "Joy3 Axis 1"},
		{UnityAxis.Joystick3Axis2, "Joy3 Axis 2"},
		{UnityAxis.Joystick3Axis3, "Joy3 Axis 3"},
		{UnityAxis.Joystick3Axis4, "Joy3 Axis 4"},
		{UnityAxis.Joystick3Axis5, "Joy3 Axis 5"},
		{UnityAxis.Joystick3Axis6, "Joy3 Axis 6"},
		{UnityAxis.Joystick3Axis7, "Joy3 Axis 7"},
		{UnityAxis.Joystick3Axis8, "Joy3 Axis 8"},
		{UnityAxis.Joystick3Axis9, "Joy3 Axis 9"},
		{UnityAxis.Joystick3Axis10, "Joy3 Axis 10"},
		{UnityAxis.Joystick4Axis1, "Joy4 Axis 1"},
		{UnityAxis.Joystick4Axis2, "Joy4 Axis 2"},
		{UnityAxis.Joystick4Axis3, "Joy4 Axis 3"},
		{UnityAxis.Joystick4Axis4, "Joy4 Axis 4"},
		{UnityAxis.Joystick4Axis5, "Joy4 Axis 5"},
		{UnityAxis.Joystick4Axis6, "Joy4 Axis 6"},
		{UnityAxis.Joystick4Axis7, "Joy4 Axis 7"},
		{UnityAxis.Joystick4Axis8, "Joy4 Axis 8"},
		{UnityAxis.Joystick4Axis9, "Joy4 Axis 9"},
		{UnityAxis.Joystick4Axis10, "Joy4 Axis 10"},
		{UnityAxis.Joystick5Axis1, "Joy5 Axis 1"},
		{UnityAxis.Joystick5Axis2, "Joy5 Axis 2"},
		{UnityAxis.Joystick5Axis3, "Joy5 Axis 3"},
		{UnityAxis.Joystick5Axis4, "Joy5 Axis 4"},
		{UnityAxis.Joystick5Axis5, "Joy5 Axis 5"},
		{UnityAxis.Joystick5Axis6, "Joy5 Axis 6"},
		{UnityAxis.Joystick5Axis7, "Joy5 Axis 7"},
		{UnityAxis.Joystick5Axis8, "Joy5 Axis 8"},
		{UnityAxis.Joystick5Axis9, "Joy5 Axis 9"},
		{UnityAxis.Joystick5Axis10, "Joy5 Axis 10"},
		{UnityAxis.Joystick6Axis1, "Joy6 Axis 1"},
		{UnityAxis.Joystick6Axis2, "Joy6 Axis 2"},
		{UnityAxis.Joystick6Axis3, "Joy6 Axis 3"},
		{UnityAxis.Joystick6Axis4, "Joy6 Axis 4"},
		{UnityAxis.Joystick6Axis5, "Joy6 Axis 5"},
		{UnityAxis.Joystick6Axis6, "Joy6 Axis 6"},
		{UnityAxis.Joystick6Axis7, "Joy6 Axis 7"},
		{UnityAxis.Joystick6Axis8, "Joy6 Axis 8"},
		{UnityAxis.Joystick6Axis9, "Joy6 Axis 9"},
		{UnityAxis.Joystick6Axis10, "Joy6 Axis 10"},
		{UnityAxis.Joystick7Axis1, "Joy7 Axis 1"},
		{UnityAxis.Joystick7Axis2, "Joy7 Axis 2"},
		{UnityAxis.Joystick7Axis3, "Joy7 Axis 3"},
		{UnityAxis.Joystick7Axis4, "Joy7 Axis 4"},
		{UnityAxis.Joystick7Axis5, "Joy7 Axis 5"},
		{UnityAxis.Joystick7Axis6, "Joy7 Axis 6"},
		{UnityAxis.Joystick7Axis7, "Joy7 Axis 7"},
		{UnityAxis.Joystick7Axis8, "Joy7 Axis 8"},
		{UnityAxis.Joystick7Axis9, "Joy7 Axis 9"},
		{UnityAxis.Joystick7Axis10, "Joy7 Axis 10"},
		{UnityAxis.Joystick8Axis1, "Joy8 Axis 1"},
		{UnityAxis.Joystick8Axis2, "Joy8 Axis 2"},
		{UnityAxis.Joystick8Axis3, "Joy8 Axis 3"},
		{UnityAxis.Joystick8Axis4, "Joy8 Axis 4"},
		{UnityAxis.Joystick8Axis5, "Joy8 Axis 5"},
		{UnityAxis.Joystick8Axis6, "Joy8 Axis 6"},
		{UnityAxis.Joystick8Axis7, "Joy8 Axis 7"},
		{UnityAxis.Joystick8Axis8, "Joy8 Axis 8"},
		{UnityAxis.Joystick8Axis9, "Joy8 Axis 9"},
		{UnityAxis.Joystick8Axis10, "Joy8 Axis 10"},
		{UnityAxis.Joystick9Axis1, "Joy9 Axis 1"},
		{UnityAxis.Joystick9Axis2, "Joy9 Axis 2"},
		{UnityAxis.Joystick9Axis3, "Joy9 Axis 3"},
		{UnityAxis.Joystick9Axis4, "Joy9 Axis 4"},
		{UnityAxis.Joystick9Axis5, "Joy9 Axis 5"},
		{UnityAxis.Joystick9Axis6, "Joy9 Axis 6"},
		{UnityAxis.Joystick9Axis7, "Joy9 Axis 7"},
		{UnityAxis.Joystick9Axis8, "Joy9 Axis 8"},
		{UnityAxis.Joystick9Axis9, "Joy9 Axis 9"},
		{UnityAxis.Joystick9Axis10, "Joy9 Axis 10"},
		{UnityAxis.Joystick10Axis1, "Joy10 Axis 1"},
		{UnityAxis.Joystick10Axis2, "Joy10 Axis 2"},
		{UnityAxis.Joystick10Axis3, "Joy10 Axis 3"},
		{UnityAxis.Joystick10Axis4, "Joy10 Axis 4"},
		{UnityAxis.Joystick10Axis5, "Joy10 Axis 5"},
		{UnityAxis.Joystick10Axis6, "Joy10 Axis 6"},
		{UnityAxis.Joystick10Axis7, "Joy10 Axis 7"},
		{UnityAxis.Joystick10Axis8, "Joy10 Axis 8"},
		{UnityAxis.Joystick10Axis9, "Joy10 Axis 9"},
		{UnityAxis.Joystick10Axis10, "Joy10 Axis 10"},
		{UnityAxis.None, ""}
	};
	
	
	static public Dictionary<string, KeyCode> StringToKeyCode = new Dictionary<string, KeyCode>() {
		{"backspace", KeyCode.Backspace},
		{"delete", KeyCode.Delete},
		{"tab", KeyCode.Tab},
		{"clear", KeyCode.Clear},
		{"return", KeyCode.Return},
		{"//pause", KeyCode.Pause},
		{"escape", KeyCode.Escape},
		{"space", KeyCode.Space},
		{"[0]", KeyCode.Keypad0},
		{"[1]", KeyCode.Keypad1},
		{"[2]", KeyCode.Keypad2},
		{"[3]", KeyCode.Keypad3},
		{"[4]", KeyCode.Keypad4},
		{"[5]", KeyCode.Keypad5},
		{"[6]", KeyCode.Keypad6},
		{"[7]", KeyCode.Keypad7},
		{"[8]", KeyCode.Keypad8},
		{"[9]", KeyCode.Keypad9},
		{"[.]", KeyCode.KeypadPeriod},
		{"[/]", KeyCode.KeypadDivide},
		{"[*]", KeyCode.KeypadMultiply},
		{"[-]", KeyCode.KeypadMinus},
		{"[+]", KeyCode.KeypadPlus},
		{"//[enter]", KeyCode.KeypadEnter},
		{"[=]", KeyCode.KeypadEquals},
		{"up", KeyCode.UpArrow},
		{"down", KeyCode.DownArrow},
		{"right", KeyCode.RightArrow},
		{"left", KeyCode.LeftArrow},
		{"insert", KeyCode.Insert},
		{"home", KeyCode.Home},
		{"end", KeyCode.End},
		{"page up", KeyCode.PageUp},
		{"page down", KeyCode.PageDown},
		{"f1", KeyCode.F1},
		{"f2", KeyCode.F2},
		{"f3", KeyCode.F3},
		{"f4", KeyCode.F4},
		{"f5", KeyCode.F5},
		{"f6", KeyCode.F6},
		{"f7", KeyCode.F7},
		{"f8", KeyCode.F8},
		{"f9", KeyCode.F9},
		{"f10", KeyCode.F10},
		{"f11", KeyCode.F11},
		{"f12", KeyCode.F12},
		{"f13", KeyCode.F13},
		{"f14", KeyCode.F14},
		{"f15", KeyCode.F15},
		{"0", KeyCode.Alpha0},
		{"1", KeyCode.Alpha1},
		{"2", KeyCode.Alpha2},
		{"3", KeyCode.Alpha3},
		{"4", KeyCode.Alpha4},
		{"5", KeyCode.Alpha5},
		{"6", KeyCode.Alpha6},
		{"7", KeyCode.Alpha7},
		{"8", KeyCode.Alpha8},
		{"9", KeyCode.Alpha9},
		{"!", KeyCode.Exclaim},
		{"\"", KeyCode.DoubleQuote},
		{"#", KeyCode.Hash},
		{"$", KeyCode.Dollar},
		{"&", KeyCode.Ampersand},
		{"'", KeyCode.Quote},
		{"(", KeyCode.LeftParen},
		{")", KeyCode.RightParen},
		{"*", KeyCode.Asterisk},
		{"+", KeyCode.Plus},
		{",", KeyCode.Comma},
		{"-", KeyCode.Minus},
		{".", KeyCode.Period},
		{"/", KeyCode.Slash},
		{":", KeyCode.Colon},
		{";", KeyCode.Semicolon},
		{"<", KeyCode.Less},
		{"=", KeyCode.Equals},
		{">", KeyCode.Greater},
		{"?", KeyCode.Question},
		{"@", KeyCode.At},
		{"[", KeyCode.LeftBracket},
		{"\\", KeyCode.Backslash},
		{"]", KeyCode.RightBracket},
		{"^", KeyCode.Caret},
		{"_", KeyCode.Underscore},
		{"`", KeyCode.BackQuote},
		{"a", KeyCode.A},
		{"b", KeyCode.B},
		{"c", KeyCode.C},
		{"d", KeyCode.D},
		{"e", KeyCode.E},
		{"f", KeyCode.F},
		{"g", KeyCode.G},
		{"h", KeyCode.H},
		{"i", KeyCode.I},
		{"j", KeyCode.J},
		{"k", KeyCode.K},
		{"l", KeyCode.L},
		{"m", KeyCode.M},
		{"n", KeyCode.N},
		{"o", KeyCode.O},
		{"p", KeyCode.P},
		{"q", KeyCode.Q},
		{"r", KeyCode.R},
		{"s", KeyCode.S},
		{"t", KeyCode.T},
		{"u", KeyCode.U},
		{"v", KeyCode.V},
		{"w", KeyCode.W},
		{"x", KeyCode.X},
		{"y", KeyCode.Y},
		{"z", KeyCode.Z},
		{"numlock", KeyCode.Numlock},
		{"caps lock", KeyCode.CapsLock},
		{"scroll lock", KeyCode.ScrollLock},
		{"right shift", KeyCode.RightShift},
		{"left shift", KeyCode.LeftShift},
		{"right ctrl", KeyCode.RightControl},
		{"left crtl", KeyCode.LeftControl},
		{"right alt", KeyCode.RightAlt},
		{"left alt", KeyCode.LeftAlt},
		{"left cmd", KeyCode.LeftCommand},
		{"//left apple", KeyCode.LeftApple},
		{"//left windows", KeyCode.LeftWindows},
		{"right cmd", KeyCode.RightCommand},
		{"//right apple", KeyCode.RightApple},
		{"//right windows", KeyCode.RightWindows},
		{"//alt group", KeyCode.AltGr},
		{"help", KeyCode.Help},
		{"//print", KeyCode.Print},
		{"//sys req", KeyCode.SysReq},
		{"//break", KeyCode.Break},
		{"menu", KeyCode.Menu},
		{"mouse 0", KeyCode.Mouse0},
		{"mouse 1", KeyCode.Mouse1},
		{"mouse 2", KeyCode.Mouse2},
		{"mouse 3", KeyCode.Mouse3},
		{"mouse 4", KeyCode.Mouse4},
		{"mouse 5", KeyCode.Mouse5},
		{"mouse 6", KeyCode.Mouse6},
		{"joystick button 0", KeyCode.JoystickButton0},
		{"joystick button 1", KeyCode.JoystickButton1},
		{"joystick button 2", KeyCode.JoystickButton2},
		{"joystick button 3", KeyCode.JoystickButton3},
		{"joystick button 4", KeyCode.JoystickButton4},
		{"joystick button 5", KeyCode.JoystickButton5},
		{"joystick button 6", KeyCode.JoystickButton6},
		{"joystick button 7", KeyCode.JoystickButton7},
		{"joystick button 8", KeyCode.JoystickButton8},
		{"joystick button 9", KeyCode.JoystickButton9},
		{"joystick button 10", KeyCode.JoystickButton10},
		{"joystick button 11", KeyCode.JoystickButton11},
		{"joystick button 12", KeyCode.JoystickButton12},
		{"joystick button 13", KeyCode.JoystickButton13},
		{"joystick button 14", KeyCode.JoystickButton14},
		{"joystick button 15", KeyCode.JoystickButton15},
		{"joystick button 16", KeyCode.JoystickButton16},
		{"joystick button 17", KeyCode.JoystickButton17},
		{"joystick button 18", KeyCode.JoystickButton18},
		{"joystick button 19", KeyCode.JoystickButton19},
		{"joystick 1 button 0", KeyCode.Joystick1Button0},
		{"joystick 1 button 1", KeyCode.Joystick1Button1},
		{"joystick 1 button 2", KeyCode.Joystick1Button2},
		{"joystick 1 button 3", KeyCode.Joystick1Button3},
		{"joystick 1 button 4", KeyCode.Joystick1Button4},
		{"joystick 1 button 5", KeyCode.Joystick1Button5},
		{"joystick 1 button 6", KeyCode.Joystick1Button6},
		{"joystick 1 button 7", KeyCode.Joystick1Button7},
		{"joystick 1 button 8", KeyCode.Joystick1Button8},
		{"joystick 1 button 9", KeyCode.Joystick1Button9},
		{"joystick 1 button 10", KeyCode.Joystick1Button10},
		{"joystick 1 button 11", KeyCode.Joystick1Button11},
		{"joystick 1 button 12", KeyCode.Joystick1Button12},
		{"joystick 1 button 13", KeyCode.Joystick1Button13},
		{"joystick 1 button 14", KeyCode.Joystick1Button14},
		{"joystick 1 button 15", KeyCode.Joystick1Button15},
		{"joystick 1 button 16", KeyCode.Joystick1Button16},
		{"joystick 1 button 17", KeyCode.Joystick1Button17},
		{"joystick 1 button 18", KeyCode.Joystick1Button18},
		{"joystick 1 button 19", KeyCode.Joystick1Button19},
		{"joystick 2 button 0", KeyCode.Joystick2Button0},
		{"joystick 2 button 1", KeyCode.Joystick2Button1},
		{"joystick 2 button 2", KeyCode.Joystick2Button2},
		{"joystick 2 button 3", KeyCode.Joystick2Button3},
		{"joystick 2 button 4", KeyCode.Joystick2Button4},
		{"joystick 2 button 5", KeyCode.Joystick2Button5},
		{"joystick 2 button 6", KeyCode.Joystick2Button6},
		{"joystick 2 button 7", KeyCode.Joystick2Button7},
		{"joystick 2 button 8", KeyCode.Joystick2Button8},
		{"joystick 2 button 9", KeyCode.Joystick2Button9},
		{"joystick 2 button 10", KeyCode.Joystick2Button10},
		{"joystick 2 button 11", KeyCode.Joystick2Button11},
		{"joystick 2 button 12", KeyCode.Joystick2Button12},
		{"joystick 2 button 13", KeyCode.Joystick2Button13},
		{"joystick 2 button 14", KeyCode.Joystick2Button14},
		{"joystick 2 button 15", KeyCode.Joystick2Button15},
		{"joystick 2 button 16", KeyCode.Joystick2Button16},
		{"joystick 2 button 17", KeyCode.Joystick2Button17},
		{"joystick 2 button 18", KeyCode.Joystick2Button18},
		{"joystick 2 button 19", KeyCode.Joystick2Button19},
		{"joystick 3 button 0", KeyCode.Joystick3Button0},
		{"joystick 3 button 1", KeyCode.Joystick3Button1},
		{"joystick 3 button 2", KeyCode.Joystick3Button2},
		{"joystick 3 button 3", KeyCode.Joystick3Button3},
		{"joystick 3 button 4", KeyCode.Joystick3Button4},
		{"joystick 3 button 5", KeyCode.Joystick3Button5},
		{"joystick 3 button 6", KeyCode.Joystick3Button6},
		{"joystick 3 button 7", KeyCode.Joystick3Button7},
		{"joystick 3 button 8", KeyCode.Joystick3Button8},
		{"joystick 3 button 9", KeyCode.Joystick3Button9},
		{"joystick 3 button 10", KeyCode.Joystick3Button10},
		{"joystick 3 button 11", KeyCode.Joystick3Button11},
		{"joystick 3 button 12", KeyCode.Joystick3Button12},
		{"joystick 3 button 13", KeyCode.Joystick3Button13},
		{"joystick 3 button 14", KeyCode.Joystick3Button14},
		{"joystick 3 button 15", KeyCode.Joystick3Button15},
		{"joystick 3 button 16", KeyCode.Joystick3Button16},
		{"joystick 3 button 17", KeyCode.Joystick3Button17},
		{"joystick 3 button 18", KeyCode.Joystick3Button18},
		{"joystick 3 button 19", KeyCode.Joystick3Button19},
		{"joystick 4 button 0", KeyCode.Joystick4Button0},
		{"joystick 4 button 1", KeyCode.Joystick4Button1},
		{"joystick 4 button 2", KeyCode.Joystick4Button2},
		{"joystick 4 button 3", KeyCode.Joystick4Button3},
		{"joystick 4 button 4", KeyCode.Joystick4Button4},
		{"joystick 4 button 5", KeyCode.Joystick4Button5},
		{"joystick 4 button 6", KeyCode.Joystick4Button6},
		{"joystick 4 button 7", KeyCode.Joystick4Button7},
		{"joystick 4 button 8", KeyCode.Joystick4Button8},
		{"joystick 4 button 9", KeyCode.Joystick4Button9},
		{"joystick 4 button 10", KeyCode.Joystick4Button10},
		{"joystick 4 button 11", KeyCode.Joystick4Button11},
		{"joystick 4 button 12", KeyCode.Joystick4Button12},
		{"joystick 4 button 13", KeyCode.Joystick4Button13},
		{"joystick 4 button 14", KeyCode.Joystick4Button14},
		{"joystick 4 button 15", KeyCode.Joystick4Button15},
		{"joystick 4 button 16", KeyCode.Joystick4Button16},
		{"joystick 4 button 17", KeyCode.Joystick4Button17},
		{"joystick 4 button 18", KeyCode.Joystick4Button18},
		{"joystick 4 button 19", KeyCode.Joystick4Button19}
	};
	
	static private OpenInputProfile DefaultProfile;
	static private Dictionary<string, OpenInputProfile> Profiles;
	
	static public OpenInputProfile GetProfile(string profileId) {
		if (Profiles == null) Profiles = new Dictionary<string, OpenInputProfile>();
		
		OpenInputProfile profile;
		if (Profiles.TryGetValue(profileId, out profile)) {
			return profile;
		} else {
			Profiles[profileId] = new OpenInputProfile(profileId);
			return Profiles[profileId];
		}
	}
	
	static public OpenInputProfile GetDefaultProfile() {
		if (DefaultProfile == null) {
			DefaultProfile = GetProfile("default");
			return DefaultProfile;
		} else {
			return DefaultProfile;
		}
	}
	
	static public KeyCode GetCurrentKey() {
		foreach(KeyCode key in KeyCode.GetValues(typeof(KeyCode))) {
			// If Joystick detects a key, that's because Joystick 1, 2, 3, or 4 detects one.
			switch (key) {
			case KeyCode.JoystickButton0:
			case KeyCode.JoystickButton1:
			case KeyCode.JoystickButton2:
			case KeyCode.JoystickButton3:
			case KeyCode.JoystickButton4:
			case KeyCode.JoystickButton5:
			case KeyCode.JoystickButton6:
			case KeyCode.JoystickButton7:
			case KeyCode.JoystickButton8:
			case KeyCode.JoystickButton9:
			case KeyCode.JoystickButton10:
			case KeyCode.JoystickButton11:
			case KeyCode.JoystickButton12:
			case KeyCode.JoystickButton13:
			case KeyCode.JoystickButton14:
			case KeyCode.JoystickButton15:
			case KeyCode.JoystickButton16:
			case KeyCode.JoystickButton17:
			case KeyCode.JoystickButton18:
			case KeyCode.JoystickButton19:
				continue;
			default:
				break;
			}
			if (Input.GetKey(key)) return key;
		}
		return KeyCode.None;
	}
	
	static public KeyCode GetCurrentKeyUp() {
		foreach(KeyCode key in KeyCode.GetValues(typeof(KeyCode))) {
			// If Joystick detects a key, that's because Joystick 1, 2, 3, or 4 detects one.
			switch (key) {
			case KeyCode.JoystickButton0:
			case KeyCode.JoystickButton1:
			case KeyCode.JoystickButton2:
			case KeyCode.JoystickButton3:
			case KeyCode.JoystickButton4:
			case KeyCode.JoystickButton5:
			case KeyCode.JoystickButton6:
			case KeyCode.JoystickButton7:
			case KeyCode.JoystickButton8:
			case KeyCode.JoystickButton9:
			case KeyCode.JoystickButton10:
			case KeyCode.JoystickButton11:
			case KeyCode.JoystickButton12:
			case KeyCode.JoystickButton13:
			case KeyCode.JoystickButton14:
			case KeyCode.JoystickButton15:
			case KeyCode.JoystickButton16:
			case KeyCode.JoystickButton17:
			case KeyCode.JoystickButton18:
			case KeyCode.JoystickButton19:
				continue;
			default:
				break;
			}
			if (Input.GetKeyUp(key)) return key;
		}
		return KeyCode.None;
	}
	
	static public KeyCode GetCurrentKeyDown() {
		foreach(KeyCode key in KeyCode.GetValues(typeof(KeyCode))) {
			// If Joystick detects a key, that's because Joystick 1, 2, 3, or 4 detects one.
			switch (key) {
			case KeyCode.JoystickButton0:
			case KeyCode.JoystickButton1:
			case KeyCode.JoystickButton2:
			case KeyCode.JoystickButton3:
			case KeyCode.JoystickButton4:
			case KeyCode.JoystickButton5:
			case KeyCode.JoystickButton6:
			case KeyCode.JoystickButton7:
			case KeyCode.JoystickButton8:
			case KeyCode.JoystickButton9:
			case KeyCode.JoystickButton10:
			case KeyCode.JoystickButton11:
			case KeyCode.JoystickButton12:
			case KeyCode.JoystickButton13:
			case KeyCode.JoystickButton14:
			case KeyCode.JoystickButton15:
			case KeyCode.JoystickButton16:
			case KeyCode.JoystickButton17:
			case KeyCode.JoystickButton18:
			case KeyCode.JoystickButton19:
				continue;
			default:
				break;
			}
			if (Input.GetKeyDown(key)) return key;
		}
		return KeyCode.None;
	}
	
	static public UnityAxis GetCurrentAxis() {
		Dictionary<UnityAxis, string>.Enumerator enumerator = AxisMap.GetEnumerator();
		while (enumerator.MoveNext()) {
			if (Input.GetAxis(enumerator.Current.Value) > 0.0f || Input.GetAxis(enumerator.Current.Value) < 0.0f) return enumerator.Current.Key;
		}
		
		return UnityAxis.None;
	}
	
	static public UnityAxis GetCurrentPositiveAxis() {
		Dictionary<UnityAxis, string>.Enumerator enumerator = AxisMap.GetEnumerator();
		while (enumerator.MoveNext()) {
			if (Input.GetAxis(enumerator.Current.Value) > 0.0f) return enumerator.Current.Key;
		}
		
		return UnityAxis.None;
	}
	
	static public UnityAxis GetCurrentNegativeAxis() {
		Dictionary<UnityAxis, string>.Enumerator enumerator = AxisMap.GetEnumerator();
		while (enumerator.MoveNext()) {
			if (Input.GetAxis(enumerator.Current.Value) < 0.0f) return enumerator.Current.Key;
		}
		
		return UnityAxis.None;
	}
	
	public class OpenInputProfile {
		Dictionary<string, List<KeyCode>> ButtonActions;
		Dictionary<string, List<UnityAxis>> AxisActions;
		Dictionary<string, List<AxisKeys>> AxisKeysActions;
		string id;
		
		public bool anyButton {
			get {
				Dictionary<string, List<KeyCode>>.Enumerator buttonActionsEnumerator = ButtonActions.GetEnumerator();
				while(buttonActionsEnumerator.MoveNext()) {
					List<KeyCode>.Enumerator keyEnumerator = buttonActionsEnumerator.Current.Value.GetEnumerator();
					while(keyEnumerator.MoveNext()) {
						if (Input.GetKey(keyEnumerator.Current)) return true;
					}
				}
				
				return false;
			}
		}
		
		public bool anyButtonDown {
			get {
				Dictionary<string, List<KeyCode>>.Enumerator buttonActionsEnumerator = ButtonActions.GetEnumerator();
				while(buttonActionsEnumerator.MoveNext()) {
					List<KeyCode>.Enumerator keyEnumerator = buttonActionsEnumerator.Current.Value.GetEnumerator();
					while(keyEnumerator.MoveNext()) {
						if (Input.GetKeyDown(keyEnumerator.Current)) return true;
					}
				}
				
				return false;
			}
		}
		
		public bool anyAxis {
			get {
				Dictionary<string, List<UnityAxis>>.Enumerator axisActionsEnumerator = AxisActions.GetEnumerator();
				while(axisActionsEnumerator.MoveNext()) {
					List<UnityAxis>.Enumerator axisEnumerator = axisActionsEnumerator.Current.Value.GetEnumerator();
					while(axisEnumerator.MoveNext()) {
						if (Input.GetAxis(AxisMap[axisEnumerator.Current]) > 0.0f || Input.GetAxis(AxisMap[axisEnumerator.Current]) < 0.0f) return true;
					}
				}
				
				Dictionary<string, List<AxisKeys>>.Enumerator axisKeysActionsEnumerator = AxisKeysActions.GetEnumerator();
				while(axisKeysActionsEnumerator.MoveNext()) {
					List<AxisKeys>.Enumerator axisKeysEnumerator = axisKeysActionsEnumerator.Current.Value.GetEnumerator();
					while(axisKeysEnumerator.MoveNext()) {
						if (Input.GetKey(axisKeysEnumerator.Current.Positive) || Input.GetKey(axisKeysEnumerator.Current.Negative)) return true;
					}
				}
				
				return false;
			}
		}
		
		public OpenInputProfile(string profileId) {
			ButtonActions = new Dictionary<string, List<KeyCode>>();
			AxisActions = new Dictionary<string, List<UnityAxis>>();
			AxisKeysActions = new Dictionary<string, List<AxisKeys>>();
			
			id = profileId;
		}
		
		public float GetAxis(string actionName) {
			if (AxisActions.ContainsKey(actionName)) {
				List<UnityAxis>.Enumerator enumerator = AxisActions[actionName].GetEnumerator();
				
				float result;
				while (enumerator.MoveNext()) {
					result = Input.GetAxis(AxisMap[enumerator.Current]);
					if (result != 0.0f) {
						return result;
					}
				}
				
				// If no axis return values, then maybe some custom axis are active
				return GetButtonAxis(actionName, true);
				
			} else {
				float buttonAxisResults = GetButtonAxis(actionName, false);
				if (buttonAxisResults != 0.0) {
					return buttonAxisResults;
				} else {
					return 0.0f;
				}
			}
		}
		
		public float GetAxisRaw(string actionName) {
			if (AxisActions.ContainsKey(actionName)) {
				List<UnityAxis>.Enumerator enumerator = AxisActions[actionName].GetEnumerator();
				
				float result;
				while (enumerator.MoveNext()) {
					result = Input.GetAxisRaw(AxisMap[enumerator.Current]);
					if (result != 0.0f) {
						return result;
					}
				}
				
				// If no axis return values, then maybe some custom axis are active
				return GetButtonAxis(actionName, true);
				
			} else {
				float buttonAxisResults = GetButtonAxis(actionName, false);
				if (buttonAxisResults != 0.0) {
					return buttonAxisResults;
				} else {
					Debug.LogWarning("\"" + actionName + "\" is not defined as an axis action.");
					return 0.0f;
				}
			}
		}
		
		protected float GetButtonAxis(string actionName, bool actionExists = false) {
			if (AxisKeysActions.ContainsKey(actionName)) {
				List<AxisKeys>.Enumerator enumerator = AxisKeysActions[actionName].GetEnumerator();
				
				while (enumerator.MoveNext()) {
					AxisKeys axis = enumerator.Current;
					if (Input.GetKey(axis.Positive) && Input.GetKey(axis.Negative)) {
						return 0.0f;
					} else if (Input.GetKey(axis.Positive)) {
						return 1.0f;
					} else if (Input.GetKey(axis.Negative)) {
						return -1.0f;
					}
				}
				
				return 0.0f;
			} else {
				Debug.LogWarning("\"" + actionName + "\" is not defined as an axis action.");
				return 0.0f;
			}
		}
		
		public bool GetButton(string actionName) {
			if (ButtonActions.ContainsKey(actionName)) {
				List<KeyCode>.Enumerator enumerator = ButtonActions[actionName].GetEnumerator();
				
				while (enumerator.MoveNext()) {
					if (Input.GetKey(enumerator.Current)) return true;
				}
				
				return false;
			} else {
				Debug.LogWarning("\"" + actionName + "\" is not defined as an button action.");
				return false;
			}
		}
		
		public bool GetButtonUp(string actionName) {
			if (ButtonActions.ContainsKey(actionName)) {
				List<KeyCode>.Enumerator enumerator = ButtonActions[actionName].GetEnumerator();
				
				while (enumerator.MoveNext()) {
					if (Input.GetKeyUp(enumerator.Current)) return true;
				}
				
				return false;
			} else {
				Debug.LogWarning("\"" + actionName + "\" is not defined as an button action.");
				return false;
			}
		}
		
		public bool GetButtonDown(string actionName) {
			if (ButtonActions.ContainsKey(actionName)) {
				List<KeyCode>.Enumerator enumerator = ButtonActions[actionName].GetEnumerator();
				
				while (enumerator.MoveNext()) {
					if (Input.GetKeyDown(enumerator.Current)) return true;
				}
				
				return false;
			} else {
				Debug.LogWarning("\"" + actionName + "\" is not defined as an button action.");
				return false;
			}
		}
		
		public void SetButton(string action, KeyCode key) {
			List<KeyCode> listOfButtons;
			
			if (!ButtonActions.TryGetValue(action, out listOfButtons)) {
				ButtonActions.Add(action, new List<KeyCode>());
				listOfButtons = ButtonActions[action];
			}
			
			if (listOfButtons.Contains(key)) {
				Debug.LogWarning("\"" + key.ToString() + "\" for \"" + action + "\" is already defined for this profile.");
			} else {
				listOfButtons.Add(key);
			}
		}
		
		public void SetButton(string action, string key) {
			KeyCode keyCode;
			if (StringToKeyCode.TryGetValue(key, out keyCode)) {
				SetButton(action, keyCode);
			} else {
				throw new UnityException("Key \"" + key + "\" is unknown.");
			}
		}
		
		public void SetAxis(string action, UnityAxis unityAxis) {
			List<UnityAxis> listOfAxis;
			if (!AxisActions.TryGetValue(action, out listOfAxis)) {
				AxisActions.Add(action, new List<UnityAxis>());
				listOfAxis = AxisActions[action];
			}
		
			if (listOfAxis.Contains(unityAxis)) {
				Debug.LogWarning("\"" + AxisMap[unityAxis] + "\" for \"" + action + "\" is already defined for this profile.");
			} else {
				listOfAxis.Add(unityAxis);
			}
		}
		
		public void SetAxis(string action, KeyCode positiveKey, KeyCode negativeKey) {
			List<AxisKeys> listOfAxisKeys;
			if (!AxisKeysActions.TryGetValue(action, out listOfAxisKeys)) {
				AxisKeysActions.Add(action, new List<AxisKeys>());
				listOfAxisKeys = AxisKeysActions[action];
			}
			
			AxisKeys newAxisKeys = new AxisKeys();
			newAxisKeys.Positive = positiveKey;
			newAxisKeys.Negative = negativeKey;
			
			if (listOfAxisKeys.Contains(newAxisKeys)) {
				Debug.LogWarning("\"" + positiveKey.ToString() + "\" and \"" + negativeKey.ToString() + "\" for \"" + action + "\" is already defined for this profile.");
			} else {
				listOfAxisKeys.Add(newAxisKeys);
			}
		}
		
		public void SetAxis(string action, string positiveKey, string negativeKey) {
			KeyCode positive;
			if (!StringToKeyCode.TryGetValue(positiveKey.ToLower(), out positive)) {
				throw new UnityException("Positive key \"" + positiveKey + "\" is unknown.");
			}
			
			KeyCode negative;
			if (!StringToKeyCode.TryGetValue(negativeKey.ToLower(), out negative)) {
				throw new UnityException("Negative key \"" + negativeKey + "\" is unknown.");
			}
			
			SetAxis(action, positive, negative);
		}
		
		public void SetAxis(string action, KeyCode positiveKey, string negativeKey) {
			KeyCode negative;
			if (StringToKeyCode.TryGetValue(negativeKey.ToLower(), out negative)) {
				SetAxis(action, positiveKey, negative);
			} else {
				throw new UnityException("Negative key \"" + negativeKey + "\" is unknown.");
			}			
		}
		
		public void SetAxis(string action, string positiveKey, KeyCode negativeKey) {
			KeyCode positive;
			if (StringToKeyCode.TryGetValue(positiveKey.ToLower(), out positive)) {
				SetAxis(action, positive, negativeKey);
			} else {
				throw new UnityException("Positive key \"" + positiveKey + "\" is unknown.");
			}
		}
		
		public void UnsetAxis(string action) {
			if (!AxisActions.Remove(action) && !AxisKeysActions.Remove(action)) {
				Debug.LogWarning("Could not remove \"" + action + "\" from the axis.");
			}
		}
		/*
		public void UnsetAxis(string action, KeyCode positiveKey, KeyCode negativeKey) {
			
		}
		*/
		
		public void UnsetButton(string action) {
			if (!ButtonActions.Remove(action)) {
				Debug.LogWarning("Could not remove \"" + action + "\" from the keys.");
			}
		}
		
		public string GetId() {
			return id;
		}
		
		public void SetAsDefaultProfile() {
			DefaultProfile = this;
		}
	}
}
