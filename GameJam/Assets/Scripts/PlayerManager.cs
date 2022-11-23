using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{

    private Vector2 movement; // Vi vil gemme det "Vector2" der kommer ind når man trykker WSAD ind på movement
    private Rigidbody2D myBody; // Den rigidbody vi vil flytte rundt

    

    [SerializeField] private int speed = 5; //Den hastighed vores human skal flyttes rundt

    private void Awake() // Awake køre kun engang når programmet starter
    {
        myBody = GetComponent<Rigidbody2D>(); // Vi sætter myBody rigidbody til rigidbody på det gameobject vi sidder på
    }
    private void OnMovement(InputValue value) // Vi laver en function der holder øje med vores Input systems value
    {
        movement = value.Get<Vector2>(); // Movement bliver sat til vector 2 fra vores Input Action når brugeren trykker WSAD
    }

    private void FixedUpdate() // FixedUpdate er mere effektiv end update når det kommer til even based ting som flytning
    {
        myBody.velocity = movement * speed; // Vi sætter vores velocity af vores rigidbody2D i den hastighed vi har sat
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
        }
    }
}
