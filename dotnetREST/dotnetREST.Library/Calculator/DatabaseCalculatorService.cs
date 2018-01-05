using dotnetREST.Library.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetREST.Library.Calculator
{
    public class DatabaseCalculatorService : ICalculatorService
    {
        private readonly ICalculatorRepository _repository;

        public DatabaseCalculatorService(ICalculatorRepository repository)
        {
            _repository = repository;
        }
    }
}
