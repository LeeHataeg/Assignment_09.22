using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] public TMP_Text jobUITxt;
    [SerializeField] public TMP_Text nameUITxt;
    [SerializeField] public TMP_Text levelUITxt;
    [SerializeField] public TMP_Text atkUITxt;
    [SerializeField] public TMP_Text defUITxt;
    [SerializeField] public TMP_Text hpUITxt;
    [SerializeField] public TMP_Text criUITxt;
    [SerializeField] public TMP_Text expUITxt;

    public static UIManager instance;

    private void Awake()
    {
        instance = this;
    }
}
