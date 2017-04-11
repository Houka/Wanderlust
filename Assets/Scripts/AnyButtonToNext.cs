using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyButtonToNext : MonoBehaviour {

    public string sceneName;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown || Input.GetAxis("Mouse Y") != 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
	}
}
