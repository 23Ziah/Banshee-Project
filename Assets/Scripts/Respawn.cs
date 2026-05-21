using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform respawnPoint;

    public void PlayerRespawn()
    {
        CharacterController controller = GetComponent<CharacterController>();
        controller.enabled = false; // Temporarily disable it so it doesn't fight the
        transform.position = respawnPoint.position;
        controller.enabled = true;
        transform.position = respawnPoint.position;
        transform.rotation = respawnPoint.rotation;

        Debug.Log("Player Respawned");
    }
}
