using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterStatsHandler : MonoBehaviour
{
    [SerializeField] private CharacterStats baseStats;

    public CharacterLevel charLevel;
    public CharacterStats currentStats { get; private set; }
    public List<CharacterStats> statsModifiers = new List<CharacterStats>();

    private void Awake()
    {
        charLevel = GetComponent<CharacterLevel>();
        UpdateCharacterStats();
        UpdateUI();
    }
    void UpdateCharacterStats()
    {
        Stats statsSO = null;
        if(baseStats.charStats != null)
        {
            statsSO = Instantiate(baseStats.charStats);
        }
        currentStats = new CharacterStats { charStats = statsSO };

        //plus/minus stats


    }
    void UpdateUI()
    {
        UIManager.instance.levelUITxt.text = gameObject.GetComponent<CharacterStatsHandler>().charLevel.level.ToString();
        //expUITxt.text = gameObject.GetComponent<CharacterStatsHandler>().charLevel.
        UIManager.instance.jobUITxt.text = gameObject.GetComponent<CharacterStatsHandler>().baseStats.charJob.ToString();
        UIManager.instance.nameUITxt.text = gameObject.GetComponent<CharacterStatsHandler>().baseStats.charName;
        UIManager.instance.atkUITxt.text = gameObject.GetComponent<CharacterStatsHandler>().baseStats.charStats.atk.ToString();
        UIManager.instance.defUITxt.text = gameObject.GetComponent<CharacterStatsHandler>().baseStats.charStats.def.ToString();
        UIManager.instance.hpUITxt.text = gameObject.GetComponent<CharacterStatsHandler>().baseStats.charStats.hp.ToString();
        UIManager.instance.criUITxt.text = gameObject.GetComponent<CharacterStatsHandler>().baseStats.charStats.cri.ToString();
    }
}
