﻿using UnityEngine;
using System.Collections;

public class s_input_micro : MonoBehaviour {
	
	public float f_loudness = 0;
	
	void Start () {
		/*	audio.clip = Microphone.Start(null, true, 10, 44100);

		IEnumerator Start() {
		yield return Application.RequestUserAuthorization(UserAuthorization.Microphone);
		if (Application.HasUserAuthorization(UserAuthorization.Microphone)) {
		} else {
		}
	}
		
		

		foreach (string device in Microphone.devices)
		{
			Debug.Log("Name: " + device);
		}			
		audio.clip = Microphone.Start("Built-in Microphone", true, 10, 44100);
		audio.Play();
	}
		/* [RequireComponent(typeof(AudioSource))]
		audio.clip = Microphone.Start(null, true, 10, 44100);
		audio.loop = true; // Set the AudioClip to loop
		audio.mute = true; // Mute the sound, we don't want the player to hear it
		while (!(Microphone.GetPosition(AudioInputDevice) > 0)){} // Wait until the recording has started
		audio.Play(); // Play the audio source!

	
	void Update(){
		loudness = GetAveragedVolume() * sensitivity;
	}
	
	float GetAveragedVolume()
	{ 
		float[] data = new float[256];
		float a = 0;
		audio.GetOutputData(data,0);
		foreach(float s in data)
		{
			a += Mathf.Abs(s);
		}
		return a/256;*/
	}
}