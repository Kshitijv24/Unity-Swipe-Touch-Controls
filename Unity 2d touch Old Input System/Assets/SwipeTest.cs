using UnityEngine;

public class SwipeTest : MonoBehaviour
{
    [SerializeField] Swipe swipeControls;
    [SerializeField] Transform player;
    [SerializeField] float moveSpeed;

    Vector3 desiredPosition;

    private void Update()
    {
        if (swipeControls.SwipeLeft)
            desiredPosition += Vector3.left;

        if (swipeControls.SwipeRight)
            desiredPosition += Vector3.right;

        if (swipeControls.SwipeUp)
            desiredPosition += Vector3.up;

        if (swipeControls.SwipeDown)
            desiredPosition += Vector3.down;

        player.position = Vector3.MoveTowards(player.position, desiredPosition, moveSpeed * Time.deltaTime);
    }
}
