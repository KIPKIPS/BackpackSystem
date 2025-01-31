﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : Item {
    public int Strength { get; set; } //力量
    public int Intellect { get; set; } //智力
    public int Agility { get; set; } //敏捷
    public int Stamina { get; set; } //体力
    public EquipType EquipmentType { get; set; } //装备类型


    public Equipment(int _id, string _name, ItemType _itemType, Quality _qualityType, string _desc, int _capacity, int _buyPrice, int _sellPrice, string _sprite, string _iconType,
        int _strength, int _intellect, int _agility, int _stamina, EquipType _equipmentType)
        : base(_id, _name, _itemType, _qualityType, _desc, _capacity, _buyPrice, _sellPrice, _sprite, _iconType) {
        Strength = _strength;
        Intellect = _intellect;
        Agility = _agility;
        Stamina = _stamina;
        EquipmentType = _equipmentType;
    }

    //装备类型
    public enum EquipType {
        None,
        Head, // 头部
        Neck, // 脖子
        Ring, // 戒指
        Leg, //腿部护具
        Bracer, // 护腕
        Boots, // 靴子
        Trinket, // 饰品
        Shoulder, // 肩膀
        Belt, // 腰带
        OffHand, // 副手武器
    }

    public override string GetItemDesc() {
        string text = base.GetItemDesc();
        text += "\n" + "力量:" + Strength + " 智力" + Intellect + " 敏捷" + Agility + " 体力" + Stamina;
        text += "\n" + "装备类型" + EquipmentType.ToString();
        return text;
    }
}