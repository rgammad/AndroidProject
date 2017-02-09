using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {
    public float speed = 1f;

    Touch touch;

    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
            Debug.Log("Touched");
            Vector2 touchDeltaPos = Input.GetTouch(0).deltaPosition;
            this.gameObject.transform.Translate(-touchDeltaPos.x * speed * Time.deltaTime, -touchDeltaPos.y * speed * Time.deltaTime,0);
        }
    }
}
