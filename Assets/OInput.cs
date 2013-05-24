using UnityEngine;
using System.Collections;
using System.Collections.Generic;

static public class OInput {
	
	/// <summary>
	/// Axis keys.
	/// </summary>
	struct AxisKeys {
		public KeyCode Positive;
		public KeyCode Negative;
	}
	
	/// <summary>
	/// Current axes in Unity.
	/// </summary>
	public enum Axis {
		Horizontal,
		Vertical,
		Fire1,
		Fire2,
		Fire3,
		Jump,
		MouseX,
		MouseY,
		MouseScrollWheel,
		MouseHorizontal,
		MouseVertical,
		MouseWheel,
		Shift,
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
	
	/// <summary>
	/// The axes map.
	/// </summary>
	static readonly Dictionary<Axis,string> AxisMap = new Dictionary<Axis, string>(){
		{Axis.Horizontal, "Horizontal"},
		{Axis.Vertical, "Vertical"},
		{Axis.Fire1, "Fire1"},
		{Axis.Fire2, "Fire2"},
		{Axis.Fire3, "Fire3"},
		{Axis.Jump, "Jump"},
		{Axis.MouseX, "Mouse X"},
		{Axis.MouseY, "Mouse Y"},
		{Axis.MouseScrollWheel, "Mouse ScrollWheel"},
		{Axis.MouseHorizontal, "Mouse Horizontal"},
		{Axis.MouseVertical, "Mouse Vertical"},
		{Axis.MouseWheel, "Mouse Wheel"},
		{Axis.Shift, "Shift"},
		{Axis.WindowShakeX, "Window Shake X"},
		{Axis.WindowShakeY, "Window Shake Y"},
		{Axis.Horizontal_Depricated, "Horizontal_Depricated"},
		{Axis.Vertical_Depricated, "Vertical_Depricated"},
		{Axis.Joystick1Axis1, "Joy1 Axis 1"},
		{Axis.Joystick1Axis2, "Joy1 Axis 2"},
		{Axis.Joystick1Axis3, "Joy1 Axis 3"},
		{Axis.Joystick1Axis4, "Joy1 Axis 4"},
		{Axis.Joystick1Axis5, "Joy1 Axis 5"},
		{Axis.Joystick1Axis6, "Joy1 Axis 6"},
		{Axis.Joystick1Axis7, "Joy1 Axis 7"},
		{Axis.Joystick1Axis8, "Joy1 Axis 8"},
		{Axis.Joystick1Axis9, "Joy1 Axis 9"},
		{Axis.Joystick1Axis10, "Joy1 Axis 10"},
		{Axis.Joystick2Axis1, "Joy2 Axis 1"},
		{Axis.Joystick2Axis2, "Joy2 Axis 2"},
		{Axis.Joystick2Axis3, "Joy2 Axis 3"},
		{Axis.Joystick2Axis4, "Joy2 Axis 4"},
		{Axis.Joystick2Axis5, "Joy2 Axis 5"},
		{Axis.Joystick2Axis6, "Joy2 Axis 6"},
		{Axis.Joystick2Axis7, "Joy2 Axis 7"},
		{Axis.Joystick2Axis8, "Joy2 Axis 8"},
		{Axis.Joystick2Axis9, "Joy2 Axis 9"},
		{Axis.Joystick2Axis10, "Joy2 Axis 10"},
		{Axis.Joystick3Axis1, "Joy3 Axis 1"},
		{Axis.Joystick3Axis2, "Joy3 Axis 2"},
		{Axis.Joystick3Axis3, "Joy3 Axis 3"},
		{Axis.Joystick3Axis4, "Joy3 Axis 4"},
		{Axis.Joystick3Axis5, "Joy3 Axis 5"},
		{Axis.Joystick3Axis6, "Joy3 Axis 6"},
		{Axis.Joystick3Axis7, "Joy3 Axis 7"},
		{Axis.Joystick3Axis8, "Joy3 Axis 8"},
		{Axis.Joystick3Axis9, "Joy3 Axis 9"},
		{Axis.Joystick3Axis10, "Joy3 Axis 10"},
		{Axis.Joystick4Axis1, "Joy4 Axis 1"},
		{Axis.Joystick4Axis2, "Joy4 Axis 2"},
		{Axis.Joystick4Axis3, "Joy4 Axis 3"},
		{Axis.Joystick4Axis4, "Joy4 Axis 4"},
		{Axis.Joystick4Axis5, "Joy4 Axis 5"},
		{Axis.Joystick4Axis6, "Joy4 Axis 6"},
		{Axis.Joystick4Axis7, "Joy4 Axis 7"},
		{Axis.Joystick4Axis8, "Joy4 Axis 8"},
		{Axis.Joystick4Axis9, "Joy4 Axis 9"},
		{Axis.Joystick4Axis10, "Joy4 Axis 10"},
		{Axis.Joystick5Axis1, "Joy5 Axis 1"},
		{Axis.Joystick5Axis2, "Joy5 Axis 2"},
		{Axis.Joystick5Axis3, "Joy5 Axis 3"},
		{Axis.Joystick5Axis4, "Joy5 Axis 4"},
		{Axis.Joystick5Axis5, "Joy5 Axis 5"},
		{Axis.Joystick5Axis6, "Joy5 Axis 6"},
		{Axis.Joystick5Axis7, "Joy5 Axis 7"},
		{Axis.Joystick5Axis8, "Joy5 Axis 8"},
		{Axis.Joystick5Axis9, "Joy5 Axis 9"},
		{Axis.Joystick5Axis10, "Joy5 Axis 10"},
		{Axis.Joystick6Axis1, "Joy6 Axis 1"},
		{Axis.Joystick6Axis2, "Joy6 Axis 2"},
		{Axis.Joystick6Axis3, "Joy6 Axis 3"},
		{Axis.Joystick6Axis4, "Joy6 Axis 4"},
		{Axis.Joystick6Axis5, "Joy6 Axis 5"},
		{Axis.Joystick6Axis6, "Joy6 Axis 6"},
		{Axis.Joystick6Axis7, "Joy6 Axis 7"},
		{Axis.Joystick6Axis8, "Joy6 Axis 8"},
		{Axis.Joystick6Axis9, "Joy6 Axis 9"},
		{Axis.Joystick6Axis10, "Joy6 Axis 10"},
		{Axis.Joystick7Axis1, "Joy7 Axis 1"},
		{Axis.Joystick7Axis2, "Joy7 Axis 2"},
		{Axis.Joystick7Axis3, "Joy7 Axis 3"},
		{Axis.Joystick7Axis4, "Joy7 Axis 4"},
		{Axis.Joystick7Axis5, "Joy7 Axis 5"},
		{Axis.Joystick7Axis6, "Joy7 Axis 6"},
		{Axis.Joystick7Axis7, "Joy7 Axis 7"},
		{Axis.Joystick7Axis8, "Joy7 Axis 8"},
		{Axis.Joystick7Axis9, "Joy7 Axis 9"},
		{Axis.Joystick7Axis10, "Joy7 Axis 10"},
		{Axis.Joystick8Axis1, "Joy8 Axis 1"},
		{Axis.Joystick8Axis2, "Joy8 Axis 2"},
		{Axis.Joystick8Axis3, "Joy8 Axis 3"},
		{Axis.Joystick8Axis4, "Joy8 Axis 4"},
		{Axis.Joystick8Axis5, "Joy8 Axis 5"},
		{Axis.Joystick8Axis6, "Joy8 Axis 6"},
		{Axis.Joystick8Axis7, "Joy8 Axis 7"},
		{Axis.Joystick8Axis8, "Joy8 Axis 8"},
		{Axis.Joystick8Axis9, "Joy8 Axis 9"},
		{Axis.Joystick8Axis10, "Joy8 Axis 10"},
		{Axis.Joystick9Axis1, "Joy9 Axis 1"},
		{Axis.Joystick9Axis2, "Joy9 Axis 2"},
		{Axis.Joystick9Axis3, "Joy9 Axis 3"},
		{Axis.Joystick9Axis4, "Joy9 Axis 4"},
		{Axis.Joystick9Axis5, "Joy9 Axis 5"},
		{Axis.Joystick9Axis6, "Joy9 Axis 6"},
		{Axis.Joystick9Axis7, "Joy9 Axis 7"},
		{Axis.Joystick9Axis8, "Joy9 Axis 8"},
		{Axis.Joystick9Axis9, "Joy9 Axis 9"},
		{Axis.Joystick9Axis10, "Joy9 Axis 10"},
		{Axis.Joystick10Axis1, "Joy10 Axis 1"},
		{Axis.Joystick10Axis2, "Joy10 Axis 2"},
		{Axis.Joystick10Axis3, "Joy10 Axis 3"},
		{Axis.Joystick10Axis4, "Joy10 Axis 4"},
		{Axis.Joystick10Axis5, "Joy10 Axis 5"},
		{Axis.Joystick10Axis6, "Joy10 Axis 6"},
		{Axis.Joystick10Axis7, "Joy10 Axis 7"},
		{Axis.Joystick10Axis8, "Joy10 Axis 8"},
		{Axis.Joystick10Axis9, "Joy10 Axis 9"},
		{Axis.Joystick10Axis10, "Joy10 Axis 10"},
		{Axis.None, ""}
	};
	
	/// <summary>
	/// The string to axis. Exists because users may be tempted to use string to delcare axis, 
	/// and Ouya-Unity-Plugin named the axis differently form Unity does.
	/// </summary>
	static Dictionary<string, Axis> StringToAxis = new Dictionary<string, Axis>() {
		{"horizontal", Axis.Horizontal},
		{"vertical", Axis.Vertical},
		{"fire1", Axis.Fire1},
		{"fire 1", Axis.Fire1},
		{"fire2", Axis.Fire1},
		{"fire 2", Axis.Fire2},
		{"fire3", Axis.Fire1},
		{"fire 3", Axis.Fire2},
		{"jump", Axis.Jump},
		{"mouse x", Axis.MouseX},
		{"mouse y", Axis.MouseY},
		{"mouse scrollwheel", Axis.MouseScrollWheel},
		{"mouse horizontal", Axis.MouseHorizontal},
		{"mouse vertical", Axis.MouseVertical},
		{"mouse wheel", Axis.MouseWheel},
		{"shift", Axis.Shift},
		{"window shake x", Axis.WindowShakeX},
		{"window shake y", Axis.WindowShakeY},
		{"horizontal_depricated", Axis.Horizontal_Depricated},
		{"vertical_depricated", Axis.Vertical_Depricated},
		{"joy1 axis 1", Axis.Joystick1Axis1},
		{"joy1 axis 2", Axis.Joystick1Axis2},
		{"joy1 axis 3", Axis.Joystick1Axis3},
		{"joy1 axis 4", Axis.Joystick1Axis4},
		{"joy1 axis 5", Axis.Joystick1Axis5},
		{"joy1 axis 6", Axis.Joystick1Axis6},
		{"joy1 axis 7", Axis.Joystick1Axis7},
		{"joy1 axis 8", Axis.Joystick1Axis8},
		{"joy1 axis 9", Axis.Joystick1Axis9},
		{"joy1 axis 10", Axis.Joystick1Axis10},
		{"joystick 1 axis 1", Axis.Joystick1Axis1},
		{"joystick 1 axis 2", Axis.Joystick1Axis2},
		{"joystick 1 axis 3", Axis.Joystick1Axis3},
		{"joystick 1 axis 4", Axis.Joystick1Axis4},
		{"joystick 1 axis 5", Axis.Joystick1Axis5},
		{"joystick 1 axis 6", Axis.Joystick1Axis6},
		{"joystick 1 axis 7", Axis.Joystick1Axis7},
		{"joystick 1 axis 8", Axis.Joystick1Axis8},
		{"joystick 1 axis 9", Axis.Joystick1Axis9},
		{"joystick 1 axis 10", Axis.Joystick1Axis10},
		{"joy2 axis 1", Axis.Joystick2Axis1},
		{"joy2 axis 2", Axis.Joystick2Axis2},
		{"joy2 axis 3", Axis.Joystick2Axis3},
		{"joy2 axis 4", Axis.Joystick2Axis4},
		{"joy2 axis 5", Axis.Joystick2Axis5},
		{"joy2 axis 6", Axis.Joystick2Axis6},
		{"joy2 axis 7", Axis.Joystick2Axis7},
		{"joy2 axis 8", Axis.Joystick2Axis8},
		{"joy2 axis 9", Axis.Joystick2Axis9},
		{"joy2 axis 10", Axis.Joystick2Axis10},
		{"joystick 2 axis 1", Axis.Joystick2Axis1},
		{"joystick 2 axis 2", Axis.Joystick2Axis2},
		{"joystick 2 axis 3", Axis.Joystick2Axis3},
		{"joystick 2 axis 4", Axis.Joystick2Axis4},
		{"joystick 2 axis 5", Axis.Joystick2Axis5},
		{"joystick 2 axis 6", Axis.Joystick2Axis6},
		{"joystick 2 axis 7", Axis.Joystick2Axis7},
		{"joystick 2 axis 8", Axis.Joystick2Axis8},
		{"joystick 2 axis 9", Axis.Joystick2Axis9},
		{"joystick 2 axis 10", Axis.Joystick2Axis10},
		{"joy3 axis 1", Axis.Joystick3Axis1},
		{"joy3 axis 2", Axis.Joystick3Axis2},
		{"joy3 axis 3", Axis.Joystick3Axis3},
		{"joy3 axis 4", Axis.Joystick3Axis4},
		{"joy3 axis 5", Axis.Joystick3Axis5},
		{"joy3 axis 6", Axis.Joystick3Axis6},
		{"joy3 axis 7", Axis.Joystick3Axis7},
		{"joy3 axis 8", Axis.Joystick3Axis8},
		{"joy3 axis 9", Axis.Joystick3Axis9},
		{"joy3 axis 10", Axis.Joystick3Axis10},
		{"joystick 3 axis 1", Axis.Joystick3Axis1},
		{"joystick 3 axis 2", Axis.Joystick3Axis2},
		{"joystick 3 axis 3", Axis.Joystick3Axis3},
		{"joystick 3 axis 4", Axis.Joystick3Axis4},
		{"joystick 3 axis 5", Axis.Joystick3Axis5},
		{"joystick 3 axis 6", Axis.Joystick3Axis6},
		{"joystick 3 axis 7", Axis.Joystick3Axis7},
		{"joystick 3 axis 8", Axis.Joystick3Axis8},
		{"joystick 3 axis 9", Axis.Joystick3Axis9},
		{"joystick 3 axis 10", Axis.Joystick3Axis10},
		{"joy4 axis 1", Axis.Joystick4Axis1},
		{"joy4 axis 2", Axis.Joystick4Axis2},
		{"joy4 axis 3", Axis.Joystick4Axis3},
		{"joy4 axis 4", Axis.Joystick4Axis4},
		{"joy4 axis 5", Axis.Joystick4Axis5},
		{"joy4 axis 6", Axis.Joystick4Axis6},
		{"joy4 axis 7", Axis.Joystick4Axis7},
		{"joy4 axis 8", Axis.Joystick4Axis8},
		{"joy4 axis 9", Axis.Joystick4Axis9},
		{"joy4 axis 10", Axis.Joystick4Axis10},
		{"joystick 4 axis 1", Axis.Joystick4Axis1},
		{"joystick 4 axis 2", Axis.Joystick4Axis2},
		{"joystick 4 axis 3", Axis.Joystick4Axis3},
		{"joystick 4 axis 4", Axis.Joystick4Axis4},
		{"joystick 4 axis 5", Axis.Joystick4Axis5},
		{"joystick 4 axis 6", Axis.Joystick4Axis6},
		{"joystick 4 axis 7", Axis.Joystick4Axis7},
		{"joystick 4 axis 8", Axis.Joystick4Axis8},
		{"joystick 4 axis 9", Axis.Joystick4Axis9},
		{"joystick 4 axis 10", Axis.Joystick4Axis10},
		{"joy5 axis 1", Axis.Joystick5Axis1},
		{"joy5 axis 2", Axis.Joystick5Axis2},
		{"joy5 axis 3", Axis.Joystick5Axis3},
		{"joy5 axis 4", Axis.Joystick5Axis4},
		{"joy5 axis 5", Axis.Joystick5Axis5},
		{"joy5 axis 6", Axis.Joystick5Axis6},
		{"joy5 axis 7", Axis.Joystick5Axis7},
		{"joy5 axis 8", Axis.Joystick5Axis8},
		{"joy5 axis 9", Axis.Joystick5Axis9},
		{"joy5 axis 10", Axis.Joystick5Axis10},
		{"joystick 5 axis 1", Axis.Joystick5Axis1},
		{"joystick 5 axis 2", Axis.Joystick5Axis2},
		{"joystick 5 axis 3", Axis.Joystick5Axis3},
		{"joystick 5 axis 4", Axis.Joystick5Axis4},
		{"joystick 5 axis 5", Axis.Joystick5Axis5},
		{"joystick 5 axis 6", Axis.Joystick5Axis6},
		{"joystick 5 axis 7", Axis.Joystick5Axis7},
		{"joystick 5 axis 8", Axis.Joystick5Axis8},
		{"joystick 5 axis 9", Axis.Joystick5Axis9},
		{"joystick 5 axis 10", Axis.Joystick5Axis10},
		{"joy6 axis 1", Axis.Joystick6Axis1},
		{"joy6 axis 2", Axis.Joystick6Axis2},
		{"joy6 axis 3", Axis.Joystick6Axis3},
		{"joy6 axis 4", Axis.Joystick6Axis4},
		{"joy6 axis 5", Axis.Joystick6Axis5},
		{"joy6 axis 6", Axis.Joystick6Axis6},
		{"joy6 axis 7", Axis.Joystick6Axis7},
		{"joy6 axis 8", Axis.Joystick6Axis8},
		{"joy6 axis 9", Axis.Joystick6Axis9},
		{"joy6 axis 10", Axis.Joystick6Axis10},
		{"joystick 6 axis 1", Axis.Joystick6Axis1},
		{"joystick 6 axis 2", Axis.Joystick6Axis2},
		{"joystick 6 axis 3", Axis.Joystick6Axis3},
		{"joystick 6 axis 4", Axis.Joystick6Axis4},
		{"joystick 6 axis 5", Axis.Joystick6Axis5},
		{"joystick 6 axis 6", Axis.Joystick6Axis6},
		{"joystick 6 axis 7", Axis.Joystick6Axis7},
		{"joystick 6 axis 8", Axis.Joystick6Axis8},
		{"joystick 6 axis 9", Axis.Joystick6Axis9},
		{"joystick 6 axis 10", Axis.Joystick6Axis10},
		{"joy7 axis 1", Axis.Joystick7Axis1},
		{"joy7 axis 2", Axis.Joystick7Axis2},
		{"joy7 axis 3", Axis.Joystick7Axis3},
		{"joy7 axis 4", Axis.Joystick7Axis4},
		{"joy7 axis 5", Axis.Joystick7Axis5},
		{"joy7 axis 6", Axis.Joystick7Axis6},
		{"joy7 axis 7", Axis.Joystick7Axis7},
		{"joy7 axis 8", Axis.Joystick7Axis8},
		{"joy7 axis 9", Axis.Joystick7Axis9},
		{"joy7 axis 10", Axis.Joystick7Axis10},
		{"joystick 7 axis 1", Axis.Joystick7Axis1},
		{"joystick 7 axis 2", Axis.Joystick7Axis2},
		{"joystick 7 axis 3", Axis.Joystick7Axis3},
		{"joystick 7 axis 4", Axis.Joystick7Axis4},
		{"joystick 7 axis 5", Axis.Joystick7Axis5},
		{"joystick 7 axis 6", Axis.Joystick7Axis6},
		{"joystick 7 axis 7", Axis.Joystick7Axis7},
		{"joystick 7 axis 8", Axis.Joystick7Axis8},
		{"joystick 7 axis 9", Axis.Joystick7Axis9},
		{"joystick 7 axis 10", Axis.Joystick7Axis10},
		{"joy8 axis 1", Axis.Joystick8Axis1},
		{"joy8 axis 2", Axis.Joystick8Axis2},
		{"joy8 axis 3", Axis.Joystick8Axis3},
		{"joy8 axis 4", Axis.Joystick8Axis4},
		{"joy8 axis 5", Axis.Joystick8Axis5},
		{"joy8 axis 6", Axis.Joystick8Axis6},
		{"joy8 axis 7", Axis.Joystick8Axis7},
		{"joy8 axis 8", Axis.Joystick8Axis8},
		{"joy8 axis 9", Axis.Joystick8Axis9},
		{"joy8 axis 10", Axis.Joystick8Axis10},
		{"joystick 8 axis 1", Axis.Joystick8Axis1},
		{"joystick 8 axis 2", Axis.Joystick8Axis2},
		{"joystick 8 axis 3", Axis.Joystick8Axis3},
		{"joystick 8 axis 4", Axis.Joystick8Axis4},
		{"joystick 8 axis 5", Axis.Joystick8Axis5},
		{"joystick 8 axis 6", Axis.Joystick8Axis6},
		{"joystick 8 axis 7", Axis.Joystick8Axis7},
		{"joystick 8 axis 8", Axis.Joystick8Axis8},
		{"joystick 8 axis 9", Axis.Joystick8Axis9},
		{"joystick 8 axis 10", Axis.Joystick8Axis10},
		{"joy9 axis 1", Axis.Joystick9Axis1},
		{"joy9 axis 2", Axis.Joystick9Axis2},
		{"joy9 axis 3", Axis.Joystick9Axis3},
		{"joy9 axis 4", Axis.Joystick9Axis4},
		{"joy9 axis 5", Axis.Joystick9Axis5},
		{"joy9 axis 6", Axis.Joystick9Axis6},
		{"joy9 axis 7", Axis.Joystick9Axis7},
		{"joy9 axis 8", Axis.Joystick9Axis8},
		{"joy9 axis 9", Axis.Joystick9Axis9},
		{"joy9 axis 10", Axis.Joystick9Axis10},
		{"joystick 9 axis 1", Axis.Joystick9Axis1},
		{"joystick 9 axis 2", Axis.Joystick9Axis2},
		{"joystick 9 axis 3", Axis.Joystick9Axis3},
		{"joystick 9 axis 4", Axis.Joystick9Axis4},
		{"joystick 9 axis 5", Axis.Joystick9Axis5},
		{"joystick 9 axis 6", Axis.Joystick9Axis6},
		{"joystick 9 axis 7", Axis.Joystick9Axis7},
		{"joystick 9 axis 8", Axis.Joystick9Axis8},
		{"joystick 9 axis 9", Axis.Joystick9Axis9},
		{"joystick 9 axis 10", Axis.Joystick9Axis10},
		{"joy10 axis 1", Axis.Joystick2Axis1},
		{"joy10 axis 2", Axis.Joystick2Axis2},
		{"joy10 axis 3", Axis.Joystick2Axis3},
		{"joy10 axis 4", Axis.Joystick2Axis4},
		{"joy10 axis 5", Axis.Joystick2Axis5},
		{"joy10 axis 6", Axis.Joystick2Axis6},
		{"joy10 axis 7", Axis.Joystick2Axis7},
		{"joy10 axis 8", Axis.Joystick2Axis8},
		{"joy10 axis 9", Axis.Joystick2Axis9},
		{"joy10 axis 10", Axis.Joystick2Axis10},
		{"joystick 10 axis 1", Axis.Joystick10Axis1},
		{"joystick 10 axis 2", Axis.Joystick10Axis2},
		{"joystick 10 axis 3", Axis.Joystick10Axis3},
		{"joystick 10 axis 4", Axis.Joystick10Axis4},
		{"joystick 10 axis 5", Axis.Joystick10Axis5},
		{"joystick 10 axis 6", Axis.Joystick10Axis6},
		{"joystick 10 axis 7", Axis.Joystick10Axis7},
		{"joystick 10 axis 8", Axis.Joystick10Axis8},
		{"joystick 10 axis 9", Axis.Joystick10Axis9},
		{"joystick 10 axis 10", Axis.Joystick10Axis10}
	};
	
	/// <summary>
	/// The string to key code.
	/// </summary>
	static Dictionary<string, KeyCode> StringToKeyCode = new Dictionary<string, KeyCode>() {
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
	/// <summary>
	/// The profiles.
	/// </summary>
	static private Dictionary<string, OInputProfile> Profiles;
	
	/// <summary>
	/// The default profile.
	/// </summary>
	static private OInputProfile DefaultProfile;
	
	/// <summary>
	/// Gets the current axis.
	/// </summary>
	/// <returns>
	/// The current axis.
	/// </returns>
	static public Axis GetCurrentAxis() {
		Dictionary<Axis, string>.Enumerator enumerator = AxisMap.GetEnumerator();
		while (enumerator.MoveNext()) {
			if (Input.GetAxis(enumerator.Current.Value) > 0.0f || Input.GetAxis(enumerator.Current.Value) < 0.0f) return enumerator.Current.Key;
		}
		
		return Axis.None;
	}
	
	/// <summary>
	/// Gets the current key.
	/// </summary>
	/// <returns>
	/// The current key.
	/// </returns>
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
	
	/// <summary>
	/// Gets the current key down.
	/// </summary>
	/// <returns>
	/// The current key down.
	/// </returns>
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
	
	/// <summary>
	/// Gets the current key up.
	/// </summary>
	/// <returns>
	/// The current key up.
	/// </returns>
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
	
	/// <summary>
	/// Gets the current negative axis.
	/// </summary>
	/// <returns>
	/// The current negative axis.
	/// </returns>
	static public Axis GetCurrentNegativeAxis() {
		Dictionary<Axis, string>.Enumerator enumerator = AxisMap.GetEnumerator();
		while (enumerator.MoveNext()) {
			if (Input.GetAxis(enumerator.Current.Value) < 0.0f) return enumerator.Current.Key;
		}
		
		return Axis.None;
	}
	
	/// <summary>
	/// Gets the current positive axis.
	/// </summary>
	/// <returns>
	/// The current positive axis.
	/// </returns>
	static public Axis GetCurrentPositiveAxis() {
		Dictionary<Axis, string>.Enumerator enumerator = AxisMap.GetEnumerator();
		while (enumerator.MoveNext()) {
			if (Input.GetAxis(enumerator.Current.Value) > 0.0f) return enumerator.Current.Key;
		}
		
		return Axis.None;
	}
	
	/// <summary>
	/// Gets the default profile.
	/// </summary>
	/// <returns>
	/// The default profile.
	/// </returns>
	static public OInputProfile GetDefaultProfile() {
		if (DefaultProfile == null) {
			DefaultProfile = GetProfile("default");
			return DefaultProfile;
		} else {
			return DefaultProfile;
		}
	}
	
	/// <summary>
	/// Gets the profile.
	/// </summary>
	/// <returns>
	/// The profile.
	/// </returns>
	/// <param name='profileId'>
	/// Profile identifier.
	/// </param>
	static public OInputProfile GetProfile(string profileId) {
		if (Profiles == null) Profiles = new Dictionary<string, OInputProfile>();
		
		OInputProfile profile;
		if (Profiles.TryGetValue(profileId, out profile)) {
			return profile;
		} else {
			Profiles[profileId] = new OInputProfile(profileId);
			return Profiles[profileId];
		}
	}
	
	/*
	 * OInputProfile class
	 */
	/// <summary>
	/// Open input profile.
	/// </summary>
	/// <exception cref='UnityException'>
	/// Is thrown when the unity exception.
	/// </exception>
	public class OInputProfile {
		Dictionary<string, List<Axis>> AxisActions;
		Dictionary<string, List<AxisKeys>> AxisKeysActions;
		Dictionary<string, List<KeyCode>> ButtonActions;
		string id;
		
		/// <summary>
		/// Gets a value indicating whether this <see cref="OInput.OInputProfile"/> any axis.
		/// </summary>
		/// <value>
		/// <c>true</c> if any axis; otherwise, <c>false</c>.
		/// </value>
		public bool anyAxis {
			get {
				Dictionary<string, List<Axis>>.Enumerator axisActionsEnumerator = AxisActions.GetEnumerator();
				while(axisActionsEnumerator.MoveNext()) {
					List<Axis>.Enumerator axisEnumerator = axisActionsEnumerator.Current.Value.GetEnumerator();
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
		
		/// <summary>
		/// Gets a value indicating whether this <see cref="OInput.OInputProfile"/> any button.
		/// </summary>
		/// <value>
		/// <c>true</c> if any button; otherwise, <c>false</c>.
		/// </value>
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
		
		/// <summary>
		/// Gets a value indicating whether this <see cref="OInput.OInputProfile"/> any button down.
		/// </summary>
		/// <value>
		/// <c>true</c> if any button down; otherwise, <c>false</c>.
		/// </value>
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
		
		/// <summary>
		/// Initializes a new instance of the <see cref="OInput.OInputProfile"/> class.
		/// </summary>
		/// <param name='profileId'>
		/// Profile identifier.
		/// </param>
		public OInputProfile(string profileId) {
			ButtonActions = new Dictionary<string, List<KeyCode>>();
			AxisActions = new Dictionary<string, List<Axis>>();
			AxisKeysActions = new Dictionary<string, List<AxisKeys>>();
			
			id = profileId;
		}
		
		/// <summary>
		/// Gets the axis.
		/// </summary>
		/// <returns>
		/// The axis.
		/// </returns>
		/// <param name='actionName'>
		/// Action name.
		/// </param>
		public float GetAxis(string actionName) {
			if (AxisActions.ContainsKey(actionName)) {
				List<Axis>.Enumerator enumerator = AxisActions[actionName].GetEnumerator();
				
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
		
		/// <summary>
		/// Gets the axis raw.
		/// </summary>
		/// <returns>
		/// The axis raw.
		/// </returns>
		/// <param name='actionName'>
		/// Action name.
		/// </param>
		public float GetAxisRaw(string actionName) {
			if (AxisActions.ContainsKey(actionName)) {
				List<Axis>.Enumerator enumerator = AxisActions[actionName].GetEnumerator();
				
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
		
		/// <summary>
		/// Gets the button.
		/// </summary>
		/// <returns>
		/// The button.
		/// </returns>
		/// <param name='actionName'>
		/// If set to <c>true</c> action name.
		/// </param>
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
		
		/// <summary>
		/// Gets the button axis.
		/// </summary>
		/// <returns>
		/// The button axis.
		/// </returns>
		/// <param name='actionName'>
		/// Action name.
		/// </param>
		/// <param name='actionExists'>
		/// Action exists.
		/// </param>
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
				if (!actionExists) {
					Debug.LogWarning("\"" + actionName + "\" is not defined as an axis action.");
				}
				return 0.0f;
			}
		}
		
		/// <summary>
		/// Gets the button down.
		/// </summary>
		/// <returns>
		/// The button down.
		/// </returns>
		/// <param name='actionName'>
		/// If set to <c>true</c> action name.
		/// </param>
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
		
		/// <summary>
		/// Gets the button up.
		/// </summary>
		/// <returns>
		/// The button up.
		/// </returns>
		/// <param name='actionName'>
		/// If set to <c>true</c> action name.
		/// </param>
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
		
		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <returns>
		/// The identifier.
		/// </returns>
		public string GetId() {
			return id;
		}
		
		/// <summary>
		/// Sets as default profile.
		/// </summary>
		public void SetAsDefaultProfile() {
			DefaultProfile = this;
		}
		
		/// <summary>
		/// Sets the axis.
		/// </summary>
		/// <param name='action'>
		/// Action.
		/// </param>
		/// <param name='positiveKey'>
		/// Positive key.
		/// </param>
		/// <param name='negativeKey'>
		/// Negative key.
		/// </param>
		/// <exception cref='UnityException'>
		/// Is thrown when the unity exception.
		/// </exception>
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
		
		/// <summary>
		/// Sets the axis.
		/// </summary>
		/// <param name='action'>
		/// Action.
		/// </param>
		/// <param name='positiveKey'>
		/// Positive key.
		/// </param>
		/// <param name='negativeKey'>
		/// Negative key.
		/// </param>
		/// <exception cref='UnityException'>
		/// Is thrown when the unity exception.
		/// </exception>
		public void SetAxis(string action, KeyCode positiveKey, string negativeKey) {
			KeyCode negative;
			if (StringToKeyCode.TryGetValue(negativeKey.ToLower(), out negative)) {
				SetAxis(action, positiveKey, negative);
			} else {
				throw new UnityException("Negative key \"" + negativeKey + "\" is unknown.");
			}			
		}
		
		/// <summary>
		/// Sets the axis.
		/// </summary>
		/// <param name='action'>
		/// Action.
		/// </param>
		/// <param name='positiveKey'>
		/// Positive key.
		/// </param>
		/// <param name='negativeKey'>
		/// Negative key.
		/// </param>
		/// <exception cref='UnityException'>
		/// Is thrown when the unity exception.
		/// </exception>
		public void SetAxis(string action, string positiveKey, KeyCode negativeKey) {
			KeyCode positive;
			if (StringToKeyCode.TryGetValue(positiveKey.ToLower(), out positive)) {
				SetAxis(action, positive, negativeKey);
			} else {
				throw new UnityException("Positive key \"" + positiveKey + "\" is unknown.");
			}
		}
		
		/// <summary>
		/// Sets the axis.
		/// </summary>
		/// <param name='action'>
		/// Action.
		/// </param>
		/// <param name='positiveKey'>
		/// Positive key.
		/// </param>
		/// <param name='negativeKey'>
		/// Negative key.
		/// </param>
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
		
		/// <summary>
		/// Sets the axis.
		/// </summary>
		/// <param name='action'>
		/// Action.
		/// </param>
		/// <param name='unityAxis'>
		/// Unity axis.
		/// </param>
		public void SetAxis(string action, Axis unityAxis) {
			List<Axis> listOfAxis;
			if (!AxisActions.TryGetValue(action, out listOfAxis)) {
				AxisActions.Add(action, new List<Axis>());
				listOfAxis = AxisActions[action];
			}
		
			if (listOfAxis.Contains(unityAxis)) {
				Debug.LogWarning("\"" + AxisMap[unityAxis] + "\" for \"" + action + "\" is already defined for this profile.");
			} else {
				listOfAxis.Add(unityAxis);
			}
		}
		
		/// <summary>
		/// Sets the button.
		/// </summary>
		/// <param name='action'>
		/// Action.
		/// </param>
		/// <param name='key'>
		/// Key.
		/// </param>
		/// <exception cref='UnityException'>
		/// Is thrown when the unity exception.
		/// </exception>
		public void SetButton(string action, string key) {
			KeyCode keyCode;
			if (StringToKeyCode.TryGetValue(key, out keyCode)) {
				SetButton(action, keyCode);
			} else {
				throw new UnityException("Key \"" + key + "\" is unknown.");
			}
		}
		
		/// <summary>
		/// Sets the button.
		/// </summary>
		/// <param name='action'>
		/// Action.
		/// </param>
		/// <param name='key'>
		/// Key.
		/// </param>
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
		
		/// <summary>
		/// Unsets the axis.
		/// </summary>
		/// <param name='action'>
		/// Action.
		/// </param>
		/// <param name='positiveKey'>
		/// Positive key.
		/// </param>
		/// <param name='negativeKey'>
		/// Negative key.
		/// </param>
		public void UnsetAxis(string action, KeyCode positiveKey, KeyCode negativeKey) {
			
		}
		
		/// <summary>
		/// Unsets the axis.
		/// </summary>
		/// <param name='action'>
		/// Action.
		/// </param>
		public void UnsetAxis(string action) {
			if (!AxisActions.Remove(action) && !AxisKeysActions.Remove(action)) {
				Debug.LogWarning("Could not remove \"" + action + "\" from the axis.");
			}
		}
		
		/// <summary>
		/// Unsets the button.
		/// </summary>
		/// <param name='action'>
		/// Action.
		/// </param>
		public void UnsetButton(string action) {
			if (!ButtonActions.Remove(action)) {
				Debug.LogWarning("Could not remove \"" + action + "\" from the keys.");
			}
		}
		
	}
}
