using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCreate : MonoBehaviour
{
    public GameObject spherePrefab;
    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 1){

        if (Input.GetMouseButtonDown(0)){
            Instantiate(spherePrefab, new Vector3(Random.Range(-15f, 15f), 1, Random.Range(-7.5f, 7.5f)), Quaternion.identity);
        }
        }
    }
}
