using UnityEngine;
using UnityEngine.UI;

public class PlayerMouve : MonoBehaviour
{
    public float movementSpeed = 5f; // Скорость перемещения объекта по оси X

    private bool isMovingLeft = false;
    private bool isMovingRight = false;

    void Update()
    {
        if (isMovingLeft || Input.GetKey(KeyCode.A))
        {
            MoveObject(-1f);
        }
        else if (isMovingRight || Input.GetKey(KeyCode.D))
        {
            MoveObject(1f);
        }
    }

    public void StartMovingLeft()
    {
        isMovingLeft = true;
    }

    public void StartMovingRight()
    {
        isMovingRight = true;
    }

    public void StopMovingLeft()
    {
        isMovingLeft = false;
    }

    public void StopMovingRight()
    {
        isMovingRight = false;
    }

    private void MoveObject(float direction)
    {
        // Движение объекта вправо-влево
        // Мы перемещаем объект по оси X, оставляя Y и Z без изменений
        Vector3 movement = new Vector3(direction, 0f, 0f) * movementSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}
