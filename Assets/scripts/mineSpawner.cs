using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mineSpawner : MonoBehaviour

{
    [SerializeField] private GameObject _mine; // Наша мина
    [SerializeField] private Transform _mineSpawnPlace; // точка, где создается
  
    

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(_mine, _mineSpawnPlace.position, _mineSpawnPlace.rotation);
          
          
        }
       
    }
}
