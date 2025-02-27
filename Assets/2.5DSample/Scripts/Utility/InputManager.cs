using UnityEngine;

public static class InputManager
{

    private static Inputs input;

    static InputManager()
    {
        input = new Inputs();
        TogglePlayerMap(true);
    }

    public static Inputs.PlayerActions PlayerMap
    {
        get { return input.Player; }
    }

    public static Vector2 PlayerMove
    {
        get { return input.Player.Move.ReadValue<Vector2>(); }
    }

    public static void TogglePlayerMap(bool enable)
    {
        if (enable)
        {
            input.Player.Enable();
        }
        else
        {
            input.Player.Disable();
        }
    }
}