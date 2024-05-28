using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speased = 7f;

    void Update()
    {
        // get keys W and S also up and down arrows
        float moveInput = Input.GetAxis("Vertical");

        // Calculate input position
        Vector3 newPosition = transform.position + Vector3.up * moveInput * speased * Time.deltaTime;

        //delimits the vertical position
        newPosition.y = Mathf.Clamp(newPosition.y, -4.27f, 4.27f);

        //update position
        transform.position = newPosition;
    }
}
