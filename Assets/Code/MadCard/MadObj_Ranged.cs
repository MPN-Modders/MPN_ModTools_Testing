using UnityEngine;
using System.Collections.Generic;


public class MadObj_Ranged : MadObj_Held
{
    [Header("REFS: Ranged")][Space(10)]
    public GameObject BreachObj;

    public GameObject Point_Shoot;
    public GameObject Point_Mag;
    public GameObject Point_Reload;
    public GameObject Point_Casing;

    public GameObject Addon_Stock;
    public GameObject Addon_Rail;
    
    [Space(5)] [Header("=== ANIMATOR ===")] [Space(20)]
    [Tooltip("Optional Animator. IMPORTANT: Assigning an animator here will skip the automatic slide/breach action of ranged weapons.")]
    public Animator WeaponAnimator;
    [Tooltip("For weapons that are smaller when holstered. Sets the size in Unity units. Any value less than zero will ignore this override.")]
    public float StowLengthOverride = -1;
    [Tooltip("OPTIONAL: Your weapon will orient to its user based on these points instead of Grip[0] and [1]. This frees up the grip points so they can be animated properly.")]
    public Transform[] OrientationPoints = new Transform[2];
    [Tooltip("OPTIONAL: Your weapon won't fire bullets. Instead, the game uses particle system collisions to determine a hit (like the flamethrower or sludgehose). Note that M:PN handles turning the particles on/off, so there's no need to animate that functionality.")]
    public ParticleSystem BulletOverride;

    public void Event_Casing(float inExpelMult)
    {
        // inExpel: Force of casing expulsion. Default value is 1.

        // For ejecting one/all casings from the weapon (if AmBreach is off/on).
        // Useful for weapons with the NoCasings trait, so you can control when
        // casings are released.
    }
}
