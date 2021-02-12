using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleted : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameMaster.LevelCompleted();
    }
}
