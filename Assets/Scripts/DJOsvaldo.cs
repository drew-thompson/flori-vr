﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJOsvaldo : MonoBehaviour {

	static AudioSource audio;
	public AudioClip[] audioClips;
	public static DJOsvaldo instance = null;

	public static Dictionary<string, AudioClip> Beats = new Dictionary<string, AudioClip> ();
	static bool isPlaying;

	// Use this for initialization
	void Start () {

		if (instance == null) instance = this;
		else if (instance != this) Destroy(gameObject);

		audio = GetComponent<AudioSource> ();
		Beats.Add ("cheer", audioClips[0]);
		Beats.Add ("whoosh", audioClips[1]);
	}

	// Update is called once per frame
	void Update () {

	}

	public static void PlayClipAt(string name, float level = 0.35f)
	{
		if (Beats.ContainsKey(name) && !audio.isPlaying) {
			audio.volume = level;
			audio.clip = Beats [name];
			audio.Play ();
		}
	}
}
