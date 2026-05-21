using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int value = 1; // The value of the collectible, you can change this based on your needs

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            // Add to the player's score or inventory
            GameManager.instance.AddScore(value);

            // Destroy the collectible object
            Destroy(gameObject);
        }
        
    }



}
