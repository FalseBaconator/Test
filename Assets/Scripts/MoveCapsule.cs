using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCapsule : MonoBehaviour
{

    public float dir;

    public float max;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y >= max || gameObject.transform.position.y <= max * -1)
        {
            dir *= -1;
        }
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + dir, gameObject.transform.position.z);
    }
}
