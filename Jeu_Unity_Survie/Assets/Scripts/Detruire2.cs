using UnityEngine;
using System.Collections;

public class Detruire2 : MonoBehaviour
{

    public GameObject ObjetRessource;
    public GameObject SpawnDrop;

    public int nombreDrop = 2;
    public int vieObjet = 5;
    public float decalHaut = 5f;
    public float decalCote = 0.8f;

    private bool presDarbreOuPas;

    void Start()
    {
    }

    
    void OnMouseUpAsButton()
    {
        if (controlerPayer.Proche)
        {
            vieObjet -= 1;
            Debug.Log("-1 point de vie.");
        }
    }


    void Update()
    {
        if (vieObjet == 0)
        { //Si l'arbre n'a plus de vie...
            StartCoroutine(DetruireArbreEtSpawn()); //Alors on execute la fonction FaireTomberlArbrePuisRepop.
        }

    }

    IEnumerator DetruireArbreEtSpawn()
    {
        for (int i = 1; i <= nombreDrop; i++)
        {
            Instantiate(SpawnDrop, new Vector3(ObjetRessource.gameObject.transform.position.x + (i * decalCote), ObjetRessource.gameObject.transform.position.y + (decalHaut * i), ObjetRessource.gameObject.transform.position.z), Quaternion.identity); // Fait apparaitre du bois).            
        }
        Destroy(ObjetRessource); //Supprime l'arbre.
        yield return new WaitForSeconds(10);
    }
}