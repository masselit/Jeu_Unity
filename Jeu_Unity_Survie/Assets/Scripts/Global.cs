using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Global : MonoBehaviour 
{	
	static public float cptBuche = 0f;
	static public float cptBaton = 0f;
	static public float cptFeuille = 0f;
	static public float cptPierre = 0f;
	static public float cptMetal = 0f;
	static public float cptTissu = 0f;
	static public float cptCorde = 0f;
	static public float cptGilet = 0f;
	
	static public bool Hache = false;
	static public bool Base = false;
	static public bool Voile = false;
	static public bool Rames = false;
	static public bool Radeau = false;

    public Text tBuche;
    public Text tBaton;
    public Text tFeuille;
    public Text tPierre;
    public Text tMetal;
    public Text tTissu;
    public Text tCorde;
    public Text tGilet;

    void Start () 
	{
       
    }
	
	void Update () 
	{
        if (cptBaton == 1 && cptCorde == 1 && cptPierre == 2 & cptMetal == 3)
        {
            Hache = true;
        }

        if (cptBuche == 30 && cptCorde == 10)
        {
            Base = true;
        }

        if (Base == true && cptCorde == 3 && Voile == true & Rames == true && cptGilet == 1)
        {
            Radeau = true;
        }

        if (cptBaton == 5 && cptCorde == 3 && cptFeuille == 20 & cptTissu == 5)
        {
           Voile = true;
        }

        if (cptBaton == 4 && cptCorde == 2 && cptBuche == 2)
        {
            Rames = true;
        }

        tBuche.text = cptBuche.ToString();
        tBaton.text = cptBaton.ToString();
        tFeuille.text = cptFeuille.ToString();
        tPierre.text = cptPierre.ToString();
        tMetal.text = cptMetal.ToString();
        tTissu.text = cptTissu.ToString();
        tCorde.text = cptCorde.ToString();
        tGilet.text = cptGilet.ToString();

    }
}
