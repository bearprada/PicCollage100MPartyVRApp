using UnityEngine;
using System.Collections;

public class play_movie : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Renderer r = GetComponent<Renderer>();
		MovieTexture movie = (MovieTexture)r.material.mainTexture;
		if (movie.isPlaying) {
			movie.Pause();
		}
		else {
			movie.Play();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
