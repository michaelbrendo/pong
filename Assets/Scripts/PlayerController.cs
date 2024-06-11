using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speased = 7f;
    public string movementAxisName = "Vertical";
    public bool isPlayer = true;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        UpdatePaddleColor();
    }

    void Update()
    {
        // get keys W and S also up and down arrows
        float moveInput = Input.GetAxis(movementAxisName);

        // Calculate input position
        Vector3 newPosition = transform.position + Vector3.up * moveInput * speased * Time.deltaTime;

        //delimits the vertical position
        newPosition.y = Mathf.Clamp(newPosition.y, -4.27f, 4.27f);

        //update position
        transform.position = newPosition;
    }

    public void UpdatePaddleColor()
    {
        if (isPlayer)
        {
            spriteRenderer.color = SaveController.Instance.colorPlayer;
        }
        else
        {
            spriteRenderer.color = SaveController.Instance.colorEnemy;
        }
    }
}
