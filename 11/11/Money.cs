using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
	class Money
	{
        int first;
        int second;
        int totalCash = 0;
 
        public Money()
        {
            first = 0;
            second = 0;
        }
 
        public Money(int nominal, int quantityNotes)
        {
            this.first = nominal;
            this.second = quantityNotes;
        }
 
        public override string ToString()
        {
            return $"У Вас в кармане {second} куп. номиналом {first} руб.";
        }

        public string CheckAvailability(double costOfGoods)
        {
            totalCash = first * second;
            if (costOfGoods < totalCash)
            {
                return $"У Вас достаточно наличных ({totalCash} руб.) для покупки товара стоимость {costOfGoods} руб.";
            }
            else
            {
                return $"К сожалению, для покупки товара стоимостью {costOfGoods} Вам не хватает {costOfGoods - totalCash} руб. ";
            }
        }

        public string CalculationOfQuantity(double costOfGoods)
        {
            int quantityGoods = (int)(totalCash / costOfGoods);
            return $"На имеющиеся {totalCash} руб. можно купить {costOfGoods} ед. товара стоимостью {quantityGoods} руб.";
        }

        public int Nominal
        {
            get => first;
            set => first = value;
        }
 
        public int QuantityNotes
        {
            get => second;
            set => second = value;
        }

        public int TotalCash
        {
            get => totalCash;
        }        
	}
}
