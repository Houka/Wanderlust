using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class channelChange : MonoBehaviour {

    public string[] playlist = new string[3];
    public MediaPlayerCtrl player;

    public GameObject sphere;
    int counter = 0;
    public Texture t0;
    public Texture t1;
    public Texture t2;
    public Texture t3;
    public Texture t4;
    public Texture t5;
    Texture[] textures;

    public int indx;
    private int preindx;

    private string y;
    private string prevy;

    // Use this for initialization
    void Start () {
        // Create a material with transparent diffuse shader
        preindx = indx;
        y = playlist[0];
        prevy = y;
    }
	
	// Update is called once per frame
	void Update () {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if (mouseX > 10)
        {
            if (y == playlist[0])
                y = playlist[1];
            else if (y == playlist[1])
                y = playlist[0];
            else
                y = playlist[0];
        }
        if (mouseY > 10)
        {//scroll up
            y = playlist[2];
        }

        if (prevy != y)
        {
            prevy = y;
            player.UnLoad();
            player.Load(y);
        }

        //sphere.GetComponent<Renderer>().material.mainTexture = textures[counter];
        }
}
