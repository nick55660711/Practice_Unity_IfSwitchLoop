
using UnityEngine;
using UnityEngine.UI;
public class practice2 : MonoBehaviour
{


    public Text input;
    public Text Result_item;

    public void Update()
    { 
        Result_item.text = input.text == "紅水" ? "道具效果：恢復血量" : input.text == "藍水" ? "道具效果：恢復魔力" :   "無法使用";



    }




}
