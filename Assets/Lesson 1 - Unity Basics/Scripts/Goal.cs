using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Goal : MonoBehaviour
{
    [System.Serializable]
    public class CharacterEvent : UnityEvent<Character> { }

    [SerializeField]
    public CharacterEvent characterEntered;

    [SerializeField]
    public CharacterEvent characterExited;
    
    private void OnTriggerEnter(Collider other)
    {
        Character character = other.gameObject.GetComponent<Character>();
        if(character != null)
        {
            Debug.Log(character.characterName);
            characterEntered.Invoke(character);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exiting");
        Character character = other.gameObject.GetComponent<Character>();
        if (character != null)
        {
            Debug.Log(character.characterName);
            characterExited.Invoke(character);
        }
    }
}
