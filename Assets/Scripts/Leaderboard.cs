using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;  
public class Leaderboard : MonoBehaviour
{
    public TMP_Text rank1;
    public TMP_Text rank2;
    public TMP_Text rank3;
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        rank1 = GetComponent<TMP_Text>();
        rank2 = GetComponent<TMP_Text>();
        rank3 = GetComponent<TMP_Text>();
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        rank1.text = playerController.leaderboard[5].ToString();
        rank2.text = playerController.leaderboard[4].ToString();
        rank3.text = playerController.leaderboard[3].ToString();
    }
}
