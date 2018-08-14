using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class settingsManager : MonoBehaviour {
	
	public Toggle fullscreenT;
	public Dropdown resolucionD;
	public Dropdown textureD;
	public Dropdown antialD;
	public Dropdown vSyncD;
	public Slider VolumenS;
	public AudioSource musica;

	public Resolution[] resolutions;
	public gameSettings Gamesettings;

	void onEnable(){
		Gamesettings = new gameSettings();

		fullscreenT.onValueChanged.AddListener (delegate { OnFullSreenToggle ();});
		resolucionD.onValueChanged.AddListener (delegate { onResolutionC ();});
		textureD.onValueChanged.AddListener (delegate { onTextureC ();});
		vSyncD.onValueChanged.AddListener (delegate { onvSyncC ();});
		VolumenS.onValueChanged.AddListener (delegate { onMusicC ();});
		antialD.onValueChanged.AddListener (delegate { onantyalaC ();});

		resolutions = Screen.resolutions;
	
	}
	public void OnFullSreenToggle()
	{
		
//		Gamesettings fullscreen = Screen.fullScreen = fullscreenT.isOn;

	}

	public void onResolutionC(){


	}

	public void onTextureC ()
	{
		//QualitySettings.masterTextureLimit = gameSettings.texture = textureD.value;

	}

	public void onantyalaC(){
		
	
//		QualitySettings.antiAliasing = gameSettings.antial = (int)Mathf.Pow (2f, antialD.value);
	
	 }

	public void onvSyncC(){
	
//		QualitySettings.vSyncCount = gameSettings.vSync = vSyncD.value;
	}
		
	public void onMusicC()
	{

//		musica.volume = gameSettings.Volume =VolumenS.value;
	}

	public void saveSet(){
	
	
	}
	public void loadSet(){
	
	
	}
}
