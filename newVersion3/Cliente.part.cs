using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA_BooKids
{
    partial class Cliente : Pessoa  
    {

        public Cliente(string nome, string morada, string localidade, int codigoPostal, int telefone, string email)
        {
            this.Nome = nome;
            this.Morada = morada;
            this.Localidade = localidade;
            this.CodPostal = codigoPostal;
            this.Telefone = telefone;
            this.Email = email;
        
        }
        
       
    }
}
