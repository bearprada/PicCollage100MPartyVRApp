using UnityEngine;
using System.Collections;

public class PicPartyNetworkImage : MonoBehaviour {
	void Start () {
		GetComponent<Renderer>().material.mainTexture = new Texture2D(512, 512, TextureFormat.DXT1, false);
	}

	public void setImageUrl(string url, float ratio) {
		StartCoroutine(WaitAndLoadImage(new WWW(url)));
	}

	IEnumerator WaitAndLoadImage(WWW www) {
		yield return www;
		// assign the downloaded image to the main texture of the object
//		Debug.LogError (">>>> www.texture size " + www.texture.width + " " + www.texture + " url " + url);
		www.LoadImageIntoTexture(GetComponent<Renderer>().material.mainTexture as Texture2D);
		Texture2D t = GetComponent<Renderer> ().material.mainTexture as Texture2D;
		Sprite sprite = Sprite.Create (t, new Rect (0, 0, t.width, t.height), new Vector2 (0.5f, 0.5f));
		SpriteRenderer render = GetComponent<SpriteRenderer> ();
		render.sprite = sprite;
	}
}
