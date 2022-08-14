﻿using CryptoCurrencySOLID.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencySOLID.Abstract
{
    public class Holochain:BaseCurrency, ICurrencySendWithAdress
    {
        
        public override string CurrencyBuy(decimal amount, string coinId, decimal buyingPrice)
        {
            return String.Concat("Kodu " + coinId + " olan coinden " + amount + " $ tutarında" + buyingPrice + "fiyatından alım gerçekleşti.");
        }

        public override string CurrencySell(decimal amount, string coinId, decimal sellingPrice)
        {
            return String.Concat("Kodu " + coinId + " olan coinden " + amount + " $ tutarında+" + sellingPrice + " fiyatından satış gerçekleşti.");
        }

        public string CurrencySendWithAdress(string adress, string coinId, decimal sendingFee, decimal sendingAmount)
        {
            return String.Concat(adress + " adrese " + coinId + " coini "+(sendingAmount- sendingFee)+ " miktarında gönderildi.");
        }

        public override string GetCurrencyAlgorithm()
        {
            return null;
        }

        public override string GetCurrencyCode()
        {
            return "Holo";
        }

        public override decimal GetCurrencyCurrentSupply()
        {
            throw new NotImplementedException();
        }

        public override string GetCurrencyDescription()
        {
            throw new NotImplementedException();
        }

        public override decimal GetCurrencyMarketCap()
        {
            return 448000000;
        }

        public override string GetCurrencyName()
        {
            return "holochain";
        }

        public override decimal GetCurrencyPrice(string moneyRate)
        {
            Ethereum eth = new Ethereum();
            if (moneyRate != "Holochain" && moneyRate == "Vitalik")
            {
                return(GetCurrencyMarketCap() / GetCurrencyCurrentSupply()) / eth.GetCurrencyPrice("Dollar");
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return GetCurrencyName();
        }
    }
}
