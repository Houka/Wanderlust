using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoChannelChangeOld : MonoBehaviour
{

    public string[] playlist = new string[3];
    [Range(5.0f, 20.0f)]
    public float sensitivity = 10.0f;

    public MediaPlayerCtrl player;
    public int indx;
    private int preindx;

    // Use this for initialization
    void Start()
    {
        preindx = indx;
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Mouse Y");
        if (v > sensitivity || Input.GetMouseButtonUp(0))
        {//scroll up
            indx++;
            indx %= playlist.Length;
        }
        else if (v < (-1.0f) * sensitivity)
        {//scroll down
            indx--;
            indx = indx <0? playlist.Length-1: indx;
        }

        if (preindx != indx)
        {
            preindx = indx;
            player.UnLoad();
            player.Load(playlist[indx]);
        }
    }
}