using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private readonly IRentalDal _service;

        public RentalManager(IRentalDal service)
        {
            _service = service;
        }

        public IResult Add(Rental rental)
        {
            try
            {
                _service.Add(rental);
                return new SuccessResult("Added successfully.");
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public IDataResult<List<Rental>> GetAll()
        {
            try
            {
                return new SuccessDataResult<List<Rental>>(_service.GetAll());
            }
            catch (Exception e)
            {

                return new ErrorDataResult<List<Rental>>(e.Message);
            }
        }

        public IDataResult<Rental> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
