using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testspawn : MonoBehaviour
{
    public GameObject myPrefab;
    public float px;
    public float py;
    public float pz;
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Mouse0)){
        Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
