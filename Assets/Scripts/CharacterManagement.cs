using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManagement : MonoBehaviour
{
    public Transform character1;
    public Transform character2;
    public Transform mergedCharacter;
    public float mergeDistance = 1.5f;
    void Update()
    {
        float distanceBetweenCharacters = Vector3.Distance(character1.position, character2.position);
        Debug.Log(distanceBetweenCharacters);
        if (distanceBetweenCharacters < mergeDistance)
        {
            MergeCharacters();
        }
        else
        {
            SeparateCharacters();
        }
    }

    void MergeCharacters()
    {
        character1.gameObject.SetActive(false);
        character2.gameObject.SetActive(false);
        mergedCharacter.gameObject.SetActive(true);
    }

    void SeparateCharacters()
    {
        character1.gameObject.SetActive(true);
        character2.gameObject.SetActive(true);
        mergedCharacter.gameObject.SetActive(false);
    }
}
