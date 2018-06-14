using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 保存每一波敌人生成所需要的属性
[System.Serializable] // 可以被序列化，就是能显示在Inspector面板上
public class Wave {
	public float rate; // 每个敌人生成的间隔
    public int moneyRate; //敌人金钱生成比
    public int expRate; //敌人经验生成比
    public int hpRate; //敌人血量生成比
    public int PDRate; //敌人物防生成比
    public int MDRate; //敌人魔防生成比
}
