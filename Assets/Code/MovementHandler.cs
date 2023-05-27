using System.Collections.Generic;
using UnityEngine;
public class MovementHandler : MonoBehaviour
{
    private Queue<(int, int)> queue;
    public (int, int) endPosition = (7, 5); 
    public (int, int) currentPosition = (0, 0); 

    void Start()
    {
        queue = new Queue<(int, int)>();
    }

    public (int, int) Pathfinder((int, int) startingPosition)
    {
        SendToQueue(startingPosition);
        
        while (queue.Count != 0)
        {
            currentPosition = queue.Dequeue();
            if (startingPosition == endPosition)
            {
                return currentPosition;
            }
        }

        return currentPosition;
    }

    void SendToQueue((int, int) currentTile)
    {
        queue.Enqueue(currentTile);
    }

    void RemoveFromQueue((int, int) currentTile)
    {
        ;
    }
}
