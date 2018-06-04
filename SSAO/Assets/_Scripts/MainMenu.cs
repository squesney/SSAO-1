﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {


	public void LaunchMageZone1()
	{
		if (SceneManager.GetSceneByName("plusgrossesave").isLoaded)
		{
			SceneManager.SetActiveScene(SceneManager.GetSceneByName("plusgrossesave"));
		}
		else
		{
			SceneManager.LoadScene("plusgrossesave");// A METTRE ZONE 1 AVEC MAGE
		}
		
		
	}
	
	public void LaunchHealerZone1()
	{
		SceneManager.LoadScene("Zone 1");
	}
	
	public void LaunchMulti()
	{
		SceneManager.LoadScene("GameLobby");
	}

	public void QuitGame()
	{
		Application.Quit();
	}
	
}
