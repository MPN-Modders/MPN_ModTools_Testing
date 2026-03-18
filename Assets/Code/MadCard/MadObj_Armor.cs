using UnityEngine;


public class MadObj_Armor : MadObj
{
    [Header("  >> REFS: Armor")]    [Space(10)]
    
    public SkinnedMeshRenderer MyRenderer;      

    [Header(" + Extras +")][Space(10)]

    [Tooltip("Alternate meshes used by MyRenderer. Leave empty if none. Otherwise, include ALL meshes this MadObject will use, including the default one already assigned to the SkinnedMeshRenderer.")]
    public Mesh[] MeshAlts;                     
    [Tooltip("Sets of alternate materials used by the SkinnedMeshRenderer. Each corresponds to a mesh in MeshAlt at the same index.")]
    public MaterialSet[] MaterialAlts;          


    [System.Serializable]
    public class MaterialSet
    {
        [Tooltip("Sets of alternate materials used by the SkinnedMeshRenderer. Each corresponds to a mesh in MeshAlt at the same index.")]
        public Material[] Materials = new Material[0];
    }


        ////////////////////////


    private void OnValidate()
    {
        if (!MyRenderer)
            MyRenderer = GetComponent<SkinnedMeshRenderer>();

        MyRenderer.enabled = true;
    }

}

