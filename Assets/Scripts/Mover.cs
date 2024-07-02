using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private void Update()
    {
        var nextPosition = transform.position;
        var direction = transform.forward;

        nextPosition.z += 0.75f * Time.deltaTime;
        nextPosition += direction * Time.deltaTime;

        transform.position = nextPosition;
    }
}
