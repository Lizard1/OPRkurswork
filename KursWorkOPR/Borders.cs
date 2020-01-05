using System;
using System.Collections.Generic;
using ELW.Library.Math;
using ELW.Library.Math.Exceptions;
using ELW.Library.Math.Expressions;
using ELW.Library.Math.Tools;

namespace KursWorkOPR
{
    public class Borders
    {
        public int scopeX1Left;
        public int scopeX1Right;
        public int scopeX2Left;
        public int scopeX2Right;
        public int numberOfPoint;
        public int numberOfPopulations;
        

        private Form1 _form;
        public Borders(Form1 form)
        {
            _form = form;
        }
        public void FullingBorder(int x1l, int x1r, int x2l, int x2r, int numOfPoint, int numberOfPop)
        {
            this.scopeX1Left = x1l;
            this.scopeX1Right = x1r;
            this.scopeX2Left = x2l;
            this.scopeX2Right = x2r;
            this.numberOfPoint = numOfPoint;
            this.numberOfPopulations = numberOfPop;
        }
        public class FunctionResult
        {
            public FunctionResult()
            {
                Result = new List<string>();
            }

            public string Message { get; set; }
            public bool OK { get; set; }
            public List<string> Result { get; set; }
        }
        public FunctionResult valueOfFunction()
        {
            FunctionResult result = new FunctionResult();
            try
            {
                PreparedExpression preparedExpression = ToolsHelper.Parser.Parse(_form.TextBoxForFunction.Text);
                CompiledExpression compiledExpression = ToolsHelper.Compiler.Compile(preparedExpression);
                CompiledExpression optimizedExpression = ToolsHelper.Optimizer.Optimize(compiledExpression);
                
                double firstValue;
                for (int i = 0; i < _form.DataForGenerations.Rows.Count - 1; i++)
                {
                    List<VariableValue> variables = new List<VariableValue>();
                    if (!Double.TryParse(_form.DataForGenerations.Rows[i].Cells[3].Value.ToString(), out firstValue))
                    {
                        result.OK = false;
                        result.Message =  "Error converting first variable value.";
                        return result;
                    }
                    variables.Add(new VariableValue(firstValue, "x"));

                    double secondValue;
                    if (!Double.TryParse(_form.DataForGenerations.Rows[i].Cells[4].Value.ToString(), out secondValue))
                    {
                       
                        result.OK = false;
                        result.Message = "Error converting second variable value.";
                        return result;
                       
                    }
                    variables.Add(new VariableValue(secondValue, "y"));
                    result.OK = true;
                 
                    double res = ToolsHelper.Calculator.Calculate(compiledExpression, variables);
                   
                    result.Message = String.Format("Result: {0}\nOptimized: {1}", res,
                        ToolsHelper.Decompiler.Decompile(optimizedExpression));
                    result.Result.Add(res.ToString());
                }

            }
            catch (CompilerSyntaxException ex)
            {
                result.OK = false;
                result.Message = String.Format("Compiler syntax error: {0}", ex.Message);
            }
            catch (MathProcessorException ex)
            {
                result.OK = false;
                result.Message = String.Format("Error: {0}", ex.Message);
            }
            catch (ArgumentException ex)
            {
                result.OK = false;
                result.Message = String.Format("Error in input data: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                result.OK = false;
                result.Message = String.Format("Error: {0}", ex.Message);
            }
            return result;
        }
    }
}
