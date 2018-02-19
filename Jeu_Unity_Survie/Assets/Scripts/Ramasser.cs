using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ramasser : MonoBehaviour
{

    public GameObject Drop;
    public int vieObjet = 1;

    public int cpt;


    void Start()
    {
        cpt = 0;
    }


    void OnMouseUpAsButton()
    {
        if (controlerPayer.Proche)
        {
            vieObjet -= 1;        
        }
    }


    void Update()
    {
        if (vieObjet == 0)
        {
            StartCoroutine(DetruireEtIncrement());
        }

    }

    IEnumerator DetruireEtIncrement()
    {
        Global.cptBuche ++;;        
        Destroy(Drop);
        yield return new WaitForSeconds(10);
    }
}

