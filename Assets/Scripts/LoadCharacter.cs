using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    
    // Start is called before the first frame update
    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        Debug.Log(selectedCharacter);
        GameObject prefab = characterPrefabs[selectedCharacter];
        GameObject clone = Instantiate(prefab, new Vector3(-20f,2.25f), Quaternion.identity);
        
    }
}
