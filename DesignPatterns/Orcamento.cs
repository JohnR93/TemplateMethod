﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }
        
        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
