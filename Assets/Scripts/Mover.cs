using UnityEngine;

public class Mover : MonoBehaviour
{
    private void Update()
    {
        Vector3 nextPosition = transform.position;
        Vector3 direction = transform.forward;

        float speed = 0.75f;

        nextPosition += direction * Time.deltaTime;
        nextPosition.z += speed * Time.deltaTime;

        transform.position = nextPosition;
    }
}
