using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultStatsData", menuName = "TotalController/Stats/Default")]
public class Stats : ScriptableObject
{
    [Header("Stats Info")]
    public float atk;
    public float def;
    public float hp;
    public float cri;
}
