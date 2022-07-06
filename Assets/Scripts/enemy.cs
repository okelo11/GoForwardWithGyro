using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{ public float speed=1;

    void Update()
    {
        transform.Translate(0, 0, -Time.deltaTime * 15*speed,Space.World);

    }
}
