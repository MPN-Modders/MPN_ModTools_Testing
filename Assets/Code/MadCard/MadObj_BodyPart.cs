using UnityEngine;

public class MadObj_BodyPart : MadObj
{
       public enum Parts { Head, Body, HandR, HandL, FootR, FootL } // Translates to the same enumerator index as ModelParts in Part_BodyPart

    public Parts Part;

    [Space(10)][Header("Head & Body Gore")]

    [Tooltip("The \"applecore\" underneath a character's skin.")]
    public SkinnedMeshRenderer Guts;            
    [Tooltip("After death from severe damage. Replaces myGuts.")]
    public SubPart_Gore[] Guts_Ruined;             
    [Tooltip("Same as above, but due to slashing damage.")]
    public SubPart_Gore[] Guts_Slashing;           


        public enum DefaultGuts {  Default, Brute, NONE = 100 }

    [Tooltip("Ignore the above values and use the following default Guts.")]
    public DefaultGuts UseDefault = DefaultGuts.NONE;
 
}
