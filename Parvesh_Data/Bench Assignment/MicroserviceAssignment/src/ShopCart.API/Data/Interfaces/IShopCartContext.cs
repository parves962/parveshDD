﻿using StackExchange.Redis;

namespace ShopCart.API.Data.Interfaces
{
    public interface IShopCartContext
    {
        IDatabase Redis { get; }
    }
}