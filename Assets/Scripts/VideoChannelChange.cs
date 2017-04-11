using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Apply to main Camera.
 */
public class VideoChannelChange : MonoBehaviour {

    public int width = 3;
    public int height = 2;
    public float sensitivity = 0.0f;

    private float sphereDim = 100;
    private float h, v, vprev = 0f;
    //private int indx;
    //private int indy;

	// Use this for initialization
	void Awake () {
        
        //indx = 0;
       // indy = 0;
       
	}
	
	// Update is called once per frame
	void Update () {
        h = Input.GetAxis("Mouse X");
        vprev = v;
        v = Input.GetAxis("Mouse Y");
        //Debug.Log(v);
        if (v > 1)
        {//scroll up
            gameObject.transform.position = new Vector3(0f,100f,0f);
           // indy++;
            //indy %= height;
        }
        if (v < -1)
        {//scroll down
            gameObject.transform.position = new Vector3(0f,0f,0f);
            //indy--;
           // indy %= height;
        }
        /*else if (h > sensitivity)
        {//scroll right
            //indx++;
            //indx %= width;
        }
        else if (h < (-1.0f) * sensitivity)
        {//scroll left
            //indx--;
            //indx %= width;
        }*/
        //gameObject.transform.position -= new Vector3(indx*sphereDim, indy*sphereDim, 0f);
	}
}
