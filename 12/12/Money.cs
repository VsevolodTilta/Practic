using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
	class Money
    {
        int first;
        int second;
        int totalCash;

        public Money()
        {
            first = 222;
            second = 322;
        }

        public Money(int value, int counts)
        {
            this.first = value;
            this.second = counts;
            this.totalCash = value * counts;
        }

        public double this[int index]               
        {
            get
            {
                if (index == 0) return first;
                else if (index == 1) return second;
                else
                {
                    throw new Exception("Введите верный индекс!");
                }
            }
            set
            {
                if (index == 0) first = Convert.ToInt32(value);
                else  if (index == 1) second = Convert.ToInt32(value);
                else
                {
                    throw new Exception("Введите верный индекс!");
                }
            }
        }
        public static Money operator ++(Money ob)       //одновременно увеличивает значение полей first и second
        {
            ob.first += 1;
            ob.second += 1;
            return ob;
        }
        public static Money operator --(Money ob)       //одновременно уменьшает значение полей first и second
        {
            try
            {
                ob.first -= 1;
                ob.second -= 1;
                if (ob.second < 0 | ob.first < 0) throw new System.ArithmeticException();
            }
            catch (System.ArithmeticException)
            {
                Console.WriteLine("Уменьшение не возможно !");
                ob.first +=1;
                ob.second += 1;
            }
            return ob;

        }
        public static bool operator !(Money ob)        //возвращает значение true, если поле second не нулевое, иначе false
        {
            if (ob.second != 0) return true;
            else return false;
        }
        public static Money operator +(Money ob, double n)        //добавляет к значению поля second значение скаляра
        {
            ob.second = Convert.ToInt32(ob.second + n);

            return ob;
        }
        public static explicit operator string(Money ob)          //Преобразование типа Money в  string
        {
            return string.Concat(string.Concat(ob.first, ' '), ob.second);
        }

        public static explicit operator Money(string str)          //Преобразование типа Money в  string
        {
            return new Money(Convert.ToInt32(str.Split(' ')[0]), Convert.ToInt32(str.Split(' ')[1]));
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
