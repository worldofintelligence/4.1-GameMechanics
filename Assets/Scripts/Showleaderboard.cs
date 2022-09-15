using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Showleaderboard : MonoBehaviour
{
    private PlayerController playerController;
    private Enemy enemy;
    public GameObject leaderboard;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
        enemy = GetComponent<Enemy>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy.isground==false)
        {
            leaderboard.SetActive(true);
        }

        
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Enemy") && other.gameObject.CompareTag("Player"))
        {
            enemy.isground= false;
        }
    }
}
