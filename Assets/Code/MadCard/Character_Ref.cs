using System.Collections.Generic;
using UnityEngine;

public class Character_Ref : MadObj
{
    public Animator MyAnimator; // Animation Controller (Mecanim)

    [Header("== ARMATURE PARTS ==")]
    [Space(10)]
    public Transform Bone_Root;
    public Transform Bone_Head;
    public Transform Bone_Chest;
    public Transform Bone_Abdomen;
    public Transform Bone_Hips;
    public Transform Bone_Arm_Up_R;
    public Transform Bone_Arm_Low_R;
    public Transform Bone_Arm_Up_L;
    public Transform Bone_Arm_Low_L;
    public Transform Bone_Leg_Up_R;
    public Transform Bone_Leg_Low_R;
    public Transform Bone_Leg_Up_L;
    public Transform Bone_Leg_Low_L;
    public Transform Bone_Hand_R;
    public Transform Bone_Hand_L;
    public Transform Bone_Foot_R;
    public Transform Bone_Foot_L;
    public Transform Bone_Finger1_R, Bone_Finger2_R, Bone_Thumb_R;
    public Transform Bone_Finger1_L, Bone_Finger2_L, Bone_Thumb_L;
    public Transform Bone_SnapWeapon_R;
    public Transform Bone_SnapWeapon_L;
    public Transform Bone_SyncNode;

    [Header("== STICK POINTS + PIVOTS ==")]
    [Space(10)]
    [Tooltip("Main hand ranged weapons.")]
    public Transform Point_Pivot_1h_R;
    [Tooltip("Off-hand ranged weapons.")]
    public Transform Point_Pivot_1h_L;
    [Tooltip("Ranged weapons being braced for aim.")]
    public Transform Point_Pivot_Sights;
    [Tooltip("For reloading, main hand reaches here when reloading off-hand weapon.")]
    public Transform Point_Pocket_R;
    [Tooltip("For reloading, off-hand reaches here when reloading main hand weapon.")]
    public Transform Point_Pocket_L;
    [Tooltip("Main hand ranged weapon during reload.")]
    public Transform Point_Reload_R;
    [Tooltip("Off-hand ranged weapon during reload.")]
    public Transform Point_Reload_L;
    [Tooltip("Main hand melee.")]
    public Transform Point_Melee_R;
    [Tooltip("Off-hand melee.")]
    public Transform Point_Melee_L;
    [Tooltip("Two-handed melee.")]
    public Transform Point_Melee_2h;
    [Tooltip("Shield when not blocking.")]
    public Transform Point_Shield;
    [Tooltip("Weapons with Stable Held trait.")]
    public Transform Point_Stable;
    [Tooltip("Non-weapons such as crates.")]
    public Transform Point_Carried;
    [Tooltip("Weapons with OverheadCarry trait.")]
    public Transform Point_CarriedBig;
    [Tooltip("Large weapons when stowed.")]
    public Transform Point_BackStorage;
    [Tooltip("Small weapons stowed, main hand.")]
    public Transform Point_Sidearm_R;
    [Tooltip("Small weapons stowed, off-hand.")]
    public Transform Point_Sidearm_L;
    [Tooltip("Thrown weapons when stowed.")]
    public Transform Point_ThrownStorage;
    [Tooltip("Where chatter appears above a character.")]
    public Transform Point_Chat;         
    

    [Header("== PARTS ==")]
    [Space(10)]
    [Tooltip("Pieces that fall off of me when I die. Parent these objects anywhere inside the character (typically to armature bones), and disable their gameobjects.")]
    public List<Rigidbody> DeathParts = new List<Rigidbody>(); // Pieces that fall off of me when I die. Must be a child of this CharacterRef, typically parented to a bone. This just enabled them.
    
    [Tooltip("The visual SkinnedMeshRenderers objects that represent parts of the body. This is how the game will apply gore to these parts, for example. RESTRICTION: ONLY ONE OF EACH TYPE ALLOWED! However, you CAN put this script onto the same part multiple times (like if your character's Head and Body are both the same mesh). ")]
    public MadObj_BodyPart[] BodyParts = new MadObj_BodyPart[0];
    [Tooltip("The armature bones that have some game function. This script is how the game will know what part was hit by an attack. You may use as many or few CharBone components as you want, even multiples of the same type, and they don't even need to go on an armature bone! All they require is a collider.")]
    public SubPart_CharBone[] CharacterBones = new SubPart_CharBone[0];
}

