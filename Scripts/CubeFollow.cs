using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeFollow : MonoBehaviour
{
    GameObject[] sphere;
    public Rigidbody rb;
    GameObject closest;
    public Text scoreText;
    int score;
    public float speed = 2;
    public float speedRotate = 2;

    public ParticleSystem particleSystem;

    // Update is called once per frame
    void Start()
    {
        particleSystem.Stop();
    }
    void FixedUpdate()
    {
        scoreText.text = "Score: " + score;

        sphere = GameObject.FindGameObjectsWithTag("Sphere");

        FindClosestEnemy();  
        
        rb.velocity = transform.forward * speed;

        Vector3 dir = closest.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speedRotate * Time.deltaTime);         
    }
    GameObject FindClosestEnemy()
    {            
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in sphere)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sphere"){
            particleSystem.Play();
            score++;
            Destroy(other.gameObject);
        }
    }
}
