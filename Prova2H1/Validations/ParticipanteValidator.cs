using FluentValidation;
using Prova2H1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova2H1.Validations
{
    public class ParticipanteValidator : AbstractValidator<Participante>
	{
		public ParticipanteValidator()
		{
			RuleFor(p => p.Nome).MinimumLength(3).WithMessage("Nome deve conter no mínimo 3 caracteres.")
								.MaximumLength(100).WithMessage("Nome deve conter no máximo 100 caracteres.")
								.NotEmpty().WithMessage("Nome é obrigatório.");

            RuleFor(p => p.NumEscolhido).NotEmpty().WithMessage("Número é obrigatório.")
							   .NotNull().WithMessage("Número é obrigatório.")
							   .Must(validaNum).WithMessage("Número é inválido");


			RuleFor(p => p.CPF).NotEmpty().WithMessage("Cpf é obrigatório")
							   .NotNull().WithMessage("Cpf é obrigatório")
							   .Must(validaCpf).WithMessage("Cpf é inválido");
		}

		private bool validaNum(int numero)
		{
			if (100 < numero)
				return false;
			else
				return true;
		}

		private bool validaCpf(string cpf)
		{
			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			string tempCpf;
			string digito;
			int soma;
			int resto;
			cpf = cpf.Trim();
			cpf = cpf.Replace(".", "").Replace("-", "");
			if (cpf.Length != 11)
				return false;
			tempCpf = cpf.Substring(0, 9);
			soma = 0;

			for (int i = 0; i < 9; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = resto.ToString();
			tempCpf = tempCpf + digito;
			soma = 0;
			for (int i = 0; i < 10; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = digito + resto.ToString();
			return cpf.EndsWith(digito);
		}
	}
}
