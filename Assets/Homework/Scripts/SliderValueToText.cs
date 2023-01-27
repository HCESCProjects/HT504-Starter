using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderValueToText : MonoBehaviour {
    Text sliderText;
    void Awake()
    {
        sliderText = GetComponent<Text>();
    }

	public void SetText(Slider slider)
    {
        // To-Do:
    }
}
