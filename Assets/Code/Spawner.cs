using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject characterPrefab;
    private GameObject character;


    void Start()
    {
        SpawnPlayer();
    }
    
    void SpawnPlayer()
    {
        GameObject tile = GameObject.Find("0 , 0");

        if (tile != null)
        {
            character = Instantiate(characterPrefab);
            character.transform.position = tile.transform.GetChild(0).transform.position;
        }
        else
        {
            Debug.Log("Starting tile not found.");
        }
    }
}
