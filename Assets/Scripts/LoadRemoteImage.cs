// Add this script to a GameObject. The Start() function fetches an
// image from the documentation site.  It is then applied as the
// texture on the GameObject.

using UnityEngine;
using System.Collections;

public class LoadRemoteImage : MonoBehaviour
{
	public string url = "https://firebasestorage.googleapis.com/v0/b/equirectangular-2-spheremat.appspot.com/o/Safari.JPG?alt=media&token=ffbadc4f-cffd-46e8-a1d5-47b276e3d99f";
	public Shader shader;

	IEnumerator Start()
	{
		Texture2D tex;
		tex = new Texture2D(4, 4, TextureFormat.DXT1, false);
		WWW www = new WWW(url);
		yield return www;
		www.LoadImageIntoTexture(tex);
		GetComponent<Renderer>().material.mainTexture = tex;
		GetComponent<Renderer> ().material.shader = shader;
	}
}