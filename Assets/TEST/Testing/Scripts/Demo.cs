using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    public Transform myTransform;
    public SpriteRenderer sp;
    public Demo demoScript;
    //public GameObject Heroprefab;
    private void Awake()
    {
        //Debug.Log("Awake");
        sp = GetComponent<SpriteRenderer>();
    }
    private void OnEnable()
    {
        //Debug.Log("OnEnable");
    }
    // Start is called before the first frame update
    void Start()
    {
        //if (sp)
        // sp.color = Color.red;
        //Debug.Log("Start");
        /* if (Heroprefab)
         {
             var heroClone = Instantiate(Heroprefab, new Vector3(3, 2, 0), Quaternion.identity);
             Destroy(heroClone, 4f);
         }*/
        //StartCoroutine("DemoCo");
        Invoke("work", 3);
    }
    private void work()
    {
        Debug.Log("Cong viec can thuc hien");
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log("update");
    }
    private void OnDisable()
    {
        //Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        //Debug.Log("OnDestroy");
    }
    /* private void OnCollisionEnter2D(Collision2D colTarget)
     {
        // Debug.Log(colTarget.gameObject.GetComponent<SpriteRenderer>().color= Color.red);

     }
     private void OnCollisionStay2D(Collision2D colTarget)
     {
         Debug.Log("2 doi tuong dang va cham voi nhau");
     }
     private void OnCollisionExit2D(Collision2D collision)
     {

     }
    */

}
