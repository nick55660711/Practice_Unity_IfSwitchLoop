using UnityEngine;
using UnityEngine.UI;
public class practice1_if : MonoBehaviour
{   


    private float HP;
    public float HP_ { get => HP; set => HP = value; }
    public Slider slider;

    public Text Result;   
    




    void Update()
    {
    HP_ = slider.value;
        if (HP_ <= 30)
        {
            Result.text = "血量：危險";
        }
        else if (HP_ <= 70)
        {
            Result.text = "血量：警告";
        }
        else 
        {
            Result.text = "血量：安全";
        }
    }
}
