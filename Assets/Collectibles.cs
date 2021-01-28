using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour
{
        public Text points;
    private int score = 0;
        public GameObject[] CollectibleNumber;
    private int Length;
    private int timer = 0;
    private bool Collected = false;
    private int NumberOfCollected = 0;


    private void Start()
    {
        CollectibleNumber = GameObject.FindGameObjectsWithTag("Collectible");
        Length = CollectibleNumber.Length;
        
    }
    private void Update()
    {
        
            points.text = "Count: " + score.ToString();
        
        if (Collected == true)
        {
            timer = timer + 1;
        }
        if (timer > 600)
        {
            for (int x = 0; x < Length; x++)
            {
                if(CollectibleNumber[x].gameObject.activeSelf == false)
                {
                    CollectibleNumber[x].gameObject.SetActive(true);
                    x = Length;
                    timer = 0;
                    NumberOfCollected = 0;
                }
                else
                {
                    if (NumberOfCollected == Length)
                    {
                        Collected = false;
                        timer = 0;
                        
                    }
                    else
                    {
                        
                        NumberOfCollected = NumberOfCollected + 1;
                    }
                }
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Collectible")
        {

            
            other.gameObject.SetActive(false);
            score = score + 1;
            Collected = true;
            

        }
    }
}
