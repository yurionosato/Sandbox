using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 0.5f;
    private Rigidbody2D rb;

    void Start()
    {
        // Rigidbody2Dコンポーネントを取得
        rb = GetComponent<Rigidbody2D>();

        // ランダムな方向に初期速度を設定
        Vector2 initialDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        rb.velocity = initialDirection * speed;
    }

    void Update()
    {
        // 速度を一定に保つ（ピンボールのように、一定の速度で動く）
        //rb.velocity = rb.velocity.normalized * speed;
    }

    // 壁に衝突したときに反発する
    void OnCollisionEnter2D(Collision2D collision)
    {
        rb.AddTorque(10f);
        // スプライトが壁に衝突したときに音や効果を加えるなど、カスタマイズ可能
    }
} 
