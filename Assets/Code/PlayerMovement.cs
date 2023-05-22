using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public void MovePlayer(Vector2 tilePosition, (int, int) globalPosition)
    {
        Debug.Log(globalPosition.Item1 + " , " + globalPosition.Item2);
        var targetDestination = GameObject.Find(globalPosition.Item1 + " , " + globalPosition.Item2);
        transform.position = targetDestination.transform.GetChild(0).transform.position;
    }
}