﻿using OsrsFlipper.Data.Mapping;

namespace OsrsFlipper;

public class ItemFlip
{
    public readonly ItemData Item;
    public readonly int? PotentialProfit;
    public readonly double RoiPercentage;
    public readonly int InstaBuyPrice;
    public readonly int InstaSellPrice;
    public readonly DateTime LastInstaBuyTime;
    public readonly DateTime LastInstaSellTime;
    public readonly int AveragePrice24Hour;
    
    public string OsrsWikiLink => $"https://oldschool.runescape.wiki/w/Special:Lookup?type=item&id={Item.Id}";
    public string OsrsWikiPricesLink => $"https://prices.runescape.wiki/osrs/item/{Item.Id}";
    public string OsrsCloudPricesLink => $"https://prices.osrs.cloud/item/{Item.Id}";
    public string OsrsGeDbLink => $"https://secure.runescape.com/m=itemdb_oldschool/viewitem?obj={Item.Id}";


    public ItemFlip(ItemData item, int? potentialProfit, double roiPercentage, int instaBuyPrice, int instaSellPrice, DateTime lastInstaBuyTime, DateTime lastInstaSellTime, int averagePrice24Hour)
    {
        Item = item;
        PotentialProfit = potentialProfit;
        RoiPercentage = roiPercentage;
        InstaBuyPrice = instaBuyPrice;
        InstaSellPrice = instaSellPrice;
        LastInstaBuyTime = lastInstaBuyTime;
        LastInstaSellTime = lastInstaSellTime;
        AveragePrice24Hour = averagePrice24Hour;
    }


    public override string ToString()
    {
        string potentialProfit = PotentialProfit.HasValue ? $"{PotentialProfit.Value.SeparateThousands()}gp" : "Unknown";
        return $"{Item.Name} - {potentialProfit} potential profit, {RoiPercentage:F1}% ROI. (Buy: {InstaBuyPrice.SeparateThousands()}gp, Sell: {InstaSellPrice.SeparateThousands()}gp, 24h avg: {AveragePrice24Hour.SeparateThousands()}gp)";
    }
}