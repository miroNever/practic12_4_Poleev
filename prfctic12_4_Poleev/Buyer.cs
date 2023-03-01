using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prfctic12_4_Poleev
{
    internal class Buyer
    {
        private string name;
        private int quantity;
        private double price;
        private double paid;  
        private double wallet;
        private double mood = 10;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public double Wallet
        {
            get { return wallet; }
            set { wallet = value; }
        }
        public double Mood
        {
            get { return mood; }
            set { mood = value; }
        }
        public double Paid 
        {
            get { return paid; }
            set { paid = value; }
        }
        public string InfoProduct()
        {
            return $@"Название: {name}
Цена: {price}
Кол-во: {quantity}
Денег в кошельке: {wallet}
Настроение: {mood}";
        }
        public string Buy()
        {
            paid = price * quantity;
            wallet -= paid;
                if (wallet > 0)
                {
                    mood += 0.5 * paid;
                }
                else 
                {
                    mood -= paid;
                }
                return $@"Вы оплатили: {paid}
В кошельке осталось: {wallet}
Настроение: {mood}"; 
        }
        public string Moods()
        {
            if (mood > 15) return "Настроение - бодрое!";
            else if (mood > 5 && mood <= 15) return "Настроение - нормальное!";
            else if (mood > -10 && mood <= 5) return "Настроение - плохое!";
            else return "Натсроение - депресивное!";
        }
    }
}
