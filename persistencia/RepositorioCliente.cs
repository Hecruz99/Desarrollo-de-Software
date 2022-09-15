using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public class RepositorioCliente: IRepositorioCliente
    {
        private readonly ApplicationContext _applicationContext;

        public RepositorioCliente(ApplicationContext applicationContext){
            _applicationContext = applicationContext;
        }

        Cliente IRepositorioCliente.Add(Cliente cliente){
            var new_cliente = _applicationContext.clientes.Add(cliente); //personas es la tabla, cliente es el objeto
            _applicationContext.SaveChanges();
            return new_cliente.Entity;
        }

        void IRepositorioCliente.Delete(int idCliente){
            var clienteEncontrado = _applicationContext.clientes.FirstOrDefault(
                p => p.Id == idCliente
            );

            if(clienteEncontrado == null){
                return;
            }
            else{
                _applicationContext.Remove(clienteEncontrado);
                _applicationContext.SaveChanges();
            }
        }//Fin delete

        IEnumerable<Cliente> IRepositorioCliente.GetAll(){
            return _applicationContext.clientes;
        }//Fin getall

        Cliente IRepositorioCliente.Get(int idCliente){
                return _applicationContext.clientes.FirstOrDefault(
                    p => p.Id == idCliente
                );
        }//Fin get

        Cliente IRepositorioCliente.Update(Cliente cliente){
            var clienteEncontrado = _applicationContext.clientes.FirstOrDefault(
                p => p.Id == cliente.Id
            );

            if(clienteEncontrado !=null){
                clienteEncontrado.Registro = cliente.Registro;
                clienteEncontrado.Solicitar_Mantenimiento = cliente.Solicitar_Mantenimiento;
                clienteEncontrado.Consultar_Mantenimiento = cliente.Consultar_Mantenimiento;
                
            }
            _applicationContext.SaveChanges();
            return clienteEncontrado;

        }
    }
}