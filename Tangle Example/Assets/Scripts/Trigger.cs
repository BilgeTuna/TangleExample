using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public float speed = 8f;

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

    }
}
