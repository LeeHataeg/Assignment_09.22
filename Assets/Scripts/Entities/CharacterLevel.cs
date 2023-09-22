using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLevel : MonoBehaviour
{
    //기본 구현 후 다시 오자
    [Range(0, 100)] public int level;
    public int maxExp;
    public int curExp;
    private void Awake()
    {
        level = 1;
        maxExp = 10;
        curExp = 0;
    }
}
