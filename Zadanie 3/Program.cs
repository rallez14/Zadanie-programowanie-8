using System;

namespace Zadanie_3;

internal class Program
{
    private static void Main(string[] args)
    {
        var items = new ItemData.Item[]
        {
            CreateItem(12.7, 15000, ItemData.Rarity.Common, ItemData.Type.Armor, "Misfortune Armour"),
            CreateItem(8.4, 11400, ItemData.Rarity.Common, ItemData.Type.Armor, "Crimson Suit"),
            CreateItem(11.9, 12500, ItemData.Rarity.Common, ItemData.Type.Armor, "Tiger Plate Armour"),
            CreateItem(1.5, 31000, ItemData.Rarity.Rare, ItemData.Type.Amulet, "Amulet of Power"),
            CreateItem(6.5, 63000, ItemData.Rarity.Unique, ItemData.Type.Weapon, "Full Moon Sword"),
            CreateItem(5.3, 94000, ItemData.Rarity.Epic, ItemData.Type.Helemt, "Dragoneer Steel Helm"),
            CreateItem(0.7, 85000, ItemData.Rarity.Unique, ItemData.Type.Ring, "Soul Crystal Bracelet"),
            CreateItem(7.3, 43000, ItemData.Rarity.Rare, ItemData.Type.Shield, "Black Round Shield"),
            CreateItem(1.9, 37600, ItemData.Rarity.Rare, ItemData.Type.Boots, "Leather Boots")
        };
            
        var randomItem = GetRandomItem(items);
        Console.WriteLine("Randomly Selected Item:");
        DisplayItemData(randomItem);

    }

    private static ItemData.Item CreateItem(double weight, int value, ItemData.Rarity rarity, ItemData.Type type, string name)
    {
        var newItem = new ItemData.Item
        {
            Weight = weight,
            Value = value,
            Rarity = rarity,
            Type = type,
            Name = name
        };

        return newItem;
    }

    private static void DisplayItemData(ItemData.Item item)
    {
        Console.WriteLine("Item: " + item.Name);
        Console.WriteLine("Type: " + item.Type);
        Console.WriteLine("Rarity: " + item.Rarity);
        Console.WriteLine("Weight: " + item.Weight);
        Console.WriteLine("Value: " + item.Value);
    }
        
    private static ItemData.Item GetRandomItem(ItemData.Item[] items)
    {
        var totalDropChance = items.Sum(item => GetItemDropChance(item.Rarity));

        var randomValue = new Random().NextDouble() * totalDropChance;

        foreach (var item in items)
        {
            randomValue -= GetItemDropChance(item.Rarity);

            if (randomValue <= 0)
            {
                return item;
            }
        }

        throw new Exception("Failed to select a random item."); // W przypadku gdyby lista przedmiotów była pusta
    }

    private static double GetItemDropChance(ItemData.Rarity rarity)
    {
        return rarity switch
        {
            ItemData.Rarity.Common => 1.0,
            ItemData.Rarity.Rare => 0.7,
            ItemData.Rarity.Unique => 0.3,
            ItemData.Rarity.Epic => 0.1,
            _ => 0.0
        };
    }
}
    
public static class ItemData
{
    public struct Item
    {
        public double Weight;
        public int Value;
        public Rarity Rarity;
        public Type Type;
        public string Name;
    }
    
    public enum Rarity
    {
        Common,
        Rare,
        Unique,
        Epic
    }

    public enum Type
    {
        Weapon,
        Armor,
        Amulet,
        Ring,
        Helemt,
        Shield,
        Boots
    }
}