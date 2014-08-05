using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L12._2
{
    class Calculator
    {
        private OperationResponse response = new OperationResponse();

        public OperationResponse Calculate(OperationRequest request)
        {
            response.Error = null;
            switch(request.Operation)
            {
                case Operations.Add:
                    {
                        Add(request.Operand1, request.Operand2);
                        break;
                    }
                case Operations.Subtract:
                    {
                        Subtract(request.Operand1, request.Operand2);
                        break;
                    }
                case Operations.Multiply:
                    {
                        Multiply(request.Operand1, request.Operand2);
                        break;
                    }
                case Operations.Divide:
                    {
                        Divide(request.Operand1, request.Operand2);
                        break;
                    }
            }

            return response;
        }

        private OperationResponse Add(double a, double b)
        {
            response.Result = a + b;
            return response;
        }

        private OperationResponse Subtract(double a, double b)
        {
            response.Result = a - b;
            return response;
        }

        private OperationResponse Multiply(double a, double b)
        {
            response.Result = a * b;
            return response;
        }

        private OperationResponse Divide(double a, double b)
        {
            if (b != 0)
            {
                response.Result = a / b;
            }
            else
            {
                response.Error = "ERROR: You cannot divide by zero!";
            }            
            return response;
        }
    }
}
