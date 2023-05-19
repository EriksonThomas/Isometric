using UnityEngine;

public class HighlightTile : MonoBehaviour
{
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
}