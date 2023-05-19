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
        GameObject foundObject = GameObject.Find("0 , 0");

        if (foundObject != null)
        {
            character = Instantiate(characterPrefab);
            character.transform.position = foundObject.transform.GetChild(0).transform.position;
        }
        else
        {
            Debug.Log("Starting tile not found.");
        }
    }
}
