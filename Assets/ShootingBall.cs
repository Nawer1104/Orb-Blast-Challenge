using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class ShootingBall : MonoBehaviour
{
    public event EventHandler GameOver;

    [SerializeField] float speed;
    [SerializeField] GameObject objectToShoot;
    private bool has_ball = true;
    private bool block_spam = false;

    private void OnMouseDown()
    {
        if (block_spam) return;
        block_spam = true;
        Shoot();
    }

    public void Shoot()
    {
        if (!has_ball) return;
        has_ball = false;
        objectToShoot.GetComponent<Rigidbody2D>().velocity = objectToShoot.transform.up * speed * Time.deltaTime;
    }

}
