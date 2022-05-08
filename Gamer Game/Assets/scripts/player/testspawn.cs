using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testspawn : MonoBehaviour
{   
    public GameObject player;
    public GameObject myPrefab;
    Vector3 place;
    public float rot=0f;
    public float px;
    public float py;
    public float pz;
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        float rot = Camera.main.transform.localEulerAngles.y;
        transform.rotation = Quaternion.Euler(0f, rot, 0f);
        Vector3 place = gameObject.transform.position;
        if (Input.GetKeyDown(KeyCode.Mouse0)){
        Instantiate(myPrefab, place, Quaternion.identity);
        }
    }
}
