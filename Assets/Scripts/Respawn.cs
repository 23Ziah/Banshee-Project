using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform respawnPoint;

    public void PlayerRespawn()
    {
        transform.position = respawnPoint.position;
        transform.rotation = respawnPoint.rotation;
    }
}
