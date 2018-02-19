using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{

	public void craftHache () 
	{
		//Conditions pour crafter "On click"
		if (Global.Hache == true)
		{
            /* hache dispo */
            Global.cptBaton -= 1;
            Global.cptCorde -= 1;
            Global.cptPierre -= 2;
            Global.cptMetal -= -3;
        }
	}
}
