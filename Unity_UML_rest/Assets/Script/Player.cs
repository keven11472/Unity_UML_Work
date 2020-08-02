using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    #region 欄位
    [Header("攻擊力"), Range(20, 50)]
    public float ATT = 25.0f;
    [Header("防禦力"), Range(10, 30)]
    public float DEF = 15.0f;
    [Header("血量"), Range(400, 700)]
    public int HP = 500;
    [Header("魔力"), Range(200, 400)]
    public int MP = 300;
    [Header("技能1"), Tooltip("技能1名稱")]
    public string SkILL1 = "火球術";
    [Tooltip("技能1消耗"), Range(10, 50)]
    public int CONSUME1 = 20;
    [Header("技能2"), Tooltip("技能2名稱")]
    public string SkILL2 = "火焰噴射";
    [Tooltip("技能2消耗"), Range(20, 50)]
    public int CONSUME2 = 30;
    [Header("是否死亡"), Tooltip("打勾代表死亡, 取消代表活著")]
    public bool DEAD = true;
    [Header("移動速度"), Range(300, 400)]
    public float SPEED = 300.0f;
    #endregion

    #region 方法
    /// <summary>
    /// 移動
    /// </summary>
    private void Move(string direction)
    {
        print("向" + direction);
    }
    /// <summary>
    /// 技能1
    /// </summary>
    private void Skill1()
    {
        print("火球術");
    }
    /// <summary>
    /// 技能2
    /// </summary>
    private void Skill2()
    {
        print("火焰噴射");
    }
    /// <summary>
    /// 受傷
    /// </summary>
    private void Hurt()
    {
        print("啊!!!");
    }
    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {
        print("嗚~~");
    }
    /// <summary>
    /// 攻擊
    /// </summary>
    private void Attack()
    {
        print("呀!!!");
    }
    #endregion
}
