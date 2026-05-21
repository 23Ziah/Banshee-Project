using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class SpawnPad : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Respawn respawn = other.GetComponent<Respawn>();

            if (respawn != null)
            {
                respawn.respawnPoint = transform;

                Debug.Log("Checkpoint Updated");
            }
        }
    }
}
