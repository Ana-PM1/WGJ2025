using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    [SerializeField] private List<HiddenObjectData> hiddenObjectsList;
    private List<HiddenObjectData> activeHiddenObjectsList;
    [SerializeField] private int maxActiveHiddenObjectsCount = 5;
   
    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) Destroy(gameObject);
    }

    void Start()
    {
        activeHiddenObjectsList = new List<HiddenObjectData>();
        AssignHiddenObjects();
    }

    void AssignHiddenObjects()
    {
        activeHiddenObjectsList.Clear();
        for (int i = 0; i < hiddenObjectsList.Count; i++)
        {
            hiddenObjectsList[i].hiddenObject.GetComponent<Collider2D>().enabled = false;
        }    

        int k = 0;
        while (k < maxActiveHiddenObjectsCount)
        { 
            int randomVal = Random.Range(0, hiddenObjectsList.Count);

            if (!hiddenObjectsList[randomVal].makeHidden)
            {
                // hiddenObjectsList[randomVal].hiddenObject.name = "" + k;
                hiddenObjectsList [randomVal].makeHidden = true;
                hiddenObjectsList[randomVal].hiddenObject.GetComponent <Collider2D>().enabled = true;

                activeHiddenObjectsList.Add(hiddenObjectsList[randomVal]);

                k++;
            }
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//posicion del mouse
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector3.zero);

            if (hit && hit.collider != null)
            {
                Debug.Log("Object Name:" + hit.collider.gameObject.name);
            }
        }
    }

    [System.Serializable]
    public class HiddenObjectData
    {
        public string name;
        public GameObject hiddenObject;
        public bool makeHidden = false;
    }    
}
