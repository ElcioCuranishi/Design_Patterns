﻿using Design_Patterns.Business.Investimentos.Interface;
using Design_Patterns.Entidades.Banco;
using System;

namespace Design_Patterns.Business.Investimentos.Business
{
    public class Arrojado : IInvestimento
    {
        //20% de chances de retornar 5%, 
        //30% de chances de retornar 3%, 
        //e 50% de chances de retornar 0.6%.

        public double Calcular(ContaBancaria contaBancaria)
        {
            int chance = new Random().Next(0, 99);

            if (chance < 20)
                return contaBancaria.Saldo * 0.05;
            else if (chance < 50)
                return contaBancaria.Saldo * 0.03;
            else
                return contaBancaria.Saldo * 0.006;
        }
    }
}
