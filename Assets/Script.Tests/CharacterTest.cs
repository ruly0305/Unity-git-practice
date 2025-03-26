using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class CharacterTest
{
    [Test(Description = "角色攻擊敵人")]
    public void Character_Attack_Enemy()
    {
        // arrange
        //  建立玩家角色元件
        var go1 = new GameObject();
        go1.AddComponent<Character>();
        var character = go1.GetComponent<Character>();
        character.SetAtk(atkValue: 10);


        // 建立敵人元件
        var go2 = new GameObject();
        go2.AddComponent<Enemy>();
        var enemy = go2.GetComponent<Enemy>();
        enemy.SetHp(hpValue: 100);

        // act
        character.Attack(enemy);
        character.Attack(enemy);

        // assert
        var hp = enemy.GetHp();
        Assert.AreEqual(expected:0 , actual:hp);
    }
}