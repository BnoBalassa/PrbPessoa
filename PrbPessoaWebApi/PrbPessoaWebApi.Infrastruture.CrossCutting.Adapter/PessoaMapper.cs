﻿using AutoMapper;
using PrbPessoaWebApi.App.ViewModel.ViewModels;
using PrbPessoaWebApi.Domain.Models;
using PrbPessoaWebApi.Infrastruture.CrossCutting.Adapter.Interfaces;


namespace PrbPessoaWebApi.Infrastruture.CrossCutting.Adapter
{
    public class PessoaMapper : IPessoaMapper
    {
        private readonly IMapper _mapper;

        public IEnumerable<PessoaViewModel> ListViewModelToPessoa(IEnumerable<Pessoa> pessoa)
        {
            return _mapper.Map<IEnumerable<PessoaViewModel>>(pessoa);
        }

        public PessoaViewModel PessoaViewToPessoa(Pessoa pessoa)
        {
            return _mapper.Map<PessoaViewModel>(pessoa);
        }

        public Pessoa PessoaToViewModel(PessoaViewModel pessoaViewModel)
        {
            Pessoa pessoa = new Pessoa
            {
                Celular = pessoaViewModel.Celular,
                CreatedDate = pessoaViewModel.CreatedDate,
                Email = pessoaViewModel.Email,
                Nome = pessoaViewModel.Nome,

            };
            return pessoa;
        }
    }
}
