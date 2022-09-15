using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public class RepositorioTecnico: IRepositorioTecnico
    {
        private readonly ApplicationContext _applicationContext;

        public RepositorioTecnico(ApplicationContext applicationContext){
            _applicationContext = applicationContext;
        }

        Tecnico IRepositorioTecnico.Add(Tecnico tecnico){
            var new_tecnico = _applicationContext.tecnicos.Add(tecnico); //carros es la tabla, tecnico es el objeto
            _applicationContext.SaveChanges();
            return new_tecnico.Entity;
        }

        void IRepositorioTecnico.Delete(int IdTecnico){
            var tecnicoEncontrada = _applicationContext.tecnicos.FirstOrDefault(
                p => p.Id == IdTecnico
            );

            if(tecnicoEncontrada == null){
                return;
            }
            else{
                _applicationContext.Remove(tecnicoEncontrada);
                _applicationContext.SaveChanges();
            }
        }//Fin delete

        IEnumerable<Tecnico> IRepositorioTecnico.GetAll(){
            return _applicationContext.tecnicos;
        }//Fin getall

        Tecnico IRepositorioTecnico.Get(int idTecnico){
                return _applicationContext.tecnicos.FirstOrDefault(
                    p => p.Id == idTecnico
                );
        }//Fin get

        Tecnico IRepositorioTecnico.Update(Tecnico tecnico){
            var tecnicoEncontrada = _applicationContext.tecnicos.FirstOrDefault(
                p => p.Id == tecnico.Id
            );

            if(tecnicoEncontrada !=null){
                tecnicoEncontrada.Realizar_Mantenimiento = tecnico.Registrar_Mantenimiento;
                tecnicoEncontrada.Instalar_Repuestos= tecnico.Instalar_Repuestos;
                tecnicoEncontrada.Consultar_Mantenimiento = tecnico.Consultar_Mantenimiento;
                tecnicoEncontrada.Placa_Carro = tecnico.Placa_Carro;
            }
            _applicationContext.SaveChanges();
            return tecnicoEncontrada;

        }
    }
}