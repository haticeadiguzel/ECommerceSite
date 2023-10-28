using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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

        public IDataResult<List<Order>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Order>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(), Messages.OrdersListed);
        }

        public IDataResult<Order> GetById(int id)
        {
            return new SuccessDataResult<Order>(_orderDal.Get(o => o.order_id == id), Messages.OrderListedGetById);
        }

        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new Result(true, Messages.OrderAdded);
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new Result(true, Messages.OrderUpdated);
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new Result(true, Messages.OrderDeleted);
        }
    }
}
