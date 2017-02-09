using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenQuads : MonoBehaviour {

    int singleTouch = 0;

    void Update()
    {
        int touchCount = Input.touchCount;
        if (touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                if      (touch.position.x < Screen.width / 2 && touch.position.y > Screen.height / 2)
                    Debug.Log("Touched Top Left");
                else if (touch.position.x < Screen.width / 2 && touch.position.y < Screen.height / 2)
                    Debug.Log("Touched Bottom Left");
                else if (touch.position.x > Screen.width / 2 && touch.position.y > Screen.height / 2)
                    Debug.Log("Touched Top Right");
                else if (touch.position.x > Screen.width / 2 && touch.position.y < Screen.height / 2)
                    Debug.Log("Touched Bottom Right");
            }
        }
    }
}
