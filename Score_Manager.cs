using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{

    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Score()); 
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    IEnumerator Score()
    {
       while (true)
       {
         yield return new WaitForSeconds(0.8f);
         score = score + 1;
        Debug.Log("Score: " + score);
       }
    }
}
