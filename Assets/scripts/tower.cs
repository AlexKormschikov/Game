using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tower : MonoBehaviour
{
    [SerializeField]
    private Transform _transformObject;
    [SerializeField]
    private float speed = 1;
    private void Update()
    {
        var relativePosition = _transformObject.position - transform.position;
        var rotation = Quaternion.LookRotation(relativePosition);
        transform.rotation = rotation;
        
    }
}
