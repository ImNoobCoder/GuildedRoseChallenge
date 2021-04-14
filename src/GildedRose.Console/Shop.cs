using System.Collections.Generic;

namespace GildedRose.Application
{
    public static class Shop
    {
        public static IList<Item> Items;

        public static void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                changeQuality(Items[i])
                decreaseSellIn(Items[i])


                if (Items[i].SellIn < 0)
                {
                    decreaseSellInQuality(item);
                }
                changeSellInQuality(item){
                    if (item.Name != "Aged Brie")
                    {
                        if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.Name != "Sulfuras, Hand of Ragnaros")
                            {
                                decreaseQuality(item)
                            }
                        }
                        else
                        {
                            item.Quality = item.Quality - item.Quality;
                        }
                    }
                    else
                    {
                        increaseQuality(item);
                    }
                }
            }
        }

        changeQuality(item)
        {
            if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert" &&
                item.Name != "Sulfuras, Hand of Ragnaros")
            {
                if (Items[i].Quality > 0)
                {
                    decreaseQuality(item)
                }
            }
            else
            {
                if (Items[i].Quality < 50)
                {
                    increaseQuality(item)
                }
            }
        }

        decreaseSellIn(item)
        {
            if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                item.SellIn = item.SellIn - 1;
            }
        }

        decreaseQuality(item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }
        }
        increaseQuality(item)
        {

        }

    }
}