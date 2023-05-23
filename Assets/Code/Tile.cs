using UnityEngine;

public class Tile : MonoBehaviour
{
    public Tile parent;
    public Tile connectedTile;
    public (int, int) tilePosition = (0, 0);
    public bool IsPathable { get; set; } = true;
    public bool Occupied { get; set; } = false;
    public bool isShootOverable { get; set; } = true;
}