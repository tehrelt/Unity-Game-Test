using UnityEngine;
using TMPro;

public class PlayerMovement : Actor
{
    [SerializeField] private GameObject spawnTest;
    [SerializeField] private TMP_Text dashCooldownText;

    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //if (dashing) return;

        

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Move(new Vector2(x, y));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dash(((Vector3)mousePosition - transform.position).normalized);
        }
    }

    private void FixedUpdate()
    {
        if (dashDelay > 0)
        {
            dashCooldownText.text = dashDelay.ToString() + " s.";
            dashDelay--;
        }

        if (dashing)
        {
            rigidbody.velocity = (dashDirection * dashSpeed);
            dashActive++;
            if(dashActive > dashDuration)
            {
                StopDash();
                dashActive = 0;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Vector3 mouse = Input.mousePosition;

        mouse = Camera.main.ScreenToWorldPoint(mouse);

        Gizmos.DrawLine(transform.position, mouse);
    }

    public void SpawnClick()
    {

    }

}
