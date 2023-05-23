using System.Collections.Generic;
using UnityEngine;
public class MovementHandler : MonoBehaviour
{
    private Queue<(int, int)> queue;

    void Start()
    {
        queue = new Queue<(int, int)>();
    }

    public void Pathfinder((int, int) startingPosition)
    {
        SendToQueue(startingPosition);
    }

    void SendToQueue((int, int) currentTile)
    {
        queue.Enqueue(currentTile);

        //pring the contence of the queue
        string[] tupleStrings = new string[queue.Count];
        int index = 0;
        foreach (var tuple in queue)
        {
            tupleStrings[index] = $"({tuple.Item1}, {tuple.Item2})";
            index++;
        }

        string result = string.Join(", ", tupleStrings);
        Debug.Log(result);
        }
        
    void RemoveFromQueue((int, int) currentTile)
    {
        ;
    }
}
