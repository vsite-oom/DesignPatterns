﻿namespace DesignPatterns.Interpreter
{
    public interface IExpression
    {
       bool Interpret(Context context);
    }
}
