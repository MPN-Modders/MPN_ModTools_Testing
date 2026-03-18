using UnityEngine;

[System.Serializable]
public class SubPart_Gore : MonoBehaviour
{
    [Tooltip("Do I ignore the blood color of my source? (Ex: Robots)")]
    public bool Inorganic = false;
    [Tooltip("What's left behind when the corresponding part is destroyed.")]
    public SkinnedMeshRenderer Guts;
    [Tooltip("Gore debris that fly away from the point of impact.")]
    public GameObject[] Gibs;
}
