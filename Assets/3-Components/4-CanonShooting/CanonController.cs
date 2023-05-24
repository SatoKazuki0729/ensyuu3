using System.Threading;
using UnityEngine;

/// <summary>
/// 砲台 (Canon) を制御するコンポーネント
/// </summary>
public class CanonController : MonoBehaviour
{
    [SerializeField] float interval;
   [SerializeField]GameObject  crosshair;
    /// <summary>砲弾として生成するプレハブ</summary>
   [SerializeField] GameObject m_shellPrefab = default;
    /// <summary>砲口を指定する</summary>
    [SerializeField] Transform m_muzzle = default;
    AudioSource m_audio = default;
    float timer = 0;
    

    void Start()
    {
        timer = interval; 
        m_audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        //timer += Time.deltaTime;

        if (timer > interval)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                m_audio.Play();
                Instantiate(m_shellPrefab, m_muzzle.position, this.transform.rotation);
                timer = 0;
            }
        }
        else
        {
            //一応
            timer += Time.deltaTime;
        }

        

        this.transform.up = crosshair.transform.position - this.transform.position;
       
    }
}
