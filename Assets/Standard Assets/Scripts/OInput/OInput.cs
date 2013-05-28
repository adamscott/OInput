using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

static public class OInput {
	
	public enum Axis {
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
		None
	}
	
	public enum Joystick {
		Joystick1,
		Joystick2,
		Joystick3,
		Joystick4
	}
	
	static internal readonly Dictionary<Axis,string> AxisToString = new Dictionary<Axis, string>(){
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
	
	static internal readonly Dictionary<string, Axis> StringToAxis = new Dictionary<string, Axis>() {
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
	
	static internal readonly Dictionary<string, KeyCode> StringToKeyCode = new Dictionary<string, KeyCode>() {
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
		
	const string DEFAULT_PROFILE_ID = "default";
	const string DETECT_KEY_UP = "detectKeyUp";
	const string DETECT_KEY_DOWN = "detectKeyDown";
	const string DETECT_KEY = "detectKey";
	
	static internal Profile _defaultProfile;
	
	static Dictionary<string, Profile> _profiles = new Dictionary<string, Profile>();
	
	static public Axis DetectAxis() {
		foreach (Axis axis in System.Enum.GetValues(typeof(Axis))) {
			switch (axis) {
			case Axis.None:
				continue;
			default:
				if (Input.GetAxisRaw(AxisToString[axis]) != 0.0f) return axis;
				break;
			}
		}
		
		return Axis.None;
	}
	
	static public KeyCode DetectKey() {
		return DetectKeyType(DETECT_KEY);
	}
	
	static public KeyCode DetectKeyUp() {
		return DetectKeyType(DETECT_KEY_UP);
	}
	
	static public KeyCode DetectKeyDown() {
		return DetectKeyType(DETECT_KEY_DOWN);
	}
	
	static private KeyCode DetectKeyType(string type) {
		foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode))) {
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
			case KeyCode.None:
				continue;
			default:
				if ((type == DETECT_KEY && Input.GetKey(key))
					|| (type == DETECT_KEY_DOWN && Input.GetKeyDown(key))
					|| (type == DETECT_KEY_UP && Input.GetKeyUp(key))) {
					return key;
				}
				break;
			}
		}
		
		return KeyCode.None;	
	}
	
	static public Profile GetProfile(string id) {
		OInput.Profile profile;
		if (!_profiles.TryGetValue(id, out profile)) {
			_profiles.Add(id, new Profile(id));
			profile = _profiles[id];
		}
		
		return profile;
	}
	
	static public Profile GetDefaultProfile() {
		if (_defaultProfile == null) {
			return GetProfile(DEFAULT_PROFILE_ID);
		} else {
			return _defaultProfile;
		}	
	}
	
	static public void RemoveProfile(string id) {
		OInput.Profile profile;
		if (!_profiles.TryGetValue(id, out profile)) {
			if (profile.Equals(_defaultProfile)) {
				_defaultProfile = null;
			}
			
			profile.Dispose();
			profile = null;
			_profiles.Remove(id);
		}
	}
	
	public class Profile {
		Dictionary<string, OInputAxisAction> _axisActions;
		Dictionary<string, OInputButtonAction> _buttonActions;
		
		string id;
		
		public Profile(string id) {
			this.id = id;
			_axisActions = new Dictionary<string, OInputAxisAction>();
			_buttonActions = new Dictionary<string, OInputButtonAction>();
		}
		
		public float GetAxis(string action) {
			OInputAxisAction axisAction;
			if (_axisActions.TryGetValue(action, out axisAction)) {
				return axisAction.Test();
			} else {
				Debug.LogError(action + " is not defined as an axis action.");
				return 0.0f;
			}
		}
		
		public float GetAxisRaw(string action) {
			OInputAxisAction axisAction;
			if (_axisActions.TryGetValue(action, out axisAction)) {
				return axisAction.TestRaw();
			} else {
				Debug.LogError(action + " is not defined as an axis action.");
				return 0.0f;
			}
		}
		
		public Profile SetAxis(string action, Axis axis, bool remap = false) {
			OInputAxisAction axisAction = GetAxisAction(action);
			if (!remap) {
				axisAction.AddAxis(axis);
			} else {
				axisAction.AddRemappedAxis(axis);
			}
			
			return this;
		}
		
		public Profile SetAxis(string action, string axis, bool remap = false) {
			OInputAxisAction axisAction = GetAxisAction(action);
			if (!remap) {
				axisAction.AddAxis(axis);
			} else {
				axisAction.AddRemappedAxis(axis);
			}
			
			return this;
		}
		
		public Profile SetAxisKeys(string action, KeyCode negativeKey, KeyCode positiveKey) {
			GetAxisAction(action).AddAxisKeys(negativeKey, positiveKey);
			return this;
		}
		
		public Profile SetAxisKeys(string action, string negativeKey, string positiveKey) {
			GetAxisAction(action).AddAxisKeys(negativeKey, positiveKey);
			return this;
		}
		
		public Profile SetAxisMix(string action, Axis negativeAxis, Axis positiveAxis) {
			GetAxisAction(action).AddAxisMix(negativeAxis, positiveAxis);
			return this;
		}
		
		public Profile SetAxisMix(string action, string negativeAxis, string positiveAxis) {
			GetAxisAction(action).AddAxisMix(negativeAxis, positiveAxis);
			return this;
		}
		
		public bool GetButton(string action) {
			if (_buttonActions.ContainsKey(action)) {
				return GetButtonAction(action).Test();
			} else {
				Debug.LogError("No button linked to action " + action);
				return false;
			}
		}
		
		public bool GetButtonDown(string action) {
			if (_buttonActions.ContainsKey(action)) {
				return GetButtonAction(action).TestDown();
			} else {
				Debug.LogError("No button linked to action " + action);
				return false;
			}
		}
		
		public bool GetButtonUp(string action) {
			if (_buttonActions.ContainsKey(action)) {
				return GetButtonAction(action).TestUp();
			} else {
				Debug.LogError("No button linked to action " + action);
				return false;
			}
		}
		
		public Profile SetButton(string action, KeyCode key) {
			GetButtonAction(action).Add(key);
			return this;
		}
		
		public Profile SetButton(string action, string key) {
			GetButtonAction(action).Add(key);
			return this;
		}
		
		public bool Save() {
			return false;
		}
		
		public bool Load() {
			return false;
		}
		
		public Profile SetAsDefault() {
			_defaultProfile = this;
			return this;
		}
		
		private OInputAxisAction GetAxisAction(string action) {
			OInputAxisAction axisAction;
			if (!_axisActions.TryGetValue(action, out axisAction)) {
				_axisActions.Add(action, new OInputAxisAction(id));
				axisAction = _axisActions[action];
			}
			return axisAction;
		}
		
		private OInputButtonAction GetButtonAction(string action) {
			OInputButtonAction buttonAction;
			if (!_buttonActions.TryGetValue(action, out buttonAction)) {
				_buttonActions.Add(action, new OInputButtonAction(id));
				buttonAction = _buttonActions[action];
			}
			return buttonAction;
		}
		
		internal void Dispose() {
			Dictionary<string, OInputAxisAction>.Enumerator axisActionEnumerator = _axisActions.GetEnumerator();
			while (axisActionEnumerator.MoveNext()) {
				axisActionEnumerator.Current.Value.Dispose();
			}
			
			Dictionary<string, OInputButtonAction>.Enumerator axisButtonEnumerator = _buttonActions.GetEnumerator();
			while (axisButtonEnumerator.MoveNext()) {
				axisButtonEnumerator.Current.Value.Dispose();
			}
			
			_axisActions.Clear();
			_axisActions = null;
			
			_buttonActions.Clear();
			_buttonActions = null;
		}
		
		/*
		 * Unity defaults
		 */
		
		public bool GetKey(KeyCode key) {
			return Input.GetKey(key);
		}
		
		public bool GetKey(string name) {
			return Input.GetKey(name);
		}
		
		public string[] GetJoystickNames() {
			return Input.GetJoystickNames();
		}
		
		public bool GetMouseButton(int button) {
			return Input.GetMouseButton(button);
		}
		
		public bool GetMouseButtonDown(int button) {
			return Input.GetMouseButtonDown(button);
		}
		
		public bool GetMouseButtonUp(int button) {
			return Input.GetMouseButtonUp(button);
		}
		
		public void ResetInputAxes() {
			Input.ResetInputAxes();
		}
		
		public AccelerationEvent GetAccelerationEvent(int index) {
			return Input.GetAccelerationEvent(index);
		}
		
		public Touch GetTouch(int index) {
			return Input.GetTouch(index);
		}
		
	}
	
	private abstract class OInputAction {
		public string id;
		
		public OInputAction(string id) {
			this.id = id;
		}
		
		public virtual void Dispose() {
			id = null;
		}
	}
	
	private class OInputAxisAction:OInputAction {
		
		struct KeyCodePair {
			public KeyCode Positive;
			public KeyCode Negative;
		}
		
		struct AxisPair {
			public Axis Positive;
			public Axis Negative;
		}
		
		List<Axis> _axes;
		List<Axis> _axesRemap;
		Dictionary<string, KeyCodePair> _axesKeys;
		Dictionary<string, AxisPair> _axesMix;
		
		public OInputAxisAction(string id):base(id) {
			_axes = new List<Axis>();
			_axesRemap = new List<Axis>();
			_axesKeys = new Dictionary<string, KeyCodePair>();
			_axesMix = new Dictionary<string, AxisPair>();
		}
		
		public void AddAxis(Axis axis) {
			if (_axes.Contains(axis)) {
				Debug.LogWarning("Axis already binded to this action.");
				return;
			}
			
			_axes.Add(axis);
		}
		
		public void AddAxis(string axis) {
			Axis realAxis;
			if (StringToAxis.TryGetValue(axis, out realAxis)) {
				AddAxis(realAxis);
			} else {
				Debug.LogError(axis + " is not a defined axis.");
				return;
			}
		}
		
		public void AddRemappedAxis(Axis axisToRemap) {
			if (_axesRemap.Contains(axisToRemap)) {
				Debug.LogWarning("Axis to remap already defined to this action.");
				return;
			}
			
			_axesRemap.Add(axisToRemap);
		}
		
		public void AddRemappedAxis(string axisToRemap) {
			Axis realAxis;
			if (StringToAxis.TryGetValue(axisToRemap, out realAxis)) {
				AddRemappedAxis(realAxis);
			} else {
				Debug.LogError(axisToRemap + " is not a defined axis.");
				return;
			}
		}
		
		public void AddAxisMix(Axis negativeAxis, Axis positiveAxis) {
			string dictionaryKey = negativeAxis.ToString() + positiveAxis.ToString();
			if (_axesMix.ContainsKey(dictionaryKey)) {
				Debug.LogWarning("Virtual axis already binded to this action.");
				return;
			}
			
			AxisPair pair = new AxisPair();
			pair.Positive = positiveAxis;
			pair.Negative = negativeAxis;
			
			_axesMix.Add(dictionaryKey, pair);
		}
		
		public void AddAxisMix(string negativeAxis, string positiveAxis) {
			Axis realNegativeAxis;
			Axis realPositiveAxis;
			
			if (StringToAxis.TryGetValue(negativeAxis, out realNegativeAxis) 
				&& StringToAxis.TryGetValue(positiveAxis, out realPositiveAxis)) {
				AddAxisMix(realNegativeAxis, realPositiveAxis);
			} else {
				if (!StringToAxis.ContainsKey(negativeAxis)) {
					Debug.LogError(negativeAxis + " is not a defined key.");
				} else {
					Debug.LogError(positiveAxis + " is not a defined key.");
				}
				return;
			}
		}
		
		public void AddAxisKeys(KeyCode negativeKey, KeyCode positiveKey) {
			string dictionaryKey = negativeKey.ToString() + positiveKey.ToString();
			if (_axesKeys.ContainsKey(dictionaryKey)) {
				Debug.LogWarning("Keys already binded to this action.");
				return;
			}
			
			KeyCodePair pair = new KeyCodePair();
			pair.Positive = positiveKey;
			pair.Negative = negativeKey;
			
			_axesKeys.Add(dictionaryKey, pair);
		}
		
		public void AddAxisKeys(string negativeKey, string positiveKey) {
			KeyCode realNegativeKey;
			KeyCode realPositiveKey;
			if (StringToKeyCode.TryGetValue(negativeKey, out realNegativeKey) 
				&& StringToKeyCode.TryGetValue(positiveKey, out realPositiveKey)) {
				AddAxisKeys(realNegativeKey, realPositiveKey);
			} else {
				if (!StringToKeyCode.ContainsKey(negativeKey)) {
					Debug.LogError(negativeKey + " is not a defined key.");
				} else {
					Debug.LogError(positiveKey + " is not a defined key.");
				}
				return;
			}
		}
		
		public float Test() {
			
			foreach (Axis axis in _axes) {
				if (Input.GetAxis(AxisToString[axis]) != 0.0f) {
					float axisValue = Input.GetAxis(AxisToString[axis]);
					return axisValue;
				}
			}
			
			foreach (Axis axis in _axesRemap) {
				float axisValue = Input.GetAxis(AxisToString[axis]);
				axisValue = (axisValue + 1) / 2; // This converts -1/1 range to 0/1: -1 maps to 0, 1 maps to 1.
				
				if (axisValue > 0.0f) {
					return axisValue;
				}
			}
			
			Dictionary<string, AxisPair>.Enumerator axisPairEnumerator = _axesMix.GetEnumerator();
			while (axisPairEnumerator.MoveNext()) {
				AxisPair pair = axisPairEnumerator.Current.Value;
				float negativeValue = Input.GetAxis(AxisToString[pair.Negative]);
				float positiveValue = Input.GetAxis(AxisToString[pair.Positive]);
				
				negativeValue = -((negativeValue + 1) / 2); // This converts -1/1 range to 0/-1
				positiveValue = (positiveValue + 1) / 2; // This converts -1/1 range to 0/1
				
				float axisValue = negativeValue + positiveValue;
				if (axisValue != 0.0f) {
					return axisValue;
				}
			}
			
			Dictionary<string, KeyCodePair>.Enumerator keyEnumerator = _axesKeys.GetEnumerator();
			while (keyEnumerator.MoveNext()) {
				KeyCodePair pair = keyEnumerator.Current.Value;
				if (Input.GetKey(pair.Positive) && Input.GetKey(pair.Negative)) {
					return GetSmoothedValue(0.0f);
				} else if (Input.GetKey(pair.Positive)) {
					return GetSmoothedValue(1.0f);
				} else if (Input.GetKey(pair.Negative)) {
					return GetSmoothedValue(-1.0f);
				} else {
					return GetSmoothedValue(0.0f);
				}
			}
			
			return 0.0f;
		}
		
		public float TestRaw() {
			foreach (Axis axis in _axes) {
				if (Input.GetAxis(AxisToString[axis]) != 0.0f) return Input.GetAxis(AxisToString[axis]);
			}
			
			foreach (Axis axis in _axesRemap) {
				float axisValue = Input.GetAxis(AxisToString[axis]);
				axisValue = (axisValue + 1) / 2; // This converts -1/1 range to 0/1: -1 maps to 0, 1 maps to 1.
				
				if (axisValue > 0.0f) {
					return axisValue;
				}
			}
			
			Dictionary<string, AxisPair>.Enumerator axisPairEnumerator = _axesMix.GetEnumerator();
			while (axisPairEnumerator.MoveNext()) {
				AxisPair pair = axisPairEnumerator.Current.Value;
				float negativeValue = Input.GetAxis(AxisToString[pair.Negative]);
				float positiveValue = Input.GetAxis(AxisToString[pair.Positive]);
				
				negativeValue = -((negativeValue + 1) / 2); // This converts -1/1 range to 0/-1
				positiveValue = (positiveValue + 1) / 2; // This converts -1/1 range to 0/1
				
				float axisValue = negativeValue + positiveValue;
				if (axisValue != 0.0f) {
					return axisValue;
				}
			}
			
			Dictionary<string, KeyCodePair>.Enumerator enumerator = _axesKeys.GetEnumerator();
			while (enumerator.MoveNext()) {
				KeyCodePair pair = enumerator.Current.Value;
				if (Input.GetKey(pair.Positive) && Input.GetKey(pair.Negative)) {
					return 0.0f;
				} else if (Input.GetKey(pair.Positive)) {
					return 1.0f;
				} else if (Input.GetKey(pair.Negative)) {
					return -1.0f;
				}
			}
			
			return 0.0f;
		}
		
		public override void Dispose() {
			base.Dispose();
			
			_axes.Clear();
			_axes = null;
			
			_axesKeys.Clear();
			_axesKeys = null;
			
			_axesMix.Clear();
			_axesMix = null;
			
			_axesRemap.Clear();
			_axesRemap = null;
		}
		
		// To implement key smoothing
		private float GetSmoothedValue(float valueToSmooth) {
			return valueToSmooth;
		}
	}
	
	private class OInputButtonAction:OInputAction {
		List<KeyCode> _buttonKeys;
		
		public OInputButtonAction(string id):base(id) {
			_buttonKeys = new List<KeyCode>();
		}
		
		public void Add(KeyCode key) {
			_buttonKeys.Add(key);
		}
		
		public void Add(string key) {
			KeyCode realKey;
			if (StringToKeyCode.TryGetValue(key, out realKey)) {
				Add(realKey);
			} else {
				Debug.LogError(key + " is not a defined key.");
			}
		}
		
		public bool Test() {
			foreach (KeyCode buttonKey in _buttonKeys) {
				if (Input.GetKey(buttonKey)) {
					return true;
				}
			}	
			return false;
		}
		
		public bool TestUp() {
			foreach (KeyCode buttonKey in _buttonKeys) {
				if (Input.GetKeyUp(buttonKey)) {
					return true;
				}
			}	
			return false;
		}
		
		public bool TestDown() {
			foreach (KeyCode buttonKey in _buttonKeys) {
				if (Input.GetKeyDown(buttonKey)) {
					return true;
				}
			}	
			return false;
		}
		
		public override void Dispose() {
			base.Dispose();
			
			_buttonKeys.Clear();
			_buttonKeys = null;
		}
	}
	
	static public class Xbox {
		public enum ControllerButton {
			A,
			B,
			X,
			Y,
			Start,
			Back,
			LB,
			RB,
			LeftStick,
			RightStick,
			Xbox
		}
		
		public enum ControllerAxis {
			LeftStickX,
			LeftStickY,
			DPadX,
			DPadY,
			RightStickX,
			RightStickY,
			LT,
			RT
		}
		
		static Dictionary<OInput.Profile, OInput.Xbox.Wrapper> _wrappers = new Dictionary<OInput.Profile, OInput.Xbox.Wrapper>();
		
		
		static public Wrapper GetWrapper(OInput.Profile profile) {
			Wrapper wrapper;
			if (!_wrappers.TryGetValue(profile, out wrapper)) {
				_wrappers.Add(profile, new Wrapper(profile));
				wrapper = _wrappers[profile];
			}
			
			return wrapper;
		}
		
		public class Wrapper {
			const string JOYSTICK_1 = "joystick 1 ";
			const string JOYSTICK_2 = "joystick 2 ";
			const string JOYSTICK_3 = "joystick 3 ";
			const string JOYSTICK_4 = "joystick 4 ";
			
			OInput.Profile _profile;
			string joystick;
			
			public Wrapper(OInput.Profile profile) {
				_profile = profile;
				joystick = JOYSTICK_1;
			}
			
			public Wrapper SetJoystick(Joystick joystick) {
				switch (joystick) {
				case Joystick.Joystick1:
					this.joystick = JOYSTICK_1;
					break;
				case Joystick.Joystick2:
					this.joystick = JOYSTICK_2;
					break;
				case Joystick.Joystick3:
					this.joystick = JOYSTICK_3;
					break;
				case Joystick.Joystick4:
					this.joystick = JOYSTICK_4;
					break;
				}
				
				return this;
			}
			
			public Wrapper SetAxis(string action, ControllerAxis axis) {
				
#if UNITY_STANDALONE_OSX || UNITY_DASHBOARD_WIDGET
				SetAxisOSX(action, axis);
#elif UNITY_STANDALONE_WIN
				SetAxisWin(action, axis);
#else
				if (Application.platform.ToString().Contains("OSX")) {
					SetAxisOSX(action, axis);
				} else if (Application.platform.ToString().Contains("Windows")) {
					SetAxisWindows(action, axis);
				}
#endif
				
				return this;
			}
	
#if UNITY_STANDALONE_OSX || UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_EDITOR
			private void SetAxisOSX(string action, ControllerAxis axis) {
				switch(axis) {
				case ControllerAxis.LeftStickX:
					_profile.SetAxis(action, joystick + "axis 1");
					break;
				case ControllerAxis.LeftStickY:
					_profile.SetAxis(action, joystick + "axis 2");
					break;
				case ControllerAxis.RightStickX:
					_profile.SetAxis(action, joystick + "axis 3");
					break;
				case ControllerAxis.RightStickY:
					_profile.SetAxis(action, joystick + "axis 4");
					break;
				case ControllerAxis.DPadX:
					_profile.SetAxisKeys(action, joystick + "button 7", joystick + "button 8");
					break;
				case ControllerAxis.DPadY:
					_profile.SetAxisKeys(action, joystick + "button 5", joystick + "button 6");
					break;
				case ControllerAxis.LT:
					_profile.SetAxis(action, joystick + "axis 5", true);
					break;
				case ControllerAxis.RT:
					_profile.SetAxis(action, joystick + "axis 6", true);
					break;
				}
			}
#endif
			
#if UNITY_STANDALONE_WIN || UNITY_WEBPLAYER || UNITY_EDITOR
			private void SetAxisWindows(string action, ControllerAxis axis) {
				switch(axis) {
				case ControllerAxis.LeftStickX:
					_profile.SetAxis(action, joystick + "axis 1");
					break;
				case ControllerAxis.LeftStickY:
					_profile.SetAxis(action, joystick + "axis 2");
					break;
				case ControllerAxis.RightStickX:
					_profile.SetAxis(action, joystick + "axis 4");
					break;
				case ControllerAxis.RightStickY:
					_profile.SetAxis(action, joystick + "axis 5");
					break;
				case ControllerAxis.DPadX:
					_profile.SetAxis(action, joystick + "axis 6");
					break;
				case ControllerAxis.DPadY:
					_profile.SetAxis(action, joystick + "axis 7");
					break;
				case ControllerAxis.LT:
					_profile.SetAxis(action, joystick + "axis 9");
					break;
				case ControllerAxis.RT:
					_profile.SetAxis(action, joystick + "axis 10");
					break;
				}
			}
#endif
			
			public Wrapper SetButton(string action, ControllerButton button) {
				
#if UNITY_STANDALONE_OSX || UNITY_DASHBOARD_WIDGET
				SetButtonOSX(action, button);
#elif UNITY_STANDALONE_WIN
				SetButtonWin(action, button);
#else
				if (Application.platform.ToString().Contains("OSX")) {
					SetButtonOSX(action, button);
				} else if (Application.platform.ToString().Contains("Windows")) {
					SetButtonWindows(action, button);
				}
#endif
				
				return this;
			}
			
#if UNITY_STANDALONE_OSX || UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_EDITOR
			private void SetButtonOSX(string action, ControllerButton button) {
				switch (button) {
				case ControllerButton.A:
					_profile.SetButton(action, joystick + "button 16");
					break;
				case ControllerButton.B:
					_profile.SetButton(action, joystick + "button 17");
					break;
				case ControllerButton.X:
					_profile.SetButton(action, joystick + "button 18");
					break;
				case ControllerButton.Y:
					_profile.SetButton(action, joystick + "button 19");
					break;
				case ControllerButton.Start:
					_profile.SetButton(action, joystick + "button 9");
					break;
				case ControllerButton.Back:
					_profile.SetButton(action, joystick + "button 10");
					break;
				case ControllerButton.Xbox:
					_profile.SetButton(action, joystick + "button 15");
					break;
				case ControllerButton.LB:
					_profile.SetButton(action, joystick + "button 13");
					break;
				case ControllerButton.RB:
					_profile.SetButton(action, joystick + "button 14");
					break;
				case ControllerButton.LeftStick:
					_profile.SetButton(action, joystick + "button 11");
					break;
				case ControllerButton.RightStick:
					_profile.SetButton(action, joystick + "button 12");
					break;
				}
			}
#endif
			
#if UNITY_STANDALONE_WIN || UNITY_WEBPLAYER || UNITY_EDITOR
			private void SetButtonWindows(string action, ControllerButton button) {
				switch (button) {
				case ControllerButton.A:
					_profile.SetButton(action, joystick + "button 0");
					break;
				case ControllerButton.B:
					_profile.SetButton(action, joystick + "button 1");
					break;
				case ControllerButton.X:
					_profile.SetButton(action, joystick + "button 2");
					break;
				case ControllerButton.Y:
					_profile.SetButton(action, joystick + "button 3");
					break;
				case ControllerButton.Start:
					_profile.SetButton(action, joystick + "button 7");
					break;
				case ControllerButton.Back:
					_profile.SetButton(action, joystick + "button 6");
					break;
				case ControllerButton.Xbox:
					// On Windows, a user cannot use the Xbox button on the controller.
					Debug.LogWarning("On Windows, a user cannot use the Xbox button on the controller.");
					break;
				case ControllerButton.LB:
					_profile.SetButton(action, joystick + "button 4");
					break;
				case ControllerButton.RB:
					_profile.SetButton(action, joystick + "button 5");
					break;
				case ControllerButton.LeftStick:
					_profile.SetButton(action, joystick + "button 8");
					break;
				case ControllerButton.RightStick:
					_profile.SetButton(action, joystick + "button 9");
					break;
				}
			}
#endif
		}
	}
	
#if UNITY_ANDROID || UNITY_EDITOR
	static public class Ouya {
		public enum ControllerButton {
			O,
			U,
			Y,
			A,
			Start,
			Back,
			LB,
			RB,
			LeftStick,
			RightStick
		}
		
		public enum ControllerAxis {
			LeftStickX,
			LeftStickY,
			DPadX,
			DPadY,
			RightStickX,
			RightStickY,
			LT,
			RT
		}
		
		static Dictionary<OInput.Profile, OInput.Ouya.Wrapper> _wrappers = new Dictionary<OInput.Profile, OInput.Ouya.Wrapper>();
		
		
		static public Wrapper GetWrapper(OInput.Profile profile) {
			Wrapper wrapper;
			if (!_wrappers.TryGetValue(profile, out wrapper)) {
				_wrappers.Add(profile, new Wrapper(profile));
				wrapper = _wrappers[profile];
			}
			
			return wrapper;
		}
		
		public class Wrapper {
			const string JOYSTICK_1 = "joystick 1 ";
			const string JOYSTICK_2 = "joystick 2 ";
			const string JOYSTICK_3 = "joystick 3 ";
			const string JOYSTICK_4 = "joystick 4 ";
			
			OInput.Profile _profile;
			string joystick;
			
			public Wrapper(OInput.Profile profile) {
				_profile = profile;
				joystick = JOYSTICK_1;
			}
			
			public Wrapper SetJoystick(Joystick joystick) {
				switch (joystick) {
				case Joystick.Joystick1:
					this.joystick = JOYSTICK_1;
					break;
				case Joystick.Joystick2:
					this.joystick = JOYSTICK_2;
					break;
				case Joystick.Joystick3:
					this.joystick = JOYSTICK_3;
					break;
				case Joystick.Joystick4:
					this.joystick = JOYSTICK_4;
					break;
				}
				
				return this;
			}
			
			public Wrapper SetAxis(string action, ControllerAxis axis) {
				switch(axis) {
				case ControllerAxis.LeftStickX:
					_profile.SetAxis(action, joystick + "axis 1");
					break;
				case ControllerAxis.LeftStickY:
					_profile.SetAxis(action, joystick + "axis 2");
					break;
				case ControllerAxis.RightStickX:
					_profile.SetAxis(action, joystick + "axis 3");
					break;
				case ControllerAxis.RightStickY:
					_profile.SetAxis(action, joystick + "axis 4");
					break;
				case ControllerAxis.DPadX:
					_profile.SetAxisKeys(action, joystick + "button 10", joystick + "button 11");
					break;
				case ControllerAxis.DPadY:
					_profile.SetAxisKeys(action, joystick + "button 8", joystick + "button 9");
					break;
				case ControllerAxis.LT:
					_profile.SetAxis(action, joystick + "axis 5", true);
					break;
				case ControllerAxis.RT:
					_profile.SetAxis(action, joystick + "axis 6", true);
					break;
				}
				return this;
			}
			
			public Wrapper SetButton(string action, ControllerButton button) {
				switch (button) {
				case ControllerButton.O:
					_profile.SetButton(action, joystick + "button 0");
					break;
				case ControllerButton.U:
					_profile.SetButton(action, joystick + "button 1");
					break;
				case ControllerButton.Y:
					_profile.SetButton(action, joystick + "button 2");
					break;
				case ControllerButton.A:
					_profile.SetButton(action, joystick + "button 3");
					break;
				case ControllerButton.LB:
					_profile.SetButton(action, joystick + "button 4");
					break;
				case ControllerButton.RB:
					_profile.SetButton(action, joystick + "button 5");
					break;
				case ControllerButton.LeftStick:
					_profile.SetButton(action, joystick + "button 6");
					break;
				case ControllerButton.RightStick:
					_profile.SetButton(action, joystick + "button 7");
					break;
				}
				return this;
			}
		}
	}
#endif
}
