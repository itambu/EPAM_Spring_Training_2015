using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InetShopLibrary
{
    public class Shop
    {
        private IShopItemGroup _rootCategories;
        private ICollection<IUser> _users;
        private ICollection<IManager> _managers;
        private ICollection<IOrder> _orders;

        #region 

        protected IShopItemGroup RootCategories
        {
            get { return _rootCategories; }
        }

        protected ICollection<IUser> Users
        {
            get { return _users; }
        }

        protected ICollection<IManager> Managers
        {
            get { return _managers; }
        }

        protected ICollection<IOrder> Orders
        {
            get { return _orders; }
        }

        #endregion

        public Shop(IShopItemGroup rootCategories, ICollection<IUser> users, ICollection<IManager> managers, ICollection<IOrder> orders)
        {
            _rootCategories = rootCategories;
            _users = users;
            _managers = managers;
            _orders = orders;
        }

        #region

        protected virtual void Validate(IShopItem shopItem, IShopItemGroup group)
        {
            if (shopItem==null)
            {
                throw new NullReferenceException("shopItem should be not null");
            }
            else if (group == null)
            {
                throw new NullReferenceException("group should be not null");
            }
        }

        public void Add(IShopItem shopItem, IShopItemGroup group)
        {
            Validate(shopItem, group);
            group.Add(shopItem);
        }


        protected virtual void Validate(IUser user)
        {
        }

        public void Add(IUser user)
        {
            Validate(user);
            Users.Add(user);
        }

        protected virtual void Validate(IManager manager)
        {
        }

        public void Add(IManager manager)
        {
            Validate(manager);
            Managers.Add(manager);
        }

        protected virtual void Validate(IOrder order)
        {
        }

        public void Add(IOrder order)
        {
            Validate(order);
            Orders.Add(order);
        }

        #endregion

    }
}
