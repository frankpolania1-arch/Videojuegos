using UnityEngine;
public class CheckGround : MonoBehaviour
{
    public static bool IsGround = true;
    private void OnTriggerEnter2D(Collider2D other)
    {
        IsGround = true;
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        IsGround = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        IsGround = false;
    }
}