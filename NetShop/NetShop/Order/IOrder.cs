using NetShop.Element;
using NetShop.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Order
{
    public interface IOrder: INotifyPropertyChanged
    {
        Basket Basket { get; }
        Decimal Sum { get; }
        IUser User { get; }
        DateTime OrderDate { get; }
        OrderStatus Status { get; }

        void Add(IElement element);
        void Remove(IElement element);
    }
}
