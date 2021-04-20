using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HahmoOhjain : MonoBehaviour
{
    public float juoksuNopeus = 3.5f;
    public float hiiriNopeus = 0f;
    public float hyppyNopeus = 100f;
    public float painovoima = 10f;
    private float vertikaalinenPyorinta = -0;
    private float horisontaalinenPyorinta = 0;
    private Vector3 liikesuunta = Vector3.zero;
    // Start is called before the first frame update moikkuu
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horisontaalinenPyorinta += Input.GetAxis("Mouse X") * hiiriNopeus;
        vertikaalinenPyorinta += Input.GetAxis("Mouse Y") * hiiriNopeus;
        Camera.main.transform.localRotation = Quaternion.Euler(vertikaalinenPyorinta, horisontaalinenPyorinta,0);
    }
}
