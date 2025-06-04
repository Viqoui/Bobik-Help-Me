using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterGameScene : MonoBehaviour
{
    public VolumeSO sliderValue;
    public Slider sliderTwo;
    public int slider;

    private void Start()
    {
        if (slider == 1)
        {
            sliderTwo.value = sliderValue.value;
        }
        else if (slider == 2)
        {
            sliderTwo.value = sliderValue.valuesfx;
        }
        else if (slider == 3)
        {
            sliderTwo.value = sliderValue.valuemusic;
        }
    }
    private void Update()
    {
        if (slider == 1)
        {
            sliderValue.value = sliderTwo.value;
        }
        else if (slider == 2)
        {
            sliderValue.valuesfx = sliderTwo.value;
        }
        else if (slider == 3)
        {
            sliderValue.valuemusic = sliderTwo.value;
        }
    }
}
