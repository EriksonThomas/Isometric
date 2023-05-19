using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public void MovePlayer(Vector2 tilePosition)
    {
        Debug.Log(tilePosition);
        transform.position = new Vector2(tilePosition.x, tilePosition.y);
    }
}
