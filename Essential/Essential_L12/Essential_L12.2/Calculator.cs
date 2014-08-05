using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L12._2
{
    class Calculator
    {
        public OperationResponse Calculate(OperationRequest request)
        {
            var response = new OperationResponse();
            response.Error = null;
            switch(request.Operation)
            {
                case Operations.Add:
                    {
                        response = Add(request.Operand1, request.Operand2);
                        break;
                    }
                case Operations.Subtract:
                    {
                        response = Subtract(request.Operand1, request.Operand2);
                        break;
                    }
                case Operations.Multiply:
                    {
                        response = Multiply(request.Operand1, request.Operand2);
                        break;
                    }
                case Operations.Divide:
                    {
                        response = Divide(request.Operand1, request.Operand2);
                        break;
                    }
                default:
                    {
                        response.Error = "Cannot perform the unknown operation!";
                        break;
                    }
            }

            return response;
        }

        private OperationResponse Add(double a, double b)
        {
            var response = new OperationResponse();
            response.Result = a + b;
            return response;
        }

        private OperationResponse Subtract(double a, double b)
        {
            var response = new OperationResponse();
            response.Result = a - b;
            return response;
        }

        private OperationResponse Multiply(double a, double b)
        {
            var response = new OperationResponse();
            response.Result = a * b;
            return response;
        }

        private OperationResponse Divide(double a, double b)
        {
            var response = new OperationResponse();
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
