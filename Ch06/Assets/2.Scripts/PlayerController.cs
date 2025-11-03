using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    public float jumpForce = 400f;
    public float walkForce = 30f;
    public float maxWalkSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0)
        {
            animator.SetTrigger("Jump Trigger");
            rb.AddForce(transform.up * jumpForce);
        }

        int key = 0;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;

        float speedX = Mathf.Abs(rb.velocity.x);
        if (speedX < maxWalkSpeed)
        {
            rb.AddForce(transform.right * key * walkForce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        if (rb.velocity.y == 0)
        {
            animator.speed = speedX / 2.0f;
        }
        else
        {
            animator.speed = 1.0f;
        }


        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("Main");
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("ClearScene");
    }
}
