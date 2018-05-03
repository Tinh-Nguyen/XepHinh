using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCamera : MonoBehaviour {

    public RawImage rawimage;
    WebCamTexture webcamTexture;
    public Image img;
    void Start()
    {
        webcamTexture = new WebCamTexture();
        rawimage.texture = webcamTexture;
        //rawimage.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }

    // Update is called once per frame
    void Update () {
		if(Input.GetKeyDown(KeyCode.A))
        {
            webcamTexture.Pause();
            Chup();
        }
        if (Input.GetKeyDown(KeyCode.S))
            webcamTexture.Play();
	}
    public void Chup()
    {
        Texture2D aaa = new Texture2D(300,300);
        for(int i=0;i<300;i++)
            for( int j = 0; j < 300; j++)
            {
                aaa.SetPixel(i, j, webcamTexture.GetPixel(i, j));
            }
        aaa.Apply();
        Sprite sprite = Sprite.Create(aaa, new Rect(0, 0, aaa.width, aaa.height), new Vector2(0.5f, 0.5f));
        img.sprite = sprite;

    }
    public void Tieptuc()
    {
        webcamTexture.Play();
    }
}
