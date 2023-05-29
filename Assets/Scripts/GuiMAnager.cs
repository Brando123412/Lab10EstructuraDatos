using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuiMAnager : MonoBehaviour
{
    [SerializeField] PlayerController playerScript;
    [SerializeField] Slider energySlider;
    void Update()
    {
        energySlider.value = playerScript.currentEnergy;
        energySlider.maxValue = playerScript.saveEnergy;
    }
}
