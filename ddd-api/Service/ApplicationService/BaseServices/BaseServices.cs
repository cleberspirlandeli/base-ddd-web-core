﻿using Domain.Models;
using FluentValidation;
using FluentValidation.Results;
using Service.Interfaces;
using Service.Notificacoes;
using System;
using System.Linq;

namespace Service.ApplicationService
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;

        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

        protected bool OperacaoValida()
        {
            return !_notificador.TemNotificacao();
        }

        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }

        protected void VerifyExists(object objectVerify, string customMessage = "")
        {
            if (objectVerify == null && !String.IsNullOrEmpty(customMessage))
                throw new Exception(customMessage);
        }
    }
}
