using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class Settings
{
	// Game pause state
	private static bool _PAUSED = false;
	public static bool PAUSED {
		get {return _PAUSED;}
		set
		{
			_PAUSED = value;
			onPause.Invoke(value);
		}
	}
	public static UnityEvent<bool> onPause = new UnityEvent<bool>();

	// Music Volume
	public static float MUSIC_VOLUME
	{
		get {return PlayerPrefs.GetFloat("Music", 1.0f);} // Default of full volume
		set
		{
			PlayerPrefs.SetFloat("Music", value);
			onMusicVolume.Invoke(value);
		}
	}
	public static UnityEvent<float> onMusicVolume = new UnityEvent<float>();

	// SFX Volume
	public static float SFX_VOLUME
	{
		get {return PlayerPrefs.GetFloat("SFX", 1.0f);} // Default of full volume
		set
		{
			PlayerPrefs.SetFloat("SFX", value);
			onSFXVolume.Invoke(value);
		}
	}
	public static UnityEvent<float> onSFXVolume = new UnityEvent<float>();
}
