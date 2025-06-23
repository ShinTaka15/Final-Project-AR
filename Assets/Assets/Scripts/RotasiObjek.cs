using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotasiObjek : MonoBehaviour
{
    public Vector3 putar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(putar * Time.deltaTime);
    }
}
