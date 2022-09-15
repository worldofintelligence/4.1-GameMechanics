using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 scalechange;
    public float speed=5;
    private GameObject foclapoint;
    public GameObject[] leaderboard = new GameObject[5];
    public int i=0;   
    Rigidbody rb;
    Material mat;
    
    private void Awake()
    {
        scalechange = new Vector3(0.1f, 0.1f, 0.1f);
    }
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        foclapoint = GameObject.FindGameObjectWithTag("focalpoint");
        mat = GetComponent<Renderer>().material;   


    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rb.AddForce(foclapoint.transform.forward * speed * x);
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
          //  gameObject.GetComponent<Renderer>().GetComponent<Material>().GetColor("Green");
            gameObject.transform.localScale += scalechange;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("walls"))
        {
            leaderboard[i] = gameObject;
            Debug.Log("Gameobject " + gameObject.name);
            Debug.Log(leaderboard[i].gameObject.name);
            i++;
           
        }
    }
}
