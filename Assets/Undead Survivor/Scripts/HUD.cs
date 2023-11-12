using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public enum InforType { Exp, Level, Kill, Time, Health }
    public InforType type;

    Text myText;
    Slider mySlider;

    void Awake()
    {
        myText = GetComponent<Text>();
        mySlider = GetComponent<Slider>();
    }

    void LateUpdate()
    {
        switch (type)
        {
            case InforType.Exp:
                float curExp = GameManager.instance.exp;
                float maxExp = GameManager.instance.nextExp[GameManager.instance.level];
                mySlider.value = curExp - maxExp;
                break;
            case InforType.Level:

                break;
            case InforType.Kill:

                break;
            case InforType.Time:

                break;
            case InforType.Health:

                break;
        }
    }
}
