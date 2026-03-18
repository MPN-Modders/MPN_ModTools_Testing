using UnityEngine;
using System.Collections.Generic;

public class SubPart_CharBone : MonoBehaviour
{
    public MadObj_BodyPart.Parts PartType = MadObj_BodyPart.Parts.Body;
    public enum PartVitality { Invincible, Intangible, Normal, Weak }
    public PartVitality Vitality = PartVitality.Normal;
    [Header("0 = None, +-1 = Modify, 2+ = Super Gore")]
    public float GoreMultiplier = 1f;
    public float armorMultiplier = 1;       // We can boost or remove it.
    public float armorMultiplier_InRagdoll = 1;       // We can boost or remove it.
    public GameObject HitEffect;            // Special hit effect if we get smacked. Ex: Robot bolts on back, Ghoul slime?
    public bool UseCustomHitSound = true;   // Robot THWONK sounds
    public bool PlayWeakSpotHit = false;    // Robots and Ghoul have special hit sounds.
    public bool IgnoreNoPain = false;       // Robot weak spot stuns them if you hit em with melee/unarmed
}
