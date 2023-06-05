using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ball : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "CircleMiddle")
        {
            OrbGameManager.Instance.RemoveBall(this);
            Destroy(gameObject);
            collision.gameObject.GetComponent<ShootingBall>().Shoot();
        }
    }
}
