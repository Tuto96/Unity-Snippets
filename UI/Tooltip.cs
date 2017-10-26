using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GUIContent))]
public class Tooltip : MonoBehaviour {

	GUIContent gui;
	public string tooltipText;

	void OnGUI()
	{
		gui = GetComponent<GUIContent>();
		gui.tooltip = tooltipText;
	}
}
