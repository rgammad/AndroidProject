using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public float speed = 10.0f;

    private Quadrant spawnQuad;
    

    void OnEnable()
    {
        if (gameObject.CompareTag("tLeftEnemy"))
            spawnQuad = Quadrant.tLeft;
        else if (gameObject.CompareTag("tRightEnemy"))
            spawnQuad = Quadrant.tRight;
        else if (gameObject.CompareTag("bLeftEnemy"))
            spawnQuad = Quadrant.bLeft;
        else
            spawnQuad = Quadrant.bRight;
    }

    void Update()
    {
        _Move();
    }

    private void _Move()
    {
        switch (spawnQuad)
        {
            case Quadrant.tLeft:
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                break;
            case Quadrant.tRight:
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                break;
            case Quadrant.bLeft:
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                break;
            case Quadrant.bRight:
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                break;
        }
    }
}
