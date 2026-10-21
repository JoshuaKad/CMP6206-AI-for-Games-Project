using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private InputSystem_Actions input;

    [SerializeField] int moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        input = new InputSystem_Actions();
        input.Player.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        var move = input.Player.Move.ReadValue<Vector2>();
        transform.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime * moveSpeed);
    }
}
