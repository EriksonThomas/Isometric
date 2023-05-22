using System;
using UnityEngine;

public class HighlightTile : MonoBehaviour
{

    GameObject playerMovement; 

    public Sprite tileOriginal;
    public Sprite tileHighlight;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        tileOriginal = spriteRenderer.sprite;
    }

    private void OnMouseOver()
    {
        spriteRenderer.sprite = tileHighlight;
    }

    private void OnMouseExit()
    {
        spriteRenderer.sprite = tileOriginal;
    }
    private void OnMouseDown()
    {
        playerMovement = GameObject.Find("Ship(Clone)");
        Vector2 parentPosition = transform.GetChild(0).transform.position;
        var tilePosition = gameObject.GetComponentInParent<TileProperties>().tilePosition;
        playerMovement.GetComponent<PlayerMovement>().MovePlayer(parentPosition, tilePosition);
    }
}