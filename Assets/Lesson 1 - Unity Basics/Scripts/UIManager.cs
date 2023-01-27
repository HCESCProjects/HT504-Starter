using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI goalInformation;

    public string defaultMessage;

    public void UpdateResidentInformationWhenCharacterEnters(Character character)
    {
        goalInformation.text = character.characterName;
    }

    public void UpdateResidentInformationWhenCharacterExits(Character character)
    {
        goalInformation.text = defaultMessage;
    }
}
