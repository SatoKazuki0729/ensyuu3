using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

/// <summary>
/// Star を制御するコンポーネント
/// </summary>
public class StarController : MonoBehaviour
{
    [SerializeField]
    GameObject m_pugya;
    void Update()
    {
        if (this.transform.position.y < -10f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 砲弾が当たった時
        if (collision.gameObject.tag == "Shell")
        {
            Debug.Log("ban");

            // AudioSource コンポーネントを取得して音を鳴らす
            //AudioSource audio = GetComponent<AudioSource>();
            //audio.Play();

            Instantiate(m_pugya, this.transform.position, this.transform.rotation);

            Debug.Log("Pーーー");
            // 自分自身を破棄する
            Destroy(this.gameObject);
        }
    }
}
