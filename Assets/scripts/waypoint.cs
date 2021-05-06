using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Transform _point;
    [SerializeField] Transform _point2;
    [SerializeField]
    private float speed = 0.5f;
    void Update()
    {
        float _step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, _point.position, _step);
        transform.position = Vector3.MoveTowards(transform.position, _point2.position, _step);
    }
}
