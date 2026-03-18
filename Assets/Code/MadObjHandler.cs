using UnityEngine;
using UnityEditor;

public class MadObjHandler
{

   

    static GameObject ref_EmptyPoint;

    static GameObject CreatePoint(string inName, Transform inParent, Vector3 inDir, Vector3 inUp, Vector3 inPos)
    {
        if (!ref_EmptyPoint)
            ref_EmptyPoint = Resources.Load("EmptyPoint") as GameObject;

        GameObject newGO = ref_EmptyPoint != null ? GameObject.Instantiate(ref_EmptyPoint) : new GameObject();
        newGO.name = inName;

        newGO.transform.SetParent(inParent);
        newGO.transform.localPosition = inPos;
        newGO.transform.rotation = Quaternion.LookRotation(inDir, inUp);

        return newGO;
    }

    public static void CreatePoints(MadObj inObj)
    {
        if (typeof(MadObj_Held).IsAssignableFrom(inObj.GetType()))
        {
            MadObj_Held moHeld = inObj as MadObj_Held;
            if (moHeld.Grip.Length != 2)
                moHeld.Grip = new GameObject[2];
            
            moHeld.Grip[0] = CreatePoint("Grip_Main", inObj.transform, inObj.transform.forward, inObj.transform.up, Vector3.down * 0.5f);
            moHeld.Grip[1] = CreatePoint("Grip_Off", inObj.transform, inObj.transform.forward, inObj.transform.up, Vector3.down * 0.55f);
        }

        if (typeof(MadObj_Melee).IsAssignableFrom(inObj.GetType()))
        {
            MadObj_Melee moMelee = inObj as MadObj_Melee;

            moMelee.MeleePoint = CreatePoint("MPoint", inObj.transform, inObj.transform.up, -inObj.transform.forward, Vector3.up * 0.55f);
        }
    }

    public static void CreateCollider(MadObj inObj)
    {
        inObj.gameObject.AddComponent<BoxCollider>();
    }

}

[RequireComponent(typeof(BoxCollider))]
public class MadObj_Held : MadObj
{
    [Header("  >> REFS: Held")]
    [Tooltip("Points where your Main and Off-Hands will go when holding this item.")]
    public GameObject[] Grip = new GameObject[2];
}


public class MadObj : MonoBehaviour
{
    [ContextMenu(" > Create Points")]
    void CreatePoints()
    {
        MadObjHandler.CreatePoints(this);
    }
    [ContextMenu(" > Add Collider")]
    void CreateCollider()
    {
        if (!gameObject.GetComponent<Collider>())
            MadObjHandler.CreateCollider(this);
    }


    public void SoundEvent(string inSound)
    {
        // For playing sound events during animations.
    }
    public void SoundEvent75(string inSound)
    {
        // For playing sound events at 75% volume during animations.
    }
    public void SoundEvent50(string inSound)
    {
        // For playing sound events at 50% volume during animations.
    }
    public void SoundEvent25(string inSound)
    {
        // For playing sound events at 25% volume during animations.
    }
}