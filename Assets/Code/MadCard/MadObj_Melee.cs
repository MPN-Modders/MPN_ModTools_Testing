using UnityEngine;


public class MadObj_Melee : MadObj_Held
{
    [Header("  >> REFS: Melee")][Space(10)]

    [Tooltip("The point in space representing the tip or end of a weapon.")]
    public GameObject MeleePoint;
    
    [Space(5)] [Header("=== ANIMATOR ===")] [Space(20)]
    [Tooltip("Optional Animator. IMPORTANT: Assigning an animator here will skip the automatic slide/breach action of ranged weapons.")]
    public Animator WeaponAnimator;
    [Tooltip("For weapons that are smaller when holstered. Sets the size in Unity units.")]
    public float StowLengthOverride = -1;
    [Tooltip("OPTIONAL: Your weapon will orient to its user based on these points instead of Grip[0] and [1]. This frees up the grip points so they can be animated properly.")]
    public Transform[] OrientationPoints = new Transform[2];
}
