﻿namespace DesignPatterns.FactoryMethod
{
    static internal class Program
    {
        // TODO: 1.0 Create Factory method to be used by Gunnery class.

        static void Main()
        {
            var gunnery = new Gunnery();
            gunnery.RecordHitResult(HitResult.Hit);
        }
    }
}
