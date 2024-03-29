﻿using Admissao__Digital.Core.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admissao__Digital.Core.Entidades;
using Newtonsoft.Json;

namespace Admissao__Digital.Core.Services
{

    public class ContratadoService : IContratadoService
    {
        private readonly IInserirContratado _inserirContratado;
        private readonly IInserirDependentes _inserirDependentes;

        public ContratadoService(IInserirContratado inserirContratado, IInserirDependentes inserirDependentes)
        {
            _inserirContratado = inserirContratado;
            _inserirDependentes = inserirDependentes;
        }

        public bool CriarUsuario(CriarUsuario modelCriarUsuario)
        {
            try
            {
                long idContratado = _inserirContratado.InserirDadosContratado(modelCriarUsuario);

                var criarDependente = CriarDependente(modelCriarUsuario, idContratado);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool CriarDependente(CriarUsuario modelCriarUsuario, long idContratado)
        {
            try
            {
                if (modelCriarUsuario.Dependente.Count > 0)
                {
                    var idsDependentes = _inserirDependentes.InserirDadosDependentes(modelCriarUsuario, idContratado);                    

                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }

        }


    }
}
