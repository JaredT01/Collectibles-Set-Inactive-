using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour
{
        public Text points;
    private int score = 0;
    private void Update()
    {
        points.text = "Count: " + score.ToString();
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Collectible")
        {
            other.gameObject.SetActive(false);
            score = score + 1;
        }
    }
}
