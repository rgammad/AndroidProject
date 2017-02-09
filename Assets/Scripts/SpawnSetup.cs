using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSetup: MonoBehaviour {
    public GameObject spawner;
    void Start()
    {
        Instantiate(spawner, new Vector2(-12, -3),Quaternion.identity).gameObject.name = "bLeftSpawn";
        Instantiate(spawner, new Vector2(-12, 3), Quaternion.identity).gameObject.name = "tLeftSpawn";
        Instantiate(spawner, new Vector2(12, -3), Quaternion.identity).gameObject.name = "bRightSpawn";
        Instantiate(spawner, new Vector2(12, 3), Quaternion.identity).gameObject.name = "tRightSpawn";
    }
}
