using UnityEngine;

public class HighlightTile : MonoBehaviour
{
    private Color originalColor;
    private Color highlightColor = Color.yellow;

    private void Start()
    {
        originalColor = GetComponent<Renderer>().material.color;
    }

    private void OnMouseOver()
    {
        GetComponent<Renderer>().material.color = highlightColor;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = originalColor;
    }
}