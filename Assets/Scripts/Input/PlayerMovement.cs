using UnityEngine;

public class PlayerMovement : Actor
{
    [SerializeField] private GameObject spawnTest;
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Move(new Vector2(x, y));

        if(Input.GetMouseButtonDown(0))
        {
            SpawnClick();
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
