﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IdentidadeCultural.Entity.Dominio.Model
{
    public class Usuario
    {

        public Guid? Usuario_Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Titulo { get; set; }
        public string Telefone { get; set; }
        public string Foto { get; set; }
        public DateTime Criacao { get; set; }

        [JsonIgnore]
        public virtual ICollection<ServicoTrabalho> Servicos { get; set; }


        [JsonIgnore]
        public virtual ICollection<Produto> Produtos { get; set; }

    }
}