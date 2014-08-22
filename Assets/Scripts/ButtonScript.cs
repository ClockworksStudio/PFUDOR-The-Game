﻿using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour
{
	public enum ButtonType{Play, Options, Credits, Quit}
	public ButtonType buttonType;

	public string gameLevel;
	public string optionsLevel;
	public string creditsLevel;

	void Touched()
	{
		if(buttonType == ButtonType.Play)
		{
			Application.LoadLevel(gameLevel);
		}
		else if(buttonType == ButtonType.Options)
		{
			Application.LoadLevel(optionsLevel);
		}
		else if(buttonType == ButtonType.Credits)
		{
			Application.LoadLevel(creditsLevel);
		}
		else if(buttonType == ButtonType.Quit)
		{
			Application.Quit();
		}
		else
		{
			Debug.LogError("Button type not defined on object '"+gameObject.name+"'", gameObject);
		}
	}
}