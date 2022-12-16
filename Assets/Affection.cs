using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Fungus;

public class Affection : MonoBehaviour
{
    public TMP_Text t;
    public Flowchart f;
    private void Start()
    {
        SetAffection();
    }
    public void SetAffection()
    {
        t.text = f.GetIntegerVariable("Affection") + "";
    }
}
