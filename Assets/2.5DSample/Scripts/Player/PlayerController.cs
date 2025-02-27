using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 3f;

    private Rigidbody rb;
    private SpriteRenderer sr;

    private Vector3 movementInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        sr = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        movementInput = new Vector3(InputManager.PlayerMove.x, 0, InputManager.PlayerMove.y).normalized * movementSpeed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(movementInput.x, rb.velocity.y, movementInput.z);
    }
}