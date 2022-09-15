using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    public GameObject[] Enemyprefab;
    public float pos = 9;

    // Start is called before the first frame update
    void Start()
    {
        spawnballs();
        
        Debug.Log("Hello"); 
        
    }

    // Update is called once per frame
    
    private Vector3 RandomGenrator()
    {
        float spawnx= Random.Range(-pos,pos);   
        float spawnz= Random.Range(-pos,pos);
        Vector3 randompos = new Vector3(spawnx, 0, spawnz);
        return randompos;
    }
    void spawnballs()
    {
        for(int i=0;i<Enemyprefab.Length;i++)
        {
            Instantiate(Enemyprefab[i], RandomGenrator(), Enemyprefab[i].transform.rotation);
            Debug.Log("spawn ball");
        }
    }
}
