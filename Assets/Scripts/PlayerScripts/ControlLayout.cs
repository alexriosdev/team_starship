using UnityEngine;
using System.Collections;

public class ControlLayout : MonoBehaviour {

	private bool _run = false;
	private PlayerControl _playerControl;
	
	void Start(){
		_playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
	}

    void OnGUI () {
	    if (_run == false && GUI.Button (new Rect (Screen.width/2-125, Screen.height/2-35, 250, 70), "Play")) {
			_playerControl.status = true;
	        _run = true;
	    } else if (_run == true && GUI.Button (new Rect (10, 275, 100, 50), "Stop")) {
			_playerControl.status = false;
	        _run = false;
	    }

        GUI.Label (new Rect(10, 100, 250, 25), "CONTROLS:");
		GUI.Label (new Rect(10, 125, 250, 25), "W - Boost");
		GUI.Label (new Rect(10, 150, 250, 25), "S - Break");
		GUI.Label (new Rect(10, 175, 250, 25), "A - Rotate Left");
		GUI.Label (new Rect(10, 200, 250, 25), "D - Rotate Right");				
		GUI.Label (new Rect(10, 225, 250, 25), "Mouse look to rotate camera");
		GUI.Label (new Rect(10, 250, 250, 25), "Mouse left-click to fire laser");
	}

    void Update()
    {
        // Joystick Controls
        if (Input.GetButtonDown("Start Button"))
        {
            _playerControl.status = true;
            _run = true;
        }
        else if (Input.GetButtonDown("Start Button") || Input.GetButtonDown("Back Button"))
        {
            _playerControl.status = false;
            _run = false;
        }
    }
}

