using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        var scale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
        
        scale.x += _speed * Time.deltaTime;
        scale.y += _speed * Time.deltaTime;
        scale.z += _speed * Time.deltaTime;

        transform.localScale = scale;
    }
}
