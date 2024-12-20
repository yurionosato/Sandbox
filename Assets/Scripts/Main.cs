
using UnityEngine;


public class Main : MonoBehaviour
{
    GameObject clickedGameObject;
    public GameObject m_square;
    [SerializeField] ParticleSystem m_particle;
    [SerializeField] GameObject m_BR;
    [SerializeField] GameObject m_BL;
    [SerializeField] GameObject m_UR;
    [SerializeField] GameObject m_UL;
    [SerializeField] GameObject m_zimen;
    [SerializeField] GameObject m_PSR;
    [SerializeField] GameObject m_PSL;


    private bool m_particleFlg = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2d)
            {
                clickedGameObject = hit2d.transform.gameObject;
                ClickObj();
            }
        }
    }



    void ClickObj() {
        string TempName = clickedGameObject.name;
        switch (TempName)
        {
            case "Square":
                m_square.GetComponent<Square>().ScuareClick();
                break;

            case "UL":
                if (m_particleFlg == true)
                {
                    m_particle.gameObject.SetActive(false);
                    m_particleFlg = false;
                }
                else {
                    m_particle.gameObject.SetActive(true);
                    m_particleFlg = true;
                }
                break;

            case "BL":
                m_BL.SetActive(false);
                m_UL.SetActive(false);
                m_BR.SetActive(false);
                m_UR.SetActive(false);
                m_zimen.SetActive(false);
                m_particle.gameObject.SetActive(false);
                m_PSL.gameObject.SetActive(true);
                m_PSR.gameObject.SetActive(true);

                break;

            case "UR":
                m_square.GetComponent<Square>().URClick();
                break;

            case "BR":
                m_square.GetComponent<Square>().BRClick();
                break;
        }
    }
}
