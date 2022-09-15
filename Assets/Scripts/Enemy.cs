using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 100.0f;
    public static float hitcount;
    private Vector3 scalechange;
    Rigidbody rb;
    private GameObject player;
    private GameObject[] enemy;
    private PlayerController playerController;
    private void Awake()
    {
        scalechange = new Vector3(0.1f, 0.1f, 0.1f);
    }
    private void Start()
    {
        rb= GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        playerController= GetComponent<PlayerController>();
    }
    private void Update()
    {
        AiMovement();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            gameObject.transform.localScale += scalechange;
            hitcount++;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("walls"))
        {
            playerController.leaderboard[playerController.i] = gameObject;
            playerController.i++;
        }
    }
    void AiMovement()
    {
        Vector3 lookdirection1 = (player.transform.position   - enemy[0].transform.position).normalized;
        Vector3 lookdirection2 = (enemy[0].transform.position - enemy[1].transform.position).normalized;
        Vector3 lookdirection3 = (enemy[3].transform.position - enemy[2].transform.position).normalized;
        Vector3 lookdirection4 = (enemy[4].transform.position - enemy[3].transform.position).normalized;
        Vector3 lookdirection5 = (player.transform.position   - enemy[4].transform.position).normalized;
        rb.AddForce(lookdirection1 * speed);
        rb.AddForce(lookdirection2 * speed); 
        rb.AddForce(lookdirection3 * speed); 
        rb.AddForce(lookdirection4 * speed); 
        rb.AddForce(lookdirection5 * speed);
    }

}
