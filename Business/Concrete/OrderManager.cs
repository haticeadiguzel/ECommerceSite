using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public Order GetById(int id)
        {
            return _orderDal.Get(o => o.OrderId == id);
        }

        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public void Update(Order order)
        {
            _orderDal.Update(order);
        }

        public void Delete(Order order)
        {
            _orderDal.Delete(order);
        }
    }
}
