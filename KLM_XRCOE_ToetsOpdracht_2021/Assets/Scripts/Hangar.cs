using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hangar : MonoBehaviour
{
    public TextMeshPro hangarText;

    public void SetText(int hangarNum)
    {
        hangarText.text = hangarNum.ToString();
    }
}
