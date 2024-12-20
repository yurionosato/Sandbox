using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundsWalls : MonoBehaviour
{
    public GameObject wallPrefab; // 壁として使うオブジェクトのプレハブ
    public float wallThickness = 0.5f; // 壁の厚さ

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;

        // 画面の四隅の座標を取得
        Vector2 screenBottomLeft = mainCamera.ScreenToWorldPoint(new Vector3(0, 0, mainCamera.nearClipPlane));
        Vector2 screenTopRight = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.nearClipPlane));

        // 上下左右の壁を作成
        CreateWall(new Vector2(0, screenTopRight.y + wallThickness / 2), new Vector2(screenTopRight.x * 2, wallThickness)); // 上の壁
        CreateWall(new Vector2(0, screenBottomLeft.y - wallThickness / 2), new Vector2(screenTopRight.x * 2, wallThickness)); // 下の壁
        CreateWall(new Vector2(screenTopRight.x + wallThickness / 2, 0), new Vector2(wallThickness, screenTopRight.y * 2)); // 右の壁
        CreateWall(new Vector2(screenBottomLeft.x - wallThickness / 2, 0), new Vector2(wallThickness, screenTopRight.y * 2)); // 左の壁
    }

    // 壁を作成する関数
    void CreateWall(Vector2 position, Vector2 size)
    {
        GameObject wall = Instantiate(wallPrefab);
        wall.transform.position = position;
        wall.transform.localScale = size;

        // 壁にBoxCollider2Dを追加して、物理的な壁として機能するようにする
        if (!wall.GetComponent<BoxCollider2D>())
        {
            wall.AddComponent<BoxCollider2D>();
        }
    }
}

