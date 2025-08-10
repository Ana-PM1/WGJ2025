using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AdmiNivel : MonoBehaviour
{
    public static AdmiNivel instance;

    [SerializeField] private float timeLimit = 0;

    [SerializeField]
    private List<AquiDtsObjs> aquiObjetosLista;

    private List<AquiDtsObjs> retornoObjetosLista;

    private int mayRetornoObjetctosCout = 5;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        retornoObjetosLista = new List<AquiDtsObjs>();
        AgregarAquiObjetos();
    }

    void AgregarAquiObjetos()
    {
        retornoObjetosLista.Clear();
        for (int i = 0; i < aquiObjetosLista.Count; i++)
        {
            aquiObjetosLista[i].aquiObjeto.GetComponent<Collider2D>().enabled = false;
        }

        int s = 0;
        while (s < mayRetornoObjetctosCout)
        {
            int cualqrVal = Random.Range(0, aquiObjetosLista.Count);

            if (!aquiObjetosLista[cualqrVal].tareaAqui)
            {
                aquiObjetosLista[cualqrVal].aquiObjeto.name = "" + s;
                aquiObjetosLista[cualqrVal].tareaAqui = true;
                aquiObjetosLista[cualqrVal].aquiObjeto.GetComponent<Collider2D>().enabled = false;

                retornoObjetosLista.Add(aquiObjetosLista[cualqrVal]);

                s++;

            }
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(pos, Vector3.zero);

            if (hit && hit.collider != null)
            {
                Debug.Log("nombre:" + hit.collider.gameObject.name);

                hit.collider.gameObject.SetActive(false);

                for (int i = 0; i < retornoObjetosLista.Count; i++)
                {
                    if (retornoObjetosLista[i].aquiObjeto.name == hit.collider.gameObject.name)
                    {
                        retornoObjetosLista.RemoveAt(i);
                        break;
                    }
                }

            }

        }
    }

    [System.Serializable]
    public class AquiDtsObjs
    {
        public string nombre;
        public GameObject aquiObjeto;
        public bool tareaAqui = false;
    }
}