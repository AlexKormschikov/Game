using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorsopend : MonoBehaviour
{
    [SerializeField] GameObject _button;
    
    [SerializeField] GameObject _doors;
    private float _speed = 1f;

    private void OnTriggerEnter(Collider other)
    {
        var button = GetComponent<BoxCollider>();
        if (button!= null)
        {
            _button.GetComponent<MeshRenderer>().material.color = Color.red;
            _doors.transform.position += _doors.transform.up * _speed * Time.deltaTime;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        _doors.transform.position += _doors.transform.up * _speed * Time.deltaTime;
    }
    private void OnTriggerExit(Collider other)
    {
        _button.GetComponent<MeshRenderer>().material.color = Color.black;
    }
}
