using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GerenciamentoProject.Data;
using GerenciamentoProject.Models;
using GerenciamentoProject.Repositorio;
using GerenciamentoProject.Filters;

namespace GerenciamentoProject.Controllers
{
    [PaginaParaUsuarioLogado]
    [PaginaRestritaADM]
    public class FuncionariosController : Controller
    {
        private readonly IFuncionarioRepositorio _modelo;
        public FuncionariosController(IFuncionarioRepositorio modelo)
        {
            _modelo = modelo;

        }


        //metodos que sairam direto das profundezas do inferno 

        public IActionResult Create()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Create( FuncionarioModel func)
        {
          try
            {
                if (ModelState.IsValid)
                {
                    _modelo.Adicionar(func);
                    TempData["MensagemSucesso"] = "Funcionario cadastrado com sucesso";
                    return RedirectToAction("Index", "Home");

                }

                return View(func);

            }
            catch (System.Exception erro)
            {
                
                TempData["MensagemErro"] =  $"Eita, não conseguimos cadastrar o funcionário, tente novamente, detalhe do erro:{erro.Message}";
                return RedirectToAction("Index", "Home");
            }
            
        }
       

        [HttpPost]
        public IActionResult Alterar(FuncionarioModel func)
        {
           try
            {
                if (ModelState.IsValid)
                {
                    _modelo.Atualizar(func);
                    TempData["MensagemSucesso"] = "Funcionario alterado com sucesso";
                    return RedirectToAction("Index", "Home");
                }
                return View("Editar", func);

            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Eita, não conseguimos atualizar o funcionário, tente novamente, detalhe do erro:{erro.Message}";
                return RedirectToAction("Index", "Home");
            }
            
        }






        // metodos que sei la pq estao aqui 



        public IActionResult Editar(int id)
        {   
            FuncionarioModel edit1 = _modelo.ListarporID(id);
            return View(edit1);
        }
       
        public IActionResult Desativar(int id)
        {
            FuncionarioModel edit1 = _modelo.ListarporID(id);
            return View(edit1);
        }

        public IActionResult Apagar(int id) 
        {
           try
            {
               bool apagado = _modelo.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Funcionario desligado com sucesso";
                }
                else
                {
                    TempData["MensagemSucesso"] = "Ops não conseguimos desligar o funcionario";
                    
                }
                return RedirectToAction("Index", "Home");

            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Eita, não conseguimos apagar o funcionário, tente novamente, detalhe do erro:{erro.Message}";
                return RedirectToAction("Index", "Home");
            }
        }


        public IActionResult Registro()
        {
           List<FuncionarioModel> func = _modelo.ListarFuncionario();
            return View(func);
        }


    }
}