using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYERCONTROLLER : MonoBehaviour
{
    Rigidbody2D rb2d;
    //ho creato una variabile di tipo rigidbody rb2d. posso accedere al rigidbody
    //del player tramite questa variabile. la variabile è un oggetto che contiene qualcosa.
    //in questo caso un componente rigidbody.

    // Start is called before the first frame update

    public int runSpeed;
    //public vuol dire che altri script vedono tale variabile runSpeed e possono
    //accedervi. possiamo conservare solo valori interi nella variabile.

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame

    void Update()
    {
        transform.position = Vector3.right * runSpeed * Time.deltaTime + transform.position;
    }
}

