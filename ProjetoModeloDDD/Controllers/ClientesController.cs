using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoModeloDDD.Controllers
{
    public class ClientesController : Controller
    {
        // private readonly ClienteRepository clienteRepository = new ClienteRepository();

        private readonly IClienteAppService _clienteApp;

        //Criar se um contrutor da controller
        public ClientesController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }
         
        // GET: Clientes
        public ActionResult Index()
        {
            var cliente = Mapper.Map<IEnumerable<Cliente>,IEnumerable< ClienteViewModel > >(_clienteApp.GetALL());
            return View(cliente);
        }

        public ActionResult Especiais()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>,IEnumerable<ClienteViewModel>>(_clienteApp.ObterClienteEspeciais());
            return View(clienteViewModel);
        }
        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(cliente);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente)
        {
           
                if (ModelState.IsValid)
                {
                    var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                     cliente.DataCadastro = DateTime.Now;
                    _clienteApp.Add(clienteDomain);
                    
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Msg"] = "Erro no registro";
                }
                return View(cliente);

                
          
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                    _clienteApp.Update(clienteDomain);
                    return RedirectToAction("Index");
                }
                return View(cliente);

            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var cliente = _clienteApp.GetById(id);
                _clienteApp.Remove(cliente);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
