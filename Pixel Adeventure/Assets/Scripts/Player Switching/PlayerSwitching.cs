using UnityEngine;

public class PlayerSwitching : MonoBehaviour
{
    [Header("Player References")]
    [SerializeField] private Player player1;
    [SerializeField] private Player2 player2;
    [SerializeField] private bool player1Active = true;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightShift))
        {
            SwitchPlayer();
        }
    }

    void SwitchPlayer()
    {
        if(player1Active)
        {
            player1.enabled = false;
            player2.enabled = true;
            player1Active = false;
        }
        else
        {
            player1.enabled = true;
            player2.enabled = false;
            player1Active = true;
        }
    }
}
