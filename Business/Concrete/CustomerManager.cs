using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            this.customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> Get()
        {
            return new SuccessDataResult<List<Customer>>(Messages.CustomersListed);
        }

        public IResult Update(Customer customer)
        {
            customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
