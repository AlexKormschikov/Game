using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponrotate : MonoBehaviour
{

    [SerializeField] private Transform _weapon;
    void Update()
    {
        transform.RotateAround(_weapon.position, Vector3.up, 50 * Time.deltaTime);
    }
}
