using UnityEngine;


public class MadObj_Addon : MadObj_Held
{
    [Header("REFS: Addon")]    [Space(10)]

    [Tooltip("Point where additional addons will branch from, if appropriate. If this is a barrel or cap addon, then this is where shots will be fired from if no additional addon is attached here.")]
    public GameObject Point_Addon;
}